using System;
using System.Collections.Generic;
using System.Dynamic;

namespace KeLi.SkillPoint.App.Syntax
{
    public class DynamicDictionary : DynamicObject
    {
        private readonly Dictionary<string, object> _dict  = new Dictionary<string, object>();

        public int Count => _dict.Count;

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return _dict.TryGetValue(binder.Name.ToLower(), out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            _dict[binder.Name.ToLower()] = value;

            return true;
        }

        public static void ShowResult()
        {
            TestExpandoObject();
            TestDynamicObject();
        }

        public static void TestExpandoObject()
        {
            dynamic dyn = new ExpandoObject();

            dyn.Number = 20;
            dyn.Method = new Func<int, string>(i => (i + 20).ToString());

            Console.WriteLine(dyn.Number);
            Console.WriteLine(dyn.Method(dyn.Number));
        }

        public static void TestDynamicObject()
        {
            dynamic person = new DynamicDictionary();

            person.FirstName = "Ellen";
            person.LastName = "Adams";

            Console.WriteLine(person.firstname + " " + person.lastname);
        }
    }
}
