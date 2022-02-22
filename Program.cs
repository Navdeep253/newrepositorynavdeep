using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(string);

            foreach(MethodInfo m in  t.GetMethods())
            {
              
                Console.WriteLine(m.Name);
            }
        }
    }
}
