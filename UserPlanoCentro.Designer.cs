namespace Proyecto_final_definitivo
{
    partial class UserPlanoCentro
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btayuda = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Planta 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Planta 2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btayuda
            // 
            this.btayuda.Image = global::Proyecto_final_definitivo.Properties.Resources.icons8_help_32;
            this.btayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btayuda.Location = new System.Drawing.Point(302, 220);
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
            this.btback.Location = new System.Drawing.Point(176, 220);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(100, 41);
            this.btback.TabIndex = 27;
            this.btback.Text = "volver";
            this.btback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // UserPlanoCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btayuda);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "UserPlanoCentro";
            this.Size = new System.Drawing.Size(568, 299);
            this.Load += new System.EventHandler(this.UserPlanoCentro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btayuda;
        private System.Windows.Forms.Button btback;
    }
}
