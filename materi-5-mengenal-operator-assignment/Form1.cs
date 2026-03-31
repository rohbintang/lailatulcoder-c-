namespace t
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //penjumlahan
            int a = 10;
            int b = 20;
            int hasil = a + b;

            Console.WriteLine(hasil);

            //pengurangan

              hasil = b - a;
            Console.WriteLine(hasil);

            //perkalian

              hasil = a * b;
            Console.WriteLine(hasil);

            //pembagian
              hasil = b / a;
            Console.WriteLine(hasil);

            //modulus
             hasil = b % a;
            Console.WriteLine(hasil);

            //peningkatan (penambahan +1)
              hasil = b++;
            Console.WriteLine(hasil);

            //penurunan (penurunan -1)
              hasil = b--;
            Console.WriteLine(hasil);


            //operator assignment += . C += A --> C = C + A
            //operator assignment -= . C -= A --> C = C - A
            //operator assignment *= . C *= A --> C = C * A
            //operator assignment /= . C /= A --> C = C / A
            //operator assignment %= . C %= A --> C = C % A




        }
    }
}
