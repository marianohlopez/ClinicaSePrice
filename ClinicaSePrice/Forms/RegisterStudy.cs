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
    public partial class RegisterStudy : Form
    {
        public RegisterStudy()
        {
            InitializeComponent();
        }

        private void RegisterStudy_Load(object sender, EventArgs e)
        {
            // Se agregan las especialidades de donde vienen los estudios en el comboBox
            comboSpecialty.Items.AddRange(new string[] { "Radiografía(RX)", "Tomografía(TC)", "Resonancia(RM)" });

            // Se agregan las secciones adonde irán los estudios en el comboBox
            comboSection.Items.AddRange(new string[] { "A1", "A2", "A3", "B1", "B2", "B3" });
        }

        private void btnRegisterStudy_Click(object sender, EventArgs e)
        {
            // Verificación de que se haya seleccionado una especialidad y una seccion
            if (comboSpecialty.SelectedIndex == -1 || comboSection.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una especialidad y una sección antes de continuar.");
                return;
            }

            // Guardar specialtyId y sectionId seleccionados
            int specialtyId = comboSpecialty.SelectedIndex;
            string sectionId = comboSection.SelectedItem as string ?? string.Empty;

            // Se usa fecha actual para el registro
            DateTime studyDate = DateTime.Now;

            // Si ambas opciones estan seleccionadas, abrir StudyConfirm.cs
            StudyConfirm studyConfirm = new StudyConfirm(specialtyId, sectionId, studyDate);
            studyConfirm.Show();
        }
    }
}
