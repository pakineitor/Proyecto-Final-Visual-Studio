namespace Proyecto_final_definitivo
{
    partial class UserEquipoDocente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btayuda = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organigrama del equipo";
            // 
            // btayuda
            // 
            this.btayuda.Image = global::Proyecto_final_definitivo.Properties.Resources.icons8_help_32;
            this.btayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btayuda.Location = new System.Drawing.Point(687, 339);
            this.btayuda.Name = "btayuda";
            this.btayuda.Size = new System.Drawing.Size(100, 41);
            this.btayuda.TabIndex = 28;
            this.btayuda.Text = "ayuda";
            this.btayuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btayuda.UseVisualStyleBackColor = true;
            // 
            // btback
            // 
            this.btback.Image = global::Proyecto_final_definitivo.Properties.Resources.dirrection_sign_arrows_chevron_icon_233796;
            this.btback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btback.Location = new System.Drawing.Point(570, 339);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(100, 41);
            this.btback.TabIndex = 27;
            this.btback.Text = "volver";
            this.btback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // UserEquipoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btayuda);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.label1);
            this.Name = "UserEquipoDocente";
            this.Size = new System.Drawing.Size(801, 398);
            this.Load += new System.EventHandler(this.UserEquipoDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btayuda;
        private System.Windows.Forms.Button btback;
    }
}
