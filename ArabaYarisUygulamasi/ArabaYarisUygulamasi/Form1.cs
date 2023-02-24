using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ArabaYarisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kazanilanpuan = 0;
        int yolhizi = 5;
        int arabahizi = 5; //benim arabamın hızı

        bool solyon = false;
        bool sagyon = false;

        int digerarabahizi = 5;  //diğer araba hızları

        Random rnd = new Random();


        public void oyunubaslat ()
        {
            btn_oyunubaslat.Enabled = false;
            carpma.Visible = false;

            lbl_yuksekskor.Text = Settings1.Default.yuksekskor.ToString();

            arabahizi = 5;
            digerarabahizi = 5;
            kazanilanpuan = 0;

            //arabaların koordinatı Kendi arabam
            bizimaraba.Left = 250;
            bizimaraba.Top = 350;

            //diğer arabaların başlangıçtaki koordinatları

            araba1.Left = 120;
            araba1.Top = 50;

            araba2.Left = 350;
            araba2.Top = 50;

            solyon = false;
            sagyon = false;

            carpma.Left = 255;
            carpma.Top = 344;

            timer1.Start();
            sesac();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunubaslat();
            sesac();
        }
        private void sesac()
        {
            SoundPlayer ses = new SoundPlayer();
            string sesyol = Application.StartupPath + "\\lostsky.wav";
            ses.SoundLocation = sesyol;
            ses.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kazanilanpuan++;
            lbl_puan.Text = kazanilanpuan.ToString();

            yol.Top = yol.Top + yolhizi;
            if (yol.Top>400)
            {
                yol.Top = -100;
            }

            if (solyon)
            {
                bizimaraba.Left = bizimaraba.Left - arabahizi;
            }
            if (sagyon)
            {
                bizimaraba.Left = bizimaraba.Left + arabahizi;
            }

            if (bizimaraba.Left<1)
            {
                solyon = false;
            }
            else if (bizimaraba.Left+bizimaraba.Width>510)
            {
                sagyon = false;
            }

            araba1.Top += arabahizi;
            araba2.Top+= arabahizi;

            if (araba1.Top>panel1.Height)
            {
                araba1degistir();
                araba1.Left = rnd.Next(90, 150);
                araba1.Top = rnd.Next(40, 150) * -1;
            }
            if (araba2.Top>panel1.Height)
            {
                araba2degistir();
                araba2.Left = rnd.Next(250, 450);
                araba2.Top = rnd.Next(40, 140) * -1;
            }

            if (bizimaraba.Bounds.IntersectsWith(araba1.Bounds) || bizimaraba.Bounds.IntersectsWith(araba2.Bounds)) 
            {
                oyunbitti();
            }
        }
        private void araba1degistir()
        {
            int sira = rnd.Next(1, 9);

            switch (sira)
            {
                case 1:araba1.Image = Properties.Resources.araba1; break;
                case 2: araba1.Image = Properties.Resources.araba2; break;
                case 3: araba1.Image = Properties.Resources.araba3; break;
                case 4: araba1.Image = Properties.Resources.araba4; break;
                case 5: araba1.Image = Properties.Resources.araba5; break;
                case 6: araba1.Image = Properties.Resources.araba6; break;
                case 7: araba1.Image = Properties.Resources.araba7; break;
                case 8: araba1.Image = Properties.Resources.araba8; break;
                case 9: araba1.Image = Properties.Resources.araba9; break;
            }
        }
        private void araba2degistir()
        {
            int sira = rnd.Next(1, 9);

            switch (sira)
            {
                case 1: araba2.Image = Properties.Resources.araba1; break;
                case 2: araba2.Image = Properties.Resources.araba2; break;
                case 3: araba2.Image = Properties.Resources.araba3; break;
                case 4: araba2.Image = Properties.Resources.araba4; break;
                case 5: araba2.Image = Properties.Resources.araba5; break;
                case 6: araba2.Image = Properties.Resources.araba6; break;
                case 7: araba2.Image = Properties.Resources.araba7; break;
                case 8: araba2.Image = Properties.Resources.araba8; break;
                case 9: araba2  .Image = Properties.Resources.araba9; break;
            }
        }

        private void oyunbitti()
        {
            timer1.Stop();

            if (Convert.ToInt32(lbl_puan.Text)>Convert.ToInt32(Settings1.Default.yuksekskor))
            {
                Settings1.Default.yuksekskor = lbl_puan.Text;
            }
            btn_oyunubaslat.Enabled = true;
            carpma.Visible = true;
            bizimaraba.Controls.Add(carpma);
            carpma.Location = new Point(7, -5);
            carpma.BringToFront();
            carpma.BackColor = Color.Transparent;
            MessageBox.Show("Tebrikler Kazandığınız Puan: " + lbl_puan.Text,"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information); 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left&&bizimaraba.Left>0)
            {
                solyon = true;
            }
            if (e.KeyCode==Keys.Right&&bizimaraba.Left+bizimaraba.Width<panel1.Width)
            {
                sagyon = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
            {
                solyon = false;
            }
            if (e.KeyCode==Keys.Right)
            {
                sagyon = false;
            }
        }

        private void btn_oyunubaslat_Click(object sender, EventArgs e)
        {
            oyunubaslat();
        }
    }
}
