namespace ClinicaSePrice
{
    public partial class Home : Form
    {
        public Home(string userName, string userRole)
        {
            InitializeComponent();

            // Asigno data a los labels dentro del form

            lblUserName.Text = userName;
            lblRole.Text = userRole;
        }
    }
}
