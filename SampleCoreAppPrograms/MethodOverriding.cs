using System;
namespace SampleCoreApp
{
    class BaseClass
    {
        public virtual void SomeFunc()
        {
            Console.WriteLine("Base class function");
        }
    }

    class DerivedClass : BaseClass
    {
        //2 ways: Retain the existing functionality and add few more...
        //Completely reimplement the functionality. 
        public override void SomeFunc()
        {
            base.SomeFunc();
            //base is the keyword in C# to represent the current class's immediate base class. 
            Console.WriteLine("adding few more features");
        }
    }
    class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            //Substitution principle...
            BaseClass instance = new DerivedClass();//Runtime polymorphism
            instance.SomeFunc();//It will invoke the derive version...
        }
    }
}