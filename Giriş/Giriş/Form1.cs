using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        // Mouse Hareketleri
        bool move;
        int mouse_x;
        int mouse_y;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X-mouse_x, MousePosition.Y-mouse_y);
            }
        }

       
        //Metin Kutuları Etkinlikleri

        // Text Box 1
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text== "Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                textBox1.Text = "Kullanıcı Adı";
                textBox1.ForeColor = Color.Silver;
            }
        }

  

        //şifre kontrol

        private void button2_Click(object sender, EventArgs e)
        {
            string ka = textBox1.Text;
            string pass = textBox2.Text;

            if (ka == "Zylles") //user name
            {
                if (pass == "2005") // password
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = "Giriş Başarılı";
                }

                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Şifre Yanlış";
                }
            }

            else
            {
                label1.ForeColor= Color.Red;
                label1.Text = "Kullanıcı Adı Yanlış";
            }
        }
    }
}
