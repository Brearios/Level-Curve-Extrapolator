using System;

namespace LevelCurveExtrapolator
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Level Curve Extrapolator!");
            Console.WriteLine("Use this to choose a \"curve\" for a given stat up to a chosen level, and it will give you each level's values (up to 9.2~ quintillion.)");

            Console.WriteLine("To begin, enter the value of your stat at level 1.");
            double levelOneStat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How much higher should this be at level 10? Enter 1.5x, 2x, 2.5x, 5x, 10x or 20x.");
            string levelTenRatio = Console.ReadLine();

            int levelUpLevel = 2; // Starting value for the loops

            Console.WriteLine("How many levels do you need data for?");
            int loopCount = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Here are your values based on a rate that increases " + levelTenRatio + "at level 10, going to level " + loopCount);
            // This is unneeded because levelUpLevel is set to two. int loopCount = loopCount -=;

            Console.WriteLine("Level 1: " + levelOneStat);

            // Math will be done with doubles, but presented as integers - rounded down. Nothing is lost, but points aren't granted early.

            if (levelTenRatio == "1.5x")
            {
                double levelUpMultiplier = 1.0461;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel <= loopCount)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (long)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "2x")
            {
                double levelUpMultiplier = 1.0805;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel <= loopCount)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (long)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "2.5x")
            {
                double levelUpMultiplier = 1.1072;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel <= loopCount)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (long)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "5x")
            {
                double levelUpMultiplier = 1.1959;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel <= loopCount)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (long)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "10x")
            {
                double levelUpMultiplier = 1.2916;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel <= loopCount)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (long)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "20x")
            {
                double levelUpMultiplier = 1.395;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel <= loopCount)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (long)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else
            {
                Console.WriteLine("The value entered does not match the choices availabe.");
            }
            Console.WriteLine("Press enter when ready to exit");
            Console.ReadLine();

        }
        
    }
}
