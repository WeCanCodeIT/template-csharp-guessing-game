using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_guessing_game
{
    public class ZingBot
    {
        // Modify these values to control range and guess amount
        private const int START_RANGE = 0;
        private const int END_RANGE = 1000000;
        private const int GUESSES = 20;

        // The number picked by the user
        private int Picked = 0;

        // The current range
        private int Min = START_RANGE;
        private int Max = END_RANGE;

        // The winning flag
        private bool Won = false;

        // The name of the program
        public string Name { get; set; } = "Zing Bot 3000";

        // Simple Greeting method
        public void Greeting()
        {
            Console.WriteLine("Hello, my name is {0}\n", this.Name );
        }

        public void Start()
        {
            Console.Clear();
            
            this.Greeting();

            Console.WriteLine("I bet if you picked a number between {0} and {1} I could guess what number you picked within {2} guesses. If I'm right, you have to admit you were defeated by a basic AI. In the unlikely case I can't guess it, I guess I'll have to admit I'm a limited AI.\n", START_RANGE, END_RANGE, GUESSES);
            Console.WriteLine("Pick a number between {0} - {1}", START_RANGE, END_RANGE);

            // Allow the user to pick a number
            Picked = Convert.ToInt32(Console.ReadLine());

            // Simple check to ensure picked number is within starting and ending range
            while(Picked > END_RANGE || Picked < START_RANGE)
            {
                Console.WriteLine("\nNo fair, you're picking outside of the designated range. Pick again!");
                Picked = Convert.ToInt32(Console.ReadLine());
            }

            // For as many guess are allowed
            for(int i = 0; i < GUESSES; i++)
            {
                int attempt = (i + 1);

                // Method that compares guess and determines if the value is higher or lower
                this.Guess(attempt);                

                // If the guess was successful max out attempts
                if (Won)
                {
                    i = GUESSES;
                    this.ZingBotWins();
                }
            }

            if (!Won) { this.ZingBotLoses(); }

            this.Reset();

            Console.WriteLine("Thank you for playing. Until next time... Bye!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        // Divide and Conquer method for searching for value
        public void Guess(int attempt)
        {
            int guess = (Max + Min)/2;

            Console.WriteLine("Guess #" + attempt + ": " + guess);

            if(guess < Picked)
            {
                Min = guess + 1;
            }
            else if(guess > Picked)
            {
                Max = guess - 1;
            }
            else if(guess == Picked)
            {
                Won = true;
            }
        }

        public void ZingBotWins()
        {
            Console.WriteLine("\nYou picked {0}! Simple human.\n", Picked);

            Console.WriteLine("Hahahaha! You lost to a BASIC AI like myself... wait why does that seem like a burn on me?\n");
        }

        public void ZingBotLoses()
        {
            Console.WriteLine("OK, OK, so you outsmarted a limited AI, I hope you're happy with youself.\n");
        }

        public void Reset()
        {
            Min = START_RANGE;
            Max = END_RANGE;
            Won = false;
        }
    }
}
