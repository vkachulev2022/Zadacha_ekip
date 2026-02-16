using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] cmd = Console.ReadLine().Split().ToArray();
            //cw .......
           // Console.WriteLine("..............");
            //........
           

            switch (cmd[0])
            {
                case "add":nums.Add(int.Parse(cmd[1]));
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                case "ins":nums.Insert(int.Parse(cmd[1]), int.Parse(cmd[2]));
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                case "contains":
                    if (nums.Contains(int.Parse(cmd[1])))
                    {
                        Console.WriteLine("Yes");
                        Console.WriteLine(string.Join(" ", nums));
                      //  Console.WriteLine("Modify");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                    break;
                case "delete": nums.Remove(int.Parse(cmd[1]));
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                case "remove": nums.RemoveAt(int.Parse(cmd[1]));
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                case "print":
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                case "countOdds": var countOdds = nums.Count(x => x % 2 == 1);
                    Console.WriteLine($"CountOdds={countOdds}");
                    break;
                default:
                    break;
            }
        }
    }
}
