using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaSePrice.Forms
{
    public partial class DeliverStudy : Form
    {
        public DeliverStudy()
        {
            InitializeComponent();
        }

        private void DeliverStudy_Load(object sender, EventArgs e)
        {

        }

        private void btnDelivStudy_Click(object sender, EventArgs e)
        {
            DeliverConfirm deliverConfirm = new DeliverConfirm();
            deliverConfirm.Show();
        }
    }
}
