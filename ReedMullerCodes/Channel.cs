﻿using System.Collections.Generic;

namespace ReedMullerCodes
{
    public class Channel
    {
        private readonly RandomNumberGenerator _generator;
        private readonly double _probability;
        public List<int> MistakesPositions;

        public Channel(double probability)
        {
            _probability = probability;
            _generator = new RandomNumberGenerator();
        }

        public List<int> SendVector(List<int> encodedVector)
        {
            MistakesPositions = new List<int>();
            var distortedVector = new List<int>(new int[encodedVector.Count]);
            for (int i = 0; i < encodedVector.Count; i++)
            {
                var randomNumber = _generator.GenerateDouble();
                if(randomNumber < _probability)
                {
                    if (encodedVector[i] == 0)
                    {
                        distortedVector[i] = 1;
                    }
                    else
                    {
                        distortedVector[i] = 0;
                    }

                    MistakesPositions.Add(i + 1);
                } else
                {
                    distortedVector[i] = encodedVector[i];
                }
            }
            return distortedVector;
        }
    }
}
