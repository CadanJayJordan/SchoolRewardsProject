using System.Windows.Forms;

namespace SchoolRewardsProject.Forms.Staff.Head_Of_Year {
    public partial class frmHeadOfYear : Form {

        int staffID;

        public frmHeadOfYear(int staffID) {
            InitializeComponent();
            // Pass staff ID onto this form
            this.staffID = staffID;
        }
    }
}
