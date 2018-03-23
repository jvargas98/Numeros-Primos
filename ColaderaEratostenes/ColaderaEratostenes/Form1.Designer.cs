namespace ColaderaEratostenes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarPrimos = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarPrimos
            // 
            this.btnMostrarPrimos.Location = new System.Drawing.Point(169, 21);
            this.btnMostrarPrimos.Name = "btnMostrarPrimos";
            this.btnMostrarPrimos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarPrimos.TabIndex = 0;
            this.btnMostrarPrimos.Text = "Mostrar";
            this.btnMostrarPrimos.UseVisualStyleBackColor = true;
            this.btnMostrarPrimos.Click += new System.EventHandler(this.btnMostrarPrimos_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(22, 65);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(277, 219);
            this.txtNumeros.TabIndex = 1;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(45, 23);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "L :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.btnMostrarPrimos);
            this.Name = "Form1";
            this.Text = "Numeros Primos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPrimos;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label label1;
    }
}

