using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Geron
    {
        private double x;
        private double y;
        private double z;
        public Geron(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double Ploshad()
        {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
        public bool Proverk()
        {
            return (x + y > z && x + z > y && y + z > x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите длину стороны x ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите длину стороны y ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите длину стороны z ");
                double z = Convert.ToDouble(Console.ReadLine());
                Geron geron = new Geron(x, y, z);
                if (geron.Proverk())
                {
                    double v = geron.Ploshad();
                    Console.WriteLine($"Площадь треугольника: {v}");
                }
                else
                {
                    Console.WriteLine("Треугольник с такими сторонами не существует  ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неправильный ввод данных ");
                
            }
            Console.ReadKey();
        }
        }
    }
