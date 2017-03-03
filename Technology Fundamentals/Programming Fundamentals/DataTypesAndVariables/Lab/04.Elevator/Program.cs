using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = persons / capacity;
            if (persons % capacity != 0)
            {
                courses++;
            }

            //int courses = (int)Math.Ceiling((double)persons / capacity) - tova e reshenieto v LAB-a

            Console.WriteLine(courses);
        }
    }
}
