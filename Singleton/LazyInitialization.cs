using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class LazyInitialization
    {
        /*
         Cách này đã khắc phục được nhược điểm của cách 1 Eager initialization, chỉ khi nào geInstance được gọi thì instance mới được khởi tạo. Tuy nhiên cách này chỉ sử dụng tốt trong trường hợp đơn luồng, trường hợp nếu có 2 luồng cùng chạy và cùng gọi hàm getInstance tại cùng một thời điểm thì đương nhiên chúng ta có ít nhất 2 thể hiện của instance. Vậy ta phải làm sao với trường hợp đa luồng. chúng ta đi tới cách tiếp theo
         */
        private static LazyInitialization _instance;

        private LazyInitialization()
        {
        }

        public static LazyInitialization GetInstance()
        {
            if (_instance == null)
                _instance = new LazyInitialization();

            return _instance;
        }
    }
}