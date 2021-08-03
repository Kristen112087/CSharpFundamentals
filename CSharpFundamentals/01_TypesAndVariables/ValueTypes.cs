using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {

            // PascalCapitalization - all words uppercase
            // camelCase - first word lower case, every word after that uppercase (C#)

            // Declared bool (bool-variable type) (value-declared) (unassigned, have to assign in next line)
            bool declared;

            // Assigning value
            declared = true;

            bool declareAndInitialized = false;

            // Can still assign value after initial assignment
            declareAndInitialized = true;

        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n'; // drops to the next line when opened
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteMin = 0;
            byte byteMax = 255;
            short shortMin = -32768;
            short shortMax = 32767;
            int intMin = -2147483648;
            int intMax = 2147483647;
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;
            int a = 15;
            int b = -2;
        }

        [TestMethod]
        public void Decimals()
        {
            // Float numbers need an 'f' at the end - precice up to 6 digits
            float floatExample = 1.29294894f;
           
            // Suffix option for doubles - 'd' means explicit (default is a double)
            double doubleExample = 1.74929474748d;
            
            // Decimal numbers need an 'm' at the end - most precice but takes more memory
            decimal decimalExample = 1.2548696548746324m;
        }
        // Collection of types, needs to be outside the method, so its available to all the code(methods), no spaces
        enum PastryType { Cake, Cupcake, Eclaire, PetitFour, Croissant };

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType yourPastry = PastryType.PetitFour;
        }

        [TestMethod]
        public void Structs() // Structured Data
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1972, 4, 3);
        }
    }
}
