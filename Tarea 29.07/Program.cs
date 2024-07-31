namespace Productos
{
     class program
    {
        static void Main(String[] args)
        {
            try
            {
                int option;
                ShowMenu();
                Console.Write("Choose a option: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {

                        }
                        break;
                    case 2:
                        {

                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                    case 4:
                        {

                        }
                        break;
                    case 5:
                        { 
                            
                        }break;
                    case 6:
                        {
                            ExitProgram();
                        }
                        break;
                }
            }
            catch (FormatException MessageError)
            {

                Console.WriteLine("Error found: " + MessageError);
            }
            catch (OverflowException MessageError1)
            {
                Console.WriteLine("Error foudn: " + MessageError1);
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
            Console.WriteLine("4. Stock");
            Console.WriteLine("5. Show Resumé");
            Console.WriteLine("6. Exit");
        }
        static void ExitProgram()
        {
            Console.WriteLine("\nCiao User...");
            Console.WriteLine("ENTER TO EXIT");

        }
    } 
}