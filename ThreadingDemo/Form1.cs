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
            MessageBox.Show("Ýþlem 1 Çalýþtý");
        }
        //Thread bir boru gibidir her iþlem bir boru kullanýr bu iþlem iþlemci çekirdekleri ile ilgilidir.
        //Oyun parkýndaki kaydýrak borularýný düþünelim default'ta bir çocuk çýkmadan diðeri kaydýraða giremez
        //multithread'de her çocuðun kendi borusu olur
        //asenkron 'da iki çocuk bir diðerini beklemeden ayný anda kaydýraða bine bilir.
        //buradaki senkron zamandýr senkron programlama zaman sýralýdýr. Asenkron zaman sýralamasý olmadan yapýlýr.
        private void btnProcess2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show ("Ýþlem 2 Çalýþtý") ;

        }
        
    }
}
