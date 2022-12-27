
namespace SchoolRewardsProject.Forms.Pupil {
    partial class frmRewardRedemptionLog {
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
            this.tblRedeemRewardLogBS = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolRewardsProject.schoolDBDataSet();
            this.tblRedeemRewardLogTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblRedeemRewardLogTableAdapter();
            this.tblRewardsBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblRewardsTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblRewardsTableAdapter();
            this.dgvShowRedemptions = new System.Windows.Forms.DataGridView();
            this.RewardNameGDVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardDescriptionDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RewardCostDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblRedeemRewardLogBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRewardsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRedemptions)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRedeemRewardLogBS
            // 
            this.tblRedeemRewardLogBS.DataMember = "tblRedeemRewardLog";
            this.tblRedeemRewardLogBS.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "schoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRedeemRewardLogTableAdapter
            // 
            this.tblRedeemRewardLogTableAdapter.ClearBeforeFill = true;
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
            // dgvShowRedemptions
            // 
            this.dgvShowRedemptions.AllowUserToAddRows = false;
            this.dgvShowRedemptions.AllowUserToDeleteRows = false;
            this.dgvShowRedemptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowRedemptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RewardNameGDVColumn,
            this.RewardDescriptionDGVColumn,
            this.RewardCostDGVColumn,
            this.TimeDGVColumn});
            this.dgvShowRedemptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowRedemptions.Location = new System.Drawing.Point(0, 0);
            this.dgvShowRedemptions.Name = "dgvShowRedemptions";
            this.dgvShowRedemptions.ReadOnly = true;
            this.dgvShowRedemptions.Size = new System.Drawing.Size(732, 307);
            this.dgvShowRedemptions.TabIndex = 0;
            // 
            // RewardNameGDVColumn
            // 
            this.RewardNameGDVColumn.HeaderText = "Reward Name";
            this.RewardNameGDVColumn.Name = "RewardNameGDVColumn";
            this.RewardNameGDVColumn.ReadOnly = true;
            this.RewardNameGDVColumn.Width = 125;
            // 
            // RewardDescriptionDGVColumn
            // 
            this.RewardDescriptionDGVColumn.HeaderText = "Reward Description";
            this.RewardDescriptionDGVColumn.Name = "RewardDescriptionDGVColumn";
            this.RewardDescriptionDGVColumn.ReadOnly = true;
            this.RewardDescriptionDGVColumn.Width = 325;
            // 
            // RewardCostDGVColumn
            // 
            this.RewardCostDGVColumn.FillWeight = 120F;
            this.RewardCostDGVColumn.HeaderText = "Cost";
            this.RewardCostDGVColumn.Name = "RewardCostDGVColumn";
            this.RewardCostDGVColumn.ReadOnly = true;
            this.RewardCostDGVColumn.Width = 58;
            // 
            // TimeDGVColumn
            // 
            this.TimeDGVColumn.HeaderText = "Time (DD:MM:YYYY hh:mm:ss)";
            this.TimeDGVColumn.Name = "TimeDGVColumn";
            this.TimeDGVColumn.ReadOnly = true;
            this.TimeDGVColumn.Width = 180;
            // 
            // frmRewardRedemptionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 307);
            this.Controls.Add(this.dgvShowRedemptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRewardRedemptionLog";
            this.Text = "School Points - Redemption Log";
            this.Load += new System.EventHandler(this.frmRewardRedemptionLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRedeemRewardLogBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRewardsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowRedemptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tblRedeemRewardLogBS;
        private schoolDBDataSet schoolDBDataSet;
        private schoolDBDataSetTableAdapters.tblRedeemRewardLogTableAdapter tblRedeemRewardLogTableAdapter;
        private System.Windows.Forms.BindingSource tblRewardsBS;
        private schoolDBDataSetTableAdapters.tblRewardsTableAdapter tblRewardsTableAdapter;
        private System.Windows.Forms.DataGridView dgvShowRedemptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardNameGDVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardDescriptionDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RewardCostDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDGVColumn;
    }
}