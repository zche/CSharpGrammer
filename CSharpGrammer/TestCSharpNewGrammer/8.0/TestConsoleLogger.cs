using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCSharpNewGrammer._8._0
{
    public class TestConsoleLogger : ITestLogger
    {
        public void TestLog(LogLevel level, string message)
        {
            Console.WriteLine($"输出错误级别以及错误消息：错误级别为：{level},错误消息为:{message}");
        }
        public void Log(Exception ex)
        {
            Console.WriteLine($"异常信息为：{ex.ToString()}");
        }
    }
}
