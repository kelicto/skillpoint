using System;
using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Syntax
{
    public class DelegateTest
    {
        public static void ShowResult()
        {
            var alarm = new Alarm();
            var dog = new Dog();

            dog.WatchAlarm(alarm);
        }

        public class Alarm
        {
            public delegate void AlarmHandler(object sender, EventArgs e);

            public Alarm()
            {
                Console.WriteLine("Alarm");
                Console.WriteLine();
            }

            public event AlarmHandler AlarmHandlerEvent;

            public void OnAlarm()
            {
                if (AlarmHandlerEvent == null)
                    return;

                Console.WriteLine("OnAlarm");
                Console.WriteLine();

                AlarmHandlerEvent.Invoke(this, new EventArgs());
            }
        }

        public class Dog
        {
            public Dog()
            {
                Console.WriteLine("Dog");
                Console.WriteLine();
            }

            public void WatchAlarm(Alarm alarm)
            {
                alarm.AlarmHandlerEvent += Alarm_AlarmHandlerEvent;

                while (true)
                {
                    if (DateTime.Now.Second == 10)
                    {
                        alarm.OnAlarm();
                        break;
                    }

                    Console.WriteLine(Resources.TimePass);
                    Console.WriteLine();
                }
            }

            private static void Alarm_AlarmHandlerEvent(object sender, EventArgs e)
            {
                Console.WriteLine("Alarm_AlarmHandlerEvent");
                Console.WriteLine();
            }
        }
    }
}