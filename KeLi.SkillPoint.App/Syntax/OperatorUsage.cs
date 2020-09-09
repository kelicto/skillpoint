using System;

namespace KeLi.SkillPoint.App.Syntax
{
    public class OperatorUsage : IResult
    {
        public void ShowResult()
        {
            var a = new Student(80, 70);
            var b = new Student(85, 83);
            var c = a + b;

            Console.WriteLine(c);
        }

        public class Student
        {
            public Student(int chinese, int math)
            {
                Chinese = chinese;
                Math = math;
            }

            public int Chinese { get; set; }

            public int Math { get; set; }

            public static Student operator +(Student a, Student b)
            {
                return new Student(a.Chinese + b.Chinese, a.Math + b.Math);
            }

            public static implicit operator int(Student s)
            {
                return s.Chinese + s.Math;
            }
        }
    }
}