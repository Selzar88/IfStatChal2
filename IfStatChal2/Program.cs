using System;

namespace IfStatChal2
{
    internal class Program
    {

        static int highscore = 300;
        static string highscorePlayer = "Denis";

        static void Main(string[] args)
        {
            CheckHighscore(250, "Maria");
            CheckHighscore(315, "Michael");
            CheckHighscore(360, "Denis");

            Console.Read();
        }

        public static void CheckHighscore(int score , string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("it is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still "
                    + highscore + " and held by " + highscorePlayer);
            }
        }
    }
}
