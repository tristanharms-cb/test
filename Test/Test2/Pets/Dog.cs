using System;

namespace Test2.Pets
{
    public class Dog: IPet
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}