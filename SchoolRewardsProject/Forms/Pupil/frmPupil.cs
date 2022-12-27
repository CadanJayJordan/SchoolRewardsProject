using System;
using System.Windows.Forms;

namespace SchoolRewardsProject.Forms.Pupil {
    public partial class frmPupil : Form {

        private int dbPupilIndex;
        private int dbPupilID;

        public frmPupil(int dbPupilIndex) {
            InitializeComponent();
            this.dbPupilIndex = dbPupilIndex;
        }

        private void frmPupil_Load(object sender, EventArgs e) {
            // Fill table adapter
            this.tblPupilsTableAdapter.Fill(this.schoolDBDataSet.tblPupils);
            // Get pupil ID from the index
            dbPupilID = Convert.ToInt32(schoolDBDataSet.tblPupils[dbPupilIndex][0]);

            // Change adapter command to get a query for the current user logged in.
            tblPupilsTableAdapter.Adapter.SelectCommand.CommandText = "SELECT        tblPupils.PupilID, tblPupils.UserID, tblPupils.TutorID, tblPupils.YearID, tblPupils.Surname, tblPupils.OtherNames, tblPupils.Points, tblPupils.TotalPoints, tblPupils.ParentMobile, tblPupils.ParentPhone, tblPupils.AddrLine1, " +
                "tblPupils.AddrLine2, tblPupils.Region, tblPupils.Postcode, tblNetworkUsers.Username" +
                "\nFROM(tblPupils INNER JOIN" +
                "\ntblNetworkUsers ON tblPupils.UserID = tblNetworkUsers.UserID)" +
                "\nWHERE(tblPupils.PupilID = " + dbPupilID.ToString() + ")";

            // Fill data table with query data
            this.tblPupilsTableAdapter.Fill(this.schoolDBDataSet.tblPupils);

            // Gets pupil name and points from table and displays a welcome message
            lblPupilWelcome.Text = "Welcome, " + schoolDBDataSet.tblPupils[0][5].ToString() + 
                "\nYou have: " + schoolDBDataSet.tblPupils[0][6].ToString() + " points";
        }

        private void btnRedeemReward_Click(object sender, EventArgs e) { // Load redeem Reward form
            this.Hide(); // hide this form
            // Create a new instance of the new form and pass pupil index through
            frmRedeemRewards frmRedeemRewards = new frmRedeemRewards(dbPupilIndex);
            frmRedeemRewards.ShowDialog(); // Show new form
            /*
             * Paused until new form is closed
             */
            frmPupil_Load(sender, e); // Clear this form
            this.Show(); // Show this form
        }

        private void btnPupilReedemptionLog_Click(object sender, EventArgs e) { // Load redeem log form
            this.Hide(); // hide this form
            // Create a new instance of the new form and pass pupil index through
            frmRewardRedemptionLog frmRewardRedemptionLog = new frmRewardRedemptionLog(dbPupilID);
            frmRewardRedemptionLog.ShowDialog(); // Show new form
            /*
             * Paused until new form is closed
             */
            frmPupil_Load(sender, e); // Clear this form
            this.Show(); // Show this form
        }

        private void btnPointLog_Click(object sender, EventArgs e) { // Load pupil log form
            this.Hide(); // hide this form
            // Create a new instance of the new form and pass pupil index through
            frmPointChangeLog frmPointChangeLog = new frmPointChangeLog(dbPupilID);
            frmPointChangeLog.ShowDialog(); // Show new form
            /*
             * Paused until new form is closed
             */
            frmPupil_Load(sender, e); // Clear this form
            this.Show(); // Show this form
        }
    }
}
