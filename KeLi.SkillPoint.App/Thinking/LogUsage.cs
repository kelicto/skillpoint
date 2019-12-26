using System;
using System.IO;
using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Thinking
{
    public class LogUsage
    {
        public static void ShowResult()
        {
            for (var i = 0; i < 100; i++)
                WriteLog(i);
        }

        private static void WriteLog(object context)
        {
            if (!Directory.Exists(Resources.ConnectLog))
                Directory.CreateDirectory(Resources.ConnectLog);

            var filePath = Path.Combine(Resources.ConnectLog, DateTime.Now.ToString(Resources.TimeFormat));

            using (var fs = new FileStream(filePath, FileMode.Append))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine("[" + DateTime.Now.ToString(Resources.ExactPartTimeFormat) + "]" + context);
                sw.WriteLine();
            }
        }
    }
}