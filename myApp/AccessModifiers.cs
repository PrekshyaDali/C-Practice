using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Contracts;
using dataypes;

namespace dataypes
{
    public class AccessModifiers
    {

        protected string CatName { get; set; }
        protected string DogName { get; set; }
        // defining for car names
        // this can only be used within same class
        private string model = "Mustang";


        public AccessModifiers(string catname, string dogname)
        {
            CatName = catname;
            DogName = dogname;
        }

        // using the non static method
        public void PrintNames()
        {
            Console.WriteLine($"My cat name is {CatName} and My dog name is {DogName}");

        }

        public virtual void OverrideExample(){
            Console.WriteLine("This is the virtual method");
        }

        // this is a nonstatic 
        public void PrintModel()
        {
            Console.WriteLine($"this {model} is very expensive");
        }



    }
    public class Animal : AccessModifiers
    {
        public override void OverrideExample()
        {
            Console.WriteLine("This is the override portion by derived class");
        }

        public Animal(string catname, string dogname)
            : base(catname, dogname)
        {

        }

        public void AccessBaseMembers()
        {
            Console.WriteLine($"I am accessing catname from base : {CatName}");
            Console.WriteLine($"I am accessing dogname from base: {DogName}");
        }

    }

}




