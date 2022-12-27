using System;
using System.Windows.Forms;
using SchoolRewardsProject.Forms;

namespace SchoolRewardsProject {
    public partial class frmStartup : Form {
        public frmStartup() {
            InitializeComponent();
        }

        private void frmStartup_Load(object sender, EventArgs e) {
            // Hide the startup form
            this.Hide();

            // Create new instance of login form and show
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();

            // Close this form ending the program
            this.Close();


        }
    }
}
