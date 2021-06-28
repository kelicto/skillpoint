using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeLi.SkillPoint.App.Usages
{
    internal class RegexProblem : IResult
    {
        public void ShowResult()
        {
            CreateMaxNameNum("[Hello]-1", "-", new[] { "[Hello]-1", "[Hello]", "(Hello)-3" });
            MatchNums("333abc");
            ContainsBirthday("19221123");
        }

        internal static List<int> MatchNums(string testStr)
        {
            return Regex.Matches(testStr, @"\d+").Cast<Match>().Select(s => int.Parse(s.Value)).ToList();
        }

        internal static bool ContainsBirthday(string pwd)
        {
            var reg1 = new Regex(@"\d{4}");
            var reg2 = new Regex(@"\d{3}");
            var reg3 = new Regex(@"\d{2}");

            var m1 = reg1.IsMatch(pwd) && !reg1.Match(pwd).Value.Contains("000");
            var m2 = reg2.IsMatch(pwd) && !reg2.Match(pwd).Value.Contains("00");
            var m3 = reg3.IsMatch(pwd) && !reg3.Match(pwd).Value.Contains("0");

            return m1 || m2 || m3;
        }

        internal static string CreateMaxNameNum(string viewName, string seperateChar, string[] viewNames)
        {
            var baseReg = new Regex($@"^(.+){seperateChar}(\d+)$");
            var rawViewName = viewName;

            if (baseReg.IsMatch(viewName))
            {
                // Group length is 3, first item is ifself.
                rawViewName = baseReg.Match(viewName).Groups[1].Value;
            }

            if (!viewNames.Any(v => v == rawViewName))
                return rawViewName;

            var mainPattern = rawViewName.Replace("(", @"\(");

            mainPattern = mainPattern.Replace(")", @"\)");
            mainPattern = mainPattern.Replace("[", @"\[");
            mainPattern = mainPattern.Replace("]", @"\]");

            var newRegex = new Regex($@"^({mainPattern}){seperateChar}(\d+)$");
            var patternNames = viewNames.Where(w => newRegex.IsMatch(w));
            var maxNum = patternNames.Select(s => newRegex.Match(s).Groups[2].Value).Max(Convert.ToInt32);
            var result = $"{rawViewName}{seperateChar}1";

            return maxNum == 0 ? result : Regex.Replace(result, @"\d+$", (maxNum + 1).ToString());
        }
    }
}