using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ThreadSafeInitialization
    {
        // double checked locking
        /*
         Cách đơn gảin nhất là chúng ta gọi phương thức synchronized của hàm getInstance() và như vậy hệ thống đảm bảo rằng tại cùng một thời điểm chỉ có thể có 1 luồng có thể truy cập vào hàm getInstance(), và đảm bảo rằng chỉ có duy nhất 1 thể hiện của class Tuy nhiên một menthod synchronized sẽ chạy rất chậm và tốn hiệu năng vì vậy chúng ta cần cải tiến nó đi 1 chút
        */
        private static ThreadSafeInitialization _instance;

        private static Object lockObject = new Object();

        private ThreadSafeInitialization()
        {
        }

        public static ThreadSafeInitialization GetInstance()
        {
            lock (lockObject)
            {
                if (_instance == null)
                {
                    _instance = new ThreadSafeInitialization();
                }
            }
            return _instance;
        }
    }
}