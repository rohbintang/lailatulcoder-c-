using System.Runtime.InteropServices.Marshalling;

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
            int angka1, angka2, hasil;
            char karakter;
            //jangkauan nilai char adalah U +0000 sampai U +ffff

            float gaji;
            //jangkauan nilai float adalah -3.4 x 10 pangkat 38 sampai 3.4 x 10 pangkat 38

            double bunga;
            //jangkauan nilai double adalah 5.0 x 10 pangkat -324 sampai 1.7 x 10 pangkat 308

            string nama = "imam mahdi";


           int usia = 17;
            // jangkauan nilai int adalah -2.147.483.648 s/d 2.147.483.648

            angka1 = 10;
            angka2 = 5;

            hasil = (angka1 + angka2);

            MessageBox.Show("hasil dari penjumlahan " + angka1.ToString() + " dan " + angka2.ToString() + " adalah " + hasil.ToString());
        }
    }
}
