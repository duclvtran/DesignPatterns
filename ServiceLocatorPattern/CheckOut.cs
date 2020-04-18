using ServiceLocatorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    public class CheckOut
    {
        private readonly IDatabase _db;
        private readonly IEmailSender _es;
        private readonly ILogger _log;

        public CheckOut()
        {
            _db = ServiceLocator.Instance.GetService<IDatabase>();
            _es = ServiceLocator.Instance.GetService<IEmailSender>();
            _log = ServiceLocator.Instance.GetService<ILogger>();
        }

        public void Run()
        {
            _db.Save(123);
            _es.SendEmail("linhvu.vn@gmail.com");
            _log.LogInfo("ServiceLocator");
        }
    }
}