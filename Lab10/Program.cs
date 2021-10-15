using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle obtuse = new Angle(120,13,8);
            Console.WriteLine("Угол: {0} градусов, {1} минут, {2} секунд.", obtuse.Gradus, obtuse.Min, obtuse.Sec);
            obtuse.ToRadians();
            Angle right = new Angle(90);
            Console.WriteLine("Угол: {0} градусов, {1} минут, {2} секунд.", right.Gradus, right.Min, right.Sec);
            right.ToRadians();
            Console.ReadKey();
        }
    }

    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    this.gradus = value;
                }
                else
                {
                    Console.WriteLine("Градус должен быть в диапазоне 0-360");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    this.min = value;
                }
                else
                {
                    Console.WriteLine("Минуты должны быть в диапазоне 0-59");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    this.sec = value;
                }
                else
                {
                    Console.WriteLine("Секунды должны быть в диапазоне 0-59");
                }
            }
            get
            {
                return sec;
            }
        }

        public Angle (int gradus, int min=0, int sec=0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public void ToRadians()
        {
            double radian = (gradus + (min / 60) + (sec / 60)) * Math.PI / 180;
            Console.WriteLine("Угол в радианах равен: {0:f2}", radian);
        }
    }
}
