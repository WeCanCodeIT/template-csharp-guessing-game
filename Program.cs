using System;

namespace template_csharp_guessing_game
{
    class Program
    {
        public const string INSTRUCTIONS = "Please choose a number between 1 and 10";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the We Can Code It Guessing Game!");

            ZingBot bot = new ZingBot();

            bool showMenu = true;
            while(showMenu)
            {
                Console.WriteLine("Choose Which Program to Run");
                Console.WriteLine("1. Guessing Game");
                Console.WriteLine("2. Revenge of ZingBot");
                Console.WriteLine("3. Quit");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        // ADD STATIC METHOD GUESSING_GAME() HERE
                        break;
                    case 2:
                        bot.Start();
                        break;
                    case 3:
                        showMenu = false;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Thank you for using the We Can Code It Guessing Game application.");
            Console.WriteLine("Press any key to close this console window.");
            Console.ReadKey();
        }
    }
}
