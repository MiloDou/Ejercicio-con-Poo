using System;
using Tarea_29._07;

namespace Productos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ids = new int[10];
            string[] names = new string[10];
            double[] prices = new double[10];
            string[] descriptions = new string[10];
            int stock = 0;
            int amount = 0;

            TProducto producto = new TProducto(ids, names, prices, descriptions, stock);

            while (true)
            {
                try
                {
                    Console.Clear();
                    ShowMenu();
                    Console.Write("Choose an option: ");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            stock = producto.NewProduct();
                            break;

                        case 2:
                            producto.ConsultProduct();
                            break;

                        case 3:
                            producto.Sale();
                            break;

                        case 4:
                            stock = producto.NewStock();
                            break;

                        case 5:
                            producto.NewPrice();
                            break;

                        case 6:
                            producto.ShowResume();
                            break;

                        case 7:
                            ExitProgram();
                            return;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error found: " + ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Error found: " + ex.Message);
                }

                Console.ReadKey();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("       PRINCIPAL MENU");
            Console.ResetColor();
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Consult product");
            Console.WriteLine("3. Sale");
            Console.WriteLine("4. Update stock");
            Console.WriteLine("5. New price");
            Console.WriteLine("6. Show résumé");
            Console.WriteLine("7. Exit");
        }

        static void ExitProgram()
        {
            Console.WriteLine("\nCiao User...");
            Console.WriteLine("ENTER TO EXIT");
            Console.ReadKey();
        }
    }
}
