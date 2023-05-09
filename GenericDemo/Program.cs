using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Program
    {
        //Generic means general form
        //it does not contain any datatype or not specific to any datatype
        //we use placeholder <> this is angle bracket with type name 
        // TypeName<T> T is your type(DataType)Parameter
        //Genric allows us to create single class or method that can be used with different datatype
        //Advantage- We can reuse our code
        static void Main(string[] args)
        {
            GenericClass<int> genericClass = new GenericClass<int>(45);
            GenericClass<double> genericClass1 = new GenericClass<double>(45.5);
            GenericClass<string> generic = new GenericClass<string>("Raj");
            generic.Demo("Reena");
            genericClass1.Demo(12.5);
            genericClass.Demo(60);

            generic.Test<string>("N");
            genericClass.Test(455.5);
            Console.ReadLine();
        }
    }
}
