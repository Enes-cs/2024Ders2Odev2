namespace BenimListem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Benim");
            list.Add("Listem");
            list.Add("Değil");
           

            Console.WriteLine("Elemean Sayısı: " + list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------");

            BenimListem<string> benimListem = new BenimListem<string>();
            benimListem.Add("İşte Bu");
            benimListem.Add("Benim Listem");
            benimListem.Listele();
            Console.WriteLine("Eleman Sayısı 'da " + benimListem.ElemanSayisi);




        }
    }

    public class BenimListem<T>
    {
        T[] _listem;
        T[] _geciciListem;

        public BenimListem()
        {
            _listem = new T[0];
        }

        public void Add(T item)
        {
            _geciciListem = _listem;
            _listem = new T[_listem.Length+1];

            for (int i = 0; i < _geciciListem.Length; i++)
            {
                _listem[i] = _geciciListem[i];
            }
            _listem[_listem.Length-1] = item;
        }


        public int ElemanSayisi
        {
            get { return _listem.Length; }

        }


        public void Listele()
        {
            foreach (var item in _listem)
            {
                Console.WriteLine(item);
            }
        }

        public void Temizle()
        {
            _listem = new T[0];
        }

      


    }
}
