using System;
using System.IO;
using System.Linq;
using System.Xml;

using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Thinking
{
    internal class ConfigRw : IResult
    {
        public void ShowResult()
        {
            WriteConfig(Resources.CrErrorConnStr);

            Console.WriteLine(Resources.CrErrorConnStr);

            WriteConfig(Resources.CrErrorConnStr);

            Console.WriteLine(Resources.CrRightConnStr);
        }

        private static void WriteConfig(string content)
        {
            var xd = new XmlDocument();
            var path = Path.Combine(Environment.CurrentDirectory, Resources.ConfigPath);

            xd.Load(path);

            var node = xd.DocumentElement;

            if (node == null)
                return;

            foreach (var childNode in node.ChildNodes.Cast<XmlNode>().Where(w => w.Name == Resources.ConnStrValueName))
            {
                if (childNode.FirstChild.Attributes != null)
                    childNode.FirstChild.Attributes[Resources.ConnStrValueName].Value = content;

                xd.Save(path);

                break;
            }
        }
    }
}