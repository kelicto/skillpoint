using System;

using KeLi.SkillPoint.App.Arithmetic;
using KeLi.SkillPoint.App.Syntax;
using KeLi.SkillPoint.App.Thinking;

namespace KeLi.SkillPoint.App
{
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Skill Point";
            Console.WindowWidth = 100;
            Console.WindowHeight = 25;

            try
            {
                TestDemo();
                ShowArithmetic();
                ShowSyntax();
                ShowThinking();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message: " + ex.Message);
                Console.WriteLine("Stack Message: " + ex.StackTrace);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static void TestDemo()
        {
            Console.ReadKey();
        }

        public static void ShowArithmetic()
        {
            new DataExchange().ShowResult();
            new GroupingUsage().ShowResult();
            new LineRelationship().ShowResult();
            new NumSum().ShowResult();
            new NumPyramid().ShowResult();
        }

        public static void ShowSyntax()
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

        public static void ShowThinking()
        {
            new DoublePerformanceTest().ShowResult();
            new HashCodeThinking().ShowResult();
            new LinqQuery().ShowResult();
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