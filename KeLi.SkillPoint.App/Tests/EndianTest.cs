using System;

namespace KeLi.SkillPoint.App.Tests
{
    internal class EndianTest : IResult
    {
        public void ShowResult()
        {
            var chts = BitConverter.GetBytes(0x1020);
            var endian = chts[0] == 0x10 ? "BigEndian" : "LittleEndian";

            Console.WriteLine(endian);
            Console.WriteLine();
        }
    }
}