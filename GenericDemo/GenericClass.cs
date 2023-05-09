using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class GenericClass<T>
    {
        //Varaible of type T
        public T data;
        //The Generic Constructor
        public GenericClass(T data)
        {
            this.data = data;
            Console.WriteLine("Data:"+this.data);
        }

        public void Demo(T data)
        {
            Console.WriteLine("Data:"+data);
        }
        public void Test<T>(T data)
        {
            Console.WriteLine("Data:" + data);
        }
    }
}
