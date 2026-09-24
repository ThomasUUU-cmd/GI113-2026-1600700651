/*
* Student ID : 1690700651
* Name       : Pharit Samranchai
* Section    : 129A
* No.        : 27
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int tvalue = 0;
            if (tvalue <= 0) { Console.WriteLine("NULL"); }
            else { Console.WriteLine("Hello, World!"); }

            int slider = 30;
            int maxSlider = 100;
            if (slider >= maxSlider) { Console.WriteLine("Subtract"); }
            else { Console.WriteLine("Add"); }

            int score = 17;
            if (score > 20) { Console.WriteLine("a"); }
            else if (score > 10) { Console.WriteLine("b"); }
            else { Console.WriteLine("c"); }

            Console.WriteLine("Assign Level");
            bool levelValid = int.TryParse(Console.ReadLine(), out var level);

            if (!levelValid || level < 1 || level > 99) { Console.WriteLine("Invalid or Mismatch value"); return; }
            else if (level >= 10) { Console.WriteLine("floor unlock"); }
            else if (level >= 5) { Console.WriteLine("door open"); }
            else { Console.WriteLine("NULL ACTION"); }
            */

            Console.WriteLine("================================================================");
            Console.WriteLine("HERO VS MONSTER");
            Console.WriteLine("================================================================");
            Console.WriteLine();

            Console.Write("Base Hero Health point: ");
            bool heroHPValid = float.TryParse(Console.ReadLine(), out float heroHP);

            Console.WriteLine();
            float monsterHP = 100;
            if (heroHPValid && heroHP > 0)
            {
                Console.WriteLine("==== < Log > ====");
                Console.WriteLine($"Hero HP = {heroHP}");
                Console.WriteLine($"Monster HP = {monsterHP}");
                Console.WriteLine("=================");
                Console.WriteLine();

                Console.WriteLine("================================================================");
                Console.Write("Select Action index (0: Attack, 1: Heal, 2: Guard): ");
                bool actionValid = int.TryParse(Console.ReadLine(), out int actionIndex);
                bool actionIndexMismatch = actionIndex > 2 || actionIndex < 0;

                Console.WriteLine();
                if (actionValid && !actionIndexMismatch)
                {
                    Console.WriteLine("--------------------------------");
                    Console.Write("Hero Turn: ");

                    float heroActionPower = heroHP / 10;
                    float monsterPower = monsterHP / 5;
                    if (actionIndex == 0)
                    {
                        monsterHP -= heroActionPower;
                        Console.WriteLine($"Attack to Monster {heroActionPower} damage");
                    }
                    else if (actionIndex == 1)
                    {
                        heroHP += heroActionPower;
                        Console.WriteLine($"Heal self {heroActionPower} point");
                    }
                    else if (actionIndex == 2)
                    {
                        monsterPower /= 2;
                        Console.WriteLine($"Guard +200%");
                    }
                    Console.WriteLine("--------------------------------");

                    Console.WriteLine();
                    Console.WriteLine("==== < Log > ====");
                    if (heroHP > 0)
                    {
                        Console.WriteLine($"Hero HP = {heroHP}");
                    }
                    else
                    {
                        Console.WriteLine("Hero is Dead");
                        Console.WriteLine($"Monster HP = {monsterHP}");
                        Console.WriteLine("=================");
                        Console.WriteLine();
                        Console.WriteLine("=================");
                        Console.WriteLine("Monster Win!!!");
                        Console.WriteLine("=================");
                        return;
                    }
                    
                    if (monsterHP > 0)
                    {
                        Console.WriteLine($"Monster HP = {monsterHP}");
                    }
                    else
                    {
                        Console.WriteLine($"Monster is Dead");
                        Console.WriteLine("=================");
                        Console.WriteLine();
                        Console.WriteLine("=================");
                        Console.WriteLine("Hero Win!!!");
                        Console.WriteLine("=================");
                        return;
                    }
                    Console.WriteLine("=================");
                    Console.WriteLine();

                    heroHP -= monsterPower;
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"Monster Turn: Attack To Hero {monsterPower} damage");
                    Console.WriteLine("--------------------------------");

                    Console.WriteLine();
                    Console.WriteLine("==== < Log > ====");
                    if (heroHP > 0)
                    {
                        Console.WriteLine($"Hero HP = {heroHP}");
                    }
                    else
                    {
                        Console.WriteLine("Hero is Dead");
                        Console.WriteLine($"Monster HP = {monsterHP}");
                        Console.WriteLine("=================");
                        Console.WriteLine();
                        Console.WriteLine("=================");
                        Console.WriteLine("Monster Win!!!");
                        Console.WriteLine("=================");
                        return;
                    }

                    if (monsterHP > 0)
                    {
                        Console.WriteLine($"Monster HP = {monsterHP}");
                    }
                    else
                    {
                        Console.WriteLine($"Monster is Dead");
                        Console.WriteLine("=================");
                        Console.WriteLine();
                        Console.WriteLine("=================");
                        Console.WriteLine("Hero Win!!!");
                        Console.WriteLine("=================");
                        return;
                    }
                    Console.WriteLine("=================");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Action Invalid or Mismatch");
                }
            }
            else
            {
                Console.WriteLine("Hero HP Invalid or Mismatch");
            }
        }
    }
}
