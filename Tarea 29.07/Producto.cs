using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;

namespace Tarea_29._07
{
    public class TProducto
    {
        public int[] Id { get; set; }
        public string[] Name { get; set; }
        public double[] Price { get; set; }
        public string[] Description { get; set; }
        public int Stock { get; set; }

        public TProducto(int[] id, string[] name, double[] price, string[] description, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Stock = stock;
        }

        public int NewProduct()
        {
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       ADD NEW PRODUCT");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");

            Console.Write("Write Product name: ");
            Name[Stock] = Console.ReadLine();

            Console.Write("Write ID Product: ");
            Id[Stock] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write the price: ");
            Price[Stock] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Write a description: ");
            Description[Stock] = Console.ReadLine();

            Console.Write("Write amount of product: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            return ++Stock;
        }

        public void ConsultProduct()
        {
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       CONSULT PRODUCT");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");

            Console.Write("Introduce ID product: ");
            int ProductConsultId = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Stock; i++)
            {
                if (Id[i] == ProductConsultId)
                {
                    Console.WriteLine($"ID: {Id[i]}");
                    Console.WriteLine($"Product Name: {Name[i]}");
                    Console.WriteLine($"Price: {Price[i]}");
                    Console.WriteLine($"Description: {Description[i]}");
                    return;
                }
            }

            Console.WriteLine("ID NO FOUND");
        }

        public double Sale()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("          SALE");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");

            Console.Write("Introduce ID product: ");
            int ProductConsultId = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Stock; i++)
            {
                if (Id[i] == ProductConsultId)
                {
                    Console.Write("Introduce the amount of products: ");
                    int amountForSale = Convert.ToInt32(Console.ReadLine());

                    if (amountForSale > Stock)
                    {
                        Console.WriteLine("Not enough stock.");
                        return 0;
                    }

                    double saleAmount = amountForSale * Price[i];
                    Console.WriteLine($"The total is: {saleAmount}");
                    Stock -= amountForSale;
                    return saleAmount;
                }
            }

            Console.WriteLine("ID NO FOUND");
            return 0;
        }

        public void ShowResume()
        {
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("          RESUMÉ");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");

            for (int i = 0; i < Stock; i++)
            {
                Console.WriteLine($"ID: {Id[i]}, Name: {Name[i]}, Price: {Price[i]}, Description: {Description[i]}, Stock: {Stock}");
            }
        }

        public int NewStock()
        {
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("          NEW STOCK");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");

            Console.Write("Introduce ID product: ");
            int ProductConsultId = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Stock; i++)
            {
                if (Id[i] == ProductConsultId)
                {
                    Console.Write("Introduce the new stock amount: ");
                    int newStockAmount = Convert.ToInt32(Console.ReadLine());

                    Stock += newStockAmount;
                    Console.WriteLine($"The new stock is: {Stock}");
                    return Stock;
                }
            }

            Console.WriteLine("ID NO FOUND");
            return Stock;
        }

        public double NewPrice()
        {
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("          NEW PRICE");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");

            Console.Write("Introduce ID product: ");
            int ProductConsultId = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Stock; i++)
            {
                if (Id[i] == ProductConsultId)
                {
                    Console.Write("Introduce the new price: ");
                    double newPrice = Convert.ToDouble(Console.ReadLine());

                    Price[i] = newPrice;
                    Console.WriteLine($"The new price is: {newPrice}");
                    return newPrice;
                }
            }

            Console.WriteLine("ID NO FOUND");
            return 0;
        }
    }
}
