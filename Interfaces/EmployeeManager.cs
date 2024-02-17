namespace Interfaces
{
    public class EmployeeManager : IPersonManager
    {
        //Personel Ekleme Kodları
        public void Add()
        {
            Console.WriteLine("Burada Personel Ekleme kodları çalışır");
        }

        public void Update()
        {
            Console.WriteLine("Burada Personel Güncelleme kodları çalışır");
        }
    }
}
