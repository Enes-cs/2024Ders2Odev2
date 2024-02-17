namespace Interfaces
{
    //inherit => Class'lar için
    //implement => Interface'ler için

    public class CustomerManager : IPersonManager
    {
        //Müşteri Ekleme Kodları
        public void Add()
        {
            Console.WriteLine("Burada Müşteri Ekleme kodları çalışır");
        }

        public void Update()
        {
            Console.WriteLine("Burada Müşteri Güncelleme kodları çalışır");
        }
    }
}
