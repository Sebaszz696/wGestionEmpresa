namespace wGestionPersonal
{
    partial class frmPersonal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtgCSV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnCSV = new Button();
            lblFecha = new Label();
            Fecha = new System.Windows.Forms.Timer(components);
            lblArea = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCSV).BeginInit();
            SuspendLayout();
            // 
            // dtgCSV
            // 
            dtgCSV.AllowUserToResizeColumns = false;
            dtgCSV.AllowUserToResizeRows = false;
            dtgCSV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgCSV.BackgroundColor = Color.White;
            dtgCSV.BorderStyle = BorderStyle.None;
            dtgCSV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtgCSV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgCSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCSV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgCSV.DefaultCellStyle = dataGridViewCellStyle2;
            dtgCSV.GridColor = SystemColors.ActiveCaptionText;
            dtgCSV.ImeMode = ImeMode.NoControl;
            dtgCSV.Location = new Point(12, 97);
            dtgCSV.Name = "dtgCSV";
            dtgCSV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dtgCSV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgCSV.RowTemplate.Height = 29;
            dtgCSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCSV.Size = new Size(932, 272);
            dtgCSV.TabIndex = 0;
            dtgCSV.CellContentClick += dtgCSV_CellContentClick;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Cedula";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Edad ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Fecha de Nacimiento";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.Frozen = true;
            Column6.HeaderText = "Profesión";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.Frozen = true;
            Column7.HeaderText = "Estado civil";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // btnCSV
            // 
            btnCSV.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCSV.Location = new Point(62, 343);
            btnCSV.Name = "btnCSV";
            btnCSV.Size = new Size(344, 77);
            btnCSV.TabIndex = 1;
            btnCSV.Text = "Cargar Archivo";
            btnCSV.UseVisualStyleBackColor = true;
            btnCSV.Click += btnCSV_Click_1;
            // 
            // lblFecha
            // 
            lblFecha.Dock = DockStyle.Top;
            lblFecha.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(0, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(956, 38);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "FECHA";
            // 
            // Fecha
            // 
            Fecha.Enabled = true;
            Fecha.Tick += Fecha_Tick;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblArea.Location = new Point(649, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(307, 31);
            lblArea.TabIndex = 3;
            lblArea.Text = "AREA RECURSOS HUMANOS";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(500, 343);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(344, 77);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(956, 560);
            Controls.Add(btnLimpiar);
            Controls.Add(lblArea);
            Controls.Add(lblFecha);
            Controls.Add(btnCSV);
            Controls.Add(dtgCSV);
            Name = "frmPersonal";
            Text = "frmPersonal";
            WindowState = FormWindowState.Maximized;
            Load += frmPersonal_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgCSV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnCSV;
        private Label lblFecha;
        private System.Windows.Forms.Timer Fecha;
        private Label lblArea;
        private Button btnLimpiar;
    }
}