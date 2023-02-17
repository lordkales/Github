namespace _113._Not_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buton_hesapla_Click(object sender, EventArgs e)
        {
            int not1, not2, ortalama;
            not1 = Convert.ToInt32(textbox_not1.Text);
            not2 = Convert.ToInt32(textbox_not2.Text);

            ortalama = ((not1 + not2) / 2);
            lbl_ortalamasonuc.Text = ortalama.ToString();
        }
    }
}