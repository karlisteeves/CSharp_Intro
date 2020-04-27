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




            //ReadLine is supposed to take a user's input and apply it. It's not working for me for some reason...
            //ReadLine method always returns a string. We must convert anything that's not a string, like int or double,
           //with Convert.ToInt16/32/64. 
            string yourName;
            Console.WriteLine("What's your name?");
            yourName = Console.ReadLine();

            Console.WriteLine("Hello" + "{0}", yourName);

            int age = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("You are {0} years old", age);

            int favNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your favorite number is {0}", favNum);
//this is a test

        }
    }
}
