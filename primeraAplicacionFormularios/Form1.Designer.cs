namespace primeraAplicacionFormularios
{
    partial class Form1
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
            btnCalcular = new Button();
            label1 = new Label();
            txtCampo1 = new TextBox();
            txtCampo2 = new TextBox();
            label2 = new Label();
            lbRespuesta = new Label();
            btnResta = new Button();
            btnMultiplicacion = new Button();
            btnDivision = new Button();
            btnAbrirNuevoFormulario = new Button();
            dtProductos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtProductos).BeginInit();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(52, 195);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(301, 46);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Campo 1";
            // 
            // txtCampo1
            // 
            txtCampo1.Location = new Point(52, 41);
            txtCampo1.Name = "txtCampo1";
            txtCampo1.Size = new Size(301, 27);
            txtCampo1.TabIndex = 2;
            // 
            // txtCampo2
            // 
            txtCampo2.Location = new Point(52, 112);
            txtCampo2.Name = "txtCampo2";
            txtCampo2.Size = new Size(301, 27);
            txtCampo2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 89);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Campo 2";
            // 
            // lbRespuesta
            // 
            lbRespuesta.AutoSize = true;
            lbRespuesta.Location = new Point(52, 159);
            lbRespuesta.Name = "lbRespuesta";
            lbRespuesta.Size = new Size(50, 20);
            lbRespuesta.TabIndex = 5;
            lbRespuesta.Text = "label3";
            // 
            // btnResta
            // 
            btnResta.Location = new Point(52, 258);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(301, 46);
            btnResta.TabIndex = 6;
            btnResta.Text = "Resta";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Location = new Point(52, 329);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(301, 51);
            btnMultiplicacion.TabIndex = 7;
            btnMultiplicacion.Text = "Multiplicacion";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(52, 400);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(301, 38);
            btnDivision.TabIndex = 8;
            btnDivision.Text = "Division";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnAbrirNuevoFormulario
            // 
            btnAbrirNuevoFormulario.BackColor = Color.ForestGreen;
            btnAbrirNuevoFormulario.FlatAppearance.BorderSize = 0;
            btnAbrirNuevoFormulario.FlatStyle = FlatStyle.Flat;
            btnAbrirNuevoFormulario.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrirNuevoFormulario.ForeColor = SystemColors.ButtonHighlight;
            btnAbrirNuevoFormulario.Location = new Point(424, 118);
            btnAbrirNuevoFormulario.Name = "btnAbrirNuevoFormulario";
            btnAbrirNuevoFormulario.Size = new Size(180, 104);
            btnAbrirNuevoFormulario.TabIndex = 9;
            btnAbrirNuevoFormulario.Text = "Convertir";
            btnAbrirNuevoFormulario.UseVisualStyleBackColor = false;
            btnAbrirNuevoFormulario.Click += btnAbrirNuevoFormulario_Click;
            // 
            // dtProductos
            // 
            dtProductos.AllowUserToAddRows = false;
            dtProductos.AllowUserToDeleteRows = false;
            dtProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtProductos.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre, precio });
            dtProductos.Location = new Point(744, 123);
            dtProductos.Name = "dtProductos";
            dtProductos.ReadOnly = true;
            dtProductos.RowHeadersWidth = 51;
            dtProductos.RowTemplate.Height = 29;
            dtProductos.Size = new Size(433, 188);
            dtProductos.TabIndex = 10;
            // 
            // codigo
            // 
            codigo.HeaderText = "Codigo";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            precio.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1387, 553);
            Controls.Add(dtProductos);
            Controls.Add(btnAbrirNuevoFormulario);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btnResta);
            Controls.Add(lbRespuesta);
            Controls.Add(label2);
            Controls.Add(txtCampo2);
            Controls.Add(txtCampo1);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private TextBox txtCampo1;
        private TextBox txtCampo2;
        private Label label2;
        private Label lbRespuesta;
        private Button btnResta;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private Button btnAbrirNuevoFormulario;
        private DataGridView dtProductos;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
    }
}