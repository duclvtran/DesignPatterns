using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        /*
        1. Làm sao để 1 class chỉ có thể có duy nhất 1instance? Trả lời
          -Private constructor của class đó để đảm bảo rằng class lớp khác không thể truy cập vào constructor và tạo ra instance mới
          -Tạo một biến private static là thể hiện của class đó để đảm bảo rằng nó là duy nhất và chỉ được tạo ra trong class đó thôi.
        2. Làm sao để có thể ccung cấp một cáchs toàn cầu để truy cấp tới instance đó.Trả lời
        -Tạo một public static menthod trả về instance vừa khởi tạo bên trên, đây là cách duy nhất để các class khác có thể truy cập vào instance của class này
        */

        private static void Main(string[] args)
        {
            //Truong hop: EagerInitialization
            Console.WriteLine("***Singleton Pattern Demo***\n");

            Console.WriteLine("Trying to create instance s1.");
            EagerInitialization s1 = EagerInitialization.GetInstance;

            Console.WriteLine("Trying to create instance s2.");
            EagerInitialization s2 = EagerInitialization.GetInstance;

            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }

            Console.Read();

            //Truong hop: LazyInitialization
        }
    }
}