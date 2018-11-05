using Test2.Pets;

namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPet blackTabby = new Cat(PetColor.Black);
            blackTabby.MakeSound();
        }
    }
}