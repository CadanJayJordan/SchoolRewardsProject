using System;
using System.Windows.Forms;

namespace SchoolRewardsProject.Forms.Pupil {
    public partial class frmRewardRedemptionLog : Form {

        private int dbPupilID;

        public frmRewardRedemptionLog(int dbPupilID) {
            InitializeComponent();

            this.dbPupilID = dbPupilID;
        }

        private void frmRewardRedemptionLog_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblRewards' table. You can move, or remove it, as needed.
            this.tblRewardsTableAdapter.Fill(this.schoolDBDataSet.tblRewards);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblRedeemRewardLog' table. You can move, or remove it, as needed.
            this.tblRedeemRewardLogTableAdapter.Fill(this.schoolDBDataSet.tblRedeemRewardLog);

            // Set adapter command
            tblRedeemRewardLogTableAdapter.Adapter.SelectCommand.CommandText = "SELECT        tblRedeemRewardLog.RedemptionID, tblRedeemRewardLog.PupilID, tblRedeemRewardLog.CategoryID, \n" +
                "tblRewards.RewardName, tblRewards.RewardDescription, tblRedeemRewardLog.PointChange, tblRedeemRewardLog.[Time]\n" +
                "FROM(tblRedeemRewardLog INNER JOIN tblRewards ON tblRedeemRewardLog.CategoryID = tblRewards.RewardID)\n" +
                "WHERE(tblRedeemRewardLog.PupilID = " + dbPupilID.ToString() + ")";

            // Get new table
            this.tblRedeemRewardLogTableAdapter.Fill(this.schoolDBDataSet.tblRedeemRewardLog);

            fillDGV();
        }

        private void fillDGV() { // Fill dgv with db info
            int dbLength = schoolDBDataSet.tblRedeemRewardLog.Rows.Count; // Get amount of rewards this user has redeemed
            for (int y = 0; y < dbLength; y++) { // for rows
                dgvShowRedemptions.Rows.Add(); // Add new row

                // Add data to dgv (Would use loops but the query seems to have made the data columns in a random order)
                dgvShowRedemptions[0, y].Value = schoolDBDataSet.tblRedeemRewardLog.Rows[y][5].ToString();
                dgvShowRedemptions[1, y].Value = schoolDBDataSet.tblRedeemRewardLog.Rows[y][6].ToString();
                dgvShowRedemptions[2, y].Value = schoolDBDataSet.tblRedeemRewardLog.Rows[y][3].ToString();
                dgvShowRedemptions[3, y].Value = schoolDBDataSet.tblRedeemRewardLog.Rows[y][4].ToString();
            }
        }
    }
}
