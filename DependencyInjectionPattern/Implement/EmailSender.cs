using DependencyInjectionPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Implement
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string emailAddress)
        {
            Console.WriteLine("Email = " + emailAddress);
        }
    }
}