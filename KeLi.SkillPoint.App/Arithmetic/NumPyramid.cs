using System;
using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Arithmetic
{
    public class NumPyramid
    {
        public static void ShowResult()
        {
            Console.Write("Please input num: ");

            var input = Console.ReadLine();
            var results = GetNumLines(input);

            if (results.Length == 0)
                return;

            else
            {
                foreach (var result in results)
                    Console.WriteLine(result);
            }
        }

        private static string[] GetNumLines(string str)
        {
            string[] results;
            int num;

            if (int.TryParse(str, out num) && num <= 30)
            {
                num += 1;
                results = new string[num];

                for (var i = 0; i < num; i++)
                {
                    var numstr = string.Empty;
                    var spacestr = string.Empty;

                    for (var j = 0; j < i; j++)
                        numstr += string.Format("{0, 2} ", i);

                    for (var j = 0; j < num - i; j++)
                        spacestr += "   ";

                    results[i] = spacestr + numstr + string.Format("{0, 2} ", i) + numstr + spacestr;
                }
            }

            else
                results = new string[0];

            return results;
        }
    }
}