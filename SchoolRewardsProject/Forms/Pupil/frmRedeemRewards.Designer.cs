namespace SchoolRewardsProject.Forms.Pupil {
    partial class frmRedeemRewards {
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
            this.tblPupilsBS = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolRewardsProject.schoolDBDataSet();
            this.tblPupilsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblPupilsTableAdapter();
            this.tblRewardsBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblRewardsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblRewardsTableAdapter();
            this.tblRedeemRewardLogBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblRedeemRewardLogTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblRedeemRewardLogTableAdapter();
            this.cbxRedeemableRewards = new System.Windows.Forms.ComboBox();
            this.lblRedeemableRewards = new System.Windows.Forms.Label();
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.gbxRewardInfo = new System.Windows.Forms.GroupBox();
            this.txtRewardName = new System.Windows.Forms.TextBox();
            this.lblRewardName = new System.Windows.Forms.Label();
            this.txtRewardCost = new System.Windows.Forms.TextBox();
            this.lblRewardCost = new System.Windows.Forms.Label();
            this.txtRewardDescription = new System.Windows.Forms.TextBox();
            this.lblRewardDescription = new System.Windows.Forms.Label();
            this.btnRedeem = new System.Windows.Forms.Button();
            this.tblRewardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUnavailbleRewards = new System.Windows.Forms.Button();
            this.lblUnavailbleRewards = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRewardsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRedeemRewardLogBS)).BeginInit();
            this.gbxRewardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRewardsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPupilsBS
            // 
            this.tblPupilsBS.DataMember = "tblPupils";
            this.tblPupilsBS.DataSource = this.schoolDBDataSet;
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
            // tblRewardsBS
            // 
            this.tblRewardsBS.DataMember = "tblRewards";
            this.tblRewardsBS.DataSource = this.schoolDBDataSet;
            // 
            // tblRewardsTableAdapter
            // 
            this.tblRewardsTableAdapter.ClearBeforeFill = true;
            // 
            // tblRedeemRewardLogBS
            // 
            this.tblRedeemRewardLogBS.DataMember = "tblRedeemRewardLog";
            this.tblRedeemRewardLogBS.DataSource = this.schoolDBDataSet;
            // 
            // tblRedeemRewardLogTableAdapter
            // 
            this.tblRedeemRewardLogTableAdapter.ClearBeforeFill = true;
            // 
            // cbxRedeemableRewards
            // 
            this.cbxRedeemableRewards.DataSource = this.tblRewardsBS;
            this.cbxRedeemableRewards.DisplayMember = "RewardName";
            this.cbxRedeemableRewards.FormattingEnabled = true;
            this.cbxRedeemableRewards.Location = new System.Drawing.Point(133, 54);
            this.cbxRedeemableRewards.Name = "cbxRedeemableRewards";
            this.cbxRedeemableRewards.Size = new System.Drawing.Size(132, 21);
            this.cbxRedeemableRewards.TabIndex = 0;
            this.cbxRedeemableRewards.ValueMember = "RewardID";
            this.cbxRedeemableRewards.SelectionChangeCommitted += new System.EventHandler(this.cbxRedeemableRewards_SelectionChangeCommitted);
            // 
            // lblRedeemableRewards
            // 
            this.lblRedeemableRewards.AutoSize = true;
            this.lblRedeemableRewards.Location = new System.Drawing.Point(12, 57);
            this.lblRedeemableRewards.Name = "lblRedeemableRewards";
            this.lblRedeemableRewards.Size = new System.Drawing.Size(115, 13);
            this.lblRedeemableRewards.TabIndex = 1;
            this.lblRedeemableRewards.Text = "Redeemable Rewards:";
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.Location = new System.Drawing.Point(12, 9);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(158, 39);
            this.lblWelcomeText.TabIndex = 2;
            this.lblWelcomeText.Text = "Welcome, [PUPILNAME]\r\nYou have [POINTS] points\r\nAnd [NUM] redeemable rewards\r\n";
            // 
            // gbxRewardInfo
            // 
            this.gbxRewardInfo.Controls.Add(this.txtRewardName);
            this.gbxRewardInfo.Controls.Add(this.lblRewardName);
            this.gbxRewardInfo.Controls.Add(this.btnRedeem);
            this.gbxRewardInfo.Controls.Add(this.txtRewardCost);
            this.gbxRewardInfo.Controls.Add(this.lblRewardCost);
            this.gbxRewardInfo.Controls.Add(this.txtRewardDescription);
            this.gbxRewardInfo.Controls.Add(this.lblRewardDescription);
            this.gbxRewardInfo.Location = new System.Drawing.Point(12, 81);
            this.gbxRewardInfo.Name = "gbxRewardInfo";
            this.gbxRewardInfo.Size = new System.Drawing.Size(254, 178);
            this.gbxRewardInfo.TabIndex = 3;
            this.gbxRewardInfo.TabStop = false;
            this.gbxRewardInfo.Text = "Reward - [REWARDNAME]";
            this.gbxRewardInfo.Visible = false;
            // 
            // txtRewardName
            // 
            this.txtRewardName.Location = new System.Drawing.Point(84, 19);
            this.txtRewardName.Name = "txtRewardName";
            this.txtRewardName.ReadOnly = true;
            this.txtRewardName.Size = new System.Drawing.Size(164, 20);
            this.txtRewardName.TabIndex = 5;
            this.txtRewardName.Text = "txtRewardName";
            // 
            // lblRewardName
            // 
            this.lblRewardName.AutoSize = true;
            this.lblRewardName.Location = new System.Drawing.Point(7, 22);
            this.lblRewardName.Name = "lblRewardName";
            this.lblRewardName.Size = new System.Drawing.Size(78, 13);
            this.lblRewardName.TabIndex = 4;
            this.lblRewardName.Text = "Reward Name:";
            // 
            // txtRewardCost
            // 
            this.txtRewardCost.Location = new System.Drawing.Point(84, 45);
            this.txtRewardCost.Name = "txtRewardCost";
            this.txtRewardCost.ReadOnly = true;
            this.txtRewardCost.Size = new System.Drawing.Size(164, 20);
            this.txtRewardCost.TabIndex = 3;
            this.txtRewardCost.Text = "txtRewardCost";
            // 
            // lblRewardCost
            // 
            this.lblRewardCost.AutoSize = true;
            this.lblRewardCost.Location = new System.Drawing.Point(7, 48);
            this.lblRewardCost.Name = "lblRewardCost";
            this.lblRewardCost.Size = new System.Drawing.Size(71, 13);
            this.lblRewardCost.TabIndex = 2;
            this.lblRewardCost.Text = "Reward Cost:";
            // 
            // txtRewardDescription
            // 
            this.txtRewardDescription.Location = new System.Drawing.Point(10, 90);
            this.txtRewardDescription.Multiline = true;
            this.txtRewardDescription.Name = "txtRewardDescription";
            this.txtRewardDescription.ReadOnly = true;
            this.txtRewardDescription.Size = new System.Drawing.Size(238, 53);
            this.txtRewardDescription.TabIndex = 1;
            this.txtRewardDescription.Text = "txtRewardDescription";
            // 
            // lblRewardDescription
            // 
            this.lblRewardDescription.AutoSize = true;
            this.lblRewardDescription.Location = new System.Drawing.Point(7, 74);
            this.lblRewardDescription.Name = "lblRewardDescription";
            this.lblRewardDescription.Size = new System.Drawing.Size(100, 13);
            this.lblRewardDescription.TabIndex = 0;
            this.lblRewardDescription.Text = "Reward Description";
            // 
            // btnRedeem
            // 
            this.btnRedeem.Location = new System.Drawing.Point(173, 149);
            this.btnRedeem.Name = "btnRedeem";
            this.btnRedeem.Size = new System.Drawing.Size(75, 23);
            this.btnRedeem.TabIndex = 4;
            this.btnRedeem.Text = "Redeem";
            this.btnRedeem.UseVisualStyleBackColor = true;
            this.btnRedeem.Click += new System.EventHandler(this.btnRedeem_Click);
            // 
            // tblRewardsBindingSource
            // 
            this.tblRewardsBindingSource.DataMember = "tblRewards";
            this.tblRewardsBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // btnUnavailbleRewards
            // 
            this.btnUnavailbleRewards.Location = new System.Drawing.Point(185, 265);
            this.btnUnavailbleRewards.Name = "btnUnavailbleRewards";
            this.btnUnavailbleRewards.Size = new System.Drawing.Size(75, 23);
            this.btnUnavailbleRewards.TabIndex = 4;
            this.btnUnavailbleRewards.Text = "Show";
            this.btnUnavailbleRewards.UseVisualStyleBackColor = true;
            this.btnUnavailbleRewards.Click += new System.EventHandler(this.btnUnavailbleRewards_Click);
            // 
            // lblUnavailbleRewards
            // 
            this.lblUnavailbleRewards.AutoSize = true;
            this.lblUnavailbleRewards.Location = new System.Drawing.Point(9, 270);
            this.lblUnavailbleRewards.Name = "lblUnavailbleRewards";
            this.lblUnavailbleRewards.Size = new System.Drawing.Size(171, 13);
            this.lblUnavailbleRewards.TabIndex = 5;
            this.lblUnavailbleRewards.Text = "Show rewards you cannot redeem:";
            // 
            // frmRedeemRewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 303);
            this.Controls.Add(this.lblUnavailbleRewards);
            this.Controls.Add(this.btnUnavailbleRewards);
            this.Controls.Add(this.gbxRewardInfo);
            this.Controls.Add(this.lblWelcomeText);
            this.Controls.Add(this.lblRedeemableRewards);
            this.Controls.Add(this.cbxRedeemableRewards);
            this.Name = "frmRedeemRewards";
            this.Text = "School Points - Redeem Rewards";
            this.Load += new System.EventHandler(this.frmRedeemRewards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPupilsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRewardsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRedeemRewardLogBS)).EndInit();
            this.gbxRewardInfo.ResumeLayout(false);
            this.gbxRewardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRewardsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblPupilsBS;
        private schoolDBDataSet schoolDBDataSet;
        private schoolDBDataSetTableAdapters.tblPupilsTableAdapter tblPupilsTableAdapter;
        private System.Windows.Forms.BindingSource tblRewardsBS;
        private schoolDBDataSetTableAdapters.tblRewardsTableAdapter tblRewardsTableAdapter;
        private System.Windows.Forms.BindingSource tblRedeemRewardLogBS;
        private schoolDBDataSetTableAdapters.tblRedeemRewardLogTableAdapter tblRedeemRewardLogTableAdapter;
        private System.Windows.Forms.ComboBox cbxRedeemableRewards;
        private System.Windows.Forms.Label lblRedeemableRewards;
        private System.Windows.Forms.Label lblWelcomeText;
        private System.Windows.Forms.GroupBox gbxRewardInfo;
        private System.Windows.Forms.TextBox txtRewardDescription;
        private System.Windows.Forms.Label lblRewardDescription;
        private System.Windows.Forms.TextBox txtRewardName;
        private System.Windows.Forms.Label lblRewardName;
        private System.Windows.Forms.TextBox txtRewardCost;
        private System.Windows.Forms.Label lblRewardCost;
        private System.Windows.Forms.Button btnRedeem;
        private System.Windows.Forms.BindingSource tblRewardsBindingSource;
        private System.Windows.Forms.Button btnUnavailbleRewards;
        private System.Windows.Forms.Label lblUnavailbleRewards;
    }
}