using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using SchoolRewardsProject.Classes;

namespace SchoolRewardsProject.Forms.Staff.Administration {
    public partial class frmEditAllUsers : Form {

        bool isPupil = false;
        int dbUserId = 0;
        DataRow tblUserDataRow = null;

        public frmEditAllUsers() {
            InitializeComponent();
        }

        private void frmEditAllUsers_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'schoolDBDataSet1.tblUserLevels' table. You can move, or remove it, as needed.
            this.tblUserLevelsTableAdapter.Fill(this.schoolDBDataSet.tblUserLevels);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblTutors' table. You can move, or remove it, as needed.
            this.tblTutorsTableAdapter.Fill(this.schoolDBDataSet.tblTutors);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblYearGroup' table. You can move, or remove it, as needed.
            this.tblYearGroupTableAdapter.Fill(this.schoolDBDataSet.tblYearGroup);
            clearTextBoxes(); // Clear all boxes on form load

            pullDbInfo(); // Pull db info 

        }

        private void pullDbInfo() {
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblSecurityQuestions' table. You can move, or remove it, as needed.
            this.tblSecurityQuestionsTableAdapter.Fill(this.schoolDBDataSet.tblSecurityQuestions);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblStaff' table. You can move, or remove it, as needed.
            this.tblStaffTableAdapter.Fill(this.schoolDBDataSet.tblStaff);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblPupils' table. You can move, or remove it, as needed.
            this.tblPupilsTableAdapter.Fill(this.schoolDBDataSet.tblPupils);
            // TODO: This line of code loads data into the 'schoolDBDataSet.tblNetworkUsers' table. You can move, or remove it, as needed.
            this.tblNetworkUsersTableAdapter.Fill(this.schoolDBDataSet.tblNetworkUsers);

        }

        private void btnSearch_Click(object sender, EventArgs e) { // Search for user via username
            pullDbInfo(); // Ensure all db info is pulled

            btnNewStaffUser.Visible = false;
            btnNewPupilUser.Visible = false;
            btnSaveNewUser.Visible = false;
            btnAllowEditing.Visible = true;
            btnSaveEdits.Visible = true;

            int dbUserIndex, dbPupilIndex;
            string usernameIn = txtUsername.Text.ToLower();

            // Clear Form ready for entry
            groupBoxVisibility(false, false);

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
                        isPupil = false;
                        tblUserDataRow = tblNetworkUsersTableAdapter.getTeacherInfo().FindByUserID(dbUserId);
                    } else {
                        // input is pupil
                        isPupil = true;
                        tblUserDataRow = tblNetworkUsersTableAdapter.getPupilInfo().FindByUserID(dbUserId);
                    }

