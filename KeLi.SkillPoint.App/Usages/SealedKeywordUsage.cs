using System;

namespace KeLi.SkillPoint.App.Usages
{
    internal class SealedKeywordUsage
    {
        private class A
        {
            protected virtual string Name { get; set; }

            protected virtual void DoSth()
            {
                Console.WriteLine("Hello, A!");
            }
        }

        // 'sealed' keyword to protect class 'B' and don't override members.
        private sealed class B : A
        {
            protected override string Name { get; set; }

            // The 'sealed' keyword be used to protect overrided method.
            protected override void DoSth()
            {
                Console.WriteLine("Hello, B!");
            }
        }
    }
}