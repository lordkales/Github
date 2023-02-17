namespace _114__Combobox_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cumartesi");
            comboBox1.Items.Add("Pazar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seciligun = comboBox1.SelectedItem.ToString();
            string secilindex = comboBox1.SelectedIndex.ToString();
            MessageBox.Show("Seçili Gün: "+seciligun+" Seçili Ýndex: "+secilindex);

        }
    }
}