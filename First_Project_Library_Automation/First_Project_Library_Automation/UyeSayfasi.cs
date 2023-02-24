using First_Project_Library_Automation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Project_Library_Automation
{
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarım;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 loginsayfasi = new Form1();
            loginsayfasi.Show();
            this.Hide();

            MessageBox.Show("Çıkış Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView22.Rows.Add(kitap.getkitapid(), kitap.getkitapisim(), kitap.getkitapyazar(), kitap.getkitapdili(), kitap.getyayinevi(), kitap.gettur(), kitap.getadet(), kitap.getsayfasayisi(), kitap.getbasimyili());
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int kitapID = Convert.ToInt32(txt_kitap.Text);
            Kitap hedefKitap=null;

            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getkitapid() == kitapID)
                {
                    hedefKitap = kitap;
                }   
            }

            dataGridView22.Rows.Clear();
            dataGridView22.Rows.Add(hedefKitap.getkitapid(), hedefKitap.getkitapisim(), hedefKitap.getkitapyazar(), hedefKitap.getkitapdili(), hedefKitap.getyayinevi(), hedefKitap.gettur(), hedefKitap.getadet(), hedefKitap.getsayfasayisi(), hedefKitap.getbasimyili());
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            dataGridView22.Rows.Clear();
            foreach (Kitap hedefKitap in kitaplarim)
            {
                dataGridView22.Rows.Add(hedefKitap.getkitapid(), hedefKitap.getkitapisim(), hedefKitap.getkitapyazar(), hedefKitap.getkitapdili(), hedefKitap.getyayinevi(), hedefKitap.gettur(), hedefKitap.getadet(), hedefKitap.getsayfasayisi(), hedefKitap.getbasimyili());

            }
        }
    }
}
