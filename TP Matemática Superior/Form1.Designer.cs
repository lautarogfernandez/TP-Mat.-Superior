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
            this._lblIngrese = new System.Windows.Forms.Label();
            this.b_ingresarValor = new System.Windows.Forms.Button();
            this._dgvDatos = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this._grpIngreso = new System.Windows.Forms.GroupBox();
            this.lbl_grupo1 = new System.Windows.Forms.Label();
            this.lbl_grupo2 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_recta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dgvDatos)).BeginInit();
            this._grpIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblIngrese
            // 
            this._lblIngrese.AutoSize = true;
            this._lblIngrese.Location = new System.Drawing.Point(175, 16);
            this._lblIngrese.Name = "_lblIngrese";
            this._lblIngrese.Size = new System.Drawing.Size(223, 13);
            this._lblIngrese.TabIndex = 0;
            this._lblIngrese.Text = "INGRESE LOS DATOS DE LAS MUESTRAS";
            // 
            // b_ingresarValor
            // 
            this.b_ingresarValor.Location = new System.Drawing.Point(77, 238);
            this.b_ingresarValor.Name = "b_ingresarValor";
            this.b_ingresarValor.Size = new System.Drawing.Size(103, 23);
            this.b_ingresarValor.TabIndex = 3;
            this.b_ingresarValor.Text = "Confirmar datos";
            this.b_ingresarValor.UseVisualStyleBackColor = true;
            this.b_ingresarValor.Click += new System.EventHandler(this.b_ingresarValor_Click_1);
            // 
            // _dgvDatos
            // 
            this._dgvDatos.AllowDrop = true;
            this._dgvDatos.AllowUserToAddRows = false;
            this._dgvDatos.AllowUserToDeleteRows = false;
            this._dgvDatos.AllowUserToOrderColumns = true;
            this._dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1});
            this._dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this._dgvDatos.Location = new System.Drawing.Point(15, 46);
            this._dgvDatos.Name = "_dgvDatos";
            this._dgvDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgvDatos.Size = new System.Drawing.Size(658, 87);
            this._dgvDatos.TabIndex = 7;
            this._dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvDatos_CellContentClick);
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "1";
            this.Columna1.Name = "Columna1";
            this.Columna1.Width = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "AGREGAR COLUMNA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _grpIngreso
            // 
            this._grpIngreso.Controls.Add(this._dgvDatos);
            this._grpIngreso.Controls.Add(this._lblIngrese);
            this._grpIngreso.Controls.Add(this.button1);
            this._grpIngreso.Location = new System.Drawing.Point(12, 12);
            this._grpIngreso.Name = "_grpIngreso";
            this._grpIngreso.Size = new System.Drawing.Size(713, 175);
            this._grpIngreso.TabIndex = 11;
            this._grpIngreso.TabStop = false;
            this._grpIngreso.Text = "Datos de ingreso:";
            // 
            // lbl_grupo1
            // 
            this.lbl_grupo1.AutoSize = true;
            this.lbl_grupo1.Location = new System.Drawing.Point(453, 220);
            this.lbl_grupo1.Name = "lbl_grupo1";
            this.lbl_grupo1.Size = new System.Drawing.Size(0, 13);
            this.lbl_grupo1.TabIndex = 12;
            // 
            // lbl_grupo2
            // 
            this.lbl_grupo2.AutoSize = true;
            this.lbl_grupo2.Location = new System.Drawing.Point(488, 264);
            this.lbl_grupo2.Name = "lbl_grupo2";
            this.lbl_grupo2.Size = new System.Drawing.Size(0, 13);
            this.lbl_grupo2.TabIndex = 13;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(582, 332);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 15;
            // 
            // lbl_recta
            // 
            this.lbl_recta.AutoSize = true;
            this.lbl_recta.Location = new System.Drawing.Point(547, 288);
            this.lbl_recta.Name = "lbl_recta";
            this.lbl_recta.Size = new System.Drawing.Size(0, 13);
            this.lbl_recta.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 411);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_recta);
            this.Controls.Add(this.lbl_grupo2);
            this.Controls.Add(this.lbl_grupo1);
            this.Controls.Add(this._grpIngreso);
            this.Controls.Add(this.b_ingresarValor);
            this.Name = "Form1";
            this.Text = "Formulario de Ingreso";
            ((System.ComponentModel.ISupportInitialize)(this._dgvDatos)).EndInit();
            this._grpIngreso.ResumeLayout(false);
            this._grpIngreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblIngrese;
        private System.Windows.Forms.Button b_ingresarValor;
        private System.Windows.Forms.DataGridView _dgvDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna1;
        private System.Windows.Forms.GroupBox _grpIngreso;
        private System.Windows.Forms.Label lbl_grupo1;
        private System.Windows.Forms.Label lbl_grupo2;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_recta;
    }
}

