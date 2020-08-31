using System;
using System.IO;

using KeLi.SkillPoint.App.Thinking;

using Newtonsoft.Json;

namespace KeLi.SkillPoint.App.Syntax
{
    public class JsonUsage : IResult
    {
        public void ShowResult()
        {
            var json = "{'Province': ['HeNan', 'HeBei', 'ShanDong', 'ShanXi', 'HuNan', 'HuBei', 'GuangXi', 'GuangDong']}";

            Console.WriteLine(Convert(json));
            Console.WriteLine();
        }

        private static string Convert(string json)
        {
            var js = new JsonSerializer();
            var result = json;

            using (var tr = new StringReader(json))
            {
                using (var jtr = new JsonTextReader(tr))
                {
                    var obj = js.Deserialize(jtr);

                    if (obj != null)
                    {
                        using (var sw = new StringWriter())
                        {
                            var jsonWriter = new JsonTextWriter(sw)
                            {
                                Formatting = Formatting.Indented,
                                Indentation = 4,
                                IndentChar = ' '
                            };

                            js.Serialize(jsonWriter, obj);
                            result = sw.ToString();
                        }
                    }
                }
            }

            return result;
        }
    }
}