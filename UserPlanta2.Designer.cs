namespace Proyecto_final_definitivo
{
    partial class UserPlanta2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btback = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            this.btOcultar = new System.Windows.Forms.Button();
            this.AulaA = new System.Windows.Forms.Label();
            this.AulaD = new System.Windows.Forms.Label();
            this.AulaC = new System.Windows.Forms.Label();
            this.AulaB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_final_definitivo.Properties.Resources.planta22;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btback
            // 
            this.btback.BackColor = System.Drawing.Color.Aqua;
            this.btback.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btback.Image = global::Proyecto_final_definitivo.Properties.Resources.dirrection_sign_arrows_chevron_icon_233796;
            this.btback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btback.Location = new System.Drawing.Point(277, 433);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(203, 41);
            this.btback.TabIndex = 28;
            this.btback.Text = "volver";
            this.btback.UseVisualStyleBackColor = false;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.BackColor = System.Drawing.Color.Aqua;
            this.Mostrar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar.Image = global::Proyecto_final_definitivo.Properties.Resources.icons8_eye_32;
            this.Mostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mostrar.Location = new System.Drawing.Point(534, 433);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(203, 41);
            this.Mostrar.TabIndex = 43;
            this.Mostrar.Text = "mostrar";
            this.Mostrar.UseVisualStyleBackColor = false;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // btOcultar
            // 
            this.btOcultar.BackColor = System.Drawing.Color.Aqua;
            this.btOcultar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOcultar.Image = global::Proyecto_final_definitivo.Properties.Resources.icons8_hide_32;
            this.btOcultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOcultar.Location = new System.Drawing.Point(534, 433);
            this.btOcultar.Name = "btOcultar";
            this.btOcultar.Size = new System.Drawing.Size(203, 41);
            this.btOcultar.TabIndex = 44;
            this.btOcultar.Text = "ocultar";
            this.btOcultar.UseVisualStyleBackColor = false;
            this.btOcultar.Click += new System.EventHandler(this.btOcultar_Click);
            // 
            // AulaA
            // 
            this.AulaA.AutoSize = true;
            this.AulaA.BackColor = System.Drawing.Color.Black;
            this.AulaA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AulaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AulaA.ForeColor = System.Drawing.Color.White;
            this.AulaA.Location = new System.Drawing.Point(494, 79);
            this.AulaA.Name = "AulaA";
            this.AulaA.Size = new System.Drawing.Size(58, 22);
            this.AulaA.TabIndex = 49;
            this.AulaA.Text = "Aula A";
            this.AulaA.Visible = false;
            // 
            // AulaD
            // 
            this.AulaD.AutoSize = true;
            this.AulaD.BackColor = System.Drawing.Color.Black;
            this.AulaD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AulaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AulaD.ForeColor = System.Drawing.Color.White;
            this.AulaD.Location = new System.Drawing.Point(494, 235);
            this.AulaD.Name = "AulaD";
            this.AulaD.Size = new System.Drawing.Size(59, 22);
            this.AulaD.TabIndex = 50;
            this.AulaD.Text = "Aula D";
            this.AulaD.Visible = false;
            // 
            // AulaC
            // 
            this.AulaC.AutoSize = true;
            this.AulaC.BackColor = System.Drawing.Color.Black;
            this.AulaC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AulaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AulaC.ForeColor = System.Drawing.Color.White;
            this.AulaC.Location = new System.Drawing.Point(666, 235);
            this.AulaC.Name = "AulaC";
            this.AulaC.Size = new System.Drawing.Size(58, 22);
            this.AulaC.TabIndex = 51;
            this.AulaC.Text = "Aula C";
            this.AulaC.Visible = false;
            this.AulaC.Click += new System.EventHandler(this.label2_Click);
            // 
            // AulaB
            // 
            this.AulaB.AutoSize = true;
            this.AulaB.BackColor = System.Drawing.Color.Black;
            this.AulaB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AulaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AulaB.ForeColor = System.Drawing.Color.White;
            this.AulaB.Location = new System.Drawing.Point(666, 79);
            this.AulaB.Name = "AulaB";
            this.AulaB.Size = new System.Drawing.Size(58, 22);
            this.AulaB.TabIndex = 52;
            this.AulaB.Text = "Aula B";
            this.AulaB.Visible = false;
            // 
            // UserPlanta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AulaB);
            this.Controls.Add(this.AulaC);
            this.Controls.Add(this.AulaD);
            this.Controls.Add(this.AulaA);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.btOcultar);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserPlanta2";
            this.Size = new System.Drawing.Size(947, 492);
            this.Load += new System.EventHandler(this.UserPlanta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Button btOcultar;
        private System.Windows.Forms.Label AulaA;
        private System.Windows.Forms.Label AulaD;
        private System.Windows.Forms.Label AulaC;
        private System.Windows.Forms.Label AulaB;
    }
}
