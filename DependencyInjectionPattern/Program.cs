using DependencyInjectionPattern.Implement;
using DependencyInjectionPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Với mỗi Interface, ta define một Module tương ứng
            DIContainer.SetModule<IDatabase, Database>();
            DIContainer.SetModule<ILogger, Logger>();
            DIContainer.SetModule<IEmailSender, EmailSender>();

            //Console.WriteLine("======================");
            //CheckOut checkout = new CheckOut();
            //checkout.Run(123, "CheckOut", "linhvu.vn@gmail.com");

            //Console.WriteLine("======================");
            //CheckOutDIContainer checkout1 = new CheckOutDIContainer();
            //checkout1.Run(123, "CheckOutDIContainer", "linhvu.vn@gmail.com");

            //Console.WriteLine("======================");
            //CheckOutDIContainerManual checkout2 = new CheckOutDIContainerManual();
            //checkout2.Run(123, "CheckOutDIContainerManual", "linhvu.vn@gmail.com");
        }
    }
}