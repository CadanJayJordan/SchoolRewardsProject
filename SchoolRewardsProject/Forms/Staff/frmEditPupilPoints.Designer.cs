namespace SchoolRewardsProject.Forms.Staff {
    partial class frmEditPupilPoints {
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
            this.btnReward = new System.Windows.Forms.Button();
            this.btnPunish = new System.Windows.Forms.Button();
            this.tblNetworkUsersBS = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolRewardsProject.schoolDBDataSet();
            this.tblNetworkUsersTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblNetworkUsersTableAdapter();
            this.tblPupilsBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblPupilsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblPupilsTableAdapter();
            this.tblPointRewardCategoriesBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblPointRewardCategoriesTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblPointRewardCategoriesTableAdapter();
            this.tblPointLogBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblPointLogTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblPointLogTableAdapter();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxPupilInfo = new System.Windows.Forms.GroupBox();
            this.lblCurrentTotalPoints = new System.Windows.Forms.Label();
            this.txtCurrentTotalPoints = new System.Windows.Forms.TextBox();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.txtCurrentPoints = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOtherNames = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtOtherNames = new System.Windows.Forms.TextBox();
            this.gbxAwardPoints = new System.Windows.Forms.GroupBox();
            this.btnDoneAward = new System.Windows.Forms.Button();
            this.btnCustomPointsAdd = new System.Windows.Forms.Button();
            this.txtPointsToAward = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblRewardCats = new System.Windows.Forms.Label();
            this.cbxRewardCategories = new System.Windows.Forms.ComboBox();
            this.gbxRevokePoints = new System.Windows.Forms.GroupBox();
            this.btnDoneRevoke = new System.Windows.Forms.Button();
            this.btnCustomPointsRemove = new System.Windows.Forms.Button();
            this.txtPointsToRevoke = new System.Windows.Forms.TextBox();
            this.lblPointsR = new System.Windows.Forms.Label();
            this.lblPunishmentCats = new System.Windows.Forms.Label();
            this.cbxPunishmentCategories = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblNetworkUsersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPointRewardCategoriesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPointLogBS)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.gbxPupilInfo.SuspendLayout();
            this.gbxAwardPoints.SuspendLayout();
            this.gbxRevokePoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReward
            // 
            this.btnReward.Location = new System.Drawing.Point(12, 12);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(98, 44);
            this.btnReward.TabIndex = 0;
            this.btnReward.Text = "Add Reward";
            this.btnReward.UseVisualStyleBackColor = true;
            this.btnReward.Click += new System.EventHandler(this.btnReward_Click);
            // 
            // btnPunish
            // 
            this.btnPunish.Location = new System.Drawing.Point(117, 12);
            this.btnPunish.Name = "btnPunish";
            this.btnPunish.Size = new System.Drawing.Size(98, 44);
            this.btnPunish.TabIndex = 1;
            this.btnPunish.Text = "Add Punishment";
            this.btnPunish.UseVisualStyleBackColor = true;
            this.btnPunish.Click += new System.EventHandler(this.btnPunish_Click);
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
            // tblPointRewardCategoriesBS
            // 
            this.tblPointRewardCategoriesBS.DataMember = "tblPointRewardCategories";
            this.tblPointRewardCategoriesBS.DataSource = this.schoolDBDataSet;
            // 
            // tblPointRewardCategoriesTableAdapter
            // 
            this.tblPointRewardCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tblPointLogBS
            // 
            this.tblPointLogBS.DataMember = "tblPointLog";
            this.tblPointLogBS.DataSource = this.schoolDBDataSet;
            // 
            // tblPointLogTableAdapter
            // 
            this.tblPointLogTableAdapter.ClearBeforeFill = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(96, 13);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Pupil Username:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(125, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnBack);
            this.gbxSearch.Controls.Add(this.txtUsername);
            this.gbxSearch.Controls.Add(this.btnSearch);
            this.gbxSearch.Controls.Add(this.lblUsername);
            this.gbxSearch.Location = new System.Drawing.Point(12, 12);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(203, 73);
            this.gbxSearch.TabIndex = 5;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search For Pupil";
            this.gbxSearch.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(48, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 27);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxPupilInfo
            // 
            this.gbxPupilInfo.Controls.Add(this.lblCurrentTotalPoints);
            this.gbxPupilInfo.Controls.Add(this.txtCurrentTotalPoints);
            this.gbxPupilInfo.Controls.Add(this.lblCurrentPoints);
            this.gbxPupilInfo.Controls.Add(this.txtCurrentPoints);
            this.gbxPupilInfo.Controls.Add(this.lblID);
            this.gbxPupilInfo.Controls.Add(this.txtID);
            this.gbxPupilInfo.Controls.Add(this.label1);
            this.gbxPupilInfo.Controls.Add(this.lblOtherNames);
            this.gbxPupilInfo.Controls.Add(this.txtSurname);
            this.gbxPupilInfo.Controls.Add(this.txtOtherNames);
            this.gbxPupilInfo.Location = new System.Drawing.Point(12, 91);
            this.gbxPupilInfo.Name = "gbxPupilInfo";
            this.gbxPupilInfo.Size = new System.Drawing.Size(203, 147);
            this.gbxPupilInfo.TabIndex = 8;
            this.gbxPupilInfo.TabStop = false;
            this.gbxPupilInfo.Text = "Pupil Information";
            this.gbxPupilInfo.Visible = false;
            // 
            // lblCurrentTotalPoints
            // 
            this.lblCurrentTotalPoints.AutoSize = true;
            this.lblCurrentTotalPoints.Location = new System.Drawing.Point(7, 121);
            this.lblCurrentTotalPoints.Name = "lblCurrentTotalPoints";
            this.lblCurrentTotalPoints.Size = new System.Drawing.Size(66, 13);
            this.lblCurrentTotalPoints.TabIndex = 12;
            this.lblCurrentTotalPoints.Text = "Total Points:";
            // 
            // txtCurrentTotalPoints
            // 
            this.txtCurrentTotalPoints.Location = new System.Drawing.Point(94, 118);
            this.txtCurrentTotalPoints.Name = "txtCurrentTotalPoints";
            this.txtCurrentTotalPoints.ReadOnly = true;
            this.txtCurrentTotalPoints.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentTotalPoints.TabIndex = 11;
            this.txtCurrentTotalPoints.Text = "txtCurrentTotalPoints";
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.AutoSize = true;
            this.lblCurrentPoints.Location = new System.Drawing.Point(7, 96);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Size = new System.Drawing.Size(39, 13);
            this.lblCurrentPoints.TabIndex = 10;
            this.lblCurrentPoints.Text = "Points:";
            // 
            // txtCurrentPoints
            // 
            this.txtCurrentPoints.Location = new System.Drawing.Point(94, 93);
            this.txtCurrentPoints.Name = "txtCurrentPoints";
            this.txtCurrentPoints.ReadOnly = true;
            this.txtCurrentPoints.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPoints.TabIndex = 9;
            this.txtCurrentPoints.Text = "txtCurrentPoints";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(47, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "Pupil ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "txtID";
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
            // lblOtherNames
            // 
            this.lblOtherNames.AutoSize = true;
            this.lblOtherNames.Location = new System.Drawing.Point(7, 70);
            this.lblOtherNames.Name = "lblOtherNames";
            this.lblOtherNames.Size = new System.Drawing.Size(78, 13);
            this.lblOtherNames.TabIndex = 6;
            this.lblOtherNames.Text = "Other Name(s):";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(94, 41);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.Text = "txtSurname";
            // 
            // txtOtherNames
            // 
            this.txtOtherNames.Location = new System.Drawing.Point(94, 67);
            this.txtOtherNames.Name = "txtOtherNames";
            this.txtOtherNames.ReadOnly = true;
            this.txtOtherNames.Size = new System.Drawing.Size(100, 20);
            this.txtOtherNames.TabIndex = 5;
            this.txtOtherNames.Text = "txtOtherNames";
            // 
            // gbxAwardPoints
            // 
            this.gbxAwardPoints.Controls.Add(this.btnDoneAward);
            this.gbxAwardPoints.Controls.Add(this.btnCustomPointsAdd);
            this.gbxAwardPoints.Controls.Add(this.txtPointsToAward);
            this.gbxAwardPoints.Controls.Add(this.lblPoints);
            this.gbxAwardPoints.Controls.Add(this.lblRewardCats);
            this.gbxAwardPoints.Controls.Add(this.cbxRewardCategories);
            this.gbxAwardPoints.Location = new System.Drawing.Point(12, 244);
            this.gbxAwardPoints.Name = "gbxAwardPoints";
            this.gbxAwardPoints.Size = new System.Drawing.Size(203, 144);
            this.gbxAwardPoints.TabIndex = 9;
            this.gbxAwardPoints.TabStop = false;
            this.gbxAwardPoints.Text = "Award Points";
            this.gbxAwardPoints.Visible = false;
            // 
            // btnDoneAward
            // 
            this.btnDoneAward.Location = new System.Drawing.Point(119, 115);
            this.btnDoneAward.Name = "btnDoneAward";
            this.btnDoneAward.Size = new System.Drawing.Size(75, 23);
            this.btnDoneAward.TabIndex = 13;
            this.btnDoneAward.Text = "Done";
            this.btnDoneAward.UseVisualStyleBackColor = true;
            this.btnDoneAward.Click += new System.EventHandler(this.btnDoneAward_Click);
            // 
            // btnCustomPointsAdd
            // 
            this.btnCustomPointsAdd.Location = new System.Drawing.Point(94, 85);
            this.btnCustomPointsAdd.Name = "btnCustomPointsAdd";
            this.btnCustomPointsAdd.Size = new System.Drawing.Size(100, 23);
            this.btnCustomPointsAdd.TabIndex = 12;
            this.btnCustomPointsAdd.Text = "Custom Points";
            this.btnCustomPointsAdd.UseVisualStyleBackColor = true;
            this.btnCustomPointsAdd.Click += new System.EventHandler(this.btnCustomPointsAdd_Click);
            // 
            // txtPointsToAward
            // 
            this.txtPointsToAward.Location = new System.Drawing.Point(94, 59);
            this.txtPointsToAward.Name = "txtPointsToAward";
            this.txtPointsToAward.ReadOnly = true;
            this.txtPointsToAward.Size = new System.Drawing.Size(100, 20);
            this.txtPointsToAward.TabIndex = 5;
            this.txtPointsToAward.Text = "txtPointsToAward";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(4, 62);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(84, 13);
            this.lblPoints.TabIndex = 11;
            this.lblPoints.Text = "Points to Award:";
            // 
            // lblRewardCats
            // 
            this.lblRewardCats.AutoSize = true;
            this.lblRewardCats.Location = new System.Drawing.Point(6, 16);
            this.lblRewardCats.Name = "lblRewardCats";
            this.lblRewardCats.Size = new System.Drawing.Size(100, 13);
            this.lblRewardCats.TabIndex = 9;
            this.lblRewardCats.Text = "Reward Categories:";
            // 
            // cbxRewardCategories
            // 
            this.cbxRewardCategories.DataSource = this.tblPointRewardCategoriesBS;
            this.cbxRewardCategories.DisplayMember = "CategoryName";
            this.cbxRewardCategories.FormattingEnabled = true;
            this.cbxRewardCategories.Location = new System.Drawing.Point(10, 32);
            this.cbxRewardCategories.Name = "cbxRewardCategories";
            this.cbxRewardCategories.Size = new System.Drawing.Size(184, 21);
            this.cbxRewardCategories.TabIndex = 10;
            this.cbxRewardCategories.ValueMember = "CategoryID";
            this.cbxRewardCategories.SelectionChangeCommitted += new System.EventHandler(this.cbxRewardCategories_SelectionChangeCommitted);
            // 
            // gbxRevokePoints
            // 
            this.gbxRevokePoints.Controls.Add(this.btnDoneRevoke);
            this.gbxRevokePoints.Controls.Add(this.btnCustomPointsRemove);
            this.gbxRevokePoints.Controls.Add(this.txtPointsToRevoke);
            this.gbxRevokePoints.Controls.Add(this.lblPointsR);
            this.gbxRevokePoints.Controls.Add(this.lblPunishmentCats);
            this.gbxRevokePoints.Controls.Add(this.cbxPunishmentCategories);
            this.gbxRevokePoints.Location = new System.Drawing.Point(221, 244);
            this.gbxRevokePoints.Name = "gbxRevokePoints";
            this.gbxRevokePoints.Size = new System.Drawing.Size(214, 144);
            this.gbxRevokePoints.TabIndex = 14;
            this.gbxRevokePoints.TabStop = false;
            this.gbxRevokePoints.Text = "Revoke Points";
            this.gbxRevokePoints.Visible = false;
            // 
            // btnDoneRevoke
            // 
            this.btnDoneRevoke.Location = new System.Drawing.Point(119, 115);
            this.btnDoneRevoke.Name = "btnDoneRevoke";
            this.btnDoneRevoke.Size = new System.Drawing.Size(75, 23);
            this.btnDoneRevoke.TabIndex = 13;
            this.btnDoneRevoke.Text = "Done";
            this.btnDoneRevoke.UseVisualStyleBackColor = true;
            this.btnDoneRevoke.Click += new System.EventHandler(this.btnDoneRevoke_Click);
            // 
            // btnCustomPointsRemove
            // 
            this.btnCustomPointsRemove.Location = new System.Drawing.Point(94, 85);
            this.btnCustomPointsRemove.Name = "btnCustomPointsRemove";
            this.btnCustomPointsRemove.Size = new System.Drawing.Size(100, 23);
            this.btnCustomPointsRemove.TabIndex = 12;
            this.btnCustomPointsRemove.Text = "Custom Points";
            this.btnCustomPointsRemove.UseVisualStyleBackColor = true;
            this.btnCustomPointsRemove.Click += new System.EventHandler(this.btnCustomPointsRemove_Click);
            // 
            // txtPointsToRevoke
            // 
            this.txtPointsToRevoke.Location = new System.Drawing.Point(94, 59);
            this.txtPointsToRevoke.Name = "txtPointsToRevoke";
            this.txtPointsToRevoke.ReadOnly = true;
            this.txtPointsToRevoke.Size = new System.Drawing.Size(100, 20);
            this.txtPointsToRevoke.TabIndex = 5;
            this.txtPointsToRevoke.Text = "txtPointsToRevoke";
            // 
            // lblPointsR
            // 
            this.lblPointsR.AutoSize = true;
            this.lblPointsR.Location = new System.Drawing.Point(4, 62);
            this.lblPointsR.Name = "lblPointsR";
            this.lblPointsR.Size = new System.Drawing.Size(92, 13);
            this.lblPointsR.TabIndex = 11;
            this.lblPointsR.Text = "Points to Revoke:";
            // 
            // lblPunishmentCats
            // 
            this.lblPunishmentCats.AutoSize = true;
            this.lblPunishmentCats.Location = new System.Drawing.Point(6, 16);
            this.lblPunishmentCats.Name = "lblPunishmentCats";
            this.lblPunishmentCats.Size = new System.Drawing.Size(118, 13);
            this.lblPunishmentCats.TabIndex = 9;
            this.lblPunishmentCats.Text = "Punishment Categories:";
            // 
            // cbxPunishmentCategories
            // 
            this.cbxPunishmentCategories.DataSource = this.tblPointRewardCategoriesBS;
            this.cbxPunishmentCategories.DisplayMember = "CategoryName";
            this.cbxPunishmentCategories.FormattingEnabled = true;
            this.cbxPunishmentCategories.Location = new System.Drawing.Point(10, 32);
            this.cbxPunishmentCategories.Name = "cbxPunishmentCategories";
            this.cbxPunishmentCategories.Size = new System.Drawing.Size(184, 21);
            this.cbxPunishmentCategories.TabIndex = 10;
            this.cbxPunishmentCategories.ValueMember = "CategoryID";
            this.cbxPunishmentCategories.SelectionChangeCommitted += new System.EventHandler(this.cbxPunishmentCategories_SelectionChangeCommitted);
            // 
            // frmEditPupilPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 395);
            this.Controls.Add(this.gbxRevokePoints);
            this.Controls.Add(this.gbxAwardPoints);
            this.Controls.Add(this.gbxPupilInfo);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.btnPunish);
            this.Controls.Add(this.btnReward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditPupilPoints";
            this.Text = "School Points - Add/Remove Points ";
            this.Load += new System.EventHandler(this.frmEditPupilPoints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblNetworkUsersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPointRewardCategoriesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPointLogBS)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxPupilInfo.ResumeLayout(false);
            this.gbxPupilInfo.PerformLayout();
            this.gbxAwardPoints.ResumeLayout(false);
            this.gbxAwardPoints.PerformLayout();
            this.gbxRevokePoints.ResumeLayout(false);
            this.gbxRevokePoints.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReward;
        private System.Windows.Forms.Button btnPunish;
        private System.Windows.Forms.BindingSource tblNetworkUsersBS;
        private schoolDBDataSet schoolDBDataSet;
        private schoolDBDataSetTableAdapters.tblNetworkUsersTableAdapter tblNetworkUsersTableAdapter;
        private System.Windows.Forms.BindingSource tblPupilsBS;
        private schoolDBDataSetTableAdapters.tblPupilsTableAdapter tblPupilsTableAdapter;
        private System.Windows.Forms.BindingSource tblPointRewardCategoriesBS;
        private schoolDBDataSetTableAdapters.tblPointRewardCategoriesTableAdapter tblPointRewardCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource tblPointLogBS;
        private schoolDBDataSetTableAdapters.tblPointLogTableAdapter tblPointLogTableAdapter;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.GroupBox gbxPupilInfo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOtherNames;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtOtherNames;
        private System.Windows.Forms.GroupBox gbxAwardPoints;
        private System.Windows.Forms.ComboBox cbxRewardCategories;
        private System.Windows.Forms.Label lblRewardCats;
        private System.Windows.Forms.TextBox txtPointsToAward;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnCustomPointsAdd;
        private System.Windows.Forms.Button btnDoneAward;
        private System.Windows.Forms.GroupBox gbxRevokePoints;
        private System.Windows.Forms.Button btnDoneRevoke;
        private System.Windows.Forms.Button btnCustomPointsRemove;
        private System.Windows.Forms.TextBox txtPointsToRevoke;
        private System.Windows.Forms.Label lblPointsR;
        private System.Windows.Forms.Label lblPunishmentCats;
        private System.Windows.Forms.ComboBox cbxPunishmentCategories;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCurrentTotalPoints;
        private System.Windows.Forms.TextBox txtCurrentTotalPoints;
        private System.Windows.Forms.Label lblCurrentPoints;
        private System.Windows.Forms.TextBox txtCurrentPoints;
    }
}