using System.Globalization;
using System.Text;

namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UTF8 reading in console
            Console.OutputEncoding = Encoding.UTF8;

            // function to add left padding to a number to reach 8 total digits
            string AddPadToNum(int number)
            {
                string padNum = number.ToString().PadLeft(8, '0');

                if (padNum.Length > 8)
                {
                    padNum = padNum.Substring(0, 8);
                }

                return padNum;
            }

            // Products
            Product product1 = new("RT-BassX", "Sony Wireless Headphones", 80);
            Product product2 = new("SmartWatch", "Apple Smartwatch", 213);
            Product product3 = new("MousePad", "RGB Light Mousepad", 24);
            Product product4 = new("MacBook Air", "Apple Laptop with good specs", 1200);
            Product product5 = new("RTX-4070", "Graphic Card for gamers", 2200);


            // Products Array
            Product[] productList = { product1, product2, product3, product4, product5 };

            for (int i = 0; i < productList.Length; i++)
            {
                string paddedProductCode = AddPadToNum(productList[i].Code);

                Console.WriteLine("*Product Info *");
                Console.WriteLine($"Product code: {paddedProductCode}");
                Console.WriteLine($"Product codename: {productList[i].GetCodeName()}");
                Console.WriteLine($"Product info: {productList[i].Description}");
                Console.WriteLine($"Product base price: {productList[i].Price}€");
                Console.WriteLine($"Product price + vat: {productList[i].GetPriceWithVat()}€");
                Console.WriteLine($"Product Vat applied: {productList[i].VAT}%");
                Console.WriteLine();
            }


        }
    }
}