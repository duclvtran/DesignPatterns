using DependencyInjectionPattern.Implement;
using DependencyInjectionPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
    public class CheckOutDIContainerC
    {
        private readonly IDatabase _db;
        private readonly IEmailSender _es;
        private readonly ILogger _log;

        public CheckOutDIContainerC(IDatabase db, IEmailSender es, ILogger log)
        {
            _db = db;
            _es = es;
            _log = log;
        }

        public void Run(int orderId, string body, string emailAddress)
        {
            _db.Save(orderId);
            _es.SendEmail(body);
            _log.LogInfo(emailAddress);
        }
    }
}