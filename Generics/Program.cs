namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ağrı");
            sehirler.Add("Erzurum");
            sehirler.Add("Van");
            sehirler.Add("Iğdır");
            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Eskişehir");
            sehirler2.Add("Kütahya");
            sehirler2.Add("Antalya");
            sehirler2.GetList();
            Console.WriteLine(sehirler2.Count);
        }
    }

    public class MyList<T> //Generic class
    {
        T[] _array; //T Türünde bir dizi tanımladık adı _array
        T[] _tempArray; //T Türünde eski datalarımızı tutacak bir geçici array tanımladık
        public MyList() //Constructer ile MyList Her Güncellendiğinde il çalışacak bloğu açtık
        {
            _array = new T[0]; //Her newlemede diziyi 0 elemanlı hale getiriyoruz.
        }

       
        public void Add(T item) //Eleman eklemek için bir ekleme methodu yazdık ve parametre olarak T Türünde bir veri istedik.
        {
            _tempArray= _array; //_array'in referans adresini _TempArray'e verdik sonra _array'e aşağıda yeni bir adres atadık.
            //Böylelikle _tempArray eski dataları tutmuş oldu biz aşağıda yeni adres tutsak da eski adresi kaybetmemiş olduk.
            _array = new T[_array.Length+1]; //Add methodu çalıştığında arrayin alanı 1 artsın dedik.
            
            //Ancak üstteki kod eski dataların kaybedilmesi ile sonuçlanır. çünkü bellekte yeni alan açar ve artık
            //Bu array eski diziden 1 fazla alana sahip yeni bir bellek adresini tutar.
            //Şimdi bu eski dataları geri yerine getirecek kod yazmamız gerek.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];                
            }

            _array[_tempArray.Length] = item;

            
            

        }

        public int Count //Eleman sayısını öğrenmek için buraya bir prop açtık Count bir property'dir List'in count'ı gibi
        {
            get { return _array.Length; } //Sadece okunabilir olarak _array'in eleman sayısını söylemesini istedik
        }

        public void GetList()
        {
            foreach (T item in _array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
