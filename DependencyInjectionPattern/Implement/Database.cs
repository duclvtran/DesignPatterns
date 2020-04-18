using DependencyInjectionPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Implement
{
    public class Database : IDatabase
    {
        public void Save(int OrderId)
        {
            Console.WriteLine("OrderId = " + OrderId);
        }
    }
}