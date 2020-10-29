using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeLi.SkillPoint.App.Syntax
{
    internal class SealedKeywordUsage
    {
        private class A
        {
            protected virtual void DoSth()
            {
                // Some code...
            }

            protected virtual string Name { get; set; }
        }

        private sealed class B : A
        {
            // The 'sealed' keyword be used to protect overrided method.
            protected sealed override void DoSth()
            {
                base.DoSth();
            }

            protected sealed override string Name { get; set; }
        }

        // 'C' cannot derive from sealed type 'B'.
        // private class C : B
        // {
        //     // 'C.DoSth()' cannot override inherited member 'B.DoSth()', because it is sealed.
        //     // protected sealed override void DoSth()
        //     // {
        //     //     base.DoSth();
        //     // }
        //
        //     // 'C.Name' cannot override inherited member 'B.Name', because it is sealed.
        //     // protected sealed override string Name { get; set; }
        // }
    }
}
