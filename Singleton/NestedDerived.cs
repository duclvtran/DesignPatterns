using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //public sealed class Singleton
    //Not using "sealed" keyword now
    public sealed class SingletonNestedDerived
    {
        private static readonly SingletonNestedDerived _instance = new SingletonNestedDerived();
        private static int numberOfInstances = 0;

        //Private constructor is used to prevent
        //creation of instances with 'new' keyword outside this class
        //protected Singleton()
        private SingletonNestedDerived()
        {
            Console.WriteLine("Instantiating inside the private constructor.");

            numberOfInstances++;
            Console.WriteLine("Number of instances ={0}", numberOfInstances);
        }

        public static SingletonNestedDerived Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now.Use it.");
                return _instance;
            }
        }

        //The keyword "sealed" can guard this scenario.
        //public class NestedDerived : SingletonNestedDerived { }
    }
}