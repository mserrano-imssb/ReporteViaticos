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
    public partial class FrmReport : Form
    {
        public int startYear, endYear, startMonth, endMonth, startWeek, endWeek;
        public LogicReport logicReport = null;

        public FrmReport()
        {
            InitializeComponent();
        }

        void Show(string text)
        {
            dgvReport.DataSource = null;
            DataTable dt = logicReport.GetReport(startYear, endYear, startMonth, endMonth, startWeek, endWeek);

            DataView dataView = new DataView(dt);
            dataView.RowFilter = $"Empleado LIKE '%{text}%'";
            dgvReport.DataSource = dataView;

            dgvReport.Columns[0].Visible = false;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            Show(null);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay filas en el DataGridView
                if (dgvReport != null && dgvReport.Rows.Count > 0)
                {
                    // Obtener el contenido de la tabla
                    string clipboardText = "";

                    // Agregar encabezados al texto del portapapeles
                    foreach (DataGridViewColumn column in dgvReport.Columns)
                    {
                        clipboardText += column.HeaderText + "\t";
                    }
                    clipboardText = clipboardText.TrimEnd('\t') + Environment.NewLine;

                    // Agregar datos de celdas al texto del portapapeles
                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            clipboardText += (cell.Value ?? string.Empty).ToString() + "\t";
                        }
                        clipboardText = clipboardText.TrimEnd('\t') + Environment.NewLine;
                    }

                    // Copiar al portapapeles
                    Clipboard.SetText(clipboardText);
                    MessageBox.Show("Tabla copiada al portapapeles. Ahora puedes pegarla en Excel");
                }
                else
                {
                    MessageBox.Show("No hay datos en la tabla para copiar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            Show(txtFilter.Text);
        }
    }
}
