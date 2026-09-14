/*
* Student ID : 1690700651
* Name       : Pharit Samranchai
* Section    : 129A
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("________________________________");
            Console.WriteLine("          Slot Container        ");
            Console.WriteLine("________________________________");

            Console.Write("Slot Index: ");
            bool slotIndexValid = int.TryParse(Console.ReadLine(), out int slotIndex);
            Console.Write("Slot Stack: ");
            bool slotStackValid = int.TryParse(Console.ReadLine(), out int slotStack);
            Console.Write("Slot Stack Size: ");
            bool slotStackSizeValid = int.TryParse(Console.ReadLine(), out int slotStackSize);
            Console.Write("Monster HP: ");
            Console.Write("Slot 2 Index: ");
            bool slot2IndexValid = int.TryParse(Console.ReadLine(), out int slot2Index);
            Console.Write("Slot 2 Stack: ");
            bool slot2StackValid = int.TryParse(Console.ReadLine(), out int slot2Stack);
            Console.Write("Slot 2 Stack Size: ");
            bool slot2StackSizeValid = int.TryParse(Console.ReadLine(), out int slot2StackSize);
            bool allStatsValid = slotIndexValid && slotStackValid && slotStackSizeValid && slot2IndexValid && slot2StackValid && slot2StackSizeValid;
            Console.WriteLine($"All stats valid: {allStatsValid}");

            Console.WriteLine($"[Slot1]    Index:{slotIndex} Stack:{slotStack} Max Stack:{slotStackSize}");
            Console.WriteLine($"[Slot2]    Index:{slot2Index} Stack:{slot2Stack} Max Stack:{slot2StackSize}");

            /*
            int potionHeal = 8;
            heroHp += potionHeal;
            Console.WriteLine($"Hero drinks a potion, healing {potionHeal}. Hero HP is now {heroHp}.");

            int normalDamage = Math.Max(0, heroAttack - monsterDefense);
            Console.WriteLine($"Normal Attack would deal: {normalDamage} damage");

            int powerDamage = Math.Max(0, heroAttack * 2 - monsterDefense);
            Console.WriteLine($"Power Attack would deal: {powerDamage} damage");

            int counterDamage = Math.Max(0, monsterAttack - heroDefense);
            Console.WriteLine($"If Monster counters afterward, it would deal: {counterDamage} damage");

            Random rng = new Random(14);
            int roll = rng.Next(1, 101);
            bool isCritical = roll <= 10;
            int criticalDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage;
            Console.WriteLine($"Critical hit roll: {roll} (critical: {isCritical})");
            Console.WriteLine($"If critical, Normal Attack would instead deal: {criticalDamage} damage");
            */
        }
    }
}
