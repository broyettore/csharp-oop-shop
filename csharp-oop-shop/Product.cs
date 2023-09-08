using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {
        // ATTRIBUTES
        public int Code { get; } // Read only
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int VAT { get; private set; } = 22; // VAT fixed at 22%


        // BASIC CONSTRUCT
        public Product(string name, string description, int price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;

            // random code generated
            this.Code = GenerateRand();
        }


        // METHOD TO GET PRICE + VAT
        public int GetPriceWithVat()
        {
            int ResultVat = (this.Price * this.VAT) / 100;
            return this.Price + ResultVat;
        }


        // METHOD TO GET CODE + NAME
        public string GetCodeName()
        {
            return this.Code + "-" + this.Name;
        }


        // METHOD TO GENERATE A RANDOM NUM, RANGE 1 - 200
        public int GenerateRand()
        {
            int min = 1;
            int max = 100;
            Random rand = new Random();
            int randNum = rand.Next(min, max);
            return randNum;
        }
        
    }
}


//VAT = (BASE PRICE * VAT) / 100
