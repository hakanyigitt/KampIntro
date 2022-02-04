using System;

namespace ETicaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.name = "Iphone 11";
            product1.price = 11999.99;
            product1.point = 4.7;

            Product product2 = new Product();
            product2.Id = 2;
            product2.name = "Apple Watch SE";
            product2.price = 4499.99;
            product2.point = 4.5;

            Product product3 = new Product();
            product3.Id = 3;
            product3.name = "Apple Airpods";
            product3.price = 1500;
            product3.point = 4.0;

            Product product4 = new Product();
            product4.Id = 4;
            product4.name = "Macbook Pro i9";
            product4.price = 63750;
            product4.point = 4.4;

            Product product5 = new Product();
            product5.Id = 5;
            product5.name = "Iphone 12";
            product5.price = 14000;
            product5.point = 4.8;

            Product[] products = new Product[] { product1, product2, product3, product4, product5 };
            int i;
            for (i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id + " " + products[i].name + " " + products[i].price + " " + products[i].point);
            }

            Console.WriteLine();

            foreach (Product product in products)
            {
                Console.WriteLine(product.Id + " " + product.name + " " + product.price + " " + product.point);
            }

            Console.WriteLine();

            i = 0;
            while(i < 5){
                Console.WriteLine(products[i].Id + " " + products[i].name + " " + products[i].price + " " + products[i].point);
                i++;
            }
        }
    }
    class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public double point { get; set; }
    }
}
