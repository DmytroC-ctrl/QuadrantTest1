using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrant
{
    public class QuadrantCalculator
    {


        public string DefinitionQuadrant(int x, int y)
        {
            string quadrant = x >= 0 ? (y >= 0 ? "quadrant1" : "quadrant4") : (y >= 0 ? "quadrant2" : "quadrant3");
            return quadrant;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите координату х- ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y- ");
            int y = int.Parse(Console.ReadLine());
            //Console.WriteLine(DefinitionQuadrant(x, y));

            Console.ReadKey();
        }
    }

}
