using ClinicaSePrice.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicaSePrice.Forms
{
    public partial class MakeAppoint : Form
    {
        public MakeAppoint()
        {
            InitializeComponent();
        }

        private List<string> currentAvailableDays = new List<string>();
        private void cboSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedSpecialty = cboSpecialty.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedSpecialty))
            {
                // Obtener los días disponibles para la especialidad seleccionada
                currentAvailableDays = MakeAppointment.GetDataTimeFromDatabase(selectedSpecialty);

                dtpAbleDays.Value = DateTime.Now;

                dtpAbleDays.ValueChanged -= dtpDays_ValueChanged;

                // Asociar un nuevo evento para validar los días disponibles
                dtpAbleDays.ValueChanged += dtpDays_ValueChanged;

                cboShifts.Items.Clear();
            }
        }

        // Obtener los horarios desde la base de datos
        private void LoadAvailableSchedules(string selectedDay)
        {
            string selectedSpecialty = cboSpecialty.SelectedItem?.ToString() ?? "No disponible";
            if (string.IsNullOrEmpty(selectedSpecialty)) return;


            List<(TimeSpan StartTime, TimeSpan EndTime)> horarios = MakeAppointment.GetSchedulesFromDatabase(selectedSpecialty, selectedDay);

            cboShifts.Items.Clear();

            foreach (var horario in horarios)
            {
                List<string> availableSchedules = MakeAppointment.MakeSchedule(horario.StartTime, horario.EndTime);
                List<string> filteredSchedules = MakeAppointment.FilterReservedSchedules(availableSchedules, dtpAbleDays.Value.Date, selectedSpecialty);

                // Añadir solo los horarios que no estén reservados
                cboShifts.Items.AddRange(filteredSchedules.ToArray());
            }
        }

        // Evento ValueChanged para validar los días disponibles
        private void dtpDays_ValueChanged(object? sender, EventArgs e)
        {
            if (currentAvailableDays == null || currentAvailableDays.Count == 0)
                return;

            string diaEnEspanol = MakeAppointment.GetDayInSpanish(dtpAbleDays.Value.DayOfWeek);

            // Validar que el día seleccionado sea uno de los disponibles
            if (!currentAvailableDays.Contains(diaEnEspanol))
            {
                MessageBox.Show($"Este día no está disponible para la especialidad seleccionada." +
                    $" Días disponibles: {string.Join(", ", currentAvailableDays)}");
                return;
            }
            LoadAvailableSchedules(diaEnEspanol);
        }

        private void btnSetAppoint_Click(object sender, EventArgs e)
        {
            // Validar que la especialidad esté seleccionada
            if (string.IsNullOrEmpty(cboSpecialty.SelectedItem?.ToString()))
            {
                MessageBox.Show("Por favor, seleccione una especialidad.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que una fecha haya sido seleccionada
            if (!dtpAbleDays.Checked)
            {
                MessageBox.Show("Por favor, seleccione una fecha.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que un horario esté seleccionado
            if (string.IsNullOrEmpty(cboShifts.SelectedItem?.ToString()))
            {
                MessageBox.Show("Por favor, seleccione un horario.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSpecialty = cboSpecialty.SelectedItem.ToString() ?? "";
            DateTime selectedDate = dtpAbleDays.Value;
            string selectedSchedule = cboShifts.SelectedItem.ToString() ?? "";

            AppointConfirm appointConfirm = new AppointConfirm(selectedSpecialty, selectedDate, selectedSchedule);
            appointConfirm.ShowDialog();
            this.Close();
        }
    }
}
