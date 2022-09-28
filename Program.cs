using System;

namespace RockPaperScicors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scicors = "Scicors";
            Console.WriteLine("Choose [r]ock , [p]aper , [s]cicors" );

            string playerMove = Console.ReadLine ();
            //string computerMove = Console.ReadLine();


            if (playerMove == "Rock" || playerMove == "r")
            {
                playerMove = rock;
            }
            else if (playerMove == "Paper" || playerMove == "p")
            {
                playerMove = paper;
            }
            else if (playerMove == "Scicors" || playerMove == "s")
            {
                playerMove = scicors;

            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = string.Empty;
            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = "Rock";
                    computerMove = rock;
                    break;
                case 2:
                    computerMove = "Paper";
                    computerMove = paper;
                    break;
                case 3:
                    computerMove = "Scicors";
                    computerMove = scicors;
                    break;

                default:
                    Console.WriteLine("Invalid Input. Try Again...");
                    break;
                
            }
            Console.WriteLine($"the computer choose {computerMove} ");
            if (playerMove == rock && computerMove == scicors || playerMove == paper && computerMove == rock 
                || playerMove == scicors && computerMove == paper)
            {
                Console.WriteLine("You win!");
            }
            else if (playerMove == rock && computerMove == paper || playerMove == paper && computerMove == scicors 
                || playerMove == scicors && computerMove == rock )
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("The game is drow!");
            }
        }
    }
}
