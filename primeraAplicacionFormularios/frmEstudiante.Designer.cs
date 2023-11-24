namespace primeraAplicacionFormularios
{
    partial class frmEstudiante
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
            dtEstudiante = new DataGridView();
            idEstudiante = new DataGridViewTextBoxColumn();
            nombreEstudiante = new DataGridViewTextBoxColumn();
            carnet = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtCarnet = new TextBox();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtEstudiante).BeginInit();
            SuspendLayout();
            // 
            // dtEstudiante
            // 
            dtEstudiante.AllowUserToAddRows = false;
            dtEstudiante.AllowUserToDeleteRows = false;
            dtEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEstudiante.Columns.AddRange(new DataGridViewColumn[] { idEstudiante, nombreEstudiante, carnet, direccion });
            dtEstudiante.Location = new Point(581, 105);
            dtEstudiante.Name = "dtEstudiante";
            dtEstudiante.ReadOnly = true;
            dtEstudiante.RowHeadersWidth = 51;
            dtEstudiante.RowTemplate.Height = 29;
            dtEstudiante.Size = new Size(670, 297);
            dtEstudiante.TabIndex = 0;
            // 
            // idEstudiante
            // 
            idEstudiante.HeaderText = "ID";
            idEstudiante.MinimumWidth = 6;
            idEstudiante.Name = "idEstudiante";
            idEstudiante.ReadOnly = true;
            idEstudiante.Width = 125;
            // 
            // nombreEstudiante
            // 
            nombreEstudiante.HeaderText = "Nombre del estudiante";
            nombreEstudiante.MinimumWidth = 6;
            nombreEstudiante.Name = "nombreEstudiante";
            nombreEstudiante.ReadOnly = true;
            nombreEstudiante.Width = 125;
            // 
            // carnet
            // 
            carnet.HeaderText = "carnet del estudiante";
            carnet.MinimumWidth = 6;
            carnet.Name = "carnet";
            carnet.ReadOnly = true;
            carnet.Width = 125;
            // 
            // direccion
            // 
            direccion.HeaderText = "direccion del estudiante";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            direccion.Width = 125;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(286, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(97, 203);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(286, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(97, 138);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(286, 27);
            txtCarnet.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(97, 262);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(286, 85);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // frmEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 603);
            Controls.Add(btnInsertar);
            Controls.Add(txtCarnet);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(dtEstudiante);
            Name = "frmEstudiante";
            Text = "frmEstudiante";
            ((System.ComponentModel.ISupportInitialize)dtEstudiante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtEstudiante;
        private DataGridViewTextBoxColumn idEstudiante;
        private DataGridViewTextBoxColumn nombreEstudiante;
        private DataGridViewTextBoxColumn carnet;
        private DataGridViewTextBoxColumn direccion;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtCarnet;
        private Button btnInsertar;
    }
}