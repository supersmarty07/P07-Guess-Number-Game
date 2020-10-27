using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            appInfo();
            greetUser();
            

            while (true) {
                //Set correct Number
                //int correctNumber = 7;

                //create a random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10.");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //Get User input
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Wrong Number. Please enter real number.");
                    }

                    //cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match Guess to correct Number
                    if (guess != correctNumber)
                    {
                        //Change text colour
                        Console.ForegroundColor = ConsoleColor.Red;

                        //write out app info
                        Console.WriteLine("Wrong Number. Please try again.");

                        //Reset text colour
                        Console.ResetColor();

                    }
                }

                //Change text colour
                Console.ForegroundColor = ConsoleColor.Yellow;

                //Tell user its right number
                Console.WriteLine("Your guess is correct.");

                //Reset Colour
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Would you like to play again ? (Y/N)");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }






            }
        }
            static void appInfo() {
            String appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sachet Thapa";

             //Change text colour
            Console.ForegroundColor = ConsoleColor.Green;
            
            //write out app info
            Console.WriteLine("{0} : Version {1} by {2}",appName, appVersion, appAuthor);

            //Reset text colour
            Console.ResetColor();
            }

        static void greetUser()
        {
            //Ask Users name
            Console.WriteLine("What is your name? ");

            //Get User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game.....", inputName);
        }
    }
}
