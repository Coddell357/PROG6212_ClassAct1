namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //products stored in list form
            var products = new List<Product>
            {
                new Product(1, 10, "Broom", 70.00),
                new Product(2, 15, "Perfume", 100.00),
                new Product(3, 3, "Sweets", 10.00),
                new Product(4, 100, "Scoops", 30.00),
                new Product(5, 5, "Screws", 10.00)
            };

            //declaring and calling methods to display values
            var lowStock = products.LowStock();
            double total = products.TotalProducts();

            Console.WriteLine("Total inventory: R" +  total);
            
            //display the products >= 5 
            Console.WriteLine("\nLow stock products less than or equal to 5: ");
            foreach (var p in lowStock) //foreach loop runs through the products in lowstock list
            {
                Console.WriteLine($"{p.name} : {p.quantity}");
            }

            //(GeeksforGeeks, 2019)
            //creating anonymous object that selects names and prices from product list using LINQ
            var anony_item = from p in products
                             select new {p.name, p.price};

            Console.WriteLine("\nProduct names and prices: ");
            
            //loop to display the products according to anonymous object conditions
            foreach (var p in anony_item)
            {
                Console.WriteLine($"Name: {p.name}, Price: R{p.price}");
            }
        }
    }
}

/* References
 * 
 * GeeksforGeeks. 2019. What is anonymous types in c#. [Version 8-SNAPSHOT] [Source Code]. Available at: https://www.geeksforgeeks.org/c-sharp/c-sharp-anonymous-types/ [Accessed 8 August 2025]
 * Troelsen, A. and Japikse, P. 2022. Pro c# 10 with .NET 6 Foundational Principles and Practies in Programming. 11th ed. New York: Apress.
 */

//Create custom types
//write extension methods
//use anonymous types
//understand pointer types
