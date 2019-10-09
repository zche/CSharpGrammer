using System;
using System.Collections.Generic;
using System.Text;
using TestCSharpNewGrammer.DTOs;

namespace TestCSharpNewGrammer._8._0
{
    public class PatternsMatch
    {
        public List<Student> Students { get; set; } = new List<Student> { new Student { Graduated = true, Name = "check" }, new Student { Graduated = false, Name = "emmy" } };
        public IEnumerable<string> GetEnrollees()
        {
            foreach (var p in Students)
            {
                if (p is Student { Graduated: false, Name: string name })
                {
                    Console.WriteLine($"");
                    yield return name;
                }
            }
        }

        public double GetArea(Graphics figure)
        {
            var area = figure switch
            {
                Line _ => 0,
                Rectangle r => r.Width * r.Height,
                Circle c => c.Radius * 2.0 * Math.PI,
                _ => throw new Exception("没找到合适的类型！！")
            };
            return area;
        }
    }
}
