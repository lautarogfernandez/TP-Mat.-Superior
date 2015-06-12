namespace TP_Matemática_Superior
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_particulasFotonicas = new System.Windows.Forms.Label();
            this.lbl_hidrogenoIonizado = new System.Windows.Forms.Label();
            this.b_ingresarValor = new System.Windows.Forms.Button();
            this.txt_particulasFotonicas = new System.Windows.Forms.TextBox();
            this.txt_hidrogenoIonizado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE LAS MUESTRAS";
            // 
            // lbl_particulasFotonicas
            // 
            this.lbl_particulasFotonicas.AutoSize = true;
            this.lbl_particulasFotonicas.Location = new System.Drawing.Point(29, 65);
            this.lbl_particulasFotonicas.Name = "lbl_particulasFotonicas";
            this.lbl_particulasFotonicas.Size = new System.Drawing.Size(104, 13);
            this.lbl_particulasFotonicas.TabIndex = 1;
            this.lbl_particulasFotonicas.Text = "Partículas Fotónicas";
            // 
            // lbl_hidrogenoIonizado
            // 
            this.lbl_hidrogenoIonizado.AutoSize = true;
            this.lbl_hidrogenoIonizado.Location = new System.Drawing.Point(29, 96);
            this.lbl_hidrogenoIonizado.Name = "lbl_hidrogenoIonizado";
            this.lbl_hidrogenoIonizado.Size = new System.Drawing.Size(99, 13);
            this.lbl_hidrogenoIonizado.TabIndex = 2;
            this.lbl_hidrogenoIonizado.Text = "Hidrógeno Ionizado";
            // 
            // b_ingresarValor
            // 
            this.b_ingresarValor.Location = new System.Drawing.Point(81, 136);
            this.b_ingresarValor.Name = "b_ingresarValor";
            this.b_ingresarValor.Size = new System.Drawing.Size(103, 23);
            this.b_ingresarValor.TabIndex = 3;
            this.b_ingresarValor.Text = "Ingresar valor";
            this.b_ingresarValor.UseVisualStyleBackColor = true;
            this.b_ingresarValor.Click += new System.EventHandler(this.b_ingresarValor_Click_1);
            // 
            // txt_particulasFotonicas
            // 
            this.txt_particulasFotonicas.Location = new System.Drawing.Point(156, 62);
            this.txt_particulasFotonicas.Name = "txt_particulasFotonicas";
            this.txt_particulasFotonicas.Size = new System.Drawing.Size(53, 20);
            this.txt_particulasFotonicas.TabIndex = 5;
            // 
            // txt_hidrogenoIonizado
            // 
            this.txt_hidrogenoIonizado.Location = new System.Drawing.Point(156, 89);
            this.txt_hidrogenoIonizado.Name = "txt_hidrogenoIonizado";
            this.txt_hidrogenoIonizado.Size = new System.Drawing.Size(53, 20);
            this.txt_hidrogenoIonizado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 262);
            this.Controls.Add(this.txt_hidrogenoIonizado);
            this.Controls.Add(this.txt_particulasFotonicas);
            this.Controls.Add(this.b_ingresarValor);
            this.Controls.Add(this.lbl_hidrogenoIonizado);
            this.Controls.Add(this.lbl_particulasFotonicas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_particulasFotonicas;
        private System.Windows.Forms.Label lbl_hidrogenoIonizado;
        private System.Windows.Forms.Button b_ingresarValor;
        private System.Windows.Forms.TextBox txt_particulasFotonicas;
        private System.Windows.Forms.TextBox txt_hidrogenoIonizado;
    }
}

