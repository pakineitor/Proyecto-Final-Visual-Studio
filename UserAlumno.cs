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

        private void btEquipoDirectivo_Click(object sender, EventArgs e)
        {
            form.MostrarEquipoDiretivo();
        }

        private void btPlanoCentro_Click(object sender, EventArgs e)
        {
            form.MostrarPlanosDelCentro();
        }
    }
}
