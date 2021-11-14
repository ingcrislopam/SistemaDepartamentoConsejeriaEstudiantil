using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio.Clases
{
    public class SendMail
    {
        string emisor;

        public string Emisor
        {
            get { return emisor; }
            set { emisor = value; }
        }

        string pwd;

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        public SendMail(string de, string pass)
        {
            emisor = de;
            pwd = pass;
        }

        public void sendMail(string destinatario, string asunto, string adjunto, string correo)
        {
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress(emisor);

            msg.To.Add(new MailAddress(destinatario));

            msg.Subject = asunto;

            Attachment Adjunto = new Attachment(adjunto);
            msg.Attachments.Add(Adjunto);

            msg.Body = correo;


            SmtpClient clienteSmtp = new SmtpClient();
            clienteSmtp.Host = "smtp.gmail.com";
            clienteSmtp.Port = 587;
            clienteSmtp.EnableSsl = false;
            clienteSmtp.UseDefaultCredentials = false;

            clienteSmtp.Credentials = new NetworkCredential(emisor, pwd);
            clienteSmtp.EnableSsl = true;

            try
            {
                clienteSmtp.Send(msg);
                MessageBox.Show("Correo enviado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Correo fallido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
