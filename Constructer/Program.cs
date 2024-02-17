namespace Constructer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Ornek(); new Ornek(); new Ornek(); new Ornek();

            Console.ReadLine();


        }
    }

    class Ornek
    {
        #region Constructer
        //Constructer metod public olmalıdır.
        //Constructer metodun geri dönüş değeri olmaz.
        //Constructer metodun ismi sınıf ismi ile aynı olmak zorundadır.
        public int x { get; set; }
        public Ornek()
        {
            Console.WriteLine("Nesne Oluşturuldu.");
        }

        //public Ornek(int a)
        //{
            
        //}
        #endregion

        #region Static Constructer
        //Normal constructerdan da önce çalışan metoddur.
        //İlgili sınıftan yapılan nesne taleplerinden ilkinde tetiklenir, sonrakilerde tetiklenmez.

        static Ornek()
        {
            Console.WriteLine("Normal Constructer'dan önce çalıştı");
        }


        #endregion
    }
}
