﻿using System;
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
    public partial class UserAlumno : UserControl
    {
        public Form1 form { set; get; }
        public UserAlumno()
        {
            InitializeComponent();
        }

        private void btayuda_Click(object sender, EventArgs e)  
        {

        }

        private void btback_Click(object sender, EventArgs e)
        {
            form.VolverAtras();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.MostrarInformacion();
        }

        private void UserAlumno_Load(object sender, EventArgs e)
        {

        }

        

        private void btPlanoCentro_Click(object sender, EventArgs e)
        {
            form.MostrarPlanosDelCentro();
        }

        private void btSitiosInteres_Click(object sender, EventArgs e)
        {
            form.MostrarUserPuntosInteres();
        }

        private void MouseHoverinformacion(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.MostrarUserContacto();
        }

        private void btAulas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para poder navegar por la aplicación, vaya pulsando por los botones y el programa le irá llevando " +
                "hacia donde necesite. Gracias ^^");
        }

        private void btPapeleriasCercanas_Click(object sender, EventArgs e)
        {
            form.MostrarPapelerias();
        }
    }
}
