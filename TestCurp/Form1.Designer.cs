namespace TestCurp
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
            this.ctlCurp1 = new ctlComponenteCurp.ctlCurp();
            this.SuspendLayout();
            // 
            // ctlCurp1
            // 
            this.ctlCurp1.BackColor = System.Drawing.Color.Transparent;
            this.ctlCurp1.CurpGenerada = "";
            this.ctlCurp1.Estado = "AS - Aguascalientes";
            this.ctlCurp1.FechaNacimiento = new System.DateTime(2025, 6, 12, 15, 19, 47, 601);
            this.ctlCurp1.Genero = "Masculino";
            this.ctlCurp1.Location = new System.Drawing.Point(156, 51);
            this.ctlCurp1.Name = "ctlCurp1";
            this.ctlCurp1.Nombre = "";
            this.ctlCurp1.PrimerApellido = "";
            this.ctlCurp1.SegundoApellido = "";
            this.ctlCurp1.Size = new System.Drawing.Size(663, 446);
            this.ctlCurp1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(939, 537);
            this.Controls.Add(this.ctlCurp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctlComponenteCurp.ctlCurp ctlCurp1;
    }
}

