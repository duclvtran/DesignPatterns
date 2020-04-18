using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public string ModelName { get; set; }
        public int Price { get; set; }

        public static int SetPrice()
        {
            int price = 0;
            Random r = new Random();
            int p = r.Next(200000, 500000);
            price = p;
            return price;
        }

        public abstract BasicCar Clone();
    }

    public class Nano : BasicCar
    {
        public Nano(string m)
        {
            ModelName = m;
        }

        public override BasicCar Clone()
        {
            return (Nano)this.MemberwiseClone();//shallow Clone
        }
    }

    public class Ford : BasicCar
    {
        public Ford(string m)
        {
            ModelName = m;
        }

        public override BasicCar Clone()
        {
            return (Ford)this.MemberwiseClone();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //=====================Cach 1===========================
            //Console.WriteLine("***Prototype Pattern Demo***\n");

            ////Base or Original Copy
            //BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };
            //BasicCar ford_base = new Ford("Ford Yellow") { Price = 500000 };

            //BasicCar bc1;
            ////Nano
            //bc1 = nano_base.Clone();
            //bc1.Price = nano_base.Price + BasicCar.SetPrice();
            //Console.WriteLine("Car is: {0}, and it's price is Rs. {1}",
            //                    bc1.ModelName,
            //                    bc1.Price);

            ////Ford
            //bc1 = ford_base.Clone();
            //bc1.Price = ford_base.Price + BasicCar.SetPrice();
            //Console.WriteLine("Car is: {0}, and it's price is Rs. {1}",
            //                    bc1.ModelName,
            //                    bc1.Price);
            //Console.ReadLine();

            //=====================Cach 2: CopyConstructor===========================
            Console.WriteLine("***A simple copy constructor demo***\n");
            Student student1 = new Student(1, "John");

            Console.WriteLine("The details of student1 is as follows:");
            student1.DisplayDetails();

            Console.WriteLine("\nCopying student1 to student2 now");
            Student student2 = new Student(student1);

            Console.WriteLine("The details of student2 is as follows:");
            student2.DisplayDetails();

            Console.ReadKey();
        }
    }
}