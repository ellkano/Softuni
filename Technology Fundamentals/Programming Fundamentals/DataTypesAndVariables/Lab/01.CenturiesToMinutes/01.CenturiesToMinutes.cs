using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(number * 100);
            uint days = (uint)(years * 365.2422);
            ulong hours = (ulong)(days * 24);
            ulong minutes = hours * 60;

            Console.WriteLine($"{number} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
