
namespace SchoolRewardsProject.Forms {
    partial class frmLogin {
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.schoolDBDataSet = new SchoolRewardsProject.schoolDBDataSet();
            this.tblNetworkUsersBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblNetworkUsersTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblNetworkUsersTableAdapter();
            this.tblPupilsBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblPupilsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblPupilsTableAdapter();
            this.tblSessionLogBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblSessionLogTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblSessionLogTableAdapter();
            this.tblStaffBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblStaffTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblStaffTableAdapter();
            this.REMOVELATER = new System.Windows.Forms.Button();
            this.REMOVELATER2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNetworkUsersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSessionLogBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(90, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(79, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "txtUsername";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(79, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "txtPassword";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(79, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(79, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(90, 170);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "schoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNetworkUsersBS
            // 
            this.tblNetworkUsersBS.DataMember = "tblNetworkUsers";
            this.tblNetworkUsersBS.DataSource = this.schoolDBDataSet;
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
            // tblSessionLogBS
            // 
            this.tblSessionLogBS.DataMember = "tblSessionLog";
            this.tblSessionLogBS.DataSource = this.schoolDBDataSet;
            // 
            // tblSessionLogTableAdapter
            // 
            this.tblSessionLogTableAdapter.ClearBeforeFill = true;
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
            // REMOVELATER
            // 
            this.REMOVELATER.Location = new System.Drawing.Point(185, 12);
            this.REMOVELATER.Name = "REMOVELATER";
            this.REMOVELATER.Size = new System.Drawing.Size(75, 23);
            this.REMOVELATER.TabIndex = 6;
            this.REMOVELATER.Text = "WIN";
            this.REMOVELATER.UseVisualStyleBackColor = true;
            this.REMOVELATER.Click += new System.EventHandler(this.REMOVELATER_Click);
            // 
            // REMOVELATER2
            // 
            this.REMOVELATER2.Location = new System.Drawing.Point(185, 41);
            this.REMOVELATER2.Name = "REMOVELATER2";
            this.REMOVELATER2.Size = new System.Drawing.Size(75, 23);
            this.REMOVELATER2.TabIndex = 7;
            this.REMOVELATER2.Text = "LOSE";
            this.REMOVELATER2.UseVisualStyleBackColor = true;
            this.REMOVELATER2.Click += new System.EventHandler(this.REMOVELATER2_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 253);
            this.Controls.Add(this.REMOVELATER2);
            this.Controls.Add(this.REMOVELATER);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "School Points - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNetworkUsersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSessionLogBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnQuit;
        private schoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.BindingSource tblNetworkUsersBS;
        private schoolDBDataSetTableAdapters.tblNetworkUsersTableAdapter tblNetworkUsersTableAdapter;
        private System.Windows.Forms.BindingSource tblPupilsBS;
        private schoolDBDataSetTableAdapters.tblPupilsTableAdapter tblPupilsTableAdapter;
        private System.Windows.Forms.BindingSource tblSessionLogBS;
        private schoolDBDataSetTableAdapters.tblSessionLogTableAdapter tblSessionLogTableAdapter;
        private System.Windows.Forms.BindingSource tblStaffBS;
        private schoolDBDataSetTableAdapters.tblStaffTableAdapter tblStaffTableAdapter;
        private System.Windows.Forms.Button REMOVELATER;
        private System.Windows.Forms.Button REMOVELATER2;
    }
}