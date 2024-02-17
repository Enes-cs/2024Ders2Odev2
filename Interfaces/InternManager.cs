namespace Interfaces
{
    public class InternManager : ProjectManager, IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("InternManager Ekleme Kodları Çalıştı");
        }

        public void Update()
        {
            Console.WriteLine("InternManager Güncelleme Kodları Çalıştı");
        }
    }
}
