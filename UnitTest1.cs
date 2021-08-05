using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace UnitTestCurrencyConverter
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestClearControls()
        {
            var test = new UnitTest1();

            
        }
        
        
        // Function to test for Positive Integers with zero inclusive  
        public bool IsWholeNumber(String strNumber)
        {
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strNumber);
        }

	}
}