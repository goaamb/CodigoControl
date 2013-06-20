namespace CodigoControl
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.factura = new System.Windows.Forms.TextBox();
            this.nit = new System.Windows.Forms.TextBox();
            this.monto = new System.Windows.Forms.TextBox();
            this.autorizacion = new System.Windows.Forms.TextBox();
            this.llave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.codigoControl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // factura
            // 
            this.factura.Location = new System.Drawing.Point(93, 12);
            this.factura.Name = "factura";
            this.factura.Size = new System.Drawing.Size(117, 20);
            this.factura.TabIndex = 0;
            // 
            // nit
            // 
            this.nit.Location = new System.Drawing.Point(93, 38);
            this.nit.Name = "nit";
            this.nit.Size = new System.Drawing.Size(117, 20);
            this.nit.TabIndex = 1;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(93, 90);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(117, 20);
            this.monto.TabIndex = 3;
            // 
            // autorizacion
            // 
            this.autorizacion.Location = new System.Drawing.Point(367, 12);
            this.autorizacion.Name = "autorizacion";
            this.autorizacion.Size = new System.Drawing.Size(117, 20);
            this.autorizacion.TabIndex = 4;
            // 
            // llave
            // 
            this.llave.Location = new System.Drawing.Point(367, 38);
            this.llave.Name = "llave";
            this.llave.Size = new System.Drawing.Size(117, 20);
            this.llave.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nº Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nit/CI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Autorizacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "llave:";
            // 
            // fecha
            // 
            this.fecha.CustomFormat = "yyyyMMdd";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(93, 67);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(117, 20);
            this.fecha.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codigoControl
            // 
            this.codigoControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.codigoControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codigoControl.Location = new System.Drawing.Point(299, 68);
            this.codigoControl.Name = "codigoControl";
            this.codigoControl.Size = new System.Drawing.Size(100, 13);
            this.codigoControl.TabIndex = 13;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 283);
            this.Controls.Add(this.codigoControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llave);
            this.Controls.Add(this.autorizacion);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.nit);
            this.Controls.Add(this.factura);
            this.Name = "Principal";
            this.Text = "Codigo de control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox factura;
        private System.Windows.Forms.TextBox nit;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.TextBox autorizacion;
        private System.Windows.Forms.TextBox llave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codigoControl;
    }
}

