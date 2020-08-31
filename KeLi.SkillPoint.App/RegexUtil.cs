using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeLi.SkillPoint.App.Common
{
    public class RegexUtil
    {
        public static List<int> GetNums(string str)
        {
            return Regex.Matches(str, @"\d+").Cast<Match>().Select(s => int.Parse(s.Value)).ToList();
        }

        public static bool ContainsBirthday(string pwd)
        {
            var reg1 = new Regex(@"\d{4}");
            var reg2 = new Regex(@"\d{3}");
            var reg3 = new Regex(@"\d{2}");

            var m1 = reg1.IsMatch(pwd) && !reg1.Match(pwd).Value.Contains("000");
            var m2 = reg2.IsMatch(pwd) && !reg2.Match(pwd).Value.Contains("00");
            var m3 = reg3.IsMatch(pwd) && !reg3.Match(pwd).Value.Contains("0");

            return m1 || m2 || m3;
        }
    }
}