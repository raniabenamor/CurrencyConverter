using System;

namespace UnitTestCurrencyConverter
{
    internal class InlineDataAttribute : Attribute
    {
        private double v1;
        private string v2;

        public InlineDataAttribute(double v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}