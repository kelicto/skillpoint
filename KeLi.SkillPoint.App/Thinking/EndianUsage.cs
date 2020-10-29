using System;

using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Thinking
{
    internal class EndianUsage : IResult
    {
        public void ShowResult()
        {
            var chts = BitConverter.GetBytes(0x1020);
            var endian = chts[0] == 0x10 ? Resources.BigEndian : Resources.LittleEndian;

            Console.WriteLine(endian);
            Console.WriteLine();
        }
    }
}