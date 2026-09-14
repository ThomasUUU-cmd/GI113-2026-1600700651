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

            Console.Write("Create Slot At Index: ");
            bool slotIndexValid = int.TryParse(Console.ReadLine(), out var slotIndex);
            if (!slotIndexValid) { Console.WriteLine("INPUT MISMATCH"); return; }
            Console.Write("Set Slot Value: ");
            bool slotValueValid = float.TryParse(Console.ReadLine(), out var slotValue);
            Console.Write("Set Slot Max Stack Size: ");
            bool slotStackSizeValid = int.TryParse(Console.ReadLine(), out var slotStackSize);

            bool isVariablesValid = slotStackSizeValid && slotValueValid;
            if (!isVariablesValid) { Console.WriteLine("INPUT MISMATCH"); return; }

            Console.WriteLine();
            Console.Write("Add Slot Value: ");
            bool newSlotValueValid = float.TryParse(Console.ReadLine(), out var newSlotValue);
            if (!newSlotValueValid) { Console.WriteLine("INPUT MISMATCH"); return; }
            slotValue += newSlotValue;
            float remainingValue = newSlotValue - (slotStackSize % newSlotValue);
            slotValue = Math.Clamp(slotValue, 0, slotStackSize);

            Console.WriteLine();
            Console.WriteLine($"Current slot {slotIndex} value is {slotValue}");
            Console.WriteLine($"remaining {remainingValue} value");

            Random rnd = new Random();
            int indexRoll = rnd.Next(0, 10);
            slotIndex = indexRoll;
            Console.WriteLine($"Move slot index to {indexRoll}");
        }
    }
}
