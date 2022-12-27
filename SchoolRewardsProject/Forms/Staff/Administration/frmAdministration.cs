using System;
using System.Windows.Forms;

namespace SchoolRewardsProject.Forms.Staff.Administration {
    public partial class frmAdministration : Form {

        int staffID;

        public frmAdministration(int staffID) {
            InitializeComponent();
            // Pass staff ID onto this form
            this.staffID = staffID;
        }

        private void frmAdministration_Load(object sender, EventArgs e) {
            // Fill the data table with the orignal data
            this.tblStaffTableAdapter.Fill(this.schoolDBDataSet.tblStaff);

            // Set the query to get the relevent information for this form
            tblStaffTableAdapter.Adapter.SelectCommand.CommandText = "SELECT        StaffID, UserID, TutorID, YearID, UserLevelID, Surname, OtherNames, Mobile, Phone, AddrLine1, AddrLine2, Region, Postcode\n" +
                "FROM tblStaff\n" +
                "WHERE(UserID = " + staffID.ToString() + ")";

            // Get new data table from the queery data
            this.tblStaffTableAdapter.Fill(this.schoolDBDataSet.tblStaff);

            // Display welcome message on form
            lblWelcomeLabel.Text = "Welcome, " + schoolDBDataSet.tblStaff.Rows[0][6];

        }

        private void btnEditUsers_Click(object sender, EventArgs e) { // Open Edit ALL Users form
            this.Hide(); // Hide this form
            // Create new instance of new form
            frmEditAllUsers frmEditAllUsers = new frmEditAllUsers();
            frmEditAllUsers.ShowDialog();
            /*
             * Paused until new form is closed
             */
            frmAdministration_Load(sender, e); // Reset this form
            this.Show(); // Show this form
        }

        private void btnEditPoints_Click(object sender, EventArgs e) { // Open Add/Remove Points Form
            this.Hide();// Hide this form
            // Create new instance of new form
            frmEditPupilPoints frmEditPupilPoints = new frmEditPupilPoints(Convert.ToInt32(schoolDBDataSet.tblStaff.Rows[0][0]));
            frmEditPupilPoints.ShowDialog();
            /*
             * Paused until new form is closed
             */
            frmAdministration_Load(sender, e); // Reset this form
            this.Show(); // Show this form
        }
    }
}
