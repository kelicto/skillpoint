﻿/*
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

using System.Collections.Generic;
using System.Linq;

namespace KeLi.SkillPoint.App.Arithmetic
{
    public class GroupingUsage
    {
        private static double Lvl => 3.0;

        public static void ShowResult()
        {
            // Gives you a num array.
            var keys = new List<double> { 1, 3, 2, 8, 9, 11, 6, 18 };

            for (var i = 0; i < keys.Count; i++)
            {
                for (var j = i + 1; j < keys.Count; j++)
                {
                    if (!(keys[j] < keys[i]))
                        continue;

                    var temp = keys[j];
                    keys[j] = keys[i];
                    keys[i] = temp;
                }
            }

            // This is current index's value.
            var index = 0;

            // Group dictionary.
            var nums = new Dictionary<int, List<double>>();

            for (var i = 0; i < keys.Max() / Lvl + 1; i++)
            {
                for (var j = index; j < keys.Count; j++)
                {
                    if (keys[j] >= keys.Min() + Lvl * i && keys[j] <= keys.Min() + Lvl * (i + 1))
                    {
                        if (nums.ContainsKey(i))
                        {
                            var temps = nums[i];

                            temps.Add(keys[j]);
                            nums[i] = temps;
                        }
                        else
                            nums.Add(i, new List<double> { keys[j] });
                    }
                    else
                    {
                        index = j;
                        break;
                    }
                }
            }

            // Adjacent group's elements to handle logic problem.
            for (var i = 0; i < nums.Keys.Count - 1; i++)
            {
                var lnis = nums[i];
                var lnjs = nums[i + 1];

                foreach (var lni in lnis)
                {
                    foreach (var lnj in lnjs)
                    {
                        // ...
                    }
                }
            }
        }
    }
}