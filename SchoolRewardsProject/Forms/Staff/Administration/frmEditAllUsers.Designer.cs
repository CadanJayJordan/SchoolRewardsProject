namespace SchoolRewardsProject.Forms.Staff.Administration {
    partial class frmEditAllUsers {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnUsernameSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblOtherNames = new System.Windows.Forms.Label();
            this.txtOtherNames = new System.Windows.Forms.TextBox();
            this.gbxPupilInfo = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tblNetworkUsersBS = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolRewardsProject.schoolDBDataSet();
            this.tblNetworkUsersTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblNetworkUsersTableAdapter();
            this.tblPupilsBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblPupilsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblPupilsTableAdapter();
            this.tblStaffBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblStaffTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblStaffTableAdapter();
            this.cbxSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.tblSecurityQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSecurityQuestionsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblSecurityQuestionsTableAdapter();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.gbxNetworkUserInfo = new System.Windows.Forms.GroupBox();
            this.txtSecurityQuestionResponce = new System.Windows.Forms.TextBox();
            this.lblSecurityQuestionResponce = new System.Windows.Forms.Label();
            this.gbxHomeInfo = new System.Windows.Forms.GroupBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblAddrL2 = new System.Windows.Forms.Label();
            this.txtAddrL2 = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddrL1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddrL1 = new System.Windows.Forms.TextBox();
            this.gbxClassInfo = new System.Windows.Forms.GroupBox();
            this.cbxTutor = new System.Windows.Forms.ComboBox();
            this.tblTutorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.tblYearGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.gbxPointsInfo = new System.Windows.Forms.GroupBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPoints = new System.Windows.Forms.TextBox();
            this.gbxUserLevelInfo = new System.Windows.Forms.GroupBox();
            this.cbxUserLevel = new System.Windows.Forms.ComboBox();
            this.tblUserLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.btnAllowEditing = new System.Windows.Forms.Button();
            this.btnSaveEdits = new System.Windows.Forms.Button();
            this.tblYearGroupTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblYearGroupTableAdapter();
            this.tblTutorsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblTutorsTableAdapter();
            this.tblUserLevelsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblUserLevelsTableAdapter();
            this.btnNewStaffUser = new System.Windows.Forms.Button();
            this.btnNewPupilUser = new System.Windows.Forms.Button();
            this.btnSaveNewUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxPupilInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNetworkUsersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityQuestionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSetBindingSource)).BeginInit();
            this.gbxNetworkUserInfo.SuspendLayout();
            this.gbxHomeInfo.SuspendLayout();
            this.gbxClassInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYearGroupBindingSource)).BeginInit();
            this.gbxPointsInfo.SuspendLayout();
            this.gbxUserLevelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserLevelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(76, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "txtUsername";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // btnUsernameSearch
            // 
            this.btnUsernameSearch.Location = new System.Drawing.Point(101, 51);
            this.btnUsernameSearch.Name = "btnUsernameSearch";
            this.btnUsernameSearch.Size = new System.Drawing.Size(75, 23);
            this.btnUsernameSearch.TabIndex = 2;
            this.btnUsernameSearch.Text = "Search";
            this.btnUsernameSearch.UseVisualStyleBackColor = true;
            this.btnUsernameSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.AccessibleDescription = "Last Name";
            this.txtSurname.AccessibleName = "Surname";
            this.txtSurname.Location = new System.Drawing.Point(94, 41);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.Text = "txtSurname";
            // 
            // lblOtherNames
            // 
            this.lblOtherNames.AutoSize = true;
            this.lblOtherNames.Location = new System.Drawing.Point(7, 70);
            this.lblOtherNames.Name = "lblOtherNames";
            this.lblOtherNames.Size = new System.Drawing.Size(78, 13);
            this.lblOtherNames.TabIndex = 6;
            this.lblOtherNames.Text = "Other Name(s):";
            // 
            // txtOtherNames
            // 
            this.txtOtherNames.AccessibleDescription = "First and other names besides the surname";
            this.txtOtherNames.AccessibleName = "Other Name(s)";
            this.txtOtherNames.Location = new System.Drawing.Point(94, 67);
            this.txtOtherNames.Name = "txtOtherNames";
            this.txtOtherNames.ReadOnly = true;
            this.txtOtherNames.Size = new System.Drawing.Size(100, 20);
            this.txtOtherNames.TabIndex = 5;
            this.txtOtherNames.Text = "txtOtherNames";
            // 
            // gbxPupilInfo
            // 
            this.gbxPupilInfo.Controls.Add(this.lblID);
            this.gbxPupilInfo.Controls.Add(this.txtID);
            this.gbxPupilInfo.Controls.Add(this.label1);
            this.gbxPupilInfo.Controls.Add(this.lblOtherNames);
            this.gbxPupilInfo.Controls.Add(this.txtSurname);
            this.gbxPupilInfo.Controls.Add(this.txtOtherNames);
            this.gbxPupilInfo.Location = new System.Drawing.Point(12, 92);
            this.gbxPupilInfo.Name = "gbxPupilInfo";
            this.gbxPupilInfo.Size = new System.Drawing.Size(200, 105);
            this.gbxPupilInfo.TabIndex = 7;
            this.gbxPupilInfo.TabStop = false;
            this.gbxPupilInfo.Text = "Staff/Pupil Information";
            this.gbxPupilInfo.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(74, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "Staff/Pupil ID:";
            // 
            // txtID
            // 
            this.txtID.AccessibleDescription = "Staff/Pupil ID";
            this.txtID.AccessibleName = "Staff/Pupil ID";
            this.txtID.Location = new System.Drawing.Point(94, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "txtID";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(96, 45);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(75, 23);
            this.btnShowPassword.TabIndex = 10;
            this.btnShowPassword.Text = "Show";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 22);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleDescription = "Password";
            this.txtPassword.AccessibleName = "Password";
            this.txtPassword.Location = new System.Drawing.Point(71, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "txtPassword";
            // 
            // tblNetworkUsersBS
            // 
            this.tblNetworkUsersBS.DataMember = "tblNetworkUsers";
            this.tblNetworkUsersBS.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "schoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNetworkUsersTableAdapter
            // 
            this.tblNetworkUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tblPupilsBS
            // 
            this.tblPupilsBS.DataMember = "tblPupils";
            this.tblPupilsBS.DataSource = this.schoolDBDataSet;
            // 
            // tblPupilsTableAdapter
            // 
            this.tblPupilsTableAdapter.ClearBeforeFill = true;
            // 
            // tblStaffBS
            // 
            this.tblStaffBS.DataMember = "tblStaff";
            this.tblStaffBS.DataSource = this.schoolDBDataSet;
            // 
            // tblStaffTableAdapter
            // 
            this.tblStaffTableAdapter.ClearBeforeFill = true;
            // 
            // cbxSecurityQuestion
            // 
            this.cbxSecurityQuestion.AccessibleName = "Security Question";
            this.cbxSecurityQuestion.DataSource = this.tblSecurityQuestionsBindingSource;
            this.cbxSecurityQuestion.DisplayMember = "SecurityQuestion";
            this.cbxSecurityQuestion.Enabled = false;
            this.cbxSecurityQuestion.FormattingEnabled = true;
            this.cbxSecurityQuestion.Location = new System.Drawing.Point(346, 19);
            this.cbxSecurityQuestion.Name = "cbxSecurityQuestion";
            this.cbxSecurityQuestion.Size = new System.Drawing.Size(251, 21);
            this.cbxSecurityQuestion.TabIndex = 11;
            this.cbxSecurityQuestion.ValueMember = "SecurityQuestionID";
            // 
            // tblSecurityQuestionsBindingSource
            // 
            this.tblSecurityQuestionsBindingSource.DataMember = "tblSecurityQuestions";
            this.tblSecurityQuestionsBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSetBindingSource
            // 
            this.schoolDBDataSetBindingSource.DataSource = this.schoolDBDataSet;
            this.schoolDBDataSetBindingSource.Position = 0;
            // 
            // tblSecurityQuestionsTableAdapter
            // 
            this.tblSecurityQuestionsTableAdapter.ClearBeforeFill = true;
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(247, 22);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(93, 13);
            this.lblSecurityQuestion.TabIndex = 12;
            this.lblSecurityQuestion.Text = "Security Question:";
            // 
            // gbxNetworkUserInfo
            // 
            this.gbxNetworkUserInfo.Controls.Add(this.txtSecurityQuestionResponce);
            this.gbxNetworkUserInfo.Controls.Add(this.lblSecurityQuestionResponce);
            this.gbxNetworkUserInfo.Controls.Add(this.txtPassword);
            this.gbxNetworkUserInfo.Controls.Add(this.lblSecurityQuestion);
            this.gbxNetworkUserInfo.Controls.Add(this.lblPassword);
            this.gbxNetworkUserInfo.Controls.Add(this.cbxSecurityQuestion);
            this.gbxNetworkUserInfo.Controls.Add(this.btnShowPassword);
            this.gbxNetworkUserInfo.Location = new System.Drawing.Point(182, 6);
            this.gbxNetworkUserInfo.Name = "gbxNetworkUserInfo";
            this.gbxNetworkUserInfo.Size = new System.Drawing.Size(612, 80);
            this.gbxNetworkUserInfo.TabIndex = 13;
            this.gbxNetworkUserInfo.TabStop = false;
            this.gbxNetworkUserInfo.Text = "Network User Information";
            this.gbxNetworkUserInfo.Visible = false;
            // 
            // txtSecurityQuestionResponce
            // 
            this.txtSecurityQuestionResponce.AccessibleDescription = "Security Question Answer";
            this.txtSecurityQuestionResponce.AccessibleName = "Security Question Responce";
            this.txtSecurityQuestionResponce.Location = new System.Drawing.Point(346, 48);
            this.txtSecurityQuestionResponce.Name = "txtSecurityQuestionResponce";
            this.txtSecurityQuestionResponce.ReadOnly = true;
            this.txtSecurityQuestionResponce.Size = new System.Drawing.Size(251, 20);
            this.txtSecurityQuestionResponce.TabIndex = 9;
            this.txtSecurityQuestionResponce.Text = "txtSecurityQuestionResponce";
            // 
            // lblSecurityQuestionResponce
            // 
            this.lblSecurityQuestionResponce.AutoSize = true;
            this.lblSecurityQuestionResponce.Location = new System.Drawing.Point(195, 51);
            this.lblSecurityQuestionResponce.Name = "lblSecurityQuestionResponce";
            this.lblSecurityQuestionResponce.Size = new System.Drawing.Size(145, 13);
            this.lblSecurityQuestionResponce.TabIndex = 13;
            this.lblSecurityQuestionResponce.Text = "Security Question Responce:";
            // 
            // gbxHomeInfo
            // 
            this.gbxHomeInfo.Controls.Add(this.lblPostcode);
            this.gbxHomeInfo.Controls.Add(this.txtPostCode);
            this.gbxHomeInfo.Controls.Add(this.lblRegion);
            this.gbxHomeInfo.Controls.Add(this.txtRegion);
            this.gbxHomeInfo.Controls.Add(this.lblAddrL2);
            this.gbxHomeInfo.Controls.Add(this.txtAddrL2);
            this.gbxHomeInfo.Controls.Add(this.lblMobile);
            this.gbxHomeInfo.Controls.Add(this.txtMobile);
            this.gbxHomeInfo.Controls.Add(this.lblPhone);
            this.gbxHomeInfo.Controls.Add(this.lblAddrL1);
            this.gbxHomeInfo.Controls.Add(this.txtPhone);
            this.gbxHomeInfo.Controls.Add(this.txtAddrL1);
            this.gbxHomeInfo.Location = new System.Drawing.Point(224, 92);
            this.gbxHomeInfo.Name = "gbxHomeInfo";
            this.gbxHomeInfo.Size = new System.Drawing.Size(570, 105);
            this.gbxHomeInfo.TabIndex = 9;
            this.gbxHomeInfo.TabStop = false;
            this.gbxHomeInfo.Text = "Home Information";
            this.gbxHomeInfo.Visible = false;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(311, 70);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(59, 13);
            this.lblPostcode.TabIndex = 14;
            this.lblPostcode.Text = "Post Code:";
            // 
            // txtPostCode
            // 
            this.txtPostCode.AccessibleDescription = "Post Code";
            this.txtPostCode.AccessibleName = "Post Code";
            this.txtPostCode.Location = new System.Drawing.Point(378, 67);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.ReadOnly = true;
            this.txtPostCode.Size = new System.Drawing.Size(94, 20);
            this.txtPostCode.TabIndex = 13;
            this.txtPostCode.Text = "txtPostCode";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(311, 44);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 12;
            this.lblRegion.Text = "Region:";
            // 
            // txtRegion
            // 
            this.txtRegion.AccessibleDescription = "Postal Region";
            this.txtRegion.AccessibleName = "Region";
            this.txtRegion.Location = new System.Drawing.Point(378, 41);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.ReadOnly = true;
            this.txtRegion.Size = new System.Drawing.Size(177, 20);
            this.txtRegion.TabIndex = 11;
            this.txtRegion.Text = "txtRegion";
            // 
            // lblAddrL2
            // 
            this.lblAddrL2.AutoSize = true;
            this.lblAddrL2.Location = new System.Drawing.Point(7, 70);
            this.lblAddrL2.Name = "lblAddrL2";
            this.lblAddrL2.Size = new System.Drawing.Size(86, 13);
            this.lblAddrL2.TabIndex = 10;
            this.lblAddrL2.Text = "Address (Line 2):";
            // 
            // txtAddrL2
            // 
            this.txtAddrL2.AccessibleDescription = "Address Line 2 (Optional)";
            this.txtAddrL2.AccessibleName = "Address Line 2";
            this.txtAddrL2.Location = new System.Drawing.Point(94, 67);
            this.txtAddrL2.Name = "txtAddrL2";
            this.txtAddrL2.ReadOnly = true;
            this.txtAddrL2.Size = new System.Drawing.Size(211, 20);
            this.txtAddrL2.TabIndex = 9;
            this.txtAddrL2.Text = "txtAddrL2";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(6, 18);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(81, 13);
            this.lblMobile.TabIndex = 8;
            this.lblMobile.Text = "Contact Mobile:";
            // 
            // txtMobile
            // 
            this.txtMobile.AccessibleDescription = "Mobile Phone Number";
            this.txtMobile.AccessibleName = "Mobile";
            this.txtMobile.Location = new System.Drawing.Point(94, 15);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(177, 20);
            this.txtMobile.TabIndex = 7;
            this.txtMobile.Text = "txtMobile";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(274, 18);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(81, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Contact Phone:";
            // 
            // lblAddrL1
            // 
            this.lblAddrL1.AutoSize = true;
            this.lblAddrL1.Location = new System.Drawing.Point(7, 44);
            this.lblAddrL1.Name = "lblAddrL1";
            this.lblAddrL1.Size = new System.Drawing.Size(86, 13);
            this.lblAddrL1.TabIndex = 6;
            this.lblAddrL1.Text = "Address (Line 1):";
            // 
            // txtPhone
            // 
            this.txtPhone.AccessibleDescription = "House Phone Number (Optional)";
            this.txtPhone.AccessibleName = "Phone";
            this.txtPhone.Location = new System.Drawing.Point(361, 15);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(194, 20);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Text = "txtPhone";
            // 
            // txtAddrL1
            // 
            this.txtAddrL1.AccessibleDescription = "Address Line 1";
            this.txtAddrL1.AccessibleName = "Address Line 1";
            this.txtAddrL1.Location = new System.Drawing.Point(94, 41);
            this.txtAddrL1.Name = "txtAddrL1";
            this.txtAddrL1.ReadOnly = true;
            this.txtAddrL1.Size = new System.Drawing.Size(211, 20);
            this.txtAddrL1.TabIndex = 5;
            this.txtAddrL1.Text = "txtAddrL1";
            // 
            // gbxClassInfo
            // 
            this.gbxClassInfo.Controls.Add(this.cbxTutor);
            this.gbxClassInfo.Controls.Add(this.cbxYear);
            this.gbxClassInfo.Controls.Add(this.lblYear);
            this.gbxClassInfo.Controls.Add(this.lblTutor);
            this.gbxClassInfo.Location = new System.Drawing.Point(12, 203);
            this.gbxClassInfo.Name = "gbxClassInfo";
            this.gbxClassInfo.Size = new System.Drawing.Size(200, 74);
            this.gbxClassInfo.TabIndex = 9;
            this.gbxClassInfo.TabStop = false;
            this.gbxClassInfo.Text = "Class Information";
            this.gbxClassInfo.Visible = false;
            // 
            // cbxTutor
            // 
            this.cbxTutor.AccessibleName = "Tutor";
            this.cbxTutor.DataSource = this.tblTutorsBindingSource;
            this.cbxTutor.DisplayMember = "TutorCode";
            this.cbxTutor.Enabled = false;
            this.cbxTutor.FormattingEnabled = true;
            this.cbxTutor.Location = new System.Drawing.Point(94, 41);
            this.cbxTutor.Name = "cbxTutor";
            this.cbxTutor.Size = new System.Drawing.Size(100, 21);
            this.cbxTutor.TabIndex = 10;
            this.cbxTutor.ValueMember = "TutorID";
            // 
            // tblTutorsBindingSource
            // 
            this.tblTutorsBindingSource.DataMember = "tblTutors";
            this.tblTutorsBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // cbxYear
            // 
            this.cbxYear.AccessibleName = "Year";
            this.cbxYear.DataSource = this.tblYearGroupBindingSource;
            this.cbxYear.DisplayMember = "Year Name";
            this.cbxYear.Enabled = false;
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(94, 9);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(100, 21);
            this.cbxYear.TabIndex = 9;
            this.cbxYear.ValueMember = "YearID";
            // 
            // tblYearGroupBindingSource
            // 
            this.tblYearGroupBindingSource.DataMember = "tblYearGroup";
            this.tblYearGroupBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(6, 18);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year:";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Location = new System.Drawing.Point(6, 44);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(35, 13);
            this.lblTutor.TabIndex = 4;
            this.lblTutor.Text = "Tutor:";
            // 
            // gbxPointsInfo
            // 
            this.gbxPointsInfo.Controls.Add(this.lblPoints);
            this.gbxPointsInfo.Controls.Add(this.txtPoints);
            this.gbxPointsInfo.Controls.Add(this.label3);
            this.gbxPointsInfo.Controls.Add(this.txtTotalPoints);
            this.gbxPointsInfo.Location = new System.Drawing.Point(224, 203);
            this.gbxPointsInfo.Name = "gbxPointsInfo";
            this.gbxPointsInfo.Size = new System.Drawing.Size(200, 74);
            this.gbxPointsInfo.TabIndex = 10;
            this.gbxPointsInfo.TabStop = false;
            this.gbxPointsInfo.Text = "Points Information";
            this.gbxPointsInfo.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.ForeColor = System.Drawing.Color.Black;
            this.lblPoints.Location = new System.Drawing.Point(6, 18);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(76, 13);
            this.lblPoints.TabIndex = 8;
            this.lblPoints.Text = "Current Points:";
            // 
            // txtPoints
            // 
            this.txtPoints.AccessibleDescription = "Current points assosiated to the students account";
            this.txtPoints.AccessibleName = "Current Points";
            this.txtPoints.Location = new System.Drawing.Point(94, 15);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.ReadOnly = true;
            this.txtPoints.Size = new System.Drawing.Size(100, 20);
            this.txtPoints.TabIndex = 7;
            this.txtPoints.Text = "txtPoints";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Points:";
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.AccessibleDescription = "Total points assosiated to the students account";
            this.txtTotalPoints.AccessibleName = "Total Points";
            this.txtTotalPoints.Location = new System.Drawing.Point(94, 41);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.ReadOnly = true;
            this.txtTotalPoints.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPoints.TabIndex = 3;
            this.txtTotalPoints.Text = "txtTotalPoints";
            // 
            // gbxUserLevelInfo
            // 
            this.gbxUserLevelInfo.Controls.Add(this.cbxUserLevel);
            this.gbxUserLevelInfo.Controls.Add(this.lblUserLevel);
            this.gbxUserLevelInfo.Location = new System.Drawing.Point(432, 203);
            this.gbxUserLevelInfo.Name = "gbxUserLevelInfo";
            this.gbxUserLevelInfo.Size = new System.Drawing.Size(200, 45);
            this.gbxUserLevelInfo.TabIndex = 11;
            this.gbxUserLevelInfo.TabStop = false;
            this.gbxUserLevelInfo.Text = "User Level Information";
            this.gbxUserLevelInfo.Visible = false;
            // 
            // cbxUserLevel
            // 
            this.cbxUserLevel.AccessibleName = "User Level";
            this.cbxUserLevel.DataSource = this.tblUserLevelsBindingSource;
            this.cbxUserLevel.DisplayMember = "UserLevelName";
            this.cbxUserLevel.Enabled = false;
            this.cbxUserLevel.FormattingEnabled = true;
            this.cbxUserLevel.Location = new System.Drawing.Point(69, 15);
            this.cbxUserLevel.Name = "cbxUserLevel";
            this.cbxUserLevel.Size = new System.Drawing.Size(125, 21);
            this.cbxUserLevel.TabIndex = 11;
            this.cbxUserLevel.ValueMember = "UserLevelID";
            // 
            // tblUserLevelsBindingSource
            // 
            this.tblUserLevelsBindingSource.DataMember = "tblUserLevels";
            this.tblUserLevelsBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.ForeColor = System.Drawing.Color.Black;
            this.lblUserLevel.Location = new System.Drawing.Point(6, 18);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(61, 13);
            this.lblUserLevel.TabIndex = 8;
            this.lblUserLevel.Text = "User Level:";
            // 
            // btnAllowEditing
            // 
            this.btnAllowEditing.Location = new System.Drawing.Point(704, 203);
            this.btnAllowEditing.Name = "btnAllowEditing";
            this.btnAllowEditing.Size = new System.Drawing.Size(75, 23);
            this.btnAllowEditing.TabIndex = 9;
            this.btnAllowEditing.Text = "Allow Editing";
            this.btnAllowEditing.UseVisualStyleBackColor = true;
            this.btnAllowEditing.Visible = false;
            this.btnAllowEditing.Click += new System.EventHandler(this.btnAllowEditing_Click);
            // 
            // btnSaveEdits
            // 
            this.btnSaveEdits.Location = new System.Drawing.Point(704, 232);
            this.btnSaveEdits.Name = "btnSaveEdits";
            this.btnSaveEdits.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEdits.TabIndex = 14;
            this.btnSaveEdits.Text = "Save Edits";
            this.btnSaveEdits.UseVisualStyleBackColor = true;
            this.btnSaveEdits.Visible = false;
            this.btnSaveEdits.Click += new System.EventHandler(this.btnSaveEdits_Click);
            // 
            // tblYearGroupTableAdapter
            // 
            this.tblYearGroupTableAdapter.ClearBeforeFill = true;
            // 
            // tblTutorsTableAdapter
            // 
            this.tblTutorsTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserLevelsTableAdapter
            // 
            this.tblUserLevelsTableAdapter.ClearBeforeFill = true;
            // 
            // btnNewStaffUser
            // 
            this.btnNewStaffUser.Location = new System.Drawing.Point(602, 203);
            this.btnNewStaffUser.Name = "btnNewStaffUser";
            this.btnNewStaffUser.Size = new System.Drawing.Size(96, 23);
            this.btnNewStaffUser.TabIndex = 15;
            this.btnNewStaffUser.Text = "New Staff User";
            this.btnNewStaffUser.UseVisualStyleBackColor = true;
            this.btnNewStaffUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnNewPupilUser
            // 
            this.btnNewPupilUser.Location = new System.Drawing.Point(602, 232);
            this.btnNewPupilUser.Name = "btnNewPupilUser";
            this.btnNewPupilUser.Size = new System.Drawing.Size(94, 23);
            this.btnNewPupilUser.TabIndex = 16;
            this.btnNewPupilUser.Text = "New Pupil User";
            this.btnNewPupilUser.UseVisualStyleBackColor = true;
            this.btnNewPupilUser.Click += new System.EventHandler(this.btnNewPupilUser_Click);
            // 
            // btnSaveNewUser
            // 
            this.btnSaveNewUser.Location = new System.Drawing.Point(602, 261);
            this.btnSaveNewUser.Name = "btnSaveNewUser";
            this.btnSaveNewUser.Size = new System.Drawing.Size(94, 23);
            this.btnSaveNewUser.TabIndex = 17;
            this.btnSaveNewUser.Text = "Save New User";
            this.btnSaveNewUser.UseVisualStyleBackColor = true;
            this.btnSaveNewUser.Visible = false;
            this.btnSaveNewUser.Click += new System.EventHandler(this.btnSaveNewUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(704, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(20, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmEditAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveNewUser);
            this.Controls.Add(this.btnNewPupilUser);
            this.Controls.Add(this.btnNewStaffUser);
            this.Controls.Add(this.btnSaveEdits);
            this.Controls.Add(this.btnAllowEditing);
            this.Controls.Add(this.gbxUserLevelInfo);
            this.Controls.Add(this.gbxPointsInfo);
            this.Controls.Add(this.gbxClassInfo);
            this.Controls.Add(this.gbxHomeInfo);
            this.Controls.Add(this.gbxNetworkUserInfo);
            this.Controls.Add(this.gbxPupilInfo);
            this.Controls.Add(this.btnUsernameSearch);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditAllUsers";
            this.Text = "School Points - Administration - Edit All Users";
            this.Load += new System.EventHandler(this.frmEditAllUsers_Load);
            this.gbxPupilInfo.ResumeLayout(false);
            this.gbxPupilInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblNetworkUsersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSecurityQuestionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSetBindingSource)).EndInit();
            this.gbxNetworkUserInfo.ResumeLayout(false);
            this.gbxNetworkUserInfo.PerformLayout();
            this.gbxHomeInfo.ResumeLayout(false);
            this.gbxHomeInfo.PerformLayout();
            this.gbxClassInfo.ResumeLayout(false);
            this.gbxClassInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTutorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblYearGroupBindingSource)).EndInit();
            this.gbxPointsInfo.ResumeLayout(false);
            this.gbxPointsInfo.PerformLayout();
            this.gbxUserLevelInfo.ResumeLayout(false);
            this.gbxUserLevelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserLevelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tblNetworkUsersBS;
        private schoolDBDataSet schoolDBDataSet;
        private schoolDBDataSetTableAdapters.tblNetworkUsersTableAdapter tblNetworkUsersTableAdapter;
        private System.Windows.Forms.BindingSource tblPupilsBS;
        private schoolDBDataSetTableAdapters.tblPupilsTableAdapter tblPupilsTableAdapter;
        private System.Windows.Forms.BindingSource tblStaffBS;
        private schoolDBDataSetTableAdapters.tblStaffTableAdapter tblStaffTableAdapter;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnUsernameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblOtherNames;
        private System.Windows.Forms.TextBox txtOtherNames;
        private System.Windows.Forms.GroupBox gbxPupilInfo;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxSecurityQuestion;
        private System.Windows.Forms.BindingSource schoolDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblSecurityQuestionsBindingSource;
        private schoolDBDataSetTableAdapters.tblSecurityQuestionsTableAdapter tblSecurityQuestionsTableAdapter;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.GroupBox gbxNetworkUserInfo;
        private System.Windows.Forms.TextBox txtSecurityQuestionResponce;
        private System.Windows.Forms.Label lblSecurityQuestionResponce;
        private System.Windows.Forms.GroupBox gbxHomeInfo;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddrL1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddrL1;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblAddrL2;
        private System.Windows.Forms.TextBox txtAddrL2;
        private System.Windows.Forms.GroupBox gbxClassInfo;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTutor;
        private System.Windows.Forms.GroupBox gbxPointsInfo;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPoints;
        private System.Windows.Forms.GroupBox gbxUserLevelInfo;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.Button btnAllowEditing;
        private System.Windows.Forms.Button btnSaveEdits;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.BindingSource tblYearGroupBindingSource;
        private schoolDBDataSetTableAdapters.tblYearGroupTableAdapter tblYearGroupTableAdapter;
        private System.Windows.Forms.ComboBox cbxTutor;
        private System.Windows.Forms.BindingSource tblTutorsBindingSource;
        private schoolDBDataSetTableAdapters.tblTutorsTableAdapter tblTutorsTableAdapter;
        private System.Windows.Forms.ComboBox cbxUserLevel;
        private System.Windows.Forms.BindingSource tblUserLevelsBindingSource;
        private schoolDBDataSetTableAdapters.tblUserLevelsTableAdapter tblUserLevelsTableAdapter;
        private System.Windows.Forms.Button btnNewStaffUser;
        private System.Windows.Forms.Button btnNewPupilUser;
        private System.Windows.Forms.Button btnSaveNewUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
    }
}