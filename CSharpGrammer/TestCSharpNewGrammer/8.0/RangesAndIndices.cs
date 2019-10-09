using System;
using System.Collections.Generic;
using System.Text;

namespace TestCSharpNewGrammer._8._0
{
    public class RangesAndIndices
    {
        Index i1 => 3;  // 下标为 3
        Index i2 => ^4; // 倒数第 4 个元素
        int[] a => new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void TestIndices()
        {
            Console.WriteLine($"输出集合中两个下标的值：{a[i1]}, {a[i2]}"); // "3, 6"
        }

        public void TestRanges()
        {
            var slice = a[i1..i2]; // { 3, 4, 5 }
            Console.WriteLine("输出左闭右开范围的值为：");
            foreach (var item in slice)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
