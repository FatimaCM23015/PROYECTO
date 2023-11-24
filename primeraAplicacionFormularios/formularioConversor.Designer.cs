namespace primeraAplicacionFormularios
{
    partial class formularioConversor
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
            convertirCF = new CheckBox();
            convertirFC = new CheckBox();
            textBox1 = new TextBox();
            lbGradosF = new Label();
            lbGradosC = new Label();
            btnConvertir = new Button();
            SuspendLayout();
            // 
            // convertirCF
            // 
            convertirCF.AutoSize = true;
            convertirCF.Location = new Point(41, 32);
            convertirCF.Name = "convertirCF";
            convertirCF.Size = new Size(148, 24);
            convertirCF.TabIndex = 0;
            convertirCF.Text = "Convertir de C a F";
            convertirCF.UseVisualStyleBackColor = true;
            // 
            // convertirFC
            // 
            convertirFC.AutoSize = true;
            convertirFC.Location = new Point(335, 32);
            convertirFC.Name = "convertirFC";
            convertirFC.Size = new Size(148, 24);
            convertirFC.TabIndex = 1;
            convertirFC.Text = "Convertir de F a C";
            convertirFC.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(442, 27);
            textBox1.TabIndex = 2;
            // 
            // lbGradosF
            // 
            lbGradosF.AutoSize = true;
            lbGradosF.Location = new Point(41, 195);
            lbGradosF.Name = "lbGradosF";
            lbGradosF.Size = new Size(50, 20);
            lbGradosF.TabIndex = 3;
            lbGradosF.Text = "label1";
            lbGradosF.Click += label1_Click;
            // 
            // lbGradosC
            // 
            lbGradosC.AutoSize = true;
            lbGradosC.Location = new Point(335, 195);
            lbGradosC.Name = "lbGradosC";
            lbGradosC.Size = new Size(50, 20);
            lbGradosC.TabIndex = 4;
            lbGradosC.Text = "label2";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(41, 267);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(442, 54);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // formularioConversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 538);
            Controls.Add(btnConvertir);
            Controls.Add(lbGradosC);
            Controls.Add(lbGradosF);
            Controls.Add(textBox1);
            Controls.Add(convertirFC);
            Controls.Add(convertirCF);
            Name = "formularioConversor";
            Text = "formularioConversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox convertirCF;
        private CheckBox convertirFC;
        private TextBox textBox1;
        private Label lbGradosF;
        private Label lbGradosC;
        private Button btnConvertir;
    }
}