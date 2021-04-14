using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        static string name = "Jesiel Palacios";

        // Entry Point Method
        static void Main(string[] args)
        {

            int age = 19;
            Console.WriteLine("Hello World!");
            Console.Write("Hello World!");
            Console.Write("Hello " + name + "!");
            Console.WriteLine();
            Console.WriteLine(name + " is " + age);
            Console.WriteLine("{0} is {1}", name,age);

            GetAppInfo(); // Run GetAppInfo function to get info.

            GreetUser(); // Ask for users name and greet.

            while(true) {

                // Set correct number.
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number.
                int correctNumber = random.Next(1, 10);

                // Init guess var.
                int guess = 0;

                // Ask for a number
                Console.WriteLine("Guess a number betwwen 1 and 10");

                // While guess is not correct
                while (guess != correctNumber) {
                    // Get users input
                    string input  = Console.ReadLine();

                    // Make sure its a number.
                    if (!int.TryParse(input, out guess)) {

                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number.");

                        //keep going
                        continue;
                    }

                    // Cast to int and put in guess.
                    guess = Int32.Parse(input);

                    // Match guess to correct number.
                    if (guess != correctNumber) {
                        // Change the color
                        //Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user is wrong number.
                        //Console.WriteLine("Wrong number, please try again.");

                        // Reset text color.
                        //Console.ResetColor();

                        // Set/Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }

                }

                // Change the color
                //Console.ForegroundColor = ConsoleColor.Yellow;

                // Tell user is right number.
                //Console.WriteLine("You are CORRECT!!!");

                // Reset text color.
                //Console.ResetColor();

                // Set/Print sucess message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guesssed it!");

                // Ask to play again
                Console.Write("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                } else if (answer == "N") {
                    return;
                } else {
                    return;
                }
            }

        }

        // Get and display app info
        static void GetAppInfo () {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = name;

            // Change text color
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.ForegroundColor = ConsoleColor.DarkCyan;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset the color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser () {
            // Ask users name
            Console.Write("What is your name?: ");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        //static void PrintColorMessage() {
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change the color
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = color;

            // Tell user its not a number.
            //Console.WriteLine("Please enter an actual number.");
            Console.WriteLine(message);

            // Reset text color.
            Console.ResetColor();
        }

    }
}
//Hecho con: https://www.youtube.com/watch?v=GcFJjpMFJvI