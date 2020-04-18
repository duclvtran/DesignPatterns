using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ThreadSafeUpgradeInitialization
    {
        //double checked locking
        /*
         Mình tạm gọi nó là Thread Safe Upgrade initialization, thay vì chúng ta Thread Safe cả menthod getInstance() chúng ta chỉ Thread Safe một đoạn mã quan trong
        */
        private static ThreadSafeUpgradeInitialization _instance;

        private static object lockObject = new object();

        private ThreadSafeUpgradeInitialization()
        {
        }

        public ThreadSafeUpgradeInitialization GetInstance()
        {
            if (_instance == null)
            {
                lock (lockObject)
                {
                    _instance = new ThreadSafeUpgradeInitialization();
                }
            }
            return _instance;
        }
    }
}