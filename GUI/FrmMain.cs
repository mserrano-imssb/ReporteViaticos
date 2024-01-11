using ENTITIES;
using LOGIC;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMain : Form
    {
        Logic logic = new Logic();
        LogicEmployee logicEmployee = new LogicEmployee();
        LogicWeek logicWeek = new LogicWeek();
        LogicWeekEmployee logicWeekEmployee = new LogicWeekEmployee();
        LogicDate logicDate = new LogicDate();
        LogicReport logicReport = new LogicReport();

        FrmEmployees frmEmployees = new FrmEmployees();
        FrmRegister frmRegister = new FrmRegister();
        FrmReport frmReport = new FrmReport();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logic.InitEF();
        }

        private void dtpWeeks_ValueChanged(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployees.logicEmployee = logicEmployee;
            frmEmployees.ShowDialog();
            this.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por Ellian Campos Ceciliano", "Acerca De", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpenWeek_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpWeeks.Value;

            int year = selectedDate.Year;
            int month = selectedDate.Month;

            DateTime firstDayOfWeek = logicDate.GetFirstDayOfWeek(selectedDate);
            DateTime lastDayOfWeek = logicDate.GetLastDayOfWeek(firstDayOfWeek);

            int weekNumber = logicDate.GetWeekNumber(selectedDate);
            string description = logicDate.GetFormatedDate(firstDayOfWeek, lastDayOfWeek, year);

            // Validar si la semana existe y en caso de no existir crearla
            if (!logicWeek.Exists(year, month, weekNumber))
                logicWeek.AddWeek(year, month, weekNumber, description);

            // Obtener la semana
            Week week = logicWeek.GetWeek(year, month, weekNumber);

            this.Hide();
            frmRegister.week = week;
            frmRegister.logicWeek = logicWeek;
            frmRegister.logicWeekEmployee = logicWeekEmployee;
            frmRegister.ShowDialog();
            this.Show();
        }

        private void btnOpenReport_Click(object sender, EventArgs e)
        {
            // Obtener las fechas seleccionadas
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            // Año
            int startYear = startDate.Year;
            int endYear = endDate.Year;

            if (startYear != endYear)
            {
                MessageBox.Show("Las fechas de los reportes deben ser de un mismo año");
                return;
            }

            // Mes
            int startMonth = startDate.Month;
            int endMonth = endDate.Month;

            // Semana
            int startWeek = logicDate.GetWeekNumber(dtpStart.Value);
            int endWeek = logicDate.GetWeekNumber(dtpEnd.Value);

            this.Hide();
            frmReport.logicReport = logicReport;
            frmReport.startYear = startYear;
            frmReport.endYear = endYear;
            frmReport.startMonth = startMonth;
            frmReport.endMonth = endMonth;
            frmReport.startWeek = startWeek;
            frmReport.endWeek = endWeek;
            frmReport.ShowDialog();
            this.Show();
        }
    }
}