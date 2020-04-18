using DependencyInjectionPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Implement
{
    public class Logger : ILogger
    {
        public void LogInfo(string body)
        {
            Console.WriteLine("Body = " + body);
        }
    }
}