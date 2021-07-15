using System;
using System.Collections.Generic;

namespace KeLi.SkillPoint.App.Tests
{
    /// <summary>
    ///     Property study.
    /// </summary>
    internal class PropertyTest : IResult
    {
        /// <summary>
        ///     Readonly property, the class inner can modify it.
        /// </summary>
        internal static List<int> Uv1s { get; private set; }

        /// <summary>
        ///     Readonly property, no area can modify it.
        /// </summary>

        // ReSharper disable once UnassignedGetOnlyAutoProperty
        internal static List<int> Uv2s { get; }

        /// <summary>
        ///     Readonly property, the class inner can modify it.
        /// </summary>
        internal static List<int> Uv3s { get; private set; } = new List<int>();

        /// <summary>
        ///     Readonly property, init it and no area can modify it.
        /// </summary>
        internal static List<int> Uv4s { get; } = new List<int>();

        /// <summary>
        ///     Readonly property, init it and no area can modify it.
        /// </summary>
        internal static List<int> Uv5s => new List<int>();

        /// <summary>
        ///     Writeonly property, no area can read it.
        /// </summary>
        internal static List<int> Uv6s { private get; set; }

        /// <summary>
        ///     Writeonly property, init it and the class inner can read it.
        /// </summary>
        internal static List<int> Uv7s { private get; set; } = new List<int>();

        /// <summary>
        ///     It can get or set value.
        /// </summary>
        internal static List<int> Uv8s { get; set; }

        /// <summary>
        ///     It can get or set value and init value.
        /// </summary>
        internal static List<int> Uv9s { get; set; } = new List<int>();

        /// <summary>
        ///     Shows property result.
        /// </summary>
        public void ShowResult()
        {
            TestPropertyMyClass();
            PropertyTestClass.TestPropertyInOtherClass();
        }

        /// <summary>
        ///     Tests property in my class.
        /// </summary>
        internal static void TestPropertyMyClass()
        {
            Uv1s = new List<int>();

            // Uvs2 = new List<int>();
            Uv3s = new List<int>();

            // Uvs4 = new List<int>();
            // Uvs5 = new List<int>();
            Uv6s = new List<int>();
            Uv7s = new List<int>();
            Uv8s = new List<int>();
            Uv9s = new List<int>();

            Console.WriteLine(Uv1s);
            Console.WriteLine(Uv2s);
            Console.WriteLine(Uv3s);
            Console.WriteLine(Uv4s);
            Console.WriteLine(Uv5s);
            Console.WriteLine(Uv6s);
            Console.WriteLine(Uv7s);
            Console.WriteLine(Uv8s);
            Console.WriteLine(Uv9s);
        }
    }

    /// <summary>
    ///     Propery access test class.
    /// </summary>
    internal class PropertyTestClass
    {
        /// <summary>
        ///     Tests property in other class.
        /// </summary>
        internal static void TestPropertyInOtherClass()
        {
            // PropertyStudy.Uv1s = new List<int>();
            // PropertyStudy.Uv2s = new List<int>();
            // PropertyStudy.Uv3s = new List<int>();
            // PropertyStudy.Uv4s = new List<int>();
            // PropertyStudy.Uv5s = new List<int>();
            PropertyTest.Uv6s = new List<int>();
            PropertyTest.Uv7s = new List<int>();
            PropertyTest.Uv8s = new List<int>();
            PropertyTest.Uv9s = new List<int>();
            Console.WriteLine(PropertyTest.Uv1s);
            Console.WriteLine(PropertyTest.Uv2s);
            Console.WriteLine(PropertyTest.Uv3s);
            Console.WriteLine(PropertyTest.Uv4s);
            Console.WriteLine(PropertyTest.Uv5s);

            // Console.WriteLine(PropertyStudy.Uv6s);
            // Console.WriteLine(PropertyStudy.Uv7s);
            Console.WriteLine(PropertyTest.Uv8s);
            Console.WriteLine(PropertyTest.Uv9s);
        }
    }
}