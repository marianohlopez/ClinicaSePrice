using ClinicaSePrice.Classes;
using ClinicaSePrice.Forms;

namespace ClinicaSePrice
{
    public partial class Home : Form
    {
        public Home(string userName, string userRole)
        {
            InitializeComponent();

            // Asigno data a los labels dentro del form

            lblUserName.Text = userName;
            lblRole.Text = $"({userRole})";
        }

        private void btnMkAppoint_Click(object sender, EventArgs e)
        {
            MakeAppoint makeAppoint = new MakeAppoint();
            makeAppoint.ShowDialog();
        }

        private void btnClAppoint_Click(object sender, EventArgs e)
        {
            CancelAppoint cancelAppoint = new CancelAppoint();
            cancelAppoint.ShowDialog();
        }

        private void btnRfAppoint_Click(object sender, EventArgs e)
        {
            RatifyAppoint ratifyAppoint = new RatifyAppoint();
            ratifyAppoint.ShowDialog();
        }

        private void btnMngSuppl_Click(object sender, EventArgs e)
        {
            ManageSupplies manageSupplies = new ManageSupplies();
            manageSupplies.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
