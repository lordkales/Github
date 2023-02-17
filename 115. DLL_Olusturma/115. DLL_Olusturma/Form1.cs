namespace _115._DLL_Olusturma
{
    public partial class Form1 : Form
    {
        MatematikIslemleri matematikIslemleri = new MatematikIslemleri();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam=matematikIslemleri.topla(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            lbl_sonuc.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cikartma=matematikIslemleri.cýkartma(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            lbl_sonuc.Text = cikartma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int carpma = matematikIslemleri.carpma(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            lbl_sonuc.Text = carpma.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double bolme = matematikIslemleri.bolme(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            lbl_sonuc.Text = bolme.ToString();
        }
    }
}