using System;

namespace datatypes
{
    public class MyClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // usage of the constructor
        public MyClass(string name, int age)
        {
            Name = name;
            Age = age;

        }

        // this is a non static method, it utilizes the state of specific object
        // static method will have direct access to the class
        public void DisplayDetails()
        {
            Console.WriteLine($"this is printing the constructor value, name: {Name}, age: {Age}");
        }
        // Overloaded method with int parameters
        public static int Add(int x, int y)
        {
            Console.WriteLine("Adding integers:");
            return x + y;
        }

        // Overloaded method with double parameters
        public static double Add(double x, double y)
        {
            Console.WriteLine("Adding doubles:");
            return x + y;
        }


    }
}
