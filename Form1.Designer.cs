namespace Proyecto_final_definitivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userBienvenida1 = new Proyecto_final_definitivo.UserBienvenida();
            this.userAlumno1 = new Proyecto_final_definitivo.UserAlumno();
            this.userInformacion1 = new Proyecto_final_definitivo.UserInformacion();
            this.userEquipoDocente1 = new Proyecto_final_definitivo.UserEquipoDocente();
            this.userPlanoCentro1 = new Proyecto_final_definitivo.UserPlanoCentro();
            this.userPlanoPlanta11 = new Proyecto_final_definitivo.UserPlanoPlanta1();
            this.SuspendLayout();
            // 
            // userBienvenida1
            // 
            this.userBienvenida1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userBienvenida1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBienvenida1.form = null;
            this.userBienvenida1.Location = new System.Drawing.Point(0, 0);
            this.userBienvenida1.Name = "userBienvenida1";
            this.userBienvenida1.Size = new System.Drawing.Size(809, 418);
            this.userBienvenida1.TabIndex = 0;
            this.userBienvenida1.Load += new System.EventHandler(this.userBienvenida1_Load);
            // 
            // userAlumno1
            // 
            this.userAlumno1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userAlumno1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAlumno1.form = null;
            this.userAlumno1.Location = new System.Drawing.Point(0, 0);
            this.userAlumno1.Name = "userAlumno1";
            this.userAlumno1.Size = new System.Drawing.Size(809, 418);
            this.userAlumno1.TabIndex = 1;
            // 
            // userInformacion1
            // 
            this.userInformacion1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userInformacion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInformacion1.form = null;
            this.userInformacion1.Location = new System.Drawing.Point(0, 0);
            this.userInformacion1.Name = "userInformacion1";
            this.userInformacion1.Size = new System.Drawing.Size(809, 418);
            this.userInformacion1.TabIndex = 2;
            // 
            // userEquipoDocente1
            // 
            this.userEquipoDocente1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userEquipoDocente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userEquipoDocente1.form = null;
            this.userEquipoDocente1.Location = new System.Drawing.Point(0, 0);
            this.userEquipoDocente1.Name = "userEquipoDocente1";
            this.userEquipoDocente1.Size = new System.Drawing.Size(809, 418);
            this.userEquipoDocente1.TabIndex = 3;
            // 
            // userPlanoCentro1
            // 
            this.userPlanoCentro1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userPlanoCentro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPlanoCentro1.form = null;
            this.userPlanoCentro1.Location = new System.Drawing.Point(0, 0);
            this.userPlanoCentro1.Name = "userPlanoCentro1";
            this.userPlanoCentro1.Size = new System.Drawing.Size(809, 418);
            this.userPlanoCentro1.TabIndex = 4;
            // 
            // userPlanoPlanta11
            // 
            this.userPlanoPlanta11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPlanoPlanta11.Location = new System.Drawing.Point(0, 0);
            this.userPlanoPlanta11.Name = "userPlanoPlanta11";
            this.userPlanoPlanta11.Size = new System.Drawing.Size(809, 418);
            this.userPlanoPlanta11.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 418);
            this.Controls.Add(this.userBienvenida1);
            this.Controls.Add(this.userAlumno1);
            this.Controls.Add(this.userInformacion1);
            this.Controls.Add(this.userEquipoDocente1);
            this.Controls.Add(this.userPlanoCentro1);
            this.Controls.Add(this.userPlanoPlanta11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserBienvenida userBienvenida1;
        private UserAlumno userAlumno1;
        private UserInformacion userInformacion1;
        private UserEquipoDocente userEquipoDocente1;
        private UserPlanoCentro userPlanoCentro1;
        private UserPlanoPlanta1 userPlanoPlanta11;
    }
}

