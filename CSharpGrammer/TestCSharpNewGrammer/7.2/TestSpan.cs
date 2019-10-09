using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestCSharpNewGrammer._7._2
{
    public class TestSpan
    {
        public void TestArrayWithSpan()
        {
            var array = new byte[10];
            Span<byte> bytes = array;
            bytes = bytes.Slice(start: 2, length: 5);

            bytes[0] = 5;
            Console.WriteLine("用Span：");
            Console.WriteLine(array[2]);
            Console.WriteLine(bytes[0]);
        }

        public void TestStringWithSpan()
        {
            var text = "https://walterlv.github.io/";
            //这种方式取出字符串替代了 SubString 这种会额外生成临时字符串的方式。
            //如果上述代码发生在较大或较多文本的处理中，那么反复的拼接将生成大量的临时字符串，造成大量 GC 压力；
            //而使用 Span<T> 将不会额外生成任何临时字符串。
            var nameSpan = text.AsSpan(8, 8);

            var builder = new StringBuilder("Hello ");
            builder.Append(nameSpan);
            builder.AppendLine("!");

            Console.WriteLine(builder.ToString());
        }

    }
}
