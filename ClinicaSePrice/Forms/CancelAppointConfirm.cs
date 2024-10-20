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
    public partial class CancelAppointConfirm : Form
    {
        public string dni { get; set; } = ""; // Asignando un valor por defecto

        public CancelAppointConfirm(string dni)
        {
            InitializeComponent();
            this.dni = dni;
        }

       
    }
}
