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
    public partial class UserPlanoCentro : UserControl
    {
        public Form1 form { set; get; }
        public UserPlanoCentro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UserPlanoCentro_Load(object sender, EventArgs e)
        {

        }

        private void btback_Click(object sender, EventArgs e)
        {
            form.OcultarUserPlanosDelCentro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.MostrarUserPlanoPlanta1();
        }
    }
}