                    // Get DB Info onto form text fields
                    fillFormWithDBInfo(tblUserDataRow, isPupil);
                }
            }
        }

        private void fillFormWithDBInfo(DataRow data, bool isPupil) { // Fill form txt boxes with the appropitate text
            // Put only relevent info to staff or students into boxes
            if (isPupil) {
                gbxPupilInfo.Text = "Pupil Information";
                lblID.Text = "Pupil ID:";
                txtPoints.Text = data[16].ToString();
                txtTotalPoints.Text = data[17].ToString();
            } else {
                gbxPupilInfo.Text = "Staff Information";
                lblID.Text = "Staff ID:";
                cbxUserLevel.SelectedValue = data[16];
            }

            // Put all other info into text boxes - Up to data[13] all info is the same between teachers and pupil, it then changes
            txtPassword.Text = data[2].ToString();
            cbxSecurityQuestion.SelectedItem = data[3]; // Set combo box to correct security question
            txtSecurityQuestionResponce.Text = data[4].ToString();
            txtID.Text = data[5].ToString();
            txtOtherNames.Text = data[6].ToString();
            txtSurname.Text = data[7].ToString();
            txtMobile.Text = data[8].ToString();
            txtPhone.Text = data[9].ToString();
            txtAddrL1.Text = data[10].ToString();
            txtAddrL2.Text = data[11].ToString();
            txtRegion.Text = data[12].ToString();
            txtPostCode.Text = data[13].ToString();
            cbxYear.SelectedValue = data[14];
            cbxTutor.SelectedValue = data[15];

            // Show any relevent hidden boxes
            groupBoxVisibility(true, isPupil);
        }

        private void btnShowPassword_Click(object sender, EventArgs e) { // Show/Hide the user password on click
            // Shows/Hides depending on what the button text is equal to
            if (btnShowPassword.Text == "Show") {
                txtPassword.PasswordChar = (char)0; // Resets password character to reveal password
                btnShowPassword.Text = "Hide";
            } else if (btnShowPassword.Text == "Hide") {
                txtPassword.PasswordChar = '*';
                btnShowPassword.Text = "Show";
            }
        }

        private void groupBoxVisibility(bool isVisible, bool isPupil) { // Change visibillty of any relevent text boxes

            gbxUserLevelInfo.Location = gbxPointsInfo.Location; // Move box location (To prevent things becoming unwanted parents)

            gbxPupilInfo.Visible = isVisible;
            gbxNetworkUserInfo.Visible = isVisible;
            gbxHomeInfo.Visible = isVisible;
            gbxClassInfo.Visible = isVisible;

            if (isPupil) {
                gbxPupilInfo.Text = "Pupil Information";
                lblID.Text = "Pupil ID:";
            } else {
                gbxPupilInfo.Text = "Staff Information";
                lblID.Text = "Staff ID:";
            }

            if (isVisible) {// True
                if (isPupil) { // Some are different depening on if pupil/teacher
                    gbxPointsInfo.Visible = isVisible;
                } else {
                    gbxUserLevelInfo.Visible = isVisible;
                }
            } else { // False
                gbxPointsInfo.Visible = isVisible;
                gbxUserLevelInfo.Visible = isVisible;
            }
        }

        private void clearTextBoxes() { // Clear all text boxes
            string s = "";

            txtAddrL1.Text = s;
            txtAddrL2.Text = s;
            txtID.Text = s;
            txtMobile.Text = s;
            txtOtherNames.Text = s;
            txtPassword.Text = s;
            txtPhone.Text = s;
            txtPoints.Text = s;
            txtPostCode.Text = s;
            txtRegion.Text = s;
            txtSecurityQuestionResponce.Text = s;
            txtSurname.Text = s;
            txtTotalPoints.Text = s;
            txtUsername.Text = s;
            cbxTutor.SelectedIndex = 0;
            cbxYear.SelectedIndex = 0;
            cbxUserLevel.SelectedIndex = 0;
        }

        private void btnAllowEditing_Click(object sender, EventArgs e) {
            textBoxesLocked = false;
            btnCancel.Visible = true;

        }

        private bool textBoxesLocked { // Unlock the text boxes to allow editing
            get { return txtID.ReadOnly; }
            set {
                bool b = value;
                txtAddrL1.ReadOnly = b;
                txtAddrL2.ReadOnly = b;
                txtMobile.ReadOnly = b;
                txtOtherNames.ReadOnly = b;
                txtPassword.ReadOnly = b;
                txtPhone.ReadOnly = b;
                txtPoints.ReadOnly = b;
                txtPostCode.ReadOnly = b;
                txtRegion.ReadOnly = b;
                txtSecurityQuestionResponce.ReadOnly = b;
                txtSurname.ReadOnly = b;
                txtTotalPoints.ReadOnly = b;

                cbxSecurityQuestion.Enabled = !(b);
                cbxTutor.Enabled = !(b);
                cbxYear.Enabled = !(b);
                cbxUserLevel.Enabled = !(b);
            }
        }

        private void btnSaveEdits_Click(object sender, EventArgs e) { // Get all the data from the boxes into the correct tables
            // Perfrom validation
            if (isValidInputs(isPupil)) {
                textBoxesLocked = true; // Lock editing while updating
                btnCancel.Visible = false;
                fillDataSetFromForm(isPupil, false); // Get all the info from the form into the data set

                updateDbInfo(); // Move info from dataset to db
                pullDbInfo(); // Ensure form is updated

                // User feedback
                MessageBox.Show("Information Successfully Saved To Database", "Success", MessageBoxButtons.OK);
            }
        }

        private void updateDbInfo() { // Send db info to the dataset
            tblPupilsTableAdapter.Update(schoolDBDataSet.tblPupils);
            tblStaffTableAdapter.Update(schoolDBDataSet.tblStaff);
            tblNetworkUsersTableAdapter.Update(schoolDBDataSet.tblNetworkUsers);
        }

        private void fillDataSetFromForm(bool isPupil, bool isNewUser) {
            DataRow dataRow = null;
            int newUserId = 0;

            // Save general network information
            dataRow = schoolDBDataSet.tblNetworkUsers.NewRow();

            if (isNewUser) { // If new user generate new username
                String newUsername = generateNewUserName(isPupil);
                dataRow[1] = newUsername;
                txtUsername.Text = newUsername;
            }
            dataRow[2] = txtPassword.Text;
            dataRow[3] = cbxSecurityQuestion.SelectedValue;
            dataRow[4] = txtSecurityQuestionResponce.Text;

            if (isNewUser) { // If new user
                newUserId = Convert.ToInt32(schoolDBDataSet.tblNetworkUsers.Rows[schoolDBDataSet.tblNetworkUsers.Rows.Count - 1][0]) + 1;
                dataRow[0] = newUserId;
                schoolDBDataSet.tblNetworkUsers.Rows.Add(dataRow);
            }

            if (isPupil) { // If the user is a pupil
                if (!isNewUser) { // If we are editing an existing user
                    dataRow = schoolDBDataSet.tblPupils.Rows[Utillies.getPupilIndex(schoolDBDataSet, dbUserId)];
                } else { // If we are adding a new user
                    dataRow = schoolDBDataSet.tblPupils.NewRow();

                    dataRow[0] = txtID.Text;
                    dataRow[1] = newUserId;
                }

                dataRow[2] = cbxTutor.SelectedValue;
                dataRow[3] = cbxYear.SelectedValue;
                dataRow[4] = txtSurname.Text;
                dataRow[5] = txtOtherNames.Text;
                dataRow[6] = Convert.ToInt32(txtPoints.Text);
                dataRow[7] = Convert.ToInt32(txtTotalPoints.Text);
                dataRow[8] = txtMobile.Text;
                dataRow[9] = txtPhone.Text;
                dataRow[10] = txtAddrL1.Text;
                dataRow[11] = txtAddrL2.Text;
                dataRow[12] = txtRegion.Text;
                dataRow[13] = txtPostCode.Text.ToUpper();

                if (isNewUser) { // Add new row if it is new user
                    schoolDBDataSet.tblPupils.Rows.Add(dataRow);
                }
            } else { // If user is staff
                if (!isNewUser) { // If we are editing an existing user
                    dataRow = schoolDBDataSet.tblStaff.Rows[Utillies.getStaffIndex(schoolDBDataSet, dbUserId)];
                } else { // If we are adding a new user
                    dataRow = schoolDBDataSet.tblStaff.NewRow();

                    dataRow[0] = txtID.Text;
                    dataRow[1] = newUserId;
                }

                dataRow[2] = cbxTutor.SelectedValue;
                dataRow[3] = cbxYear.SelectedValue;
                dataRow[4] = cbxUserLevel.SelectedValue;
                dataRow[5] = txtSurname.Text;
                dataRow[6] = txtOtherNames.Text;
                dataRow[7] = txtMobile.Text;
                dataRow[8] = txtPhone.Text;
                dataRow[9] = txtAddrL1.Text;
                dataRow[10] = txtAddrL2.Text;
                dataRow[11] = txtRegion.Text;
                dataRow[12] = txtPostCode.Text.ToUpper();

                if (isNewUser) { // Add new row if it is a new user
                    schoolDBDataSet.tblStaff.Rows.Add(dataRow);
                    
                }
            }

        }

        private void btnNewUser_Click(object sender, EventArgs e) {
            // Display form for staff users
            isPupil = false;
            groupBoxVisibility(true, isPupil);
            btnSaveNewUser.Visible = true;
            btnSaveEdits.Visible = false;
            btnAllowEditing.Visible = false;
            btnNewPupilUser.Visible = false;
            btnNewStaffUser.Visible = false;
            btnCancel.Visible = true;
            txtUsername.Visible = false;
            btnClear.Visible = false;
            btnUsernameSearch.Visible = false;
            lblUsername.Visible = false;
            textBoxesLocked = false;

            // Set combo box to default values
            cbxSecurityQuestion.SelectedValue = -1;
            cbxTutor.SelectedValue = -1;
            cbxYear.SelectedValue = -1;
            cbxUserLevel.SelectedValue = -1;

            // Add text to boxes that require it
            txtID.Text = (Convert.ToInt32(schoolDBDataSet.tblStaff.Rows[schoolDBDataSet.tblStaff.Rows.Count - 1][0]) + 1).ToString();
            txtRegion.Text = "Cornwall";
        }

        private void btnNewPupilUser_Click(object sender, EventArgs e) {
            // Display form info for pupil users
            isPupil = true;
            groupBoxVisibility(true, isPupil);
            btnSaveNewUser.Visible = true;
            btnSaveEdits.Visible = false;
            btnAllowEditing.Visible = false;
            btnNewPupilUser.Visible = false;
            btnNewStaffUser.Visible = false;
            btnCancel.Visible = true;
            txtUsername.Visible = false;
            btnClear.Visible = false;
            btnUsernameSearch.Visible = false;
            lblUsername.Visible = false;
            textBoxesLocked = false;

           // Set combo boxes to default values
            cbxSecurityQuestion.SelectedValue = -1;
            cbxTutor.SelectedValue = -1;
            cbxYear.SelectedValue = -1;

            // Add text to boxes that require it
            txtPoints.Text = "0";
            txtTotalPoints.Text = "0";
            txtRegion.Text = "Cornwall";
            txtID.Text = (Convert.ToInt32(schoolDBDataSet.tblPupils.Rows[schoolDBDataSet.tblPupils.Rows.Count - 1][0]) + 1).ToString();
        }

        private void btnSaveNewUser_Click(object sender, EventArgs e) {
            // Perform validation
            if (isValidInputs(isPupil)) {
                // Hide/Show various tbxs
                btnSaveNewUser.Visible = false;
                btnNewPupilUser.Visible = true;
                btnNewStaffUser.Visible = true;
                btnCancel.Visible = false;
                btnUsernameSearch.Visible = true;
                btnClear.Visible = true;
                lblUsername.Visible = true;
                txtUsername.Visible = true;

                // Fills the data row with form info as a new user
                fillDataSetFromForm(isPupil, true);

                MessageBox.Show("New User Added\nUsername: " + txtUsername.Text + "\nPassword: " + txtPassword.Text, "New User Added", MessageBoxButtons.OK);

                clearTextBoxes();
                textBoxesLocked = true;

                groupBoxVisibility(false, isPupil);

                // Updae info and pull the db info back down
                updateDbInfo();
                pullDbInfo();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) { // Reset Form To Empty to start again
            var msgBoxResult = MessageBox.Show("Are you sure you want to cancel text entry", "Cancel Editing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgBoxResult == DialogResult.Yes) { // if text erntry is canceled
                groupBoxVisibility(false, isPupil);
                textBoxesLocked = true;
                btnSaveEdits.Visible = false;
                btnAllowEditing.Visible = false;
                btnCancel.Visible = false;
                btnSaveNewUser.Visible = false;
                btnNewPupilUser.Visible = true;
                btnNewStaffUser.Visible = true;
                btnUsernameSearch.Visible = true;
                btnClear.Visible = true;
                lblUsername.Visible = true;
                txtUsername.Visible = true;
                clearTextBoxes();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { // Clear all boxes, to reset form
            if (btnCancel.Visible) { // If there is a possiblity of editing being lost
                MessageBox.Show("Ensure you have finished editing all boxes", "Are you done?", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            } else {
                // If we are certain no editing is happening
                txtUsername.Text = "";
                clearTextBoxes();
                groupBoxVisibility(false, false);
                btnNewPupilUser.Visible = true;
                btnNewStaffUser.Visible = true;
                btnSaveEdits.Visible = false;
                btnAllowEditing.Visible = false;
            }
        }

        private string generateNewUserName(bool isPupil) {
            string Username = "";

            // Getting the two letters in the username
            Username += txtOtherNames.Text.ToLower()[0];
            Username += txtSurname.Text.ToLower()[0];

            if (isPupil) {
                Username += "1";
            } // start username with 1 if pupil

            // Add the 0's
            Username = Username.PadRight(8 - txtID.Text.Length, '0');
            // Add the ID
            Username += txtID.Text;

            return Username; // return
        }

        private bool isValidInputs(bool isPupil) {
            string zeroLengthError = "Input box cannot be empty"; // Error to append to zero length

            formatInputs(); // Ensure all text is formatted correctly

            // Catch error
            try {
                // For every item on the form
                foreach (Control control in this.Controls) {
                    // If it a textbox
                    if (control is TextBox) {
                        // Check zero length
                        checkZeroLength(control, isPupil, zeroLengthError);
                    // If Control is combo box
                    } else if (control is ComboBox) {
                        // Check selection
                        checkComboBoxSelection(control, isPupil);
                    // If control is group box
                    } else if (control is GroupBox) {
                        // Check every control in the group box
                        foreach (Control gbControl in control.Controls) {
                            // If sub control text box
                            if (gbControl is TextBox) {
                                // Check zero length
                                checkZeroLength(gbControl, isPupil, zeroLengthError);
                            // if sub control is combo box
                            } else if (gbControl is ComboBox) {
                                // Check selection
                                checkComboBoxSelection(gbControl, isPupil);
                            }
                        }
                    }
                }

                if (isPupil) {
                    isValidPointsInt(); // Ensure points are valid ints
                }
                checkValidPhoneNumbers(); // Ensure phone numbers are valid
                checkValidPostCode(); // Ensure post code is valid
                checkPasswordValidity();

                return true;
            } catch (invalidInputException iEx) {
                MessageBox.Show("Validation Unsuccessful: \n" + iEx.Message, "Validation Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void formatInputs() {
            // For all controls
            foreach (Control control in this.Controls) {
                // If control is texbox
                if (control is TextBox) {
                    TextBox tb = (TextBox)control;
                    // Trim all boxes
                    tb.Text = tb.Text.Trim();

                    // If control is group box
                } else if (control is GroupBox) {
                    // Check every control in the group box
                    foreach (Control gbControl in control.Controls) {
                        // If sub control is text box
                        if (gbControl is TextBox) {
                            TextBox tb = (TextBox)gbControl;

                            // Trim all boxes
                            tb.Text = tb.Text.Trim();
                        }
                    }
                }
            }
        }

        private void checkZeroLength(Control control, bool isPupil, string zeroLengthError) { // Check for 0 length text boxes
            TextBox tb = (TextBox)control;
            string[] allowedEmptyBoxes;

            // List of textboxes with all length allowed to be 0
            if (isPupil) {
                allowedEmptyBoxes = new string[] { "txtUsername", "txtAddrL2", "txtPhone" };
            } else {
                allowedEmptyBoxes = new string[] { "txtUsername", "txtAddrL2", "txtPhone", "txtPoints", "txtTotalPoints" }; // Staff dont have points
            }

            // If text box name is not in the above list
            if (!allowedEmptyBoxes.Contains(tb.Name)) {
                // If the length is 0
                if (tb.Text.Length == 0) {
                    throw new invalidInputException("TextBox: " + tb.AccessibleName + "\nError: " + zeroLengthError);
                }
            }
        }

        private void isValidPointsInt() { // Are point boxes valid ints (Integer that is >= 0)
            int points, totalPoints;
            try { // Try to convert to int first
                points = Convert.ToInt32(txtPoints.Text);
                totalPoints = Convert.ToInt32(txtTotalPoints.Text);
            } catch (FormatException) { // If conversion failed
                throw new invalidInputException("TextBox: Points/Total Points\nError: Ensure points are inputted as numbers only");
            } catch (OverflowException) { // If Int is overflowed
                throw new invalidInputException("TextBox: Points/Total Points\nError: Overflow, consider using smaller numbers");
            }
        }

        private void checkValidPostCode() { // Check valid uk postcode
            // Regex Pattern
            string ukPostCodePattern = @"^([A-PR-UWYZ0-9][A-HK-Y0-9][AEHMNPRTVXY0-9]?[ABEHMNPRVWXY0-9]{1,2}[0-9][ABD-HJLN-UW-Z]{2}|GIR 0AA)$";
            string inputPostCode = txtPostCode.Text.ToUpper().Replace(" ", ""); // Input from form (with no spaces, accounting for postcodes written as AA00 0AA and AA000AA)

            Regex regex = new Regex(ukPostCodePattern); // Create regex from above pattern
            Match match = regex.Match(inputPostCode); // See if the postcode matches the regex pattern

            if (!(match.Success)) { // If there is no match, throw error
                throw new invalidInputException("TextBox: " + txtPostCode.AccessibleName + "\nError: " + "'" + inputPostCode + "' is not a valid UK Post Code");
            }
        }

        private void checkValidPhoneNumbers() { // Check for valid uk phone numbers (format)
            // Regex Pattern
            Match match;
            string ukPhoneNumberPattern = @"(((\+44)? ?(\(0\))? ?)|(0))( ?[0-9]{3,4}){3}";

            string mobileInput = txtMobile.Text.Replace(" ", "");
            string phoneInput = txtPhone.Text.Replace(" ", "");

            Regex regex = new Regex(ukPhoneNumberPattern); // Create regex from above pattern

            if (txtPhone.Text.Length != 0) { // If phone box IS NOT empty
                match = regex.Match(phoneInput); // See if phone input matches the pattern
                if (!(match.Success)) { // If there is no match, throw error
                    throw new invalidInputException("TextBox: " + txtPhone.AccessibleName + "\nError: " + "'" + phoneInput + "' is not a valid UK Phone Number");
                }
            }
            // Regardless of phone being empty, check mobile as it is required
            match = regex.Match(mobileInput); // See if mobile input matches the pattern
            if (!(match.Success)) { // If there is no match, throw error
                throw new invalidInputException("TextBox: " + txtPhone.AccessibleName + "\nError: " + "'" + mobileInput + "' is not a valid UK Phone Number");
            }
        }
        private void checkComboBoxSelection(Control control, bool isPupil) { // Ensure the box is selected
            ComboBox cb = (ComboBox)control;
            List<string> allowedEmptyBoxes;

            // List of combo boxes with allowed empty
            if (isPupil) {
                allowedEmptyBoxes = new List<string> { "cbxUserLevel" };
            } else {
                allowedEmptyBoxes = new List<string> { };
            }

            if (!allowedEmptyBoxes.Contains(cb.Name)) {
                if (cb.SelectedIndex < 0) { // If combobox has not got a slection
                    throw new invalidInputException("Selection Box: " + cb.AccessibleName + "\nError: Selected Index is not valid, please select an item");
                }
            }
        }

        private void checkPasswordValidity() { // Ensure passwords are valid
            int passLength = 6;
            if (!Utillies.isValidPassword(txtPassword.Text, passLength)) {
                throw new invalidInputException("Password:\nError: Password is not valid, ensure the following are true:" +
                    "\n- Length is greater than " + (passLength - 1).ToString() +
                    "\n- Has a lower case character" +
                    "\n- Has an upper case character" +
                    "\n- Has a number" +
                    "\n- Has a symbol" +
                    "\n- Is not common like 'password'");
            }
        }
    }  
}
