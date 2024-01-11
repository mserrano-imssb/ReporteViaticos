using ENTITIES;
using LOGIC;
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
    public partial class FrmEmployees : Form
    {
        public LogicEmployee logicEmployee = null;
        int idSelectedEmployee;

        public FrmEmployees()
        {
            InitializeComponent();
        }

        public void ShowEmployees(string filter)
        {
            dgvEmployees.DataSource = null;
            List<Employee> employees = logicEmployee.GetEmployees();
            if (filter == null)
            {
                dgvEmployees.DataSource = employees;
            }
            else
            {
                List<Employee> employeesFiltered = employees.
                    Where(x => 
                        x.Name.ToLower().Contains(filter) || 
                        x.LastName.ToLower().Contains(filter))
                    .ToList();
                dgvEmployees.DataSource = employeesFiltered;
            }
            dgvEmployees.Columns[0].Visible = false;
            dgvEmployees.Columns[1].HeaderText = "Nombre";
            dgvEmployees.Columns[2].HeaderText = "Apellidos";
            dgvEmployees.Columns[3].HeaderText = "Estado";
            foreach (DataGridViewRow row in dgvEmployees.Rows)
            {
                row.Selected = false;
            }
        }

        public void ClearFields()
        {
            txtName.Clear();
            txtLastName.Clear();
            txtName.Focus();
            btnAdd.Visible = Visible;
            btnUpdate.Visible = false;
        }

        public bool ValidateFields()
        {
            errorProvider1.Clear();

            if (txtName.Text.Equals(""))
            {
                errorProvider1.SetError(txtName, "Campo requerido");
                return false;
            }

            return true;
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            ShowEmployees(null);
            btnUpdate.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            Employee employee = new Employee();
            employee.Name = txtName.Text;
            employee.LastName = txtLastName.Text;

            if (logicEmployee.AddEmployee(employee))
            {
                ClearFields();
                ShowEmployees(null);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al registrar el nuevo empleado");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            Employee employee = new Employee();
            employee.Id = idSelectedEmployee;
            employee.Name = txtName.Text;
            employee.LastName = txtLastName.Text;

            if (logicEmployee.UpdateEmployee(employee))
            {
                ClearFields();
                ShowEmployees(null);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al actualizar los datos del empleado");
            }
        }

        private void dgvEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idSelectedEmployee = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells[0].Value);
            txtName.Text = dgvEmployees.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dgvEmployees.SelectedRows[0].Cells[2].Value.ToString();

            btnAdd.Visible = false;
            btnUpdate.Visible = true;
        }

        private void dgvEmployees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployees.Columns[3].Index && e.RowIndex >= 0)
            {
                bool valorCheckBox = (bool)dgvEmployees.Rows[e.RowIndex].Cells["Active"].Value;

                int id = Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells[0].Value);

                logicEmployee.UpdateEmployeeEstate(id, valorCheckBox);

                ShowEmployees(null);

                foreach (DataGridViewRow row in dgvEmployees.Rows)
                {
                    row.Selected = false;
                }
            }
        }


        private void dgvEmployees_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.IsCurrentCellDirty)
            {
                dgvEmployees.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            ShowEmployees(txtFilter.Text.ToLower());
        }
    }
}
