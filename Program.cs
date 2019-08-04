using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = FeetToInches(30);
            Console.WriteLine(x);
            
        }

        static int FeetToInches(int feet) {
            int inches = feet * 12;
            return inches;
        }
    }
}
