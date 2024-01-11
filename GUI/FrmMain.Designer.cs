namespace GUI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dtpWeeks = new DateTimePicker();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnOpenWeek = new Button();
            label2 = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            label3 = new Label();
            btnOpenReport = new Button();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dtpWeeks
            // 
            dtpWeeks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpWeeks.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpWeeks.Format = DateTimePickerFormat.Short;
            dtpWeeks.Location = new Point(329, 115);
            dtpWeeks.Name = "dtpWeeks";
            dtpWeeks.Size = new Size(126, 25);
            dtpWeeks.TabIndex = 1;
            dtpWeeks.ValueChanged += dtpWeeks_ValueChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem, empleadosToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(224, 91);
            label1.Name = "label1";
            label1.Size = new Size(336, 21);
            label1.TabIndex = 3;
            label1.Text = "Seleccione un día de la semana que desea abrir";
            // 
            // btnOpenWeek
            // 
            btnOpenWeek.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenWeek.Location = new Point(329, 146);
            btnOpenWeek.Name = "btnOpenWeek";
            btnOpenWeek.Size = new Size(126, 29);
            btnOpenWeek.TabIndex = 4;
            btnOpenWeek.Text = "Abrir";
            btnOpenWeek.UseVisualStyleBackColor = true;
            btnOpenWeek.Click += btnOpenWeek_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(213, 258);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 5;
            label2.Text = "Reporte desde";
            // 
            // dtpStart
            // 
            dtpStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(329, 255);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(126, 25);
            dtpStart.TabIndex = 6;
            // 
            // dtpEnd
            // 
            dtpEnd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpEnd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(329, 284);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(126, 25);
            dtpEnd.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(213, 284);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 8;
            label3.Text = "Hasta";
            // 
            // btnOpenReport
            // 
            btnOpenReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenReport.Location = new Point(329, 315);
            btnOpenReport.Name = "btnOpenReport";
            btnOpenReport.Size = new Size(126, 29);
            btnOpenReport.TabIndex = 11;
            btnOpenReport.Text = "Abrir";
            btnOpenReport.UseVisualStyleBackColor = true;
            btnOpenReport.Click += btnOpenReport_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btnOpenReport);
            Controls.Add(label3);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(label2);
            Controls.Add(btnOpenWeek);
            Controls.Add(label1);
            Controls.Add(dtpWeeks);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Reporte Viáticos";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpWeeks;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Label label1;
        private Button btnOpenWeek;
        private Label label2;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Label label3;
        private Button btnOpenReport;
        private ErrorProvider errorProvider1;
    }
}