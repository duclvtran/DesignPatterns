using DependencyInjectionPattern.Implement;
using DependencyInjectionPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern
{
    public class CheckOut
    {
        public void Run(int orderId, string body, string emailAddress)
        {
            // Nếu muốn thay đổi database, ta chỉ cần thay dòng code dưới
            // Các Module XMLDatabase, SQLDatabase phải implement IDatabase
            //IDatabase db = new XMLDatabase();
            //IDatebase db = new SQLDatabase();
            IDatabase db = new Database();
            db.Save(orderId);

            ILogger log = new Logger();
            log.LogInfo(body);

            IEmailSender es = new EmailSender();
            es.SendEmail(emailAddress);
        }
    }
}