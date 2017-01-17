using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            string input = Console.ReadLine();

            while (input != "print")
            {
                string[] commandLine = input.Split().ToArray();

                string manipulator = commandLine[0];

                //switch (manipulator)
                //{
                //    case "add":
                //        AddElement(commandLine, numbers);
                //        break;
                //    case "addMany":
                //        AddMany(commandLine, numbers);
                //        break;
                //    case "contains":
                //        ContainsElement(commandLine, numbers);
                //        break;
                //    case "remove":
                //        RemoveElements(commandLine, numbers);
                //        break;
                //    case "shift":
                //        ShiftElements(commandLine, numbers);
                //        break;
                //    case "sumPairs":
                //        numbers = SumPairs(numbers);
                //        break;

                //    default:
                //        break;
                //}




                if (manipulator == "add")
                {
                    AddElement(commandLine, numbers);
                }

                else if (manipulator == "addMany")
                {
                    AddMany(commandLine, numbers);
                }

                else if (manipulator == "contains")
                {
                    ContainsElement(commandLine, numbers);
                }

                else if (manipulator == "remove")
                {
                    RemoveElements(commandLine, numbers);
                }

                else if (manipulator == "shift")
                {
                    ShiftElements(commandLine, numbers);
                }

                else if (manipulator == "sumPairs")
                {
                    numbers = SumPairs(numbers);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));



        }
        private static List<int> AddElement(string[] commandLine, List<int> numbers)
        {


            int index = int.Parse(commandLine[1]);

            int newNumber = int.Parse(commandLine[2]);

            numbers.Insert(index, newNumber);
            return numbers;
        }

        private static List<int> AddMany(string[] commandLine, List<int> numbers)
        {
            int index = int.Parse(commandLine[1]);

            for (int j = 2; j < commandLine.Length; j++)
            {
                numbers.Insert(index, int.Parse(commandLine[j]));
                index++;
            }

            return numbers;
        }

        private static void ContainsElement(string[] commandLine, List<int> numbers)
        {
            int index = int.Parse(commandLine[1]);

            if (numbers.Contains(index))
            {
                Console.WriteLine(numbers.IndexOf(index));
            }

            else
            {
                Console.WriteLine("-1");
            }

        }

        private static List<int> RemoveElements(string[] commandLine, List<int> numbers)
        {

            int index = int.Parse(commandLine[1]);

            numbers.RemoveAt(index);

            return numbers;
        }

        private static List<int> ShiftElements(string[] commandLine, List<int> numbers)
        {
            int index = int.Parse(commandLine[1]);

            for (int i = 0; i < index; i++)
            {
                int firstElement = numbers[i];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Count - 1] = firstElement;
            }

            return numbers;
        }

        private static List<int> SumPairs(List<int> numbers)
        {
            List<int> sum = new List<int>();

            for (int i = 0; i < numbers.Count-1; i += 2)
            {
                sum.Add(numbers[i] + numbers[i + 1]);
            }

            if (numbers.Count % 2 == 1)
            {
                sum.Add(numbers[numbers.Count - 1]);
            }

            numbers = sum;

            return numbers;
        }


    }
}
