using System;
using System.Windows.Forms;

namespace SchoolRewardsProject.Forms.Pupil {
    public partial class frmPointChangeLog : Form {

        private int dbPupilID;
        public frmPointChangeLog(int dbPupilID) {
            InitializeComponent();
            this.dbPupilID = dbPupilID;
        }

        private void frmPointChangeLog_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblStaff' table. You can move, or remove it, as needed.
            this.tblStaffTableAdapter.Fill(this.schoolDBDataSet.tblStaff);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblPointRewardCategories' table. You can move, or remove it, as needed.
            this.tblPointRewardCategoriesTableAdapter.Fill(this.schoolDBDataSet.tblPointRewardCategories);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblPointLog' table. You can move, or remove it, as needed.
            this.tblPointLogTableAdapter.Fill(this.schoolDBDataSet.tblPointLog);

            // Update adapter command with queery       
            tblPointLogTableAdapter.Adapter.SelectCommand.CommandText = "SELECT        tblPointRewardCategories.CategoryName, tblPointRewardCategories.CategoryDescription, tblPointLog.PointChange, tblStaff.Surname, tblPointLog.[Time]\n" +
                "FROM((tblPointLog INNER JOIN tblStaff ON tblPointLog.StaffID = tblStaff.StaffID) INNER JOIN tblPointRewardCategories ON tblPointLog.CategoryID = tblPointRewardCategories.CategoryID)\n" +
                "WHERE(tblPointLog.PupilID = " + dbPupilID.ToString() + ")\n" +
                "ORDER BY tblPointLog.PointLogID DESC";

            // Fill with queiry information
            this.tblPointLogTableAdapter.Fill(this.schoolDBDataSet.tblPointLog);

            fillDGV(); // Fill the dgv
        }

        private void fillDGV() {
            int dbLength = schoolDBDataSet.tblPointLog.Rows.Count;

            for (int y = 0; y < dbLength; y++) { // Loop through every row in the db
                dgvPointLog.Rows.Add(); // Add new row

                // Insert data into the row
                dgvPointLog[0, y].Value = schoolDBDataSet.tblPointLog.Rows[y][6];
                dgvPointLog[1, y].Value = schoolDBDataSet.tblPointLog.Rows[y][7];
                dgvPointLog[2, y].Value = schoolDBDataSet.tblPointLog.Rows[y][4];
                dgvPointLog[3, y].Value = schoolDBDataSet.tblPointLog.Rows[y][8];
                dgvPointLog[4, y].Value = schoolDBDataSet.tblPointLog.Rows[y][5];
            }
        }
    }
}
