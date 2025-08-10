using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    public class Product
    {
        //define product class with variables
        public int productId { get; set; }
        public int quantity { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public Product(int productId, int quantity, string name, double price)
        {
            this.productId = productId;
            this.quantity = quantity;
            this.name = name;
            this.price = price;
        }
    }
        //(Microsoft, 2025)
        //extension methods- always static
        public static class ExtensionsForProducts
        { 
            public static double TotalProducts(this List<Product> product)
            {
                if (product == null) return 0;
                return product.Sum(p => p.price * p.quantity); //return inventory value
            }

            //returns products with less than 5 items left
            public static IEnumerable<Product> LowStock(this List<Product> products)
            {
                if(products == null) return Enumerable.Empty<Product>(); //if nothing then it returns an empty product list
                return products.Where(p => p.quantity <= 5);
            }
        }
    }

/* References
 * 
 * Microsoft. 2025. Extension members (C# Programming Guide). [Version 8-SNAPSHOT] [Source Code]. Available at: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods [Accessed 10 August 2025]
 * Troelsen, A. and Japikse, P. 2022. Pro c# 10 with .NET 6 Foundational Principles and Practies in Programming. 11th ed. New York: Apress.
 */

