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
