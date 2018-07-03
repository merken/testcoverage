namespace calculation
{
    public class Subtraction : ICalculation
    {
        private readonly decimal x;
        private readonly decimal y;

        public Subtraction(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        public decimal Calculate()
        {
            return x - y;
        }
    }
}