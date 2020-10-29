using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Syntax
{
    internal class XmlUsage : IResult
    {
        public void ShowResult()
        {
            SerializeA();
            SerializeB();
            SerializeC();

            Console.WriteLine(DeserializeA().Count);
            Console.WriteLine(DeserializeB().Apps.Count);
            Console.WriteLine(DeserializeC().Count);
        }

        private static List<Apple> GetApples()
        {
            return new List<Apple>
            {
                new Apple("Apple 1000", 1000),
                new Apple("Apple 900", 900),
                new Apple("Apple 800", 800),
                new Apple("Apple 700", 700),
                new Apple("Apple 600", 600),
                new Apple("Apple 500", 500),
                new Apple("Apple 400", 400),
                new Apple("Apple 300", 300),
                new Apple("Apple 200", 200),
                new Apple("Apple 100", 100)
            };
        }

        private static void SerializeA()
        {
            using (var fs = new FileStream("Apple1.xml", FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                    new XmlSerializer(typeof(List<Apple>)).Serialize(sw, GetApples());
            }
        }

        private static void SerializeB()
        {
            var apps = new Apples(GetApples());

            using (var fs = new FileStream("Apple2.xml", FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                    new XmlSerializer(typeof(Apples)).Serialize(sw, apps);
            }
        }

        private static void SerializeC()
        {
            var xao = new XmlAttributeOverrides();

            xao.Add(typeof(List<Apple>), new XmlAttributes { XmlRoot = new XmlRootAttribute(Resources.Apples) });

            using (var fs = new FileStream("Apple3.xml", FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    var xs = new XmlSerializer(typeof(List<Apple>), xao);
                    var namespaces = new XmlSerializerNamespaces();

                    namespaces.Add(Resources.XsdKey, Resources.XsdValue);
                    namespaces.Add(Resources.XsiKey, Resources.XsiValue);
                    xs.Serialize(sw, GetApples(), namespaces);
                }
            }
        }

        private static List<Apple> DeserializeA()
        {
            using (var fs = new FileStream("Apple1.xml", FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                    return new XmlSerializer(typeof(List<Apple>)).Deserialize(sr) as List<Apple>;
            }
        }

        private static Apples DeserializeB()
        {
            using (var fs = new FileStream("Apple2.xml", FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                    return new XmlSerializer(typeof(Apples)).Deserialize(sr) as Apples;
            }
        }

        private static List<Apple> DeserializeC()
        {
            using (var fs = new FileStream("Apple3.xml", FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    var xml = sr.ReadToEnd();
                    var node1 = Resources.ApplesNode;
                    var node2 = Resources.ArrayOfAppleNode;

                    xml = xml.Replace(node1, node2);
                    xml = xml.Replace(Resources.ApplesNodeEnd, Resources.ArrayOfAppleNodeEnd);

                    var ms = new MemoryStream(Encoding.ASCII.GetBytes(xml));
                    var xs = new XmlSerializer(typeof(List<Apple>));

                    return xs.Deserialize(ms) as List<Apple>;
                }
            }
        }

        [XmlRoot("Apples")]
        internal class Apples
        {
            internal Apples()
            {
                Apps = new List<Apple>();
            }

            internal Apples(List<Apple> apps)
            {
                Apps = apps;
            }

            [XmlArrayItem("Apple")]
            internal List<Apple> Apps { get; set; }
        }

        internal class Apple
        {
            internal Apple()
            {
            }

            internal Apple(string category, double price)
            {
                Category = category;
                Price = price;
            }

            internal string Category { get; set; }

            internal double Price { get; set; }
        }
    }
}