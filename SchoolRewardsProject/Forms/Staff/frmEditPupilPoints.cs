using System;
using System.Data;
using System.Windows.Forms;

using SchoolRewardsProject.Classes;

namespace SchoolRewardsProject.Forms.Staff {
    public partial class frmEditPupilPoints : Form {

        private bool isReward;
        private DataRow rowPupilDataRow = null;
        private int dbUserIndex = 0;
        private int dbUserId = 0;
        private int dbPupilIndex = 0;
        private int teacherId;

        public frmEditPupilPoints(int teacherId) {
            InitializeComponent();
            this.teacherId = teacherId; // Pass teacher id through from the previous form
        }

        private void btnPunish_Click(object sender, EventArgs e) { // Pupil Is to have points removed
            isOriginalBtnsVisible = false; // Hide Buttons
            gbxSearch.Visible = true; // Show search box
            isReward = false; // It is a punishment
        }

        private void btnReward_Click(object sender, EventArgs e) {// Pupil is to have points added
            isOriginalBtnsVisible = false; // Hide Buttons
            gbxSearch.Visible = true; // Show search box
            isReward = true; // It is a reward
        }

        private bool isOriginalBtnsVisible { // Method to change the visibillity of the original buttons
            get { return (btnPunish.Visible); }
            set { 
                btnPunish.Visible = value; 
                btnReward.Visible = value; 
            }
        }

        private void frmEditPupilPoints_Load(object sender, EventArgs e) {
            pullDB();
            clearTextBoxes();
        }

        private void pullDB() {
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblPointLog' table. You can move, or remove it, as needed.
            this.tblPointLogTableAdapter.Fill(this.schoolDBDataSet.tblPointLog);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblPointRewardCategories' table. You can move, or remove it, as needed.
            this.tblPointRewardCategoriesTableAdapter.Fill(this.schoolDBDataSet.tblPointRewardCategories);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblPupils' table. You can move, or remove it, as needed.
            this.tblPupilsTableAdapter.Fill(this.schoolDBDataSet.tblPupils);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblNetworkUsers' table. You can move, or remove it, as needed.
            this.tblNetworkUsersTableAdapter.Fill(this.schoolDBDataSet.tblNetworkUsers);
        }

