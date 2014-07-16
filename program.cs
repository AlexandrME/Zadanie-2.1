using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manaev
{
    public class Line
    {
        int[,] _pryam;
        public int _k;
        int _b;
        public int perese4Oy;

        public Line(int k, int b)
        {
            _k = k;
            _b = b;
            perese4Oy = b;
            _pryam = new int[k, b];
        }
        public void paralel(int k)
        {
            if (_k == 0)
                Console.WriteLine("Прямая паралельна оси абсцис");
            else
                Console.WriteLine("Прямая не паралельна оси абсцис");
        }

        public void NOVPR(int k)
        {
            if (_k != 0 && _k < 100)
                Console.WriteLine("Прямая перпендекулярная данной и проходящая через начало координат:y=-"+ (k) + "x");
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите угловой коэффециент прямой : К=");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Введите свободный коэффециент прямой : b=");
            int b = int.Parse(Console.ReadLine());

            Line pryam = new Line(k, b);
           
            
            pryam.paralel(k);

            pryam.NOVPR(k);
            
            Console.ReadKey();
        }
    }
}
