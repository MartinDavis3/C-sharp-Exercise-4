using System;

namespace C_sharp_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            userInput = ObtainUserInput();
            string modText;
            modText = AddPostSmiley(userInput);
            modText = AddPreSadFace(modText);
            WriteOutput(modText);
        }
        static string ObtainUserInput()
        {
            Console.WriteLine("Enter your line:");
            return Console.ReadLine();
        }
        static string AddPostSmiley(string passedText)
        {
            return passedText + ":)";
        }
        static string AddPreSadFace(string passedText)
        {
            return ":(" + passedText;
        }
        static void WriteOutput(string passedText)
        {
            Console.WriteLine("Modified line:");
            Console.WriteLine(passedText);
        }
    }
}
