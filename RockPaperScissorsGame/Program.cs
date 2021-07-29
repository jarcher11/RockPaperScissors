using System;
using System.IO;

namespace RockPaperScissorsGame
{
    class MainClass
    {
        static void Main(string[] args)
        {


            string inputPlayer = null, inputCPU;
            int randomInt;
            bool validEntry = false;
            string rock = "Rock";
            string paper = "Paper";
            string scissors = "Scissors";
            bool playAgain = true;
            while (playAgain)
            {
                int scorePlayer = 0;
                int drawTimes = 0;
                int scoreCPU = 0;
                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    validEntry = false;
                    while (!validEntry)
                    {
                        Console.WriteLine($"Pick between {rock}, {paper}, and {scissors}: "); 
                        inputPlayer = Console.ReadLine();
                        validEntry = RequireValidEntry();
                    }
                  
                    inputPlayer = inputPlayer?.ToUpper();
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);
                    switch (randomInt)
                    {
                        case 1:
                            Console.WriteLine($"Computer chose {rock}");
                            if (inputPlayer == rock.ToUpper())
                            {
                                Console.WriteLine("DRAW!\n\n");
                                drawTimes++;
                            }
                            else if (inputPlayer == paper.ToUpper())
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == scissors.ToUpper())
                            {
                                Console.WriteLine("CPU WINS!/n / n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            Console.WriteLine($"Computer chose {paper}");
                            if (inputPlayer == paper.ToUpper())
                            {
                                Console.WriteLine("DRAW!\n\n");
                                drawTimes++;
                            }
                            else if (inputPlayer == rock.ToUpper())
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == scissors.ToUpper())
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == scissors.ToUpper())
                            {
                                Console.WriteLine("DRAW!\n\n");
                                drawTimes++;
                            }
                            else if (inputPlayer == rock.ToUpper())
                            {
                                Console.WriteLine("PLAYER WINS!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == paper.ToUpper())
                            {
                                Console.WriteLine("CPU WINS!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            using (StreamWriter sw = new StreamWriter("Logs.txt"))
                            {
                                sw.WriteLine("Something went wrong in the switch statement.");
                            }
                            break;
                    }
                    Console.WriteLine("\n\nSCORES:\tPlayer:\t{0}\tCPU:\t{1}\tDraws:\t{2}", scorePlayer, scoreCPU,
                        drawTimes);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player Won!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU Won!");
                }
                Console.WriteLine("Do you want to play again?(y/n)");
                string playersChoice = Console.ReadLine();
                if (playersChoice == "y")
                {
                    Console.Clear();
                }
                else if (playersChoice == "n")
                {
                    playAgain = false;
                }
                
            }
            bool RequireValidEntry()
            {
                if (inputPlayer?.ToUpper() == paper.ToUpper() || inputPlayer?.ToUpper() == scissors.ToUpper() ||
                    inputPlayer?.ToUpper() == rock.ToUpper())
                {
                    return true;
                }
                Console.WriteLine("Please enter a valid option of either Rock, Paper, Or Scissors.");
                using (StreamWriter sw = new StreamWriter("Logs.txt"))
                {
                    sw.WriteLine("User entered invalid entry");
                }
                return false;
            }


        }
    }
}

/*using System.Diagnostics;

//...
void StopwatchUsingMethod()
{
    //A: Setup and stuff you don't want timed
    var timer = new Stopwatch();
    timer.Start();

    //B: Run stuff you want timed
    timer.Stop();

    TimeSpan timeTaken = timer.Elapsed;
    string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
}*/
