using System;
using System.Collections.Generic;
using System.Linq;

using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Thinking
{
    public class LinqThinking : IResult
    {
        public void ShowResult()
        {
            SearchData();
            DestroySearch();
        }

        public static void SearchData()
        {
            var names = GetNames();

            // Deferred query.
            var name1S = from n in names where n.StartsWith("J") orderby n select n;

            // Deferred query.
            var name2S = names.Where(n => n.StartsWith("J"));

            // Query now.
            var name3S = names.FindAll(n => n.StartsWith("J"));

            names.Add(Resources.John);
            names.Add(Resources.Jim);
            names.Add(Resources.Jack);
            names.Add(Resources.Denny);

            // Cans get now data.
            name1S.ToList().ForEach(Console.WriteLine);

            // Cans get now data.
            name2S.ToList().ForEach(Console.WriteLine);

            // Not can get now data.
            name3S.ToList().ForEach(Console.WriteLine);
        }

        public static void DestroySearch()
        {
            var names = GetNames();

            // Deferred query.
            var name1S = from n in names where n.StartsWith("J") orderby n select n;

            // Deferred query is destroyed.
            var name2S = names.Where(n => n.StartsWith("J")).ToList();

            // Query now.
            var name3S = names.FindAll(n => n.StartsWith("J"));

            // Object Transfer, destroy delayed queries
            var namels = new List<string>();

            names = namels;
            names.Add(Resources.John);
            names.Add(Resources.Jim);
            names.Add(Resources.Jack);
            names.Add(Resources.Denny);

            name1S.ToList().ForEach(Console.WriteLine);
            name2S.ToList().ForEach(Console.WriteLine);
            name3S.ToList().ForEach(Console.WriteLine);
        }

        private static List<string> GetNames()
        {
            return new List<string> { Resources.Nino, Resources.Juan, Resources.Mike, Resources.Phil };
        }
    }
}