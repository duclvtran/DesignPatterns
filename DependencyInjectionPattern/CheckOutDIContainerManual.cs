using DependencyInjectionPattern.Implement;
using DependencyInjectionPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
    public class CheckOutDIContainerManual
    {
        private readonly IDatabase _db;
        private readonly IEmailSender _es;
        private readonly ILogger _log;

        public CheckOutDIContainerManual()
        {
            _db = DIContainer.GetModule<IDatabase>();
            _es = DIContainer.GetModule<IEmailSender>();
            _log = DIContainer.GetModule<ILogger>();
        }

        public void Run(int orderId, string body, string emailAddress)
        {
            _db.Save(orderId);
            _es.SendEmail(body);
            _log.LogInfo(emailAddress);
        }
    }
}