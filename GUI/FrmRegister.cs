using ENTITIES;
using LOGIC;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmRegister : Form
    {
        public LogicWeek logicWeek = null;
        public LogicWeekEmployee logicWeekEmployee = null;
        public Week week;

        public FrmRegister()
        {
            InitializeComponent();
        }

        public void Show(List<Register> data)
        {
            dgvRegister.DataSource = null;

            if (data == null)
            {
                dgvRegister.DataSource = logicWeekEmployee.Get(week.Id);
            }
            else
            {
                dgvRegister.DataSource = data;
            }

            dgvRegister.Columns[0].Visible = false;
            dgvRegister.Columns[1].HeaderText = "Empleado";
            dgvRegister.Columns[2].HeaderText = "Viáticos entregados";
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            label1.Text = week.Description;
            Show(null);
        }

        private void dgvRegister_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvRegister.IsCurrentCellDirty)
            {
                dgvRegister.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvRegister_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRegister.Columns[2].Index && e.RowIndex >= 0)
            {
                bool valorCheckBox = (bool)dgvRegister.Rows[e.RowIndex].Cells[2].Value;

                int idEmployee = Convert.ToInt32(dgvRegister.Rows[e.RowIndex].Cells[0].Value);

                logicWeekEmployee.Do(idEmployee, week, valorCheckBox);

                Show();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string text = txtFilter.Text.ToLower();

            if (text.Equals(""))
            {
                Show(null);
            }
            else
            {
                List<Register> weekEmployees = logicWeekEmployee.Get(week.Id);

                List<Register> weekEmployeesFiltered = weekEmployees.Where(x => x.Name.ToLower().Contains(text)).ToList();

                Show(weekEmployeesFiltered);
            }
        }
    }
}
