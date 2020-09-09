using System;
using System.Threading;

using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Syntax
{
    public class SemaphoreUsage : IResult
    {
        private static readonly Semaphore Semaphore = new Semaphore(5, 15);

        public void ShowResult()
        {
            for (var i = 0; i < 10; i++)
            {
                var td = new ParameterizedThreadStart(GoBathroom);

                new Thread(td).Start(string.Format(Resources.SuNo, i));
            }
        }

        private static void GoBathroom(object obj)
        {
            Semaphore.WaitOne();
            Console.WriteLine(Resources.SuTime, obj, DateTime.Now);
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.WriteLine(Resources.SuTime, obj, DateTime.Now);
            Console.WriteLine();
            Semaphore.Release();
        }
    }
}