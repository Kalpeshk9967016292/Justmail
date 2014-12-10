using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace JustMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string attach;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "9967016292")
            {
                int x = groupBox2.Location.X;
                int y = groupBox2.Location.Y;

                for (int cy = y; cy > -this.Height; cy--)
                {
                    groupBox2.Location = new Point(x, cy);
                    this.Text = "x : " + x + " y: " + cy;
                }

                groupBox1.Enabled = true;
                groupBox1.Visible = true;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = groupBox2.Location.X;
            int y = groupBox2.Location.Y;

            for (int cy = y; cy <= 30; cy++)
            {
                groupBox2.Location = new Point(x, cy);
                this.Text = "x : " + x + " y: " + cy;
                textBox4.Text = "";
            }

            groupBox1.Enabled = false;
            groupBox1.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);

                mail.From = new MailAddress("yourmail");
                mail.To.Add(textBox1.Text);
                mail.Subject = textBox2.Text;
                mail.Body = richTextBox1.Text;

                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("yourmail", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;   
                
            }

            catch (Exception ex)
            { 
            
            }
        }

        
    }
}
