using System;

namespace KeLi.SkillPoint.App.Problems
{
    internal class NumPyramidProblem : IResult
    {
        public void ShowResult()
        {
            Console.Write("Please input num: ");

            var input = Console.ReadLine();
            var results = GetNumLines(input);

            if (results.Length == 0)
                return;

            foreach (var result in results)
                Console.WriteLine(result);
        }

        private static string[] GetNumLines(string str)
        {
            string[] results;

            if (int.TryParse(str, out var num) && num <= 30)
            {
                num += 1;
                results = new string[num];

                for (var i = 0; i < num; i++)
                {
                    var numstr = string.Empty;
                    var spacestr = string.Empty;

                    for (var j = 0; j < i; j++)
                        numstr += $"{i,2} ";

                    for (var j = 0; j < num - i; j++)
                        spacestr += "   ";

                    results[i] = spacestr + numstr + $"{i,2} " + numstr + spacestr;
                }
            }

            else
                results = new string[0];

            return results;
        }
    }
}