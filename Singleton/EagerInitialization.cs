using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class EagerInitialization
    {
        /*
        Đây là cách dễ nhất nhưng nó có một nhược điểm là mặc dù instance đã được khởi tạo nhưng có thể sẽ không dùng tới. vì vậy chúng ta có cách thứ 2
        */
        private static readonly EagerInitialization _instance = new EagerInitialization();
        private int numberOfInstances = 0;

        private EagerInitialization()
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            numberOfInstances++;
            Console.WriteLine("Number of instances ={0}", numberOfInstances);
        }

        public static EagerInitialization GetInstance
        {
            get
            {
                Console.WriteLine("We already have an instance now.Use it.");
                return _instance;
            }
        }
    }
}