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
    public partial class UserPapelerias : UserControl
    {
        public Form1 form { set; get; }
        public UserPapelerias()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?sa=X&rlz=1C1CHBF_esES1017ES1017&biw=1920&bih=969&tbs=lf:1,lf_ui:10&tbm=lcl&q=papeler%C3%ADas+albaic%C3%ADn+granada&rflfq=1&num=10&ved=2ahUKEwiz4cCosaH9AhXiTqQEHR9tApEQtgN6BAgREAc#rlfi=hd:;si:16405627808841930249,l,Ch1wYXBlbGVyw61hcyBhbGJhaWPDrW4gZ3JhbmFkYUj97PD9lKuAgAhaLRAAGAAYARgCIh1wYXBlbGVyw61hcyBhbGJhaWPDrW4gZ3JhbmFkYSoECAMQAJIBD3Nob3BwaW5nX2NlbnRlcqoBExABKg8iC3BhcGVsZXLDrWFzKA4;mv:[[37.18493754517876,-3.5885859451528823],[37.18145861469852,-3.59663257219756],null,[37.1831980999686,-3.592609258675221],18]");
            this.button2.BackColor = System.Drawing.Color.BlueViolet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?sa=X&rlz=1C1CHBF_esES1017ES1017&biw=1920&bih=969&tbs=lf:1,lf_ui:10&tbm=lcl&q=papeler%C3%ADas+albaic%C3%ADn+granada&rflfq=1&num=10&ved=2ahUKEwiz4cCosaH9AhXiTqQEHR9tApEQtgN6BAgREAc#rlfi=hd:;si:8224252444611704770;mv:[[37.18493754517876,-3.5885859451528823],[37.18145861469852,-3.59663257219756],null,[37.1831980999686,-3.592609258675221],18]");
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
        }

        private void UserPapelerias_Load(object sender, EventArgs e)
        {
            
        }

        private void btback_Click(object sender, EventArgs e)
        {
            form.SalirDePapelerias();
        }
    }
}
