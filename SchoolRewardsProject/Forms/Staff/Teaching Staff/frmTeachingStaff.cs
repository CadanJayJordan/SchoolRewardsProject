using System.Windows.Forms;

namespace SchoolRewardsProject.Forms.Staff.Teaching_Staff {
    public partial class frmTeachingStaff : Form {

        int staffID;

        public frmTeachingStaff(int staffID) {
            InitializeComponent();
            // Pass staff ID onto this form
            this.staffID = staffID;
        }
    }
}
