using System;

using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Syntax
{
    internal class DelegateTest : IResult
    {
        public void ShowResult()
        {
            var alarm = new Alarm();
            var dog = new Dog();

            dog.WatchAlarm(alarm);
        }

        internal class Alarm
        {
            internal delegate void AlarmHandler(object sender, EventArgs e);

            internal Alarm()
            {
                Console.WriteLine("Alarm");
                Console.WriteLine();
            }

            internal event AlarmHandler AlarmHandlerEvent;

            internal void OnAlarm()
            {
                if (AlarmHandlerEvent == null)
                    return;

                Console.WriteLine("OnAlarm");
                Console.WriteLine();

                AlarmHandlerEvent.Invoke(this, new EventArgs());
            }
        }

        internal class Dog
        {
            internal Dog()
            {
                Console.WriteLine("Dog");
                Console.WriteLine();
            }

            internal void WatchAlarm(Alarm alarm)
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