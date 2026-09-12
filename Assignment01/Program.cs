/*
* Student ID : 1690700651
* Name       : Pharit Samranchai
* Section    : 129A
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string BaseSeed = "214ea667-2687-4517-a400-679d99ba5e0b";

            var mapDisplayName = "terrain_1";
            var mapKey = 'I';
            int mapLength = 32;
            float mapGenerateThreshold = 5.6f;
            double mapGenerateWeightPerCell = 0.75;
            bool mapIsSolve = false;

            Console.WriteLine("==================================");
            Console.WriteLine("|     Wave Function Collapse     |");
            Console.WriteLine("|      Entropy-based Solver      |");
            Console.WriteLine("|          Map Generater         |");
            Console.WriteLine("+--------------------------------+");
            Console.WriteLine();
            Console.WriteLine( "+--------------------------------+");
            Console.WriteLine( "|     Map Generate Propoties     |");
            Console.WriteLine( "+--------------------------------+");
            Console.WriteLine($"|   Name:       {mapDisplayName}");
            Console.WriteLine($"|   Seed:       {BaseSeed}");
            Console.WriteLine($"|   Key:        {mapKey}");
            Console.WriteLine($"|   Length:     {mapLength}");
            Console.WriteLine($"|   Threshold:  {mapGenerateThreshold}");
            Console.WriteLine($"|   Weight:     {mapGenerateWeightPerCell}");
            Console.WriteLine($"|   Is Solve:   {mapIsSolve}");
            Console.WriteLine( "+--------------------------------");

            double lengthAsDouble = mapLength;
            int weightPerCellTruncated = (int)mapGenerateWeightPerCell;
            int weightPerCellRounded = Convert.ToInt16(mapGenerateWeightPerCell);
            mapIsSolve = true;

            Console.WriteLine();
            Console.WriteLine("+--------------------------------+");
            Console.WriteLine("|           Process log          |");
            Console.WriteLine("+--------------------------------+");
            Console.WriteLine($"|   Convert 'mapLength' variable to double by implicit, current value is {lengthAsDouble}");
            Console.WriteLine($"|   Convert 'mapGenerateWeightPerCell' variable to int by explicit cast, current value is {weightPerCellTruncated}");
            Console.WriteLine($"|   Convert 'mapGenerateWeightPerCell' variable to int by Convert, current value is {weightPerCellRounded}");
            Console.WriteLine($"|   Solving Success, current value is {mapIsSolve}");
            Console.WriteLine("+--------------------------------");
        }
    }
}
