// using System.Linq.Expressions;
using datatypes;
using dataypes;

namespace Main
{
    class Program
    {
        public static void Main()
        {
            Hello test = new Hello();
            test.findElement();
            test.AddingList();
            test.TestFunction();
            test.Conditional();
            test.SwitchCase();
            test.forLoop();
            test.forEachLoop();
            test.whileLoop();
            test.BreakContinue();
            test.ImplicitConversion();
            test.ExplicitConversion();
            test.ConversionMethods();
            test.List();

            // MyClass myclass = new MyClass();
            int sumInt = MyClass.Add(1, 5);
            double sumDouble = MyClass.Add(1.5, 2.5);

            Console.WriteLine($"Sum of integers: {sumInt}");
            Console.WriteLine($"Sum of doubles: {sumDouble}");

            // for Access Modifiers
            AccessModifiers accessmodifiers = new AccessModifiers("Biralo", "Dog");
            Animal animal = new Animal("Biralo", "Lucy");
            Console.WriteLine("Printing cat and dog names");
            animal.PrintNames();
            animal.OverrideExample();

            // try catch
            Exceptions exceptions = new Exceptions(12);
            exceptions.TryCatch();
            exceptions.Throw();
            exceptions.ArgumentEx();

            // interfaces
            Rectangle rect = new Rectangle();
            Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");

        }
    }
}
