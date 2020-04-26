using System;

namespace PracticeSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Big smelly!");

            int num = 5;
            Console.WriteLine(num);
            int num2 = 10;
            Console.WriteLine(num2);



            string yourName;
            Console.WriteLine("What's your name?");
            yourName = Console.ReadLine();

            Console.WriteLine("Hello" + "{0}", yourName);
          
        }
    }
}
