using System;
using System.Linq;

namespace KeLi.SkillPoint.App.Problems
{
    internal class NumSumProblem : IResult
    {
        public void ShowResult()
        {
            Console.Write("Please input num: ");

            var input = Console.ReadLine();
            var result = GetNumSum(input);

            switch (result)
            {
                case -1:
                    Console.WriteLine("Input Error!");

                    break;

                case 0:
                    Console.WriteLine("Max Num Error!");

                    break;

                default:
                    Console.WriteLine("Total Num: " + GetNumSum(input));

                    break;
            }
        }

        private static int GetNumSum(string str)
        {
            var result = 0;

            if (int.TryParse(str, out var num))
            {
                if (num > 1000)
                    result = 0;

                else
                {
                    var chs = num.ToString().ToCharArray();

                    result += chs.Sum(ch => int.Parse(ch.ToString()));
                }
            }

            else
                result = -1;

            return result;
        }
    }
}