using System;
using System.Collections.Generic;
using System.Linq;

namespace ReedMullerCodes
{
    public class Decoder
    {
        private List<List<int>> w;
        private List<int> wt;
        private int m;
        private int r;
        private int[,] matrix;
        private List<string> bytes;
        private List<int> finalVotes;
        int votesCounted;

        public Decoder(int m, int r, int[,] matrix)
        {
            votesCounted = 0;
            this.m = m;
            this.r = r;
            this.matrix = matrix;
        }

        public List<int> Decode(List<int> encodedVector)
        {
            votesCounted = 0;
            w = new List<List<int>>();
            wt = new List<int>();
            finalVotes = new List<int>();

            var decodedVector = GetVotes(encodedVector);

            decodedVector.Reverse();

            return decodedVector;
        }


        /// <summary>
        /// Gauna visus koeficientus kurie yra pradinis vektorius
        /// </summary>
        /// <param name="encodedVector"></param>
        /// <returns></returns>
        private List<int> GetVotes(List<int> encodedVector)
        {
            var n = (int)Math.Pow(2, m);
            var rows = m.CountCombination(r);
            bytes = BytesCounter.GetBytes(n, m);

            for (int i = r; i >= 0; i--)
            {
                if (i == 0)
                {
                    w = new List<List<int>>();
                    for (int h = 0; h < n; h++)
                    {
                        wt = new List<int>();
                        for (int j = 0; j < n - 1; j++)
                        {
                            wt.Add(0);
                        }
                        wt.Insert(h, 1);
                        w.Add(wt);
                    }
                    CalculateDominantVote(n, encodedVector);
                }

                else
                {
                    int positionsMissingCount = m - i;
                    var missingPositionsList = GetMissingPossitionsList(positionsMissingCount);

                    var tList = BytesCounter.GetBytes((int)Math.Pow(2, positionsMissingCount), positionsMissingCount);

                    foreach (var missingPosition in missingPositionsList)
                    {
                        w = new List<List<int>>();
                        foreach (var t in tList)
                        {
                            wt = new List<int>();
                            foreach (var _byte in bytes)
                            {
                                bool value = false;
                                for (int pos = 0; pos < positionsMissingCount; pos++)
                                {
                                    if (_byte[missingPosition[pos]] == t[pos])
                                    {
                                        value = true;
                                    }
                                    else
                                    {
                                        value = false;
                                        break;
                                    }
                                }
                                if (value == false)
                                {
                                    wt.Add(0);
                                }
                                else
                                {
                                    wt.Add(1);
                                }
                            }
                            w.Add(wt);
                        }
                        CalculateDominantVote(n, encodedVector);
                    }

                    if (finalVotes.Count != rows)
                    {
                        encodedVector = SubtractFromMainVector(rows, n, encodedVector);
                    }
                }
            }
            return finalVotes;
        }


        /// <summary>
        /// Sudaugina paketus su užkoduotu vektoriumi ir paskaičiuoja dominuojantį koeficientą.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="encodedVector"></param>
        private void CalculateDominantVote(int n, List<int> encodedVector)
        {
            int vote = 0;
            var votes = new List<int>();
            for (int j = 0; j < w.Count; j++)
            {
                var wtPack = w[j];
                vote = wtPack.Select((x, i) => x * encodedVector[i]).Aggregate((a, b) => a + b);
                votes.Add(vote % 2);
            }
            var mostOccuredVote = votes.GroupBy(i => i)
                    .OrderByDescending(grp => grp.Count())
                    .Select(grp => grp.Key).First();
            finalVotes.Add(mostOccuredVote);
        }


        /// <summary>
        /// Sudaugina matricos eilutes su gautais koeficientais ir atima iš užkoduoto vektoriaus
        /// </summary>
        /// <param name="k"></param>
        /// <param name="n"></param>
        /// <param name="encodedVector"></param>
        /// <returns></returns>
        public List<int> SubtractFromMainVector(int k, int n, List<int> encodedVector)
        {
            var vectorSum = new List<int>(new int[n]);
            int votesCount = finalVotes.Count;
            int rows = k - votesCount;
            for (int row = rows; row < k - votesCounted; row++)
            {
                var index = votesCount - (row - rows) - 1;
                var newVector = new List<int>();
                for (int column = 0; column < n; column++)
                {
                    int bit = matrix[row, column] * finalVotes[index];
                    newVector.Add(bit);
                }

                vectorSum = AddVector(vectorSum, newVector);
            }

            var vectorToReturn = SubtractVector(encodedVector, vectorSum);

            votesCounted = finalVotes.Count;
            return vectorToReturn;
        }

        /// <summary>
        /// Atima vieną vektorių iš kito
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        private List<int> SubtractVector(List<int> minuend, List<int> subtrahend)
        {
            var difference = minuend.Select((m, i) => m - subtrahend[i]).ToList();
            var result = difference.Select(x => Convert.ToInt32(x < 0 || x ==1)).ToList();
            return result;
        }


        /// <summary>
        /// Sudeda du vektorius
        /// </summary>
        /// <param name="firstAddend"></param>
        /// <param name="secondAddend"></param>
        /// <returns></returns>
        private List<int> AddVector(List<int> firstAddend, List<int> secondAddend)
        {
            return firstAddend.Select((add, index) => (add + secondAddend[index]) % 2).ToList();
        }

        /// <summary>
        /// Gauna trūkstamas pozicijas atitinkamoms dimensijoms
        /// </summary>
        /// <param name="numberOfMissingPositions"></param>
        /// <returns></returns>
        private List<List<int>> GetMissingPossitionsList(int numberOfMissingPositions)
        {
            var listOfPositions = new List<List<int>>();

            foreach (string _byte in bytes)
            {
                var zeros = _byte.Where(x => x != '1').Count();

                if (zeros == numberOfMissingPositions)
                {
                    var positions = _byte.Select((character, index) => new { index, character })
                    .Where(t => t.character == '0')
                    .Select(t => t.index)
                    .ToList();
                    listOfPositions.Add(positions);
                }
            }
            return listOfPositions;
        }
    }
}
