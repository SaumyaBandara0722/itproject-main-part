using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
namespace itproject
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void Mail_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

           // string to, from, pass, mail;

            //to=(t1.Text).ToString();
           // from=(t2.Text).ToString();
           // pass=(t3.Text).ToString();
           // mail=(t5.Text).ToString();


            //MailMessage message = new MailMessage();
            //message.To.Add(to);

            //message.From = new MailAddress(from);
            //message.Body = mail;
            //message.Subject = "Testing Mail";

          //  SmtpClient smtp = new SmtpClient("smtp.gmail.com");
           // smtp.EnableSsl = true;
            //smtp.Port = 587;

            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                //smtp.Send(message);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("tctcools@gmail.com","Ultygirl0");
                MailMessage msg = new MailMessage();
                msg.To.Add(t1.Text);
                msg.From = new MailAddress("tctcools@gmail.com");
                msg.Subject = t2.Text;
                msg.Body = t5.Text;
                client.Send(msg);
             

                 MessageBox.Show("Successfully inserting.", "Inserted.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed !.", "Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Emailclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Emailmaximize_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Emailminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
