﻿using System;
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
    public partial class UserEquipoDocente : UserControl
    {
        public Form1 form { set; get; }
        public UserEquipoDocente()
        {
            InitializeComponent();
        }

        private void UserEquipoDocente_Load(object sender, EventArgs e)
        {
        
        }

        private void btback_Click(object sender, EventArgs e)
        {
               form.SalirUserAlumno();
        }
    }
}
