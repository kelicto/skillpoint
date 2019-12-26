using System;
using KeLi.SkillPoint.App.Arithmetic;
using KeLi.SkillPoint.App.Syntax;
using KeLi.SkillPoint.App.Thinking;
using KeLi.SkillPoint.Test;

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
            DataExchange.ShowResult();
            GroupingUsage.ShowResult();
            LineRelationship.ShowResult();
            NumSum.ShowResult();
            NumPyramid.ShowResult();
        }

        public static void ShowSyntax()
        {
            PropertyStudy.ShowResult();
            ListStruct.ShowResult();
            DynamicDictionary.ShowResult();
            SemaphoreUsage.ShowResult();
            XmlUsage.ShowResult();
            FuncDelegation.ShowResult();
            CustomerFormat.ShowResult();
            JsonUsage.ShowResult();
            ParameterType.ShowResult();
            HashcodeUsage.ShowResult();
            OperatorUsage.ShowResult();
            DelegateTest.ShowResult();
        }

        public static void ShowThinking()
        {
            PathUtil.ShowResult();
            BitOperator.ShowResult();
            TeacherData.ShowResult();
            ConfigRw.ShowResult();
            DtLoading.ShowResult();
            LogUsage.ShowResult();
            EndianUsage.ShowResult();
            FibonacciSequence.ShowResult();
            LinqThinking.ShowResult();
            LoopUsage.ShowResult();
            PriorityUsage.ShowResult();
            UvSort.ShowResult();
            XyzThinking.ShowResult();
        }
    }
}