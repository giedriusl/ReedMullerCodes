using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ReedMullerCodes
{
    public static class BytesCounter
    {
        /// <summary>
        /// Gauna baitus 
        /// </summary>
        /// <param name="lengthOfBytesList">Nusako kiek tų baitų bus</param>
        /// <param name="lengthOfByte">Nusako kokio ilgio 'baitas'</param>
        /// <returns></returns>
        public static List<string> GetBytes(int lengthOfBytesList, int lengthOfByte)
        {
            var bytes = new List<string>();
            for (int i = 0; i < lengthOfBytesList; i++)
            {
                var binary = Convert.ToString(i, 2).PadLeft(lengthOfByte, '0');
                bytes.Add(binary);
            }
            return bytes;
        }
    }
}
