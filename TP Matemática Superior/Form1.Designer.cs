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
            this._cmbCantTiposMuestra = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lblTiposMuestra = new System.Windows.Forms.Label();
            this._grpIngreso = new System.Windows.Forms.GroupBox();
            this._lblCombinacionesPosibles = new System.Windows.Forms.Label();
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
            this.b_ingresarValor.Location = new System.Drawing.Point(62, 193);
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
            this._dgvDatos.Size = new System.Drawing.Size(509, 87);
            this._dgvDatos.TabIndex = 7;
            this._dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvDatos_CellContentClick);
            // 
            // _cmbCantTiposMuestra
            // 
            this._cmbCantTiposMuestra.FormattingEnabled = true;
            this._cmbCantTiposMuestra.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this._cmbCantTiposMuestra.Location = new System.Drawing.Point(404, 143);
            this._cmbCantTiposMuestra.Name = "_cmbCantTiposMuestra";
            this._cmbCantTiposMuestra.Size = new System.Drawing.Size(121, 21);
            this._cmbCantTiposMuestra.TabIndex = 8;
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
            // Columna1
            // 
            this.Columna1.HeaderText = "1";
            this.Columna1.Name = "Columna1";
            this.Columna1.Width = 40;
            // 
            // _lblTiposMuestra
            // 
            this._lblTiposMuestra.AutoSize = true;
            this._lblTiposMuestra.Location = new System.Drawing.Point(223, 146);
            this._lblTiposMuestra.Name = "_lblTiposMuestra";
            this._lblTiposMuestra.Size = new System.Drawing.Size(175, 13);
            this._lblTiposMuestra.TabIndex = 10;
            this._lblTiposMuestra.Text = "Cantidad de cada tipo de Muestras:";
            // 
            // _grpIngreso
            // 
            this._grpIngreso.Controls.Add(this._dgvDatos);
            this._grpIngreso.Controls.Add(this._lblTiposMuestra);
            this._grpIngreso.Controls.Add(this._lblIngrese);
            this._grpIngreso.Controls.Add(this.button1);
            this._grpIngreso.Controls.Add(this._cmbCantTiposMuestra);
            this._grpIngreso.Location = new System.Drawing.Point(12, 12);
            this._grpIngreso.Name = "_grpIngreso";
            this._grpIngreso.Size = new System.Drawing.Size(542, 175);
            this._grpIngreso.TabIndex = 11;
            this._grpIngreso.TabStop = false;
            this._grpIngreso.Text = "Datos de ingreso:";
            // 
            // _lblCombinacionesPosibles
            // 
            this._lblCombinacionesPosibles.AutoSize = true;
            this._lblCombinacionesPosibles.Location = new System.Drawing.Point(211, 202);
            this._lblCombinacionesPosibles.Name = "_lblCombinacionesPosibles";
            this._lblCombinacionesPosibles.Size = new System.Drawing.Size(185, 13);
            this._lblCombinacionesPosibles.TabIndex = 12;
            this._lblCombinacionesPosibles.Text = "Cantidad de combinaciones posibles: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 411);
            this.Controls.Add(this._lblCombinacionesPosibles);
            this.Controls.Add(this._grpIngreso);
            this.Controls.Add(this.b_ingresarValor);
            this.Name = "Form1";
            this.Text = "Formulario de Ingreso";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ComboBox _cmbCantTiposMuestra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna1;
        private System.Windows.Forms.Label _lblTiposMuestra;
        private System.Windows.Forms.GroupBox _grpIngreso;
        private System.Windows.Forms.Label _lblCombinacionesPosibles;
    }
}

