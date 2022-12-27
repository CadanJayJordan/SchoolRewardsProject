
namespace SchoolRewardsProject.Forms.Pupil {
    partial class frmPointChangeLog {
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
            this.dgvPointLog = new System.Windows.Forms.DataGridView();
            this.tblPointLogBS = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolRewardsProject.schoolDBDataSet();
            this.tblPointLogTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblPointLogTableAdapter();
            this.tblPointRewardCategoriesBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblPointRewardCategoriesTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblPointRewardCategoriesTableAdapter();
            this.tblStaffBS = new System.Windows.Forms.BindingSource(this.components);
            this.tblStaffTableAdapter = new SchoolRewardsProject.schoolDBDataSetTableAdapters.tblStaffTableAdapter();
            this.CategoryDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointDescriptionDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointChangeDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeDGVColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPointLogBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPointRewardCategoriesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPointLog
            // 
            this.dgvPointLog.AllowUserToAddRows = false;
            this.dgvPointLog.AllowUserToDeleteRows = false;
            this.dgvPointLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPointLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryDGVColumn,
            this.PointDescriptionDGVColumn,
            this.PointChangeDGVColumn,
            this.StaffDGVColumn,
            this.TimeDGVColumn});
            this.dgvPointLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPointLog.Location = new System.Drawing.Point(0, 0);
            this.dgvPointLog.Name = "dgvPointLog";
            this.dgvPointLog.ReadOnly = true;
            this.dgvPointLog.Size = new System.Drawing.Size(873, 405);
            this.dgvPointLog.TabIndex = 0;
            // 
            // tblPointLogBS
            // 
            this.tblPointLogBS.DataMember = "tblPointLog";
            this.tblPointLogBS.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "schoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPointLogTableAdapter
            // 
            this.tblPointLogTableAdapter.ClearBeforeFill = true;
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
            // tblStaffBS
            // 
            this.tblStaffBS.DataMember = "tblStaff";
            this.tblStaffBS.DataSource = this.schoolDBDataSet;
            // 
            // tblStaffTableAdapter
            // 
            this.tblStaffTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryDGVColumn
            // 
            this.CategoryDGVColumn.HeaderText = "Points Category";
            this.CategoryDGVColumn.Name = "CategoryDGVColumn";
            this.CategoryDGVColumn.ReadOnly = true;
            this.CategoryDGVColumn.Width = 150;
            // 
            // PointDescriptionDGVColumn
            // 
            this.PointDescriptionDGVColumn.HeaderText = "Point Description";
            this.PointDescriptionDGVColumn.Name = "PointDescriptionDGVColumn";
            this.PointDescriptionDGVColumn.ReadOnly = true;
            this.PointDescriptionDGVColumn.Width = 300;
            // 
            // PointChangeDGVColumn
            // 
            this.PointChangeDGVColumn.HeaderText = "Point Change";
            this.PointChangeDGVColumn.Name = "PointChangeDGVColumn";
            this.PointChangeDGVColumn.ReadOnly = true;
            // 
            // StaffDGVColumn
            // 
            this.StaffDGVColumn.HeaderText = "Staff Member";
            this.StaffDGVColumn.Name = "StaffDGVColumn";
            this.StaffDGVColumn.ReadOnly = true;
            // 
            // TimeDGVColumn
            // 
            this.TimeDGVColumn.HeaderText = "Time (DD:MM:YYYY hh:mm:ss)";
            this.TimeDGVColumn.Name = "TimeDGVColumn";
            this.TimeDGVColumn.ReadOnly = true;
            this.TimeDGVColumn.Width = 180;
            // 
            // frmPointChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 405);
            this.Controls.Add(this.dgvPointLog);
            this.Name = "frmPointChangeLog";
            this.Text = "School Points - Points Log";
            this.Load += new System.EventHandler(this.frmPointChangeLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPointLogBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPointRewardCategoriesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblPointLogBS;
        private schoolDBDataSet schoolDBDataSet;
        private schoolDBDataSetTableAdapters.tblPointLogTableAdapter tblPointLogTableAdapter;
        private System.Windows.Forms.BindingSource tblPointRewardCategoriesBS;
        private schoolDBDataSetTableAdapters.tblPointRewardCategoriesTableAdapter tblPointRewardCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource tblStaffBS;
        private schoolDBDataSetTableAdapters.tblStaffTableAdapter tblStaffTableAdapter;
        private System.Windows.Forms.DataGridView dgvPointLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointDescriptionDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointChangeDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffDGVColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeDGVColumn;
    }
}