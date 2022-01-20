using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormA
{
    class Start_Form : System.Windows.Forms.Form
    {
        public Start_Form()
        {

            this.Height = 750;
            this.Width = 750;
            this.BackColor=Color.Orange;

            Button st_btn = new Button
            {
                Text = "8k saalid",
                Location = new System.Drawing.Point(10, 10)
            };
            st_btn.Click += St_btn_Click;
            this.Controls.Add(st_btn);
            Button st_btn2 = new Button()
            {
                Text = "4k saal",
                Location = new System.Drawing.Point(10, 50)
                
            };
            st_btn2.Click += St_btn_Click1; 
            this.Controls.Add(st_btn2);


            PictureBox film = new PictureBox
            {
                Image = Image.FromFile(@"..\..\Filmid\titinik.jpg"),
                Location = new System.Drawing.Point(10, 100),
                Size = new System.Drawing.Size(500,500),
                SizeMode = PictureBoxSizeMode.Zoom

            };
            this.Controls.Add(film);
            film.Click += Film_Click;


            PictureBox film2 = new PictureBox
            {
                Image = Image.FromFile(@"..\..\Filmid\venom.jpg"),
                Location = new System.Drawing.Point(500, 100),
                Size = new System.Drawing.Size(500, 500),
                SizeMode = PictureBoxSizeMode.Zoom

            };
            this.Controls.Add(film2);
            film2.Click += Film_Click1;
        }
        string filminimetus;

        private void Film_Click(object sender, EventArgs e)
        {
            filminimetus = Film();
        }

        private void Film_Click1(object sender, EventArgs e)
        {
            filminimetus = Film2();
        }
        private string Film()
        {
            filminimetus = "Titanik";
            return filminimetus;

        }
        private string Film2()
        {
            filminimetus = "Venom";
            return filminimetus;

        }
        private void St_btn_Click1(object sender, EventArgs e)
        {

            FormAgain uus_aken = new FormAgain(8, 5,filminimetus);
            

            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }
        private void St_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vabandage saalid ei töötovad ,saalite lahti alustamine on 20.05.2023");
        }
    }
}