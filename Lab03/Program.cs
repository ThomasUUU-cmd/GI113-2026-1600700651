/*
* Student ID : 1690700651
* Name       : Pharit Samranchai
* Section    : 129A
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}\n" +
                $"Rank: {rank}\n" +
                $"Level: {level} / {MaxLevel}\n" +
                $"HP: {currentHp} / {maxHp}\n" +
                $"Attack Power: {attackPower}\n" +
                $"Crit Multiplier: {critMultiplier}\n" +
                $"Is Boss: {isBoss}\n");

            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}\n");

            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%\n");

            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}\n");

            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}\n" +
                $"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}
