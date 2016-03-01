using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        /*
         *  Your Mission....
         *  -----------------
         *  
         *  Create a STRING CALCULATOR that takes a delimited set of numbers and returns the sum.
         *  
         *  E.g. "2,4,9" = 15!
         *  
         *  Complete the mission by making the tests go GREEN!
         * 
         *  Aside from the standard functionality you should try to:
         *  
         *  - Allow any delimiter to be used, not just a comma
         *  - Ignore any numbers more than 100
         *  - Return 0 if a non numeric value is entered
         *  - Throw a custom exception if the first 7 numbers match the Fibonacci Sequence
         *  
         *  DON'T WORRY if you can't complete all tests!
         * 
         */

        [Test]
        public void Calculate_EmptyString_ReturnsZero()
        {
            //e.g. "" = 0
            Assert.IsTrue(false);
        }

        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_SingleNumber_ReturnsSameNumber()
        {
            //e.g. "1" = 1
        }

        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_TwoNumbers_ReturnsSum()
        {
            //e.g. "1,2" = 3
        }
        

        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_FiveNumbers_ReturnsSum()
        {
            //e.g. "1,2,3,4,5" = 15
        }


        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_CanUseAlternativeDelimiters_ReturnsSum()
        {
            //e.g. "1|2|3" = 6
        }

        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_NumbersLargerThan100_IgnoresOver100sInSum()
        {
            //e.g. "1,2,100" = 3
        }

        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_NonNumericValue_ReturnsZero()
        {
            //e.g. "1,Elephant,6" = 0
        }

        [Test]
        [Ignore("complete previous test first")]
        public void Calculate_FirstSevenInFibonacciSequence_ThrowsCustomFibonacciAlertException()
        {
            //e.g. "0,1,1,2,3,5,8" = FibonacciAlertException!
        }

    }
}
