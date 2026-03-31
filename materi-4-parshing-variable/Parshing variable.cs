namespace Parshing_variable
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama;
            decimal usia;
            string tinggi;
            int total_tinggi;

            nama = textBox1.Text;
            usia = numericUpDown1.Value;
            tinggi = textBox2.Text;
            total_tinggi = int.Parse(tinggi) + 5;

            MessageBox.Show("Halo " + nama + " usia kamu " + usia + " tinggi kamu " + total_tinggi);

        }
    }
}
