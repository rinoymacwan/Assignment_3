using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> Inventory = new List<Product>
            {
            new Product("lettuce", 10.5, 50, "Leafy green"),
            new Product("cabbage", 20, 100, "Cruciferous"),
            new Product("pumpkin", 30 , 30, "Marrow"),
            new Product("cauliflower", 10 , 25, "Cruciferous"),
            new Product("zucchini", 20.5 , 50, "Marrow"),
            new Product("yam", 30 , 50, "Root"),
            new Product("spinach", 10 , 100, "Leafy green"),
            new Product("broccoli", 20.2 , 75, "Cruciferous"),
            new Product("garlic", 30 , 20, "Leafy green"),
            new Product("silverbeet", 10 , 50, "Marrow")
            };

            //1
            var total = Inventory.Select(p => p.Quantity).ToList();
            Console.WriteLine(total.Sum());

            //2
            Inventory.Add(new Product("Potato", 10, 50, "Root"));
            var prodwithquantity = Inventory.Select(p => new { p.Name, p.Quantity });
            Console.WriteLine(String.Join(",",prodwithquantity.ToList()));

            //3
            var leafyGreen = Inventory.Where(p => p.Type.Contains("Leafy green")).Select(p => p.Name);
            Console.WriteLine(String.Join(",",leafyGreen.ToList()));

            //4
            Console.WriteLine("***Garlic sold out!***");
            var rem = Inventory.SingleOrDefault(p => p.Name=="Garlic");
            Inventory.Remove(rem);
            Inventory.ForEach(Console.WriteLine);

            //5
            Console.WriteLine("***Cabbage Added***");
            var cab = Inventory.Where(p => p.Name == "cabbage").ToList()[0].Quantity+=50;
            Inventory.ForEach(Console.WriteLine);

            //6
            var let = Inventory.Where(p => p.Name.Contains("lettuce")).Select(p => p.Price).ToList()[0];
            var zuc = Inventory.Where(p => p.Name.Contains("zucchini")).Select(p => p.Price).ToList()[0];
            var bro = Inventory.Where(p => p.Name.Contains("broccoli")).Select(p => p.Price).ToList()[0];

            Console.WriteLine("Total for 1 kg of lettuce, 2 kgs of zucchini and 1 kg of broccoli is Rs. "+(let+(zuc*2)+bro));
            Console.ReadKey();
        }
    }
}
