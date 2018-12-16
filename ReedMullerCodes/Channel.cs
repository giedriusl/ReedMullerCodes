using System.Collections.Generic;

namespace ReedMullerCodes
{
    public class Channel
    {
        private readonly RandomNumberGenerator _generator;
        private readonly double _probability;
        public readonly List<int> MistakesPositions;

        public Channel(double probability)
        {
            _probability = probability;
            _generator = new RandomNumberGenerator();
            MistakesPositions = new List<int>();
        }

        public List<int> SendVector(List<int> encodedVector)
        {
            var distortedVector = new List<int>();
            for (int i = 0; i < encodedVector.Count; i++)
            {
                var randomNumber = _generator.GenerateDouble();
                if(randomNumber < _probability)
                {
                    MistakesPositions.Add(encodedVector[i]);
                    if (encodedVector[i] == 0)
                    {
                        distortedVector[i] = 1;
                    }
                    else
                    {
                        distortedVector[i] = 0;
                    }

                    MistakesPositions.Add(i);
                } else
                {
                    distortedVector[i] = encodedVector[i];
                }
            }
            return distortedVector;
        }
    }
}
