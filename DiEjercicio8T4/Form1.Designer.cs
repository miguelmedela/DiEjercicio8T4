
namespace DiEjercicio8T4
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
            this.components = new System.ComponentModel.Container();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.buttonRetroceso = new System.Windows.Forms.Button();
            this.buttonAvance = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbImagen = new System.Windows.Forms.Label();
            this.lbDirect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Location = new System.Drawing.Point(93, 74);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(75, 23);
            this.buttonAbrir.TabIndex = 0;
            this.buttonAbrir.Text = "Abrir";
            this.toolTip1.SetToolTip(this.buttonAbrir, "Abrir visor");
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // buttonRetroceso
            // 
            this.buttonRetroceso.Location = new System.Drawing.Point(12, 138);
            this.buttonRetroceso.Name = "buttonRetroceso";
            this.buttonRetroceso.Size = new System.Drawing.Size(85, 23);
            this.buttonRetroceso.TabIndex = 1;
            this.buttonRetroceso.Text = "Retroceso";
            this.toolTip1.SetToolTip(this.buttonRetroceso, "Imagen anterior");
            this.buttonRetroceso.UseVisualStyleBackColor = true;
            this.buttonRetroceso.Click += new System.EventHandler(this.buttonRetroceso_Click);
            // 
            // buttonAvance
            // 
            this.buttonAvance.Location = new System.Drawing.Point(161, 138);
            this.buttonAvance.Name = "buttonAvance";
            this.buttonAvance.Size = new System.Drawing.Size(75, 23);
            this.buttonAvance.TabIndex = 2;
            this.buttonAvance.Text = "Avance";
            this.toolTip1.SetToolTip(this.buttonAvance, "Siguiente imagen");
            this.buttonAvance.UseVisualStyleBackColor = true;
            this.buttonAvance.Click += new System.EventHandler(this.buttonAvance_Click);
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(274, 167);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(0, 17);
            this.lbImagen.TabIndex = 3;
            // 
            // lbDirect
            // 
            this.lbDirect.AutoSize = true;
            this.lbDirect.Location = new System.Drawing.Point(274, 36);
            this.lbDirect.Name = "lbDirect";
            this.lbDirect.Size = new System.Drawing.Size(0, 17);
            this.lbDirect.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 282);
            this.Controls.Add(this.lbDirect);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.buttonAvance);
            this.Controls.Add(this.buttonRetroceso);
            this.Controls.Add(this.buttonAbrir);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Visor de Imagenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAbrir;
        public System.Windows.Forms.Button buttonRetroceso;
        public System.Windows.Forms.Button buttonAvance;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Label lbDirect;
    }
}

