using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void Comparision()
        {
            int age = 25;
            string username = "Joshua";

            // Equal comparison
            bool equals = age == 41;
            bool userIsAdam = username == "Adam";

            // Inequals Comparison
            bool notEqual = age != 112;
            bool userIsNotJustin = username == "Justin";

            // Not all things are equal, reference types arent understood the same way
            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool isEqual = firstList == secondList;

            bool greaterThan = age > 12;
            bool greaterThanOrEquals = age >= 24;
            bool lessThan = age < 66;
            bool lessThanOrEqual = age <= 24;

        }

        [TestMethod]
        public void AndOr()
        {
            bool trueValue = true;
            bool falseValue = false;

            // Or ||
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrF = falseValue || falseValue;

            // And &&
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndF = falseValue && falseValue;


        }
    }
}
