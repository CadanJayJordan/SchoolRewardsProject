
namespace SchoolRewardsProject.Forms.Staff.Administration {
    partial class frmAdministration {
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
            this.lblWelcomeLabel = new System.Windows.Forms.Label();
            this.btnEditUsers = new System.Windows.Forms.Button();
            this.tblStaffBS = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolRewardsProject.schoolDBDataSet();
            this.tblStaffTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblStaffTableAdapter();
            this.btnEditPoints = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeLabel
            // 
            this.lblWelcomeLabel.AutoSize = true;
            this.lblWelcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.lblWelcomeLabel.Name = "lblWelcomeLabel";
            this.lblWelcomeLabel.Size = new System.Drawing.Size(88, 13);
            this.lblWelcomeLabel.TabIndex = 0;
            this.lblWelcomeLabel.Text = "lblWelcomeLabel";
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Location = new System.Drawing.Point(110, 38);
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(89, 41);
            this.btnEditUsers.TabIndex = 1;
            this.btnEditUsers.Text = "Edit Users";
            this.btnEditUsers.UseVisualStyleBackColor = true;
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // tblStaffBS
            // 
            this.tblStaffBS.DataMember = "tblStaff";
            this.tblStaffBS.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "schoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStaffTableAdapter
            // 
            this.tblStaffTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditPoints
            // 
            this.btnEditPoints.Location = new System.Drawing.Point(15, 38);
            this.btnEditPoints.Name = "btnEditPoints";
            this.btnEditPoints.Size = new System.Drawing.Size(89, 41);
            this.btnEditPoints.TabIndex = 2;
            this.btnEditPoints.Text = "Add/Remove Points";
            this.btnEditPoints.UseVisualStyleBackColor = true;
            this.btnEditPoints.Click += new System.EventHandler(this.btnEditPoints_Click);
            // 
            // frmAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 98);
            this.Controls.Add(this.btnEditPoints);
            this.Controls.Add(this.btnEditUsers);
            this.Controls.Add(this.lblWelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdministration";
            this.Text = "School Points - Administration";
            this.Load += new System.EventHandler(this.frmAdministration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeLabel;
        private System.Windows.Forms.BindingSource tblStaffBS;
        private schoolDBDataSet schoolDBDataSet;
        private schoolDBDataSetTableAdapters.tblStaffTableAdapter tblStaffTableAdapter;
        private System.Windows.Forms.Button btnEditUsers;
        private System.Windows.Forms.Button btnEditPoints;
    }
}