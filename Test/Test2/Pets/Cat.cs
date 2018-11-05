using System;

namespace Test2.Pets
{
    public class Cat : IPet
    {
        private PetColor Color { get; }

        public Cat(PetColor color)
        {
            Color = color;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Color} cat says meow!");
        }
    }
}