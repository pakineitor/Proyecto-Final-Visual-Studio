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

    public partial class UserPlanta0 : UserControl
    {
    
        public Form1 form { set; get; }
        public UserPlanta0()
        {
            InitializeComponent();
        }

        private void UserPlanoPlanta1_Load(object sender, EventArgs e)
        {

        }

        private void btback_Click(object sender, EventArgs e)
        {
            form.OcultarUserPlanoPlanta1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            
           
                this.EntradaLateral.Visible = true;
                this.EntradaPrincipalExterior.Visible = true;
                this.EntradaPatioInterior.Visible = true;

                this.AseosNiñas.Visible = true;
                this.AseosNiños.Visible = true;
                this.AseoProfesores.Visible = true;
                this.AseoMinusvalido.Visible = true;

                this.aula1DAM.Visible = true;
                this.AulaIntegracionSocial2.Visible = true;
                this.Aulabach2.Visible = true;
                this.laula2DAM.Visible = true;

                this.pictureBox3.Visible = true;
                this.Patio.Visible = true;
                this.SalaProfesores.Visible = true;
                this.salaFrenteConserjeria.Visible = true;
                this.SalaEstar.Visible = true;
                this.Conserjeria.Visible = true;
                this.pictureBox2.Visible = true;
                
                
                
            


                this.Mostrar.Visible = false;
                this.btOcultar.Visible = true;
                this.Mostrar.SendToBack();
                this.btOcultar.Visible = true;
                this.btOcultar.BringToFront();
            

        }

        private void btOcultar_Click(object sender, EventArgs e)
        {
            this.EntradaLateral.Visible = false;
            this.EntradaPrincipalExterior.Visible = false;
            this.EntradaPatioInterior.Visible = false;

            this.AseosNiñas.Visible = false;
            this.AseosNiños.Visible = false;
            this.AseoProfesores.Visible = false;
            this.AseoMinusvalido.Visible = false;

            this.aula1DAM.Visible = false;
            this.AulaIntegracionSocial2.Visible = false;
            this.Aulabach2.Visible = false;
            this.laula2DAM.Visible = false;

            this.pictureBox3.Visible = false;
            this.Patio.Visible = false;
            this.SalaProfesores.Visible = false;
            this.salaFrenteConserjeria.Visible = false;
            this.SalaEstar.Visible = false;
            this.Conserjeria.Visible = false;
            this.pictureBox2.Visible = false;


            this.btOcultar.SendToBack();
            this.btOcultar.Visible = false;
            this.Mostrar.Visible = true;
            this.Mostrar.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
