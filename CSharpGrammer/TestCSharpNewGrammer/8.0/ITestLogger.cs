using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCSharpNewGrammer._8._0
{
    public interface ITestLogger
    {
        void TestLog(LogLevel level, string message);
        void TestLog(Exception ex) => TestLog(LogLevel.Error, ex.ToString()); // 这是一个默认实现重载
    }
}
