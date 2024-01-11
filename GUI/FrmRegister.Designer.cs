namespace GUI
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvRegister = new DataGridView();
            txtFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRegister).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dgvRegister
            // 
            dgvRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegister.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegister.Location = new Point(12, 43);
            dgvRegister.Name = "dgvRegister";
            dgvRegister.RowTemplate.Height = 25;
            dgvRegister.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegister.Size = new Size(760, 406);
            dgvRegister.TabIndex = 1;
            dgvRegister.CellValueChanged += dgvRegister_CellValueChanged;
            dgvRegister.CurrentCellDirtyStateChanged += dgvRegister_CurrentCellDirtyStateChanged;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFilter.Location = new Point(572, 12);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(200, 25);
            txtFilter.TabIndex = 2;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(txtFilter);
            Controls.Add(dgvRegister);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "Registro de viáticos";
            Load += FrmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvRegister;
        private TextBox txtFilter;
    }
}