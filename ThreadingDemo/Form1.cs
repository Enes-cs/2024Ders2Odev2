using System.Security.Cryptography.X509Certificates;

namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��lem 1 �al��t�");
        }
        //Thread bir boru gibidir her i�lem bir boru kullan�r bu i�lem i�lemci �ekirdekleri ile ilgilidir.
        //Oyun park�ndaki kayd�rak borular�n� d���nelim default'ta bir �ocuk ��kmadan di�eri kayd�ra�a giremez
        //multithread'de her �ocu�un kendi borusu olur
        //asenkron 'da iki �ocuk bir di�erini beklemeden ayn� anda kayd�ra�a bine bilir.
        //buradaki senkron zamand�r senkron programlama zaman s�ral�d�r. Asenkron zaman s�ralamas� olmadan yap�l�r.
        private void btnProcess2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show ("��lem 2 �al��t�") ;

        }
        
    }
}
