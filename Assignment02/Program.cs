/*
* Student ID : 1690700651
* Name       : Pharit Samranchai
* Section    : 129A
* No.        : 27
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Plutonium";
            const float SmeltRate = 6.2f, SalvageRate = 4.9f;
            const float MaxBatch = 500;

            Console.WriteLine("================================");
            Console.WriteLine("|           The Forge          |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|             MENU             |");
            Console.WriteLine("| S = Smelt      B = Breakdown |");
            Console.WriteLine("================================");
            Console.Write("Select Menu: ");
            bool isMenuValid = char.TryParse(Console.ReadLine(), out char menu);
            if (isMenuValid)
            {
                if (menu == 's' || menu == 'S')
                {
                    Console.Write($"Select {MaterialName} Ore Amount: ");
                    bool isAmountValid = float.TryParse(Console.ReadLine(), out float amount);
                    if (amount > 0 && amount <= MaxBatch)
                    {
                        float ingotAmount = amount * SmeltRate;
                        Console.WriteLine($"Smelted {amount} {MaterialName} Ore => {ingotAmount} {MaterialName} Ingot");
                    }
                    else
                    {
                        Console.WriteLine("[Error] Amount is Over than 'MaxBatch' or Lower than 0!!");
                    }
                }
                else if (menu == 'b' || menu == 'B')
                {
                    Console.Write($"Select {MaterialName} Ingot Amount: ");
                    bool isAmountValid = float.TryParse(Console.ReadLine(), out float amount);
                    if (amount > 0 && amount <= MaxBatch)
                    {
                        float oreAmount = amount / SalvageRate;
                        Console.WriteLine($"Smelted {amount} {MaterialName} Ingot => {oreAmount} {MaterialName} Ore");
                    }
                    else
                    {
                        Console.WriteLine("[Error] Amount is Over than 'MaxBatch' or Lower than 0!!");
                    }
                }
                else
                {
                    Console.WriteLine("[Error] Menu is Mismatch!!");
                }
            }
            else
            {
                Console.WriteLine("[Error] Menu Mismatch or Invalid!!");
            }
        }
    }
}
