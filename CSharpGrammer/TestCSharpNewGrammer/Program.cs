using System;
using TestCSharpNewGrammer._7._2;
using TestCSharpNewGrammer._8._0;
using TestCSharpNewGrammer.DTOs;

namespace TestCSharpNewGrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            //RangesAndIndices rangesAndIndices = new RangesAndIndices();
            //rangesAndIndices.TestIndices();
            //rangesAndIndices.TestRanges();

            //ITestLogger testLogger = new TestConsoleLogger();
            //testLogger.TestLog(new Exception("这是一个测试的异常！"));

            //PatternsMatch patternsMatch = new PatternsMatch();
            //Rectangle rectangle = new Rectangle { Height = 2, Width = 3 };
            //var area = patternsMatch.GetArea(rectangle);
            //Console.WriteLine($"返回的面积为：{area}");
            //var lstNames = patternsMatch.GetEnrollees();
            //foreach (var item in lstNames)
            //{
            //    Console.WriteLine($"返回的学生有：{item}");
            //}
            //NullReference nullReference = new NullReference();
            //nullReference.TestNullReferrence();
            TestSpan testSpan = new TestSpan();
            testSpan.TestArrayWithSpan();
            testSpan.TestStringWithSpan();
            Console.ReadLine();
        }

    }
}
