
namespace SchoolRewardsProject.Forms.Pupil {
    partial class frmPupil {
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
            this.lblPupilWelcome = new System.Windows.Forms.Label();
            this.btnRedeemReward = new System.Windows.Forms.Button();
            this.btnPupilReedemptionLog = new System.Windows.Forms.Button();
            this.tblPupilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolRewardsProject.schoolDBDataSet();
            this.tblPupilsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblPupilsTableAdapter();
            this.btnPointLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPupilWelcome
            // 
            this.lblPupilWelcome.AutoSize = true;
            this.lblPupilWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblPupilWelcome.Name = "lblPupilWelcome";
            this.lblPupilWelcome.Size = new System.Drawing.Size(126, 26);
            this.lblPupilWelcome.TabIndex = 4;
            this.lblPupilWelcome.Text = "Welcome, [PUPILNAME]\r\nYou have: [Points] points";
            // 
            // btnRedeemReward
            // 
            this.btnRedeemReward.Location = new System.Drawing.Point(12, 38);
            this.btnRedeemReward.Name = "btnRedeemReward";
            this.btnRedeemReward.Size = new System.Drawing.Size(75, 58);
            this.btnRedeemReward.TabIndex = 5;
            this.btnRedeemReward.Text = "Redeem Reward";
            this.btnRedeemReward.UseVisualStyleBackColor = true;
            this.btnRedeemReward.Click += new System.EventHandler(this.btnRedeemReward_Click);
            // 
            // btnPupilReedemptionLog
            // 
            this.btnPupilReedemptionLog.Location = new System.Drawing.Point(93, 38);
            this.btnPupilReedemptionLog.Name = "btnPupilReedemptionLog";
            this.btnPupilReedemptionLog.Size = new System.Drawing.Size(75, 58);
            this.btnPupilReedemptionLog.TabIndex = 6;
            this.btnPupilReedemptionLog.Text = "View Redemption Log";
            this.btnPupilReedemptionLog.UseVisualStyleBackColor = true;
            this.btnPupilReedemptionLog.Click += new System.EventHandler(this.btnPupilReedemptionLog_Click);
            // 
            // tblPupilsBindingSource
            // 
            this.tblPupilsBindingSource.DataMember = "tblPupils";
            this.tblPupilsBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "schoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPupilsTableAdapter
            // 
            this.tblPupilsTableAdapter.ClearBeforeFill = true;
            // 
            // btnPointLog
            // 
            this.btnPointLog.Location = new System.Drawing.Point(174, 38);
            this.btnPointLog.Name = "btnPointLog";
            this.btnPointLog.Size = new System.Drawing.Size(75, 58);
            this.btnPointLog.TabIndex = 7;
            this.btnPointLog.Text = "View Point Log";
            this.btnPointLog.UseVisualStyleBackColor = true;
            this.btnPointLog.Click += new System.EventHandler(this.btnPointLog_Click);
            // 
            // frmPupil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 108);
            this.Controls.Add(this.btnPointLog);
            this.Controls.Add(this.btnPupilReedemptionLog);
            this.Controls.Add(this.btnRedeemReward);
            this.Controls.Add(this.lblPupilWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPupil";
            this.Text = "School Points - Pupil";
            this.Load += new System.EventHandler(this.frmPupil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private schoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.BindingSource tblPupilsBindingSource;
        private schoolDBDataSetTableAdapters.tblPupilsTableAdapter tblPupilsTableAdapter;
        private System.Windows.Forms.Label lblPupilWelcome;
        private System.Windows.Forms.Button btnRedeemReward;
        private System.Windows.Forms.Button btnPupilReedemptionLog;
        private System.Windows.Forms.Button btnPointLog;
    }
}