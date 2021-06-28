using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace KeLi.SkillPoint.App.Usages
{
    internal class PathUsage : IResult
    {
        public void ShowResult()
        {
            // Environment.CurrentDirectory: [BasePath]\KeLi.SkillPoint\KeLi.SkillPoint.App\bin\Debug
            Console.WriteLine("Environment.CurrentDirectory: " + Environment.CurrentDirectory);

            // Process.GetCurrentProcess().MainModule.FileName: [BasePath]\KeLi.SkillPoint\KeLi.SkillPoint.App\bin\Debug\KeLi.SkillPoint.App.exe
            Console.WriteLine("Process.GetCurrentProcess().MainModule.FileName: " + Process.GetCurrentProcess().MainModule?.FileName);

            // Application.ExecutablePath: [BasePath]\KeLi.SkillPoint\KeLi.SkillPoint.App\bin\Debug\KeLi.SkillPoint.App.exe
            Console.WriteLine("Application.ExecutablePath: " + Application.ExecutablePath);

            // Application.StartupPath: [BasePath]\KeLi.SkillPoint\KeLi.SkillPoint.App\bin\Debug
            Console.WriteLine("Application.StartupPath: " + Application.StartupPath);

            // Directory.GetCurrentDirectory(): [BasePath]\KeLi.SkillPoint\KeLi.SkillPoint.App\bin\Debug
            Console.WriteLine("Directory.GetCurrentDirectory(): " + Directory.GetCurrentDirectory());

            // AppDomain.CurrentDomain.BaseDirectory: [BasePath]\KeLi.SkillPoint\KeLi.SkillPoint.App\bin\Debug\
            Console.WriteLine("AppDomain.CurrentDomain.BaseDirectory: " + AppDomain.CurrentDomain.BaseDirectory);

            // AppDomain.CurrentDomain.SetupInformation.ApplicationBase: [BasePath]\KeLi.SkillPoint\KeLi.SkillPoint.App\bin\Debug\
            Console.WriteLine("AppDomain.CurrentDomain.SetupInformation.ApplicationBase: " + AppDomain.CurrentDomain.SetupInformation.ApplicationBase);

            // Assembly.GetExecutingAssembly().Location: [BasePath]\KeLi.SkillPoint\KeLi.SkillPoint.App\bin\Debug\KeLi.SkillPoint.Test.dll
            Console.WriteLine("Assembly.GetExecutingAssembly().Location: " + Assembly.GetExecutingAssembly().Location);
        }
    }
}