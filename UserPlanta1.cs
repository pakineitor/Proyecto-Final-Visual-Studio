using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_definitivo
{
    public partial class UserPlanta1 : UserControl
    {
        public Form1 form { set; get; }
        public UserPlanta1()
        {
            InitializeComponent();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            this.Mostrar.Visible = false;
            this.Mostrar.SendToBack();

            this.btOcultar.Visible = true;
            this.btOcultar.BringToFront();

            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.label9.Visible = true;
            
        }

        private void btOcultar_Click(object sender, EventArgs e)
        {
            this.btOcultar.Visible = false;
            this.btOcultar.SendToBack();

            this.Mostrar.Visible = true;
            this.Mostrar.BringToFront();

            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
        }

        private void btback_Click(object sender, EventArgs e)
        {
            form.SalirPlanoPlanta1();
        }

        private void UserPlanta1_Load(object sender, EventArgs e)
        {

        }
    }
}
