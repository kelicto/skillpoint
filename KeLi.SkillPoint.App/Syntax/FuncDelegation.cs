using System;

using KeLi.SkillPoint.App.Thinking;

namespace KeLi.SkillPoint.App.Syntax
{
    public class FuncDelegation : IResult
    {
        public void ShowResult()
        {
            Console.WriteLine(ToBool(null, true));
            Console.WriteLine();
            Console.WriteLine(ToInt(null, -1));
            Console.WriteLine();
            Console.WriteLine(ToDouble(null, -1));
            Console.WriteLine();
            Console.WriteLine(ToDecimal(null, -1));
            Console.WriteLine();
        }

        private static bool ToBool(object obj, bool flag)
        {
            return ConvertValue(obj, f =>
            {
                bool.TryParse(obj.ToString(), out flag);

                return flag;
            }, flag);
        }

        private static int ToInt(object obj, int num)
        {
            return ConvertValue(obj, f =>
            {
                int.TryParse(obj.ToString(), out num);

                return num;
            }, num);
        }

        private static double ToDouble(object obj, double num)
        {
            return ConvertValue(obj, f =>
            {
                double.TryParse(obj.ToString(), out num);

                return num;
            }, num);
        }

        private static decimal ToDecimal(object obj, decimal num)
        {
            return ConvertValue(obj, f =>
            {
                decimal.TryParse(obj.ToString(), out num);

                return num;
            }, num);
        }

        private static T ConvertValue<T>(object obj, Func<object, T> func, T t)
        {
            return HasValue(obj) ? func.Invoke(obj) : t;
        }

        private static bool HasValue(object obj)
        {
            bool result;

            if (obj == null)
                result = false;

            else if (obj == DBNull.Value)
                result = false;

            else if (string.IsNullOrWhiteSpace(obj.ToString()))
                result = false;

            else
                result = true;

            return result;
        }
    }
}