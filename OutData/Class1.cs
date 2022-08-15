using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutData
{
    public class Initial
    {
        public static void PrintInfo(string stuName, int workNum)
        {
            Console.WriteLine($"Домашняя работа к занятию № {workNum}");
            Console.WriteLine($"Выполнил: {stuName}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();
        }

    }
}
