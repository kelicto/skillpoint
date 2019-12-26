/*
 * MIT License
 *
 * Copyright(c) 2019 kelicto
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

/*
			 ,---------------------------------------------------,              ,---------,
		,----------------------------------------------------------,          ,"        ,"|
	  ,"                                                         ,"|        ,"        ,"  |
	 +----------------------------------------------------------+  |      ,"        ,"    |
	 |  .----------------------------------------------------.  |  |     +---------+      |
	 |  | C:\>FILE -INFO                                     |  |  |     | -==----'|      |
	 |  |                                                    |  |  |     |         |      |
	 |  |                                                    |  |  |/----|`---=    |      |
	 |  |                 Author: kelicto                    |  |  |     |         |      |
	 |  |                 Email: kelistudy@163.com           |  |  |     |         |      |
	 |  |                 Creation Time: 10/21/2019 10:34:05 PM |  |  |     |         |      |
	 |  | C:\>_                                              |  |  |     | -==----'|      |
	 |  |                                                    |  |  |   ,/|==== ooo |      ;
	 |  |                                                    |  |  |  // |(((( [66]|    ,"
	 |  `----------------------------------------------------'  |," .;'| |((((     |  ,"
	 +----------------------------------------------------------+  ;;  | |         |,"
		/_)_________________________________________________(_/  //'   | +---------+
		   ___________________________/___  `,
		  /  oooooooooooooooo  .o.  oooo /,   \,"-----------
		 / ==ooooooooooooooo==.o.  ooo= //   ,`\--{)B     ,"
		/_==__==========__==_ooo__ooo=_/'   /___________,"
*/

using System;
using System.Collections.Generic;

namespace KeLi.SkillPoint.App.Thinking
{
    /// <summary>
    /// Property study.
    /// </summary>
    public class PropertyStudy
    {
        /// <summary>
        /// Readonly property, the class inner can modify it.
        /// </summary>
        public static List<int> Uvs1 { get; private set; }

        /// <summary>
        /// Readonly property, no area can modify it.
        /// </summary>
        public static List<int> Uvs2 { get; }

        /// <summary>
        /// Readonly property, the class inner can modify it.
        /// </summary>
        public static List<int> Uvs3 { get; private set; } = new List<int>();

        /// <summary>
        /// Readonly property, init it and no area can modify it.
        /// </summary>
        public static List<int> Uvs4 { get; } = new List<int>();

        /// <summary>
        /// Readonly property, init it and no area can modify it.
        /// </summary>
        public static List<int> Uvs5 => new List<int>();

        /// <summary>
        /// Writeonly property, no area can read it.
        /// </summary>
        public static List<int> Uvs6 { private get; set; }

        /// <summary>
        /// Writeonly property, init it and the class inner can read it.
        /// </summary>
        public static List<int> Uvs7 { private get; set; } = new List<int>();

        /// <summary>
        /// It can get or set value.
        /// </summary>
        public static List<int> Uvs8 { get; set; }

        /// <summary>
        /// It can get or set value and init value.
        /// </summary>
        public static List<int> Uvs9 { get; set; } = new List<int>();

        /// <summary>
        /// Tests property in my class.
        /// </summary>
        public static void TestPropertyMyClass()
        {
            Uvs1 = new List<int>();
            // Uvs2 = new List<int>();
            Uvs3 = new List<int>();
            // Uvs4 = new List<int>();
            // Uvs5 = new List<int>();
            Uvs6 = new List<int>();
            Uvs7 = new List<int>();
            Uvs8 = new List<int>();
            Uvs9 = new List<int>();

            Console.WriteLine(Uvs1);
            Console.WriteLine(Uvs2);
            Console.WriteLine(Uvs3);
            Console.WriteLine(Uvs4);
            Console.WriteLine(Uvs5);
            Console.WriteLine(Uvs6);
            Console.WriteLine(Uvs7);
            Console.WriteLine(Uvs8);
            Console.WriteLine(Uvs9);
        }

        /// <summary>
        /// Shows property result.
        /// </summary>
        public static void ShowResult()
        {
            TestPropertyMyClass();
            PropertyTestClass.TestPropertyInOtherClass();
        }
    }

    /// <summary>
    /// Propery access test class.
    /// </summary>
    public class PropertyTestClass
    {
        /// <summary>
        /// Tests property in other class.
        /// </summary>
        public static void TestPropertyInOtherClass()
        {
            // PropertyStudy.Uvs1 = new List<int>();
            // PropertyStudy.Uvs2 = new List<int>();
            // PropertyStudy.Uvs3 = new List<int>();
            // PropertyStudy.Uvs4 = new List<int>();
            // PropertyStudy.Uvs5 = new List<int>();
            PropertyStudy.Uvs6 = new List<int>();
            PropertyStudy.Uvs7 = new List<int>();
            PropertyStudy.Uvs8 = new List<int>();
            PropertyStudy.Uvs9 = new List<int>();
            Console.WriteLine(PropertyStudy.Uvs1);
            Console.WriteLine(PropertyStudy.Uvs2);
            Console.WriteLine(PropertyStudy.Uvs3);
            Console.WriteLine(PropertyStudy.Uvs4);
            Console.WriteLine(PropertyStudy.Uvs5);
            // Console.WriteLine(PropertyStudy.Uvs6);
            // Console.WriteLine(PropertyStudy.Uvs7);
            Console.WriteLine(PropertyStudy.Uvs8);
            Console.WriteLine(PropertyStudy.Uvs9);
        }
    }
}