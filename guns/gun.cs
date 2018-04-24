using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guns
{
    class gun
    {
        //свойства класса
        public string name { get; set; }   
        public double caliber { get; set; }
        public double range { get; set; }
        //конструктор по
        public gun()
        {
            name = null;
            caliber = 0;
            range = 0;
        }

        public virtual void input()
        {
            Console.Write("Название: ");
            name = Console.ReadLine();
            Console.Write("Калибр: ");
            caliber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Дальность: ");
            range = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void output()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Калибр: " + caliber);
            Console.WriteLine("Дальность: " + range);
        }
    }
}
