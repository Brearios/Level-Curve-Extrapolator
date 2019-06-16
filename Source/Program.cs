using System;

namespace LevelPaceMultiplicator
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Level Pace Multiplicator!");
            Console.WriteLine("Use this to choose a \"pace\" for a given stat while leveling, and it will give you values for your stat up to level 100.");

            Console.WriteLine("To begin, enter the value of your stat at level 1.");
            double levelOneStat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Now how much higher should this be at level 10? Enter 1.5x, 2x, 2.5x, 5x, 10x or 20x.");
            string levelTenRatio = Console.ReadLine();
            int levelUpLevel = 2;

            Console.WriteLine("Level 1: " + levelOneStat);

            // Math will be done with doubles, but presented as integers - rounded down. Nothing is lost, but points aren't granted early.

            if (levelTenRatio == "1.5x")
            {
                double levelUpMultiplier = 1.0461;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel < 101)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (int)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "2x")
            {
                double levelUpMultiplier = 1.0805;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel < 101)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (int)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "2.5x")
            {
                double levelUpMultiplier = 1.1072;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel < 101)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (int)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "5x")
            {
                double levelUpMultiplier = 1.1959;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel < 101)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (int)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "10x")
            {
                double levelUpMultiplier = 1.2916;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel < 101)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (int)levelUpStat);
                    levelUpLevel++;
                    levelUpStat = levelUpStat * levelUpMultiplier;
                }
            }
            else if (levelTenRatio == "20x")
            {
                double levelUpMultiplier = 1.395;
                double levelUpStat = levelOneStat * levelUpMultiplier;
                while (levelUpLevel < 101)
                {
                    Console.WriteLine("Level " + levelUpLevel + ": " + (int)levelUpStat);
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
