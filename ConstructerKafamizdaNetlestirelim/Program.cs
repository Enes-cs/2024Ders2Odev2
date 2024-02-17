namespace ConstructerKafamizdaNetlestirelim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Enes", LastName = "Özbay", City = "Ankara" }; 
            //Scope içi kullanımı,Aşağıdaki kullanıma Eşittir. 
            customer.Id = 1;
            customer.FirstName = "Enes";
            customer.LastName = "Özbay";
            customer.City = "Angara";


            Customer customer1 = new Customer(2, "Enes2", "Ozbay", "Kutahya");//Parametrik Kullanım

            Console.WriteLine(customer1.FirstName);
        }
    }

    class Customer
    {
        public Customer(int id, string firstName, string lastName, string city)
        {

            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("Ben Constructer Scope'u içindeki" +
                " Console.WriteLine Çalıştım Bak");
            
        }
        public Customer()
        {
            
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
