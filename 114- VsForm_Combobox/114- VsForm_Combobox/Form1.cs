namespace _114__VsForm_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Perþembe");
            comboBox2.Items.Add("Cuma");
            comboBox2.Items.Add("Cumartesi");
            comboBox2.Items.Add("Pazar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.Text);
        }
    }
}