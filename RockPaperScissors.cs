using System;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string scissors = "Scissors";
            const string paper = "Paper";            

            Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");

            string playerMove = Console.ReadLine();

            if(playerMove == "r" || playerMove == "rock")
            {
                playerMove = rock;
            }
            else if(playerMove == "s" || playerMove == "scissors")
            {
                playerMove = scissors;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = paper;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again");
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";
            switch(computerRandomNumber)
            {
                case 1:
                    computerMove = rock;
                    break;

                case 2:
                    computerMove = paper;
                    break;
                case 3:
                    computerMove = scissors;
                    break;
            }

            Console.WriteLine($"The computer chose: {computerMove}");

            if(playerMove == computerMove)
            {
                Console.WriteLine("Draw");
            }
            else if((playerMove == rock && computerMove == scissors) || 
                    (playerMove == paper && computerMove == rock) ||
                    (playerMove == scissors && computerMove == paper))
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("You lose");
            }
        }
    }
}
