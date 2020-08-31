using System;

using KeLi.SkillPoint.App.Thinking;

namespace KeLi.SkillPoint.App.Syntax
{
    public class CustomerFormat : IResult, IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider provider)
        {
            var formattable = arg as IFormattable;
            string result;

            switch (format)
            {
                case "US":
                    result = "$" + arg;

                    break;

                case "CN":
                    result = "￥" + arg;

                    break;

                case null:
                    result = formattable?.ToString(null, provider) ?? arg.ToString();

                    break;

                default:
                    result = formattable?.ToString(null, provider) ?? arg.ToString();

                    break;
            }

            return result;
        }

        public object GetFormat(Type format)
        {
            if (format == typeof(ICustomFormatter))
                return this;

            return null;
        }

        public void ShowResult()
        {
            var mf = new CustomerFormat();

            Console.WriteLine("Custom US" + string.Format(mf, "{0:US}", 10));
            Console.WriteLine();
            Console.WriteLine("Custom CN" + string.Format(mf, "{0:CN}", 10));
            Console.WriteLine();
        }
    }
}