using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string text = Console.ReadLine();


            PrintResult(text, n);

            
        }

        private static void PrintResult(string text, double n)
        {
            if (text == "face")
            {
                FaceOfCube(n);
            }

            else if (text == "space")
            {
                SpaceOfCube(n);
            }

            else if (text == "volume")
            {
                VolumeOfCube(n);
            }

            else
            {
                AreaOfCube(n);
            }
        }

        private static void AreaOfCube(double n)
        {
            Console.WriteLine("{0:f2}",Math.Pow(n, 2)*6);
        }

        private static void VolumeOfCube(double n)
        {
            Console.WriteLine("{0:f2}", Math.Pow(n, 3));
        }

        private static void SpaceOfCube(double n)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(Math.Pow(n, 2) * 3));
        }

        private static void FaceOfCube(double n)
        {
            Console.WriteLine("{0:f2}", Math.Sqrt(Math.Pow(n, 2)*2));
        }
    }
}