        private void clearTextBoxes() {
            txtPointsToAward.Text = "";
            txtOtherNames.Text = "";
            txtID.Text = "";
            txtSurname.Text = "";
            txtUsername.Text = "";
            txtCurrentPoints.Text = "";
            txtCurrentTotalPoints.Text = "";
            txtPointsToRevoke.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e) { // Search for user
            string usernameIn = txtUsername.Text;
            

            // Is the username a valid format
            if (!Utillies.isValidUsername(usernameIn)) {
                // Suppose not, display error
                MessageBox.Show("Username is not in a valid format", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                // Else username is valid format
                // Check database for username
                dbUserIndex = Utillies.getNetworkUserIndex(schoolDBDataSet, usernameIn);

                // Is user in DB
                if (dbUserIndex < 0) {
                    // Suppose Not, user is not in DB, retunr error
                    MessageBox.Show("User not found", "Username Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    // User is found in DB

                    // Now we can get the user ID
                    dbUserId = Utillies.getUserId(schoolDBDataSet, dbUserIndex);

                    // attempt to get pupil ID, if it has failed it will retunr -1 meaning not a pupil
                    dbPupilIndex = Utillies.getPupilIndex(schoolDBDataSet, dbUserId);

                    // Is input pupil
                    if (dbPupilIndex < 0) {
                        // Suppose not, input is staff
                        MessageBox.Show("User is not a pupil\nYou cannot edit the points of this user", "User is not a pupil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {
                        // Input is pupil
                        rowPupilDataRow = tblNetworkUsersTableAdapter.getPupilInfo().FindByUserID(dbUserId); // All pupil info is quereid into one row
                        fillUserDataOntoForm();
                        showGroupBoxes();
                    }
                }
            }
        }

        private void fillUserDataOntoForm() { // Show pupil data in the txt boxes
            txtID.Text = rowPupilDataRow[5].ToString();
            txtOtherNames.Text = rowPupilDataRow[6].ToString();
            txtSurname.Text = rowPupilDataRow[7].ToString();
            txtCurrentPoints.Text = rowPupilDataRow[16].ToString();
            txtCurrentTotalPoints.Text = rowPupilDataRow[17].ToString();
        }

        private void showGroupBoxes() {
            gbxRevokePoints.Location = gbxAwardPoints.Location; // Move locations (To stop grouping on the designer view)

            gbxPupilInfo.Visible = true; // In all cases we want pupil info to be visibile
            if (isReward) { // Show reward groupbox
                this.tblPointRewardCategoriesTableAdapter.getAwards(this.schoolDBDataSet.tblPointRewardCategories); // Get only awards (Points > 0)
                cbxRewardCategories.SelectedValue = -1;
                gbxAwardPoints.Visible = true;
            } else { // show punishment groupbox
                this.tblPointRewardCategoriesTableAdapter.getPunishments(this.schoolDBDataSet.tblPointRewardCategories); // Get only punishments (Points < 0)
                cbxPunishmentCategories.SelectedValue = -1;
                gbxRevokePoints.Visible = true;
            }
        }

        private void cbxRewardCategories_SelectionChangeCommitted(object sender, EventArgs e) {
            if (cbxRewardCategories.SelectedIndex >= 0) { // Stops out of index crashes
                // Set the txtbox to equal the amount of points to be awarded from database
                txtPointsToAward.Text = schoolDBDataSet.tblPointRewardCategories.Rows[cbxRewardCategories.SelectedIndex][3].ToString();
            }
        }
        private void cbxPunishmentCategories_SelectionChangeCommitted(object sender, EventArgs e) {
            if (cbxPunishmentCategories.SelectedIndex >= 0) { // Stops out of index crashes
                // Set the txtbox to equal the amount of points to be awarded from database
                txtPointsToRevoke.Text = schoolDBDataSet.tblPointRewardCategories.Rows[cbxPunishmentCategories.SelectedIndex][3].ToString();
            }
        }

        private void btnCustomPointsAdd_Click(object sender, EventArgs e) { // Allows custom amount of points
            txtPointsToAward.ReadOnly = false;
        }
        private void btnCustomPointsRemove_Click(object sender, EventArgs e) { // Allows custom amount of points
            txtPointsToRevoke.ReadOnly = false;
        }

        private void btnDoneAward_Click(object sender, EventArgs e) { // Complete award transaction and update relevent tables
            try {
                int pointsToAdd = Convert.ToInt32(txtPointsToAward.Text); // Get the change in points
                // Ensure points are greater than 0
                if (pointsToAdd > 0) {
                    finishedUserEditing(pointsToAdd);
                } else {
                    MessageBox.Show("Error: Amount of points to add needs to be greater than 0", "Invalid Points", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            // Catch various int related errors
            } catch (FormatException) {
                MessageBox.Show("Error: '" + txtPointsToAward.Text + "' is not a valid amount of points", "Invalid Points", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException) {
                MessageBox.Show("Overflow, consider using smaller numbers of points", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnDoneRevoke_Click(object sender, EventArgs e) {// Complete punishment transaction and update relevent tables
            try {
                int pointsToRevoke = Convert.ToInt32(txtPointsToRevoke.Text); // Get the change in points
                // Ensure points are less than 0
                if (pointsToRevoke < 0) {
                    finishedUserEditing(pointsToRevoke);
                } else {
                    MessageBox.Show("Error: Amount of points to remove needs to be less than 0", "Invalid Points", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Catch various int related errors
            } catch (FormatException) {
                MessageBox.Show("Error: '" + txtPointsToRevoke.Text + "' is not a valid amount of points", "Invalid Points", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (OverflowException) {
                MessageBox.Show("Overflow, consider using smaller numbers of points", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editPupilPoints(int pointChange32) { // Update user points in pupil table
            DataRow pupilDataRow = schoolDBDataSet.tblPupils.Rows[dbPupilIndex];
            Int64 currentPoints = Convert.ToInt64(pupilDataRow[6]); // Get current points
            Int64 currentTotalPoints = Convert.ToInt64(pupilDataRow[7]); // Get current total points

            Int64 pointChange = Convert.ToInt64(pointChange32);

            // If either value exceed a 32 bit integer (maxima)
            if (((currentPoints + pointChange) >= Int32.MaxValue) ||
                ((currentTotalPoints + pointChange) >= Int32.MaxValue)) {
                // Throw a new exception to break the program
                throw new OverflowException();
            // If either value exceed a 32 bit integer (minima)
            } else if (((currentPoints + pointChange) <= Int32.MinValue) ||
                ((currentTotalPoints + pointChange) <= Int32.MinValue)) {
                // Throw a new exception to break the program
                throw new OverflowException();
            } else {    // Else assume the value is acceptable
                // Update values with new point chnage
                pupilDataRow[6] = currentPoints + pointChange;
                pupilDataRow[7] = currentTotalPoints + pointChange;

                // Update and pull from db to sync
                tblPupilsTableAdapter.Update(schoolDBDataSet.tblPupils);
                tblPupilsTableAdapter.Fill(schoolDBDataSet.tblPupils);
            }
        }

        private void addLogRow(int pointChange) { // Add a log row to log the transaction
            DataRow pointLogRow = schoolDBDataSet.tblPointLog.NewRow();
            pointLogRow[0] = Convert.ToInt32(schoolDBDataSet.tblPointLog.Rows[schoolDBDataSet.tblPointLog.Rows.Count - 1][0]) + 1;
            pointLogRow[1] = rowPupilDataRow[5];
            pointLogRow[2] = teacherId;
            pointLogRow[3] = cbxRewardCategories.SelectedValue;
            pointLogRow[4] = pointChange;
            pointLogRow[5] = DateTime.Now;
            schoolDBDataSet.tblPointLog.Rows.Add(pointLogRow);

            tblPointLogTableAdapter.Update(schoolDBDataSet.tblPointLog); // Update the db with log row
            tblPointLogTableAdapter.Fill(schoolDBDataSet.tblPointLog); // Pull new data to keep db sync
        }

        private void finishedUserEditing(int pointsToAdd) {
            try {
                editPupilPoints(pointsToAdd); // Update total points in tblPupil
                addLogRow(pointsToAdd); // Log the transaction

                MessageBox.Show("User: " + txtUsername.Text + "\nPoint Change: " + pointsToAdd.ToString(), "Points Change", MessageBoxButtons.OK);

                gbxAwardPoints.Visible = false;
                gbxPupilInfo.Visible = false;
                gbxRevokePoints.Visible = false;
                txtUsername.Text = "";
                txtPointsToRevoke.ReadOnly = true;
                txtPointsToAward.ReadOnly = true;
                txtPointsToAward.Text = "";
                txtPointsToRevoke.Text = "";
            } catch (OverflowException) { // Catch exception from editPupilPoints
                MessageBox.Show("Pupil points are above the max value\nPlease reset this user's points to fix this", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e) { // Hide all boxes and go back to the two original buttons
            gbxAwardPoints.Visible = false;
            gbxPupilInfo.Visible = false;
            gbxRevokePoints.Visible = false;
            gbxSearch.Visible = false;
            txtUsername.Text = "";

            isOriginalBtnsVisible = true;
        }
    }
}
