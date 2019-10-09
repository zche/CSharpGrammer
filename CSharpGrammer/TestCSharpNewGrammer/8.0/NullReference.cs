using System;
using System.Collections.Generic;
using System.Text;

namespace TestCSharpNewGrammer._8._0
{
    public class NullReference
    {
        string S1 => null; // 产生警告: 对不可空引用类型赋值 null

        int? A => null;

        string? S => null ;

#nullable enable
        string? S2 => null; // Ok
       

        public void TestNullReferrence()
        {
            Console.WriteLine(S2.Length);
            Console.WriteLine(S1.Length);
            if (S1 != null)
            {
                Console.WriteLine(S1.Length); // Ok
            }
        }
    }
}
