using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            //чета от конзолата и създавам речника, който ще ми държи крайните резултати, които ми трябват

            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> allUserData = new Dictionary<string, Dictionary<string, int>>();


            while (!input.Equals("end")) // цикъл за всеки един ред, който ще чета
            {
                List<string> firstSplitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

                List<string> userNameFields = firstSplitInput[0].Split('=').ToList();
                string userName = userNameFields[1];

                List<string> ipAddress = firstSplitInput[2].Split('=').ToList();
                string ip = ipAddress[1];

                //if (!ipData.ContainsKey(ip))
                //{
                //    ipData[ip] = 1;
                //}
                //else
                //{
                //    ipData[ip]++;
                //}

                if (!allUserData.ContainsKey(userName)) //ако не съществува, създавам нов подречник за value-то на основния речник
                {

                    Dictionary<string, int> ipData = new Dictionary<string, int>();
                    ipData[ip] = 1;
                    
                    allUserData[userName] = ipData;
                }

                else // ако съществува, това означава, че подречника вече е създаден и сега трябва да допълвам стойности в него
                {
                    if (allUserData[userName].ContainsKey(ip))
                    {
                        allUserData[userName][ip]++; // allUserData[userName] ми връща като стойност подречника, който от своя страна има ключ [ip] на който сега увеличавам стойноста
                    }
                    else
                    {
                        allUserData[userName].Add(ip, 1);// allUserData[userName] ми връща като стойност подречника, на който сега създавам ключ [ip] и му задавам стойност 1.
                                                         // allUserData[userName].[ip] = 1; - същото като горния ред
                    }
                }



                input = Console.ReadLine();
            }

            
            foreach (KeyValuePair<string, Dictionary<string, int>> date in allUserData.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{date.Key}:");

                foreach (var thing in allUserData[date.Key])
                {
                    if (thing.Key != date.Value.Keys.Last())
                    {
                        Console.Write("{0} => {1}, ", thing.Key, thing.Value);
                    }
                    else
                    {
                        Console.WriteLine("{0} => {1}.", thing.Key, thing.Value);
                    }

                }

            }
        }
    }
}
