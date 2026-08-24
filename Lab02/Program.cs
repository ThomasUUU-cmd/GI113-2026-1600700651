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
            /// 
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
            /// เกมของผมเอง
            /// 
            var allCharactor = new List<CharactorStatus>(); // ขออนุญาตใช้ List กับการประกาศคลาสเองเพื่อเก็บข้อมูลเพื่อความสะดวกในการเขียนและความยืดหยุ่นในการขยายงานนะครับ 

            var player = new CharactorStatus("Thomas", CharactorStatus.CharactorType.Player,
                new RangedFloat(835f, 0f, 835f), new RangedFloat(50f, 0f, 50f),
                100f, 1, 'F');

            allCharactor.Add(player);
            allCharactor.Add(new CharactorStatus("Skeleton", CharactorStatus.CharactorType.Enemy,
                new RangedFloat(200f, 0f, 200f), new RangedFloat(100f, 0f, 100f),
                5f, 2, 'E'));
            allCharactor.Add(new CharactorStatus("Slime", CharactorStatus.CharactorType.Enemy,
                new RangedFloat(157f, 0f, 157f), new RangedFloat(100f, 0f, 100f),
                15f, 2, 'E'));
            allCharactor.Add(new CharactorStatus("Devil", CharactorStatus.CharactorType.Boss,
                new RangedFloat(250f, 0f, 250f), new RangedFloat(250f, 0f, 250f),
                80f, 2, 'D'));

            Console.WriteLine();
            Console.WriteLine("===== ALL CHARACTOR STATUS: INITIAL =====");
            foreach (CharactorStatus charactor in allCharactor)
            {
                WriteStatus(charactor);
            }

            Console.Write("Select Charactor to Attack (Please Enter Charactor's Name): ");
            string? selectedCharactor = Console.ReadLine();

            var targetCharactor = allCharactor.FirstOrDefault(c => c.Name == selectedCharactor);
            if (targetCharactor == null) { Console.WriteLine("ERROR: Not Found Select Charactor!"); return; }
            var attackAmount = GetAttackAmount(player);
            targetCharactor.Health.Value -= attackAmount;
            Console.WriteLine($"{player.Name} attack to {targetCharactor.Name} {attackAmount} damage");
            WriteStatus(targetCharactor);
        }
        static int CalculatePercent(int value, int max) => value * 100 / max; // ผมเคยใช้ (int)((float)value / (float)max * 100) แต่ผมเองก็พึ่งรู้เหมือนกันว่าแค่เปลี่ยน order การคำนวนเป็นแบบนี้มันก็ใช้ได้เหมือนกัน
        static int CalculatePercent(RangedFloat input) => (int)(input.Value * 100 / input.Max);
        static float GetAttackAmount(CharactorStatus attacker) // method สำหรับคำนวณหาดาเมจที่คาแรคเตอร์นั้นๆควรจะสามารถทำได้
        {
            return (attacker.Stamina.Value / 100) * (float)attacker.Level * attacker.AttackPower;
        }
        static void WriteStatus(CharactorStatus charactor) // method สำหรับการพิมพ์ status
        {
            Console.WriteLine($"Name: {charactor.Name}\n" +
                $"Type: {charactor.Type.ToString()}\n" +
                $"HP: {charactor.Health.Value} / {charactor.Health.Max}, {CalculatePercent(charactor.Health)}%\n" +
                $"Stamina: {charactor.Stamina.Value} / {charactor.Stamina.Max}, {CalculatePercent(charactor.Stamina)}%\n" +
                $"Level: {charactor.Level}\n" +
                $"Rank: {charactor.Rank}\n" +
                (charactor.IsAlive ? "Alive" : "Die") + "\n");
        }
    }

    public class CharactorStatus // ขออนุญาตสร้าง class เพื่อเก็บข้อมูลสเตตัสนะครับ จะได้ใช้ได้ทีเดียวเลย
    {
        public enum CharactorType
        {
            Player,
            Enemy,
            Boss
        }

        public string Name { get; } = "Untitled";
        public CharactorType Type = CharactorType.Player;
        public RangedFloat Health = new RangedFloat(100f, 0f, 100f);
        public RangedFloat Stamina = new RangedFloat(100f, 0f, 100f);
        public float AttackPower = 10f;
        public int Level = 1;
        public char Rank = 'F';
        public bool IsAlive => Health.Value > 0;

        public CharactorStatus(string name, CharactorType type, RangedFloat health, RangedFloat stamina, float attackPower, int level, char rank)
        {
            Name = name;
            Type = type;
            Health = health;
            Stamina = stamina;
            AttackPower = attackPower;
            Level = level;
            Rank = rank;
        }

    }
    public class RangedFloat // เกี่ยวกับการเก็บตัวแปรประเภท float ที่มี min / max จะได้เรียกใช้ได้อย่างสะดวก
    {
        public float Value
        {
            get;
            set => field = Math.Clamp(value, Min, Max);
        }
        public float Min;
        public float Max;

        public RangedFloat(float value = 0f, float min = 0f, float max = 100f)
        {
            Min = min;
            Max = max;
            Value = value;
        }
    }
}
