using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_definitivo
{
    public partial class UserPlanta2 : UserControl
    {
        public Form1 form { set; get; }
        public UserPlanta2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            this.Mostrar.Visible = false;
            this.Mostrar.SendToBack();
            this.btOcultar.Visible = true;
            this.btOcultar.BringToFront();

            this.AulaA.Visible = true;
            this.AulaB.Visible = true;
            this.AulaC.Visible = true;
            this.AulaD.Visible = true;
        }

        private void btOcultar_Click(object sender, EventArgs e)
        {
            this.btOcultar.Visible = false;
            this.btOcultar.SendToBack();
            this.Mostrar.Visible = true;
            this.Mostrar.BringToFront();

            this.AulaA.Visible = false;
            this.AulaB.Visible = false;
            this.AulaC.Visible = false;
            this.AulaD.Visible = false;
        }

        private void UserPlanta2_Load(object sender, EventArgs e)
        {

        }

        private void btback_Click(object sender, EventArgs e)
        {
            
            form.MostrarPlanosDelCentro();
        }
    }
}
