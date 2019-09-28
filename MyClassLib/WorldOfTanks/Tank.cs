using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        private string _name;
        private int _attack;
        private int _armor;
        private int _mobility;
        private static Random random = new Random();

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Attack
        {
            get
            {
                return _attack;
            }
        }

        public int Armor
        {
            get
            {
                return _armor;
            }
        }

        public int Mobility
        {
            get
            {
                return _mobility;
            }
        }

        public Tank()
        {
            _name = string.Empty;
            _attack = random.Next(0, 100);
            _armor = random.Next(0, 100);
            _mobility = random.Next(0, 100);
        }

        public Tank(string name)
        {
            _name = name;
            _attack = random.Next(0, 100);
            _armor = random.Next(0, 100);
            _mobility = random.Next(0, 100);
        }

        public string GetStats()
        {
            return $"name: {Name}; attack: {_attack}; armor: {_armor}; mobility: {_mobility}";
        }

        public static bool operator *(Tank firstTank, Tank secondTank)
        {
            int winner = 0;
            Console.WriteLine($"Name:   {firstTank.Name} vs {secondTank.Name}");
            Console.WriteLine($"Attack:   {firstTank.Attack} - {secondTank.Attack}");
            Console.WriteLine($"Armor:    {firstTank.Armor} - {secondTank.Armor}");
            Console.Write($"Mobility: {firstTank.Mobility} - {secondTank.Mobility}");
            winner += firstTank.Attack > secondTank.Attack ? 1 : -1;
            winner += firstTank.Armor > secondTank.Armor ? 1 : -1;
            winner += firstTank.Mobility > secondTank.Mobility ? 1 : -1;
            if (winner > 0)
            {
                Console.WriteLine($"  {firstTank.Name} wins\n");
                return true;
            }
            Console.WriteLine($"  {secondTank.Name} wins\n");
            return false;
        }
    }
}
