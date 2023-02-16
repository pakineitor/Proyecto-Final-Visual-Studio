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
    public partial class UserInformacion : UserControl
    {
        public Form1 form { set; get; }
        public UserInformacion()
        {
            InitializeComponent();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            form.SalirInformacion();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.google.es/maps/place/Colegio+Cristo+Rey/@37.1843953,-3.5956216,17z/data=!4m12!1m6!3m5!1s0xd71fcc5dc559503:0x80c10ce5d10004c4!2sColegio+Cristo+Rey!8m2!3d37.1842549!4d-3.5933762!3m4!1s0xd71fcc5dc559503:0x80c10ce5d10004c4!8m2!3d37.1842549!4d-3.5933762?hl=es");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Jos%C3%A9_Gras_y_Granollers");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.cescristorey.com/");
        }
    }
}
