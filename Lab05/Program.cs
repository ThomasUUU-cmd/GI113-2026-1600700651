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

            int addStack = 5;
            slotStack += addStack;
            Console.WriteLine($"Slot add stack {addStack}. Current Slot Stack is {slotStack}.");

            int slotContainerStackSum = Math.Max(0, slotStack + slot2Stack);
            Console.WriteLine($"Sum of container stack: {slotContainerStackSum}");
            int slotContainerStackSizeSum = Math.Max(0, slotStackSize + slot2StackSize);
            Console.WriteLine($"Sum of container stack size: {slotContainerStackSizeSum}");

            Random rng = new Random(14);
            int roll = rng.Next(1, 11);
            bool isMerge = roll <= 2;
            Console.WriteLine($"Roll to merge slot: {roll} (merge: {isMerge})");
            Console.WriteLine($"If Merge, Slot merge to {slot2Index} index with {slotContainerStackSum} Stack and {slotContainerStackSizeSum} Stack Size");
        }
    }
}
