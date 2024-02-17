namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Referans Tipleri Anlamak
            ////int, decimal, float, boolean, value types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine(sayi1);

            //Ref(ref sayi1);

            //Console.WriteLine(sayi1);

            //void Ref(ref int sref)
            //{
            //    sref = sayi2;
            //}

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] {10,20, 30 };

            //foreach (int i in sayilar1)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (int i in sayilar2)
            //{
            //    Console.WriteLine(i);
            //}

            //sayilar1 = sayilar2;
            //sayilar2[0] = sayi1;

            //foreach (int i in sayilar1)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (int i in sayilar2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Enes";

            person2 = person1;

            person2.FirstName = "İbrahim";
            Console.WriteLine(person1.FirstName);

            string adi = new string("enes");

            Console.WriteLine(adi);
            Customer customer = new Customer();
            customer.FirstName = "Delibaş";
            customer.CreditCardNumber = 546542154564;

            Employee employee = new Employee();
            employee.FirstName = "İbram";

            Person _person3 =customer;
            Console.WriteLine(((Customer)_person3).CreditCardNumber); //Boxing

            Person person3=(Person)_person3; //UnBoxing

            _person3.FirstName = "Özbay";
            Console.WriteLine( customer.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(person1);
            personManager.Add(employee);


        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public long CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName + " Eklendi");
        }
    }

}
