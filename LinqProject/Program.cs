namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar" },
                new Category { CategoryId = 2, CategoryName = "Telefon" }
            };

            List<Product> products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Excalibur",QuantityPerUnit=5,UnitPrice=25000},
                new Product{CategoryId=1,ProductId=2,ProductName="MSI",QuantityPerUnit=4,UnitPrice=50000},
                new Product{CategoryId=1,ProductId=3,ProductName="Monster",QuantityPerUnit=2,UnitPrice=30000},
                new Product{CategoryId=2,ProductId=4,ProductName="iPhone",QuantityPerUnit=7,UnitPrice=90000},
                new Product{CategoryId=2,ProductId=5,ProductName="Samsung",QuantityPerUnit=6,UnitPrice=75000},
                new Product{CategoryId=2,ProductId=6,ProductName="Huawei",QuantityPerUnit=10,UnitPrice=40000},
            };

            Console.WriteLine("Algoritmik --------------------------------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 30000&&product.QuantityPerUnit>4 && product.CategoryId==2)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("LINQ --------------------------------------------");

            var result = products.Where(products => products.UnitPrice > 30000 && products.QuantityPerUnit>4 && products.CategoryId==2);
            
            foreach (var product in result) { Console.WriteLine(product.ProductName); }

            GetProducts(products);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> pFiltered = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 30000 && product.QuantityPerUnit > 4 && product.CategoryId == 2)
                {
                    pFiltered.Add(product);
                }
            }
            return pFiltered;
        }

        static List<Product> GetProductsLINQ(List<Product> products)
        {
            return products.Where(products => products.UnitPrice > 30000 && products.QuantityPerUnit > 4 && products.CategoryId == 2).ToList();
        
        }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStoc { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
