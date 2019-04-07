using System;
//name space//
namespace numberGesser
{
    //main class//
    class Program
    {
        //entry point for the app
        static void Main(string[] args)
        {
            // set app vers
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sam Arbid";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();

            // ask user name
            Console.WriteLine("What is your name?");
            // get answer
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game ! ;) ", inputName);

            // init correct number
            // int correctnumber = 7;
            while (true)
            {


                // creat new random object 
                Random random = new Random();

                int correctnumber = random.Next(1, 10);

                // init guess var
                int guess = 0;
                // ask user for number 
                Console.WriteLine("Gess a number between 1 and 10");
                while (guess != correctnumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    // make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //change text color
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("it's not a number , try agin !");
                        //reset text color
                        Console.ResetColor();
                        // keep going
                        continue;
                    }

                    // cast to int and put it in guess
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctnumber)
                    {
                        //change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Worng Number my Freind, try agin !");
                        //reset text color
                        Console.ResetColor();
                    }

                }
                //output success message
                //change text color
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Great ! you found it !");
                //reset text color
                Console.ResetColor();

                //ask to play again
                Console.WriteLine("playe agin?[Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else

                {
                    return;

                }
            }
        }




        
    } 
}

