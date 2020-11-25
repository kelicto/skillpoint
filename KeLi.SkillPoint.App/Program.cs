using System;

using KeLi.SkillPoint.App.Arithmetic;
using KeLi.SkillPoint.App.Syntax;
using KeLi.SkillPoint.App.Thinking;

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
            const string test = "Hello, world!";

            if (test.Length > 10)
                Console.WriteLine(">10.");

            else
                Console.WriteLine("<=10");
        }

        internal static void ShowArithmetic()
        {
            new DataExchange().ShowResult();
            new GroupingUsage().ShowResult();
            new LineRelationship().ShowResult();
            new NumSum().ShowResult();
            new NumPyramid().ShowResult();
        }

        internal static void ShowSyntax()
        {
            new RegexStudy().ShowResult();
            new PropertyStudy().ShowResult();
            new ListStruct().ShowResult();
            new DynamicDictionary().ShowResult();
            new SemaphoreUsage().ShowResult();
            new XmlUsage().ShowResult();
            new FuncDelegation().ShowResult();
            new CustomerFormat().ShowResult();
            new JsonUsage().ShowResult();
            new ParameterType().ShowResult();
            new HashcodeUsage().ShowResult();
            new OperatorUsage().ShowResult();
            new DelegateTest().ShowResult();
        }

        internal static void ShowThinking()
        {
            new DoubleDanger().ShowResult();
            new DoublePerformanceTest().ShowResult();
            new HashCodeThinking().ShowResult();
            new LinqQueryPerformanceTest().ShowResult();
            new PathUtil().ShowResult();
            new BitOperator().ShowResult();
            new TeacherData().ShowResult();
            new ConfigRw().ShowResult();
            new DataTableLoading().ShowResult();
            new LogUsage().ShowResult();
            new EndianUsage().ShowResult();
            new FibonacciSequence().ShowResult();
            new LinqThinking().ShowResult();
            new LoopUsage().ShowResult();
            new PriorityUsage().ShowResult();
            new UvSort().ShowResult();
            new XyzThinking().ShowResult();
        }
    }
}