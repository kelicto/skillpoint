using System;

namespace KeLi.SkillPoint.App
{
    internal class Program
    {
        internal static void Main()
        {
            Console.Title = "Skill Point";
            Console.WindowWidth = 100;
            Console.WindowHeight = 25;

            try
            {
                TestDemo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }

        internal static void TestDemo()
        {
        }
    }
}