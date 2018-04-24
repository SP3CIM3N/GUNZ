using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию о стрелковом оружии");
            gun gun1 = new gun();
            gun1.input();
            Console.Clear();
            gun1.output();
            Console.ReadKey();
        }
    }
}
