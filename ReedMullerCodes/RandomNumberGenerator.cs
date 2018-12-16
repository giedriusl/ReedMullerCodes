using System;

namespace ReedMullerCodes
{
    public class RandomNumberGenerator
    {
        private readonly Random _random;
        
        public RandomNumberGenerator()
        {
            _random = new Random();
        }

        public double GenerateDouble()
        {
            return _random.NextDouble();
        }
    }
}
