using System;

namespace inheritance
{
    public class Animal
    {
        public void eat() { Console.WriteLine("Eating"); }
    }


    class TestInheritance2
    {
        public static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.eat();
            d1.bark();
        }
    }
}
