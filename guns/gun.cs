using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guns
{
    /// <summary>
    /// Класс "Стрелковое оружие" где описаны наши переменные
    /// </summary>
    class gun
    {
        public string name { get; set; }
        public double caliber { get; set; }
        public double range { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public gun()
        {
            name = null;
            caliber = 0;
            range = 0;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public gun(string x, double y, double z)
        {
            name = x;
            caliber = y;
            range = z;
        }
        /// <summary>
        /// Метод ввода параметров с клавиатуры
        /// </summary>
        public virtual void input()
        {
            Console.Write("Название: ");
            name = Console.ReadLine();
            Console.Write("Калибр: ");
            caliber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Дальность: ");
            range = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Метод вывода значения в консоль
        /// </summary>
        public virtual void output()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Калибр: " + caliber);
            Console.WriteLine("Дальность: " + range);
        }
    }
}
