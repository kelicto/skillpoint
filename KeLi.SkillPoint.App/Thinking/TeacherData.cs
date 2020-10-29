using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace KeLi.SkillPoint.App.Thinking
{
    internal class TeacherData : IResult
    {
        public void ShowResult()
        {
            foreach (var tm in GetTeacherModels())
            {
                foreach (var classroom in tm.Classrooms)
                {
                    foreach (var student in tm.Students.Where(w => w.ClassroomId == classroom.ClassroomId))
                        Console.WriteLine(tm.TeacherId + "\t" + classroom.ClassroomName + "\t" + student.StudentName);
                }
            }
        }

        internal static TeacherModelCollection GetTeacherModels()
        {
            var cc1 = new ClassroomInfoCollection
            {
                new ClassroomInfo("101", "Room 101"),
                new ClassroomInfo("102", "Room 102"),
                new ClassroomInfo("103", "Room 103")
            };

            var cc2 = new ClassroomInfoCollection
            {
                new ClassroomInfo("201", "Room 201"),
                new ClassroomInfo("202", "Room 202"),
                new ClassroomInfo("203", "Room 203")
            };

            var cc3 = new ClassroomInfoCollection
            {
                new ClassroomInfo("301", "Room 301"),
                new ClassroomInfo("302", "Room 302"),
                new ClassroomInfo("303", "Room 303")
            };

            var sc1 = new StudentInfoCollection
            {
                new StudentInfo("s101", "s101", "101"),
                new StudentInfo("s102", "s102", "102"),
                new StudentInfo("s103", "s103", "103"),
                new StudentInfo("s104", "s104", "101"),
                new StudentInfo("s105", "s105", "102"),
                new StudentInfo("s106", "s106", "103")
            };

            var sc2 = new StudentInfoCollection
            {
                new StudentInfo("s201", "s201", "201"),
                new StudentInfo("s202", "s202", "202"),
                new StudentInfo("s203", "s203", "203"),
                new StudentInfo("s204", "s204", "201"),
                new StudentInfo("s205", "s205", "202"),
                new StudentInfo("s206", "s206", "203")
            };

            var sc3 = new StudentInfoCollection
            {
                new StudentInfo("s301", "s301", "301"),
                new StudentInfo("s302", "s302", "302"),
                new StudentInfo("s303", "s303", "303"),
                new StudentInfo("s304", "s304", "301"),
                new StudentInfo("s305", "s305", "302"),
                new StudentInfo("s306", "s306", "303")
            };

            var tc = new TeacherInfoCollection
            {
                new TeacherInfo("t101", "t101", cc1),
                new TeacherInfo("t102", "t102", cc2),
                new TeacherInfo("t103", "t103", cc3)
            };

            return new TeacherModelCollection
            {
                new TeacherModel(tc[0].TeacherId, cc1, sc1),
                new TeacherModel(tc[1].TeacherId, cc2, sc2),
                new TeacherModel(tc[2].TeacherId, cc3, sc3)
            };
        }
    }

    internal class TeacherModelCollection : KeyedCollection<string, TeacherModel>
    {
        protected override string GetKeyForItem(TeacherModel item)
        {
            return item.TeacherId;
        }
    }

    internal class TeacherModel
    {
        internal TeacherModel(string teacherId, ClassroomInfoCollection classrooms, StudentInfoCollection students)
        {
            TeacherId = teacherId;
            Classrooms = classrooms;
            Students = students;
        }

        internal string TeacherId { get; set; }

        internal ClassroomInfoCollection Classrooms { get; set; }

        internal StudentInfoCollection Students { get; set; }
    }

    internal class StudentInfoCollection : KeyedCollection<string, StudentInfo>
    {
        protected override string GetKeyForItem(StudentInfo item)
        {
            return item.StudentId;
        }
    }

    internal class TeacherInfoCollection : KeyedCollection<string, TeacherInfo>
    {
        protected override string GetKeyForItem(TeacherInfo item)
        {
            return item.TeacherId;
        }
    }

    internal class ClassroomInfoCollection : KeyedCollection<string, ClassroomInfo>
    {
        protected override string GetKeyForItem(ClassroomInfo item)
        {
            return item.ClassroomId;
        }
    }

    internal class StudentInfo
    {
        internal StudentInfo(string studentId, string studentName, string classroomId)
        {
            StudentId = studentId;
            StudentName = studentName;
            ClassroomId = classroomId;
        }

        internal string StudentId { get; set; }

        internal string StudentName { get; set; }

        internal string ClassroomId { get; set; }
    }

    internal class TeacherInfo
    {
        internal TeacherInfo(string teacherId, string teacherName, ClassroomInfoCollection belongClassrooms)
        {
            TeacherId = teacherId;
            TeacherName = teacherName;
            BelongClassrooms = belongClassrooms;
        }

        internal string TeacherId { get; set; }

        internal string TeacherName { get; set; }

        internal ClassroomInfoCollection BelongClassrooms { get; set; }
    }

    internal class ClassroomInfo
    {
        internal ClassroomInfo(string classroomId, string classroomName)
        {
            ClassroomId = classroomId;
            ClassroomName = classroomName;
        }

        internal string ClassroomId { get; set; }

        internal string ClassroomName { get; set; }
    }
}