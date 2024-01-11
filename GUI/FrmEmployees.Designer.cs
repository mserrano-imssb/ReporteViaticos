namespace GUI
{
    partial class FrmEmployees
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnExit = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtLastName = new TextBox();
            txtName = new TextBox();
            lblLastName = new Label();
            lblName = new Label();
            label1 = new Label();
            dgvEmployees = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            txtFilter = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(txtFilter);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 461);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(3, 427);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(194, 31);
            btnExit.TabIndex = 6;
            btnExit.Text = "Volver";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(12, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 31);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Guardar cambios";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(12, 133);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(178, 31);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Registrar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(11, 102);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 25);
            txtLastName.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(11, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(179, 25);
            txtName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(11, 82);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(62, 17);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Apellidos";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(11, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 17);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestion de empleados";
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(206, 12);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowTemplate.Height = 25;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(566, 437);
            dgvEmployees.TabIndex = 7;
            dgvEmployees.CellMouseDoubleClick += dgvEmployees_CellMouseDoubleClick;
            dgvEmployees.CellValueChanged += dgvEmployees_CellValueChanged;
            dgvEmployees.CurrentCellDirtyStateChanged += dgvEmployees_CurrentCellDirtyStateChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFilter.Location = new Point(11, 273);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(179, 25);
            txtFilter.TabIndex = 7;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 253);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 8;
            label2.Text = "Filtrar";
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(dgvEmployees);
            Controls.Add(panel1);
            Name = "FrmEmployees";
            Text = "Empleados";
            Load += FrmEmployees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtName;
        private Label lblLastName;
        private Label lblName;
        private Label label1;
        private Button btnExit;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtLastName;
        private DataGridView dgvEmployees;
        private ErrorProvider errorProvider1;
        private TextBox txtFilter;
        private Label label2;
    }
}