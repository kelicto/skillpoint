using System;

using KeLi.SkillPoint.App.Thinking;

namespace KeLi.SkillPoint.App.Syntax
{
    public class BitOperator : IResult
    {
        public void ShowResult()
        {
            var a1 = 0b1;
            var a2 = 0b10;
            var status = a1 | a2;

            Console.WriteLine($"Start Status: {status}");
            Console.WriteLine("Do you want to remove the item a1?[Y/N]");

            // Method 1: using ~ operation and & operation.
            if (Console.ReadLine() == "Y")
                status &= ~a1;

            // Method 2: using ^ operation.
            if (Console.ReadLine() == "Y")
                status ^= a1;

            // Note 1: Bitwise logic operation is less than == operation on priority.
            // Note 2: Multiple bitwise logic operation  does not affect the result.

            if ((status & a1) == 0)
                Console.WriteLine("The item a1 is removed.");

            Console.WriteLine($"Current Status: {status}");

            // Method 1: using % operation.
            if (status % 2 == 1)
                Console.WriteLine("The number is odd number.");

            else
                Console.WriteLine("The number is even number.");

            // Method 2: using & operation.
            if ((status & 1) == 1)
                Console.WriteLine("Current Status is odd number.");

            else
                Console.WriteLine("Current Status is even number.");

            Console.ReadLine();
        }
    }
}