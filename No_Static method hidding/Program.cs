using System;

namespace No_Static_method_hidding
{
    class MyClass
    {
        public  void name()
        {
            Console.WriteLine("Hello :");
        }
        public void show()
        {
            name();
            Console.WriteLine("No static methid :");
        }
    }
    class Program:MyClass
    {
        public  new void show()
        {
            base.show();
            
            Console.WriteLine("No Static Method Hidding :");
        }
        static void Main(string[] args)
        {
           MyClass obj = new Program();
            obj.show();
        }
    }
}
