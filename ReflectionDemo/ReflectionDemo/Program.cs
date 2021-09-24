using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            Type tt = t.GetType();

            Console.WriteLine("Name : "+tt.Name);
            Console.WriteLine("Full Name : " + tt.FullName);
            Console.WriteLine("Is Calss : " + tt.IsClass);
            Console.WriteLine("Is abstract : " + tt.IsAbstract);
            Console.WriteLine("Is interface : " + tt.IsInterface);
            Console.WriteLine();

            Console.Read();
        }
    }

    class Test
    {
        public int Id;
        public string Name;

        public void Details()
        {

        }


    }


}
