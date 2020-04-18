using ServiceLocatorPattern.Implement;
using ServiceLocatorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ServiceLocator.Instance.Register<IDatabase>(new Database());
            ServiceLocator.Instance.Register<IEmailSender>(new EmailSender());
            ServiceLocator.Instance.Register<ILogger>(new Logger());

            CheckOut check = new CheckOut();
            check.Run();
        }
    }
}