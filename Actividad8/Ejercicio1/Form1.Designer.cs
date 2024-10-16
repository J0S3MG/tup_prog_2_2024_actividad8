namespace Ejercicio1
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
            this.tbxVer = new System.Windows.Forms.TextBox();
            this.btnVerCuentas = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxVer
            // 
            this.tbxVer.Location = new System.Drawing.Point(12, 12);
            this.tbxVer.Multiline = true;
            this.tbxVer.Name = "tbxVer";
            this.tbxVer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxVer.Size = new System.Drawing.Size(669, 312);
            this.tbxVer.TabIndex = 0;
            // 
            // btnVerCuentas
            // 
            this.btnVerCuentas.Location = new System.Drawing.Point(696, 12);
            this.btnVerCuentas.Name = "btnVerCuentas";
            this.btnVerCuentas.Size = new System.Drawing.Size(110, 49);
            this.btnVerCuentas.TabIndex = 1;
            this.btnVerCuentas.Text = "1- Ver Cuentas";
            this.btnVerCuentas.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(696, 67);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(110, 49);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "2- Importar Cuentas";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(696, 142);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(110, 49);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "3- Exportar Cuentas";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(696, 219);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(110, 49);
            this.btnBackUp.TabIndex = 4;
            this.btnBackUp.Text = "4- BackUp";
            this.btnBackUp.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(696, 274);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(110, 49);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "5- Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 335);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnVerCuentas);
            this.Controls.Add(this.tbxVer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxVer;
        private System.Windows.Forms.Button btnVerCuentas;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Button btnRestore;
    }
}

