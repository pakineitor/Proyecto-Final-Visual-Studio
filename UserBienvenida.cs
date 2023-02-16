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
    public partial class UserBienvenida : UserControl
    {
        public Form1 form { set; get; }

        public UserBienvenida()
        {
            InitializeComponent();
        }

        private void btAlumno_Click(object sender, EventArgs e)
        {
            form.ocultarInicio();
        }
    }
}
