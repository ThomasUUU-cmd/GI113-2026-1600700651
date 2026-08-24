/*
 * Student ID : 1690700651
 * Name       : Pharit Samranchai
 * Section    : 129A
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// --- Part A --- 
            /// Kirin's Status Report
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int currentHp = 175;
            int maxHp = 240;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}\n"+
                $"Rank: {rank}\n"+
                $"Level: {level}\n"+
                $"HP: {currentHp} / {maxHp}\n"+
                $"Attack Power: {attackPower}\n"+
                $"Crit Multiplier: {critMultiplier}\n"+
                $"Is Boss: {isBoss}");
            Console.WriteLine();
            Console.WriteLine($"HP Percent: {CalculatePercent(currentHp, maxHp)}%");
            Console.WriteLine();

            int damageAmount = 60;
            currentHp -= damageAmount;

            Console.WriteLine($"{bossName} takes {damageAmount} damage!");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}\n" + $"HP Percent: {CalculatePercent(currentHp, maxHp)}%");

            /// --- Part B --- 
            /// เกมของผมเอง (WIP)
        }
        static int CalculatePercent(int value, int max) => value * 100 / max; // เคยใช้ (int)((float)value / (float)max * 100) แต่ผมเองก็พึ่งรู้เหมือนกันว่าแค่เปลี่ยน order การคำนวนเป็นแบบนี้มันก็ใช้ได้เหมือนกัน
    }
}
