namespace Proyecto_final_definitivo
{
    partial class UserBienvenida
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
            this.label2 = new System.Windows.Forms.Label();
            this.btAdmin = new System.Windows.Forms.Button();
            this.btAlumno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(106, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bienvenid@s al punto de información del instituto ^^";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(280, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "¿Quién eres?\r\n";
            // 
            // btAdmin
            // 
            this.btAdmin.Location = new System.Drawing.Point(427, 245);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(114, 48);
            this.btAdmin.TabIndex = 10;
            this.btAdmin.Text = "Administrador";
            this.btAdmin.UseVisualStyleBackColor = true;
            // 
            // btAlumno
            // 
            this.btAlumno.Location = new System.Drawing.Point(160, 245);
            this.btAlumno.Name = "btAlumno";
            this.btAlumno.Size = new System.Drawing.Size(114, 48);
            this.btAlumno.TabIndex = 9;
            this.btAlumno.Text = "Alumno";
            this.btAlumno.UseVisualStyleBackColor = true;
            this.btAlumno.Click += new System.EventHandler(this.btAlumno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_final_definitivo.Properties.Resources.josegras;
            this.pictureBox1.Location = new System.Drawing.Point(197, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAdmin);
            this.Controls.Add(this.btAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserBienvenida";
            this.Size = new System.Drawing.Size(726, 339);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Button btAlumno;
    }
}
