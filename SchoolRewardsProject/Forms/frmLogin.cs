using System;
using System.Data;
using System.Windows.Forms;

using SchoolRewardsProject.Classes;
using SchoolRewardsProject.Forms.Pupil;
using SchoolRewardsProject.Forms.Staff.Administration;
using SchoolRewardsProject.Forms.Staff.Head_Of_Year;
using SchoolRewardsProject.Forms.Staff.Teaching_Staff;

namespace SchoolRewardsProject.Forms {

    public partial class frmLogin : Form {

        public frmLogin() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            int dbUserIndex = 0;
            int dbUserId = 0;

            string usernameIn = txtUsername.Text.ToLower();
            string passwordIn = txtPassword.Text;

            // Is username empty
            if (usernameIn == "") {
                // If so, error
                MessageBox.Show("Please Enter A Username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // See if the username is a valid format
            } else if (!Utillies.isValidUsername(usernameIn)) {
                // If not error
                MessageBox.Show("Invalid Username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                // If it is continue
                // See if password box actully has text
                if (passwordIn == "") {
                    // IF not error
                    MessageBox.Show("Please Enter A Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else { 
                    // If so continue

                    // Get network user index from the username
                    dbUserIndex = Utillies.getNetworkUserIndex(schoolDBDataSet, usernameIn);

                    // Is the user in the db, if not show error
                    if (dbUserIndex < 0) {
                        // Show Error
                        MessageBox.Show("Username not found", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        dbUserId = Utillies.getUserId(schoolDBDataSet, dbUserIndex);
                        // Get password from the db
                        string dbPassword = schoolDBDataSet.tblNetworkUsers.Rows[dbUserIndex][2].ToString();
                        if (passwordIn != dbPassword) {
                            // Show Error
                            MessageBox.Show("Incorrect Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else {
                            // Checks to see if the user is a pupil (returns -1 if not, esle retunrs the id)
                            int dbPupilIndex = Utillies.getPupilIndex(schoolDBDataSet, dbUserId);

                            // Start login session
                            DateTime sessionStartDT = DateTime.Now;

                            // Clear login form
                            clearTXTBoxes();
                            // Hide login form
                            this.Hide();

                            // If the user is a pupil, open the pupil form
                            if (dbPupilIndex > -1) {
                                frmPupil frmPupil = new frmPupil(dbPupilIndex);
                                frmPupil.ShowDialog();
                            } else {
                                // Get staff detail info from db, create a new table with only the relevent info
                                tblStaffTableAdapter.Adapter.SelectCommand.CommandText = "SELECT        StaffID, UserID, TutorID, YearID, UserLevelID, Surname, OtherNames, Mobile, Phone, AddrLine1, AddrLine2, Region, Postcode\n" +
                                    "FROM tblStaff\n" +
                                    "WHERE(UserID = " + dbUserId.ToString() + ")";

                                // Fill data table to get only the needed info (staffid, userid and userlevelid)
                                tblStaffTableAdapter.Fill(schoolDBDataSet.tblStaff);

                                // Get staff level and ID from db
                                int dbStaffID = Convert.ToInt32(schoolDBDataSet.tblStaff.Rows[0][0]);
                                int dbStaffLevelID = Convert.ToInt32(schoolDBDataSet.tblStaff.Rows[0][4]);

                                // Determine which staff level the user is to log them into the correct form
                                switch (dbStaffLevelID) {
                                    case 1:
                                        frmAdministration frmAdministration = new frmAdministration(dbStaffID);
                                        frmAdministration.ShowDialog();
                                        break;
                                    case 2:
                                        frmHeadOfYear frmHeadOfYear = new frmHeadOfYear(dbStaffID);
                                        frmHeadOfYear.ShowDialog();
                                        break;
                                    case 3:
                                    case 4:
                                        frmTeachingStaff frmTeachingStaff = new frmTeachingStaff(dbStaffID);
                                        frmTeachingStaff.ShowDialog();
                                        break;
                                    default:
                                        break;
                                }
                            }

                            // End login session
                            DateTime sessionEndDT = DateTime.Now;

                            // Record Login Session
                            sessionInfoToDb(schoolDBDataSet, "tblSessionLog", dbUserId, sessionStartDT, sessionEndDT);
                            // Update the database
                            tblSessionLogTableAdapter.Update(schoolDBDataSet.tblSessionLog);
                            // Fill dataset from the db to keep sync
                            tblSessionLogTableAdapter.Fill(schoolDBDataSet.tblSessionLog);

                            frmLogin_Load(sender, e);

                            this.Show();

                        }
                    }
                }
            }
}

        private void btnQuit_Click(object sender, EventArgs e) {
            // Close application on quit button
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblStaff' table. You can move, or remove it, as needed.
            this.tblStaffTableAdapter.Fill(this.schoolDBDataSet.tblStaff);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblSessionLog' table. You can move, or remove it, as needed.
            this.tblSessionLogTableAdapter.Fill(this.schoolDBDataSet.tblSessionLog);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblPupils' table. You can move, or remove it, as needed.
            this.tblPupilsTableAdapter.Fill(this.schoolDBDataSet.tblPupils);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblNetworkUsers' table. You can move, or remove it, as needed.
            this.tblNetworkUsersTableAdapter.Fill(this.schoolDBDataSet.tblNetworkUsers);

            // Clear TXTBoxes
            clearTXTBoxes();
        }

        

        private void clearTXTBoxes() {
            // Clear Text Boxes
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
        private void sessionInfoToDb(DataSet dbData, String sessionTableNameInDb, int userID, DateTime startDateTime, DateTime finishDateTime) {
            // Gets the datatable
            DataTable sessionTable = dbData.Tables[sessionTableNameInDb];
            // Adds new row
            sessionTable.Rows.Add();
            // Gets the new row index
            int lastRow = sessionTable.Rows.Count - 1;

            // Fill data into the row
            sessionTable.Rows[lastRow][1] = userID;
            sessionTable.Rows[lastRow][2] = startDateTime;
            sessionTable.Rows[lastRow][3] = finishDateTime;
        }

        private void REMOVELATER_Click(object sender, EventArgs e) {
            txtUsername.Text = "ll000001";
            txtPassword.Text = "p";
            btnLogin_Click(sender, e);
        }

        private void REMOVELATER2_Click(object sender, EventArgs e) {
            txtUsername.Text = "jj100001";
            txtPassword.Text = "p";
            btnLogin_Click(sender, e);
        }
    }
}
