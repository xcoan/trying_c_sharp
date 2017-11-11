using System;

namespace LearnDotNet
{
    class TestClass 
    {
        // User input String
        String myString;

        // Constructor
        public TestClass(string inputString) 
        {
            myString = inputString;
        }

        public void printString()
        {
            Console.WriteLine("You entered: ");
            Console.WriteLine(myString);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input String: ");
            String userInput = Console.ReadLine();
            TestClass testClass = new TestClass(userInput);
            testClass.printString();
        }
    }
}
