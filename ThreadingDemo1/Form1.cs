namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //              single thread 
        //i�lemler tek bir thread ile s�raya konularak yap�l�r 

        //              Multi thread 
        //i�lemler ayn� anda yap�labilir �ekirdek say�s�na g�re proccess dolduktan sonra 
        // proccess ler s�raya konulur

        //              Asenkron thread
        //bir proccess devam ederken ba�ka bir proccess i�leme konulabiliyor
        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 1 �al��t�");

        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 2 �al��t�");
        }

    }
}
