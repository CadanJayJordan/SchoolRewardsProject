using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolRewardsProject.Forms.Pupil {
    public partial class frmRedeemRewards : Form {

        private int dbPupilIndex;

        private DataTable tblAvailibleRewards = null;

        public frmRedeemRewards(int dbPupilIndex) {
            InitializeComponent();
            this.dbPupilIndex = dbPupilIndex;
        }

        private void frmRedeemRewards_Load(object sender, EventArgs e) {
            pullDbInfo(); // Pull all db info (Except rewards)
            pullRewards(); // Get Rewards from db

            // Set Welcome text
            lblWelcomeText.Text = "Welcome, " + schoolDBDataSet.tblPupils[dbPupilIndex][5].ToString() +
                "\nYou have: " + schoolDBDataSet.tblPupils[dbPupilIndex][6].ToString() + " points" +
                "\nAnd " + tblAvailibleRewards.Rows.Count + " Redeemable Rewards";

            cbxRedeemableRewards.SelectedIndex = -1;

        }

        private void clearTextBoxes() {
            txtRewardCost.Text = "";
            txtRewardDescription.Text = "";
            txtRewardName.Text = "";
        }

        private void pullDbInfo() {
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblRedeemRewardLog' table. You can move, or remove it, as needed.
            this.tblRedeemRewardLogTableAdapter.Fill(this.schoolDBDataSet.tblRedeemRewardLog);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblPupils' table. You can move, or remove it, as needed.
            this.tblPupilsTableAdapter.Fill(this.schoolDBDataSet.tblPupils);
        }

        private void pullRewards() {
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblRewards' table. You can move, or remove it, as needed.
            this.tblRewardsTableAdapter.Fill(this.schoolDBDataSet.tblRewards);        

            // Rewards That can be afforded, queeries for rewardcost <= points
            tblRewardsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT        RewardID, RewardName, RewardDescription, RewardCost\n" +
                "FROM tblRewards\n" +
                "WHERE(RewardCost <= " + schoolDBDataSet.tblPupils.Rows[dbPupilIndex][6] + ")";
            this.tblRewardsTableAdapter.Fill(this.schoolDBDataSet.tblRewards);
            tblAvailibleRewards = schoolDBDataSet.tblRewards;
        }

        private void cbxRedeemableRewards_SelectionChangeCommitted(object sender, EventArgs e) {
            // Get al linfo from db
            int rewardRow = Convert.ToInt32(cbxRedeemableRewards.SelectedIndex);
            string rewardName = tblAvailibleRewards.Rows[rewardRow][1].ToString();
            string rewardDescription = tblAvailibleRewards.Rows[rewardRow][2].ToString();
            int rewardCost = Convert.ToInt32(tblAvailibleRewards.Rows[rewardRow][3]);

            // Put text in approptiate boxes
            gbxRewardInfo.Text = "Reward - " + rewardName;
            txtRewardName.Text = rewardName;
            txtRewardCost.Text = rewardCost.ToString();
            txtRewardDescription.Text = rewardDescription;

            gbxRewardInfo.Visible = true; // Show all the boxes
        }

        private void btnRedeem_Click(object sender, EventArgs e) {
            int currentPoints = Convert.ToInt32(schoolDBDataSet.tblPupils.Rows[dbPupilIndex][6]); // Get current points
            int rewardCost = Convert.ToInt32(tblAvailibleRewards.Rows[Convert.ToInt32(cbxRedeemableRewards.SelectedIndex)][3]); // get reward cost from db
            string rewardName = tblAvailibleRewards.Rows[Convert.ToInt32(cbxRedeemableRewards.SelectedIndex)][1].ToString();

            // Ask the user if they want to redeem the award
            var redeemAskResponce = MessageBox.Show("Are you sure you want to redeem: " + rewardName + "\nFor " + rewardCost + " points", "Redeem confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (redeemAskResponce == DialogResult.Yes) { // If yes
                if (canRedeemAward(rewardCost, currentPoints)) {
                    pullDbInfo(); // keep sync with db

                    schoolDBDataSet.tblPupils.Rows[dbPupilIndex][6] = currentPoints - rewardCost; // Put new reward cost in db

                    logRedemption(rewardCost); // Log the transaction

                    tblPupilsTableAdapter.Update(schoolDBDataSet.tblPupils); // Update the pupils table with new points total

                    pullDbInfo(); // Pull all tables to keep db sync
                    MessageBox.Show("Successfully Redeemed Reward: " + rewardName + "\nCost: " + rewardCost + "\nNew Account Balance: " + (currentPoints - rewardCost)
                        , "Reward Redeemed", MessageBoxButtons.OK);
                } else {
                    // Show error
                    MessageBox.Show("You do not have enough points to redeem this reward", "Error Redeeming Reward", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool canRedeemAward(int rewardCost, int pupilCurrentPoints) { // Can the user afford award (in case the combo box does soemthing funky)
            if (rewardCost > pupilCurrentPoints) { // If reward cost is more than points
                return false;
            } else { // If reward cost is equal to or smaller than points
                return true;
            }
        }

        private void logRedemption(int rewardCost) {
            // Create new row from the redeem reward table
            DataRow logRow = schoolDBDataSet.tblRedeemRewardLog.NewRow();

            // Add all the appropiate values to the log
            logRow[1] = Convert.ToInt32(schoolDBDataSet.tblPupils.Rows[dbPupilIndex][0]);
            logRow[2] = Convert.ToInt32(cbxRedeemableRewards.SelectedValue);
            logRow[3] = rewardCost;
            logRow[4] = DateTime.Now;
            // Add the row to the datset
            schoolDBDataSet.tblRedeemRewardLog.Rows.Add(logRow);
            // Update the data set with the new row
            tblRedeemRewardLogTableAdapter.Update(schoolDBDataSet.tblRedeemRewardLog);

        }

        private void btnUnavailbleRewards_Click(object sender, EventArgs e) {
            this.Hide();
            // Rewards That can not be afforded, queeries for rewardcost > points
            tblRewardsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT        RewardID, RewardName, RewardDescription, RewardCost\n" +
                "FROM tblRewards\n" +
                "WHERE(RewardCost > " + schoolDBDataSet.tblPupils.Rows[dbPupilIndex][6] + ")";
            this.tblRewardsTableAdapter.Fill(this.schoolDBDataSet.tblRewards); // Fill dataset

            // Set the base message
            string messageBoxMessage = "You have " + schoolDBDataSet.tblRewards.Rows.Count.ToString() + " rewards you cannot redeem: ";
            for (int i = 0; i < schoolDBDataSet.tblRewards.Rows.Count; i++) { // Add each unnafordable reward to the stirng
                DataRow rewardRow = schoolDBDataSet.tblRewards.Rows[i];
                messageBoxMessage += "\n - " + rewardRow[1].ToString() + ", Cost: " + rewardRow[3].ToString();
            }
            // Show string in a messagebox
            MessageBox.Show(messageBoxMessage, "Unavailble Rewards", MessageBoxButtons.OK);
            // Reload form
            frmRedeemRewards_Load(sender, e);
            this.Show();
        }
    }
}
