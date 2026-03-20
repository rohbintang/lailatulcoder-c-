namespace uji_coba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angka1;
            int angka2;
            int hasil;

            angka1 = 10;
            angka2 = 5;

            hasil = (angka1 + angka2);

            MessageBox.Show("hasil dari penjumlahan " + angka1.ToString() + " dan " + angka2.ToString() + " adalah " + hasil.ToString());
        }
    }
}
