namespace Pico_Placa
{
    partial class frmPrincipal
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
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.TextBox();
            this.cmddisponibilidad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(122, 37);
            this.txtplaca.MaxLength = 7;
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(100, 22);
            this.txtplaca.TabIndex = 0;            
            this.txtplaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtplaca_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº de Placa: ";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(122, 66);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 22);
            this.txtfecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora:";
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(122, 94);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(53, 22);
            this.txthora.TabIndex = 5;
            // 
            // cmddisponibilidad
            // 
            this.cmddisponibilidad.Location = new System.Drawing.Point(25, 135);
            this.cmddisponibilidad.Name = "cmddisponibilidad";
            this.cmddisponibilidad.Size = new System.Drawing.Size(106, 46);
            this.cmddisponibilidad.TabIndex = 6;
            this.cmddisponibilidad.Text = "Verificar Disponibilidad";
            this.cmddisponibilidad.UseVisualStyleBackColor = true;
            this.cmddisponibilidad.Click += new System.EventHandler(this.cmddisponibilidad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
            this.label4.Location = new System.Drawing.Point(228, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "(XXX1112)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
            this.label5.Location = new System.Drawing.Point(228, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "(dd/MM/yyyy)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.8F);
            this.label6.Location = new System.Drawing.Point(181, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "(HH:mm   24Hs)";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 205);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmddisponibilidad);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplaca);
            this.Name = "frmPrincipal";
            this.Text = "Pico & Placa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Button cmddisponibilidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

