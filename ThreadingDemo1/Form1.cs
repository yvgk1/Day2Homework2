namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //              single thread 
        //iþlemler tek bir thread ile sýraya konularak yapýlýr 

        //              Multi thread 
        //iþlemler ayný anda yapýlabilir çekirdek sayýsýna göre proccess dolduktan sonra 
        // proccess ler sýraya konulur

        //              Asenkron thread
        //bir proccess devam ederken baþka bir proccess iþleme konulabiliyor
        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 1 Çalýþtý");

        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 2 Çalýþtý");
        }

    }
}
