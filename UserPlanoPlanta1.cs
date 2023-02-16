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
    public partial class UserPlanoPlanta1 : UserControl
    {
        public Form1 form { set; get; }
        public UserPlanoPlanta1()
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
    }
}
