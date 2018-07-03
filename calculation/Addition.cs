using System;

namespace calculation
{
    public class Addition : ICalculation
    {
        private readonly decimal x;
        private readonly decimal y;

        public Addition(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        public decimal Calculate()
        {
            return x + y;
        }
    }
}
