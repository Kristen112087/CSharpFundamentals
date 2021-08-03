using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string declared;

            declared = "This is initialized";

            string declaredAndInitialized = "This is both declared and initialized";

            string firstName = "Kristen";
            string lastName = "Gamelin";

            // Concatenation
            string concatenatedFullName = firstName + " " + lastName; //shows up as - Kristen Gamelin

            // Composit Format
            string compositeFormatting = string.Format("{0} {1}", firstName, lastName);

            // Interpolation
            string interpolatedFormatting = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFormatting);
            Console.WriteLine(interpolatedFormatting);

        }

        [TestMethod]
        public void Collections()
        {
            // Arrays
            string greeting = "Greetings";

            string[] stringArray = { "Hello", "Hi", "Goodbye" , greeting };

                 // 3 items         // index starts with 0, so you want number2
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            // Re-assigned 2nd item as Good Morning
            stringArray[2] = "Good Morning";
            Console.WriteLine(stringArray[2]);

            // Lists
            List<string> listOfString = new List<string>();
            List<int> listOfInts = new List<int>();

            listOfString.Add("Here's a string");
            listOfString.Add("2545678");

            listOfInts.Add(7);

            // Queue's - FIFO
            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("i'm first");
            firstInFirstOut.Enqueue("i'm next");

            Console.WriteLine(firstInFirstOut.Peek());

            firstInFirstOut.Dequeue();

            Console.WriteLine(firstInFirstOut.Peek());

            // Stacks
            // Stacks last object added is first object returned
            Stack<string> firstInLastOut = new Stack<string>();

            firstInLastOut.Push("I'm a bun");
            firstInLastOut.Push("I'm a meat");
            firstInLastOut.Push("I'm a top bun");

            Console.WriteLine(firstInLastOut.Peek());


            // Dictionaries - 
            // Key Value Pair
            // Key    Value
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>(); ;

            keyAndValue.Add(7, "Agent");

            string atSeven = keyAndValue[7];

            Dictionary<string, string> dictionaryDefinition = new Dictionary<string, string>();

            dictionaryDefinition.Add("Duck", "It quacks");

            string definitionOfDuck = dictionaryDefinition["Duck"];

            Console.WriteLine(definitionOfDuck);

        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();

            Console.WriteLine(randomNumber);

        }

    }
}
