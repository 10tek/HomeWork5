using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WorldOfTanks;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            // При разработке программы использовать обработку исключительных ситуаций. Варианты возможных исключительных ситуаций рассмотреть самостоятельно!
            // Не смог найти варианты возможных искл. ситуаций.
            var tanksT34 = new Tank[5];
            var tanksPantera = new Tank[5];
            var winner = 0;
            for (var i = 0; i < tanksT34.Length; i++)
            {
                tanksT34[i] = new Tank("T-34_" + i);
                tanksPantera[i] = new Tank("Pantera_" + i);
            }
            Console.WriteLine("Team T-34:");
            foreach (var tank in tanksT34)
            {
                Console.WriteLine(tank.GetStats());
            }
            Console.WriteLine("Team Pantera:");
            foreach (var tank in tanksPantera)
            {
                Console.WriteLine(tank.GetStats());
            }
            for (var i = 0; i < tanksPantera.Length; i++)
            {
                if (tanksT34[i] * tanksPantera[i])
                {
                    winner++;
                }
                else
                {
                    winner--;
                }
            }
            if (winner > 0)
            {
                Console.WriteLine("Победила команда T-34");
            }
            else
            {
                Console.WriteLine("Победила команда Pantera");
            }





            Console.ReadKey();
        }
    }
}
