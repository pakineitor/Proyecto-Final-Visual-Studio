using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_definitivo
{
    public partial class UserContacto : UserControl
    {
        public Form1 form { set; get; }
        public UserContacto()
        {
            InitializeComponent();
        }

        private void UserContacto_Load(object sender, EventArgs e)
        {

        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
            form.MostrarUserAlumno1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            msg.To.Add("sugerencias@cescristorey.com");
            msg.Subject = this.textBox1.Text;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = this.richTextBox1.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.From = new System.Net.Mail.MailAddress(this.correo.Text);

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("sugerencias@cescristorey.com", "2DAM2021");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smpt.cescristorey.com";

            try
            {
                cliente.Send(msg);
                MessageBox.Show("Mensaje enviado con éxito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar el mensaje");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

