using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, double> totalPrice = new Dictionary<string, double>();
            Dictionary<string, int> totalQuantity = new Dictionary<string, int>();
            string command = Console.ReadLine();
            
            while (command != "buy")
            {
                string[] input = command
                    .Split();

                string product = input[0];

                if (totalPrice.ContainsKey(product))
                {
                    double price = double.Parse(input[1]);
                    int quantity = int.Parse(input[2]);

                    totalPrice[product] = (totalQuantity[product] += quantity )* price;

                }
                else
                {
                    
                    double price = double.Parse(input[1]);
                    int quantity = int.Parse(input[2]);
                    totalQuantity[product] = quantity;
                    double allPrice = quantity * price;
                    totalPrice[product] = allPrice;



                }


                command = Console.ReadLine();
            }
           
                foreach (var p in totalPrice)
                {
                    Console.WriteLine($"{p.Key} -> {p.Value:f2}");
                }
           

        }

        }
}