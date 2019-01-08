using System.Collections.Generic;
using System.Linq;

namespace ReedMullerCodes
{
    public static class Extensions
    {
        public static int CountFactorial(this int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Suskaičiuoja derinių skaičių pagal formulę
        /// </summary>
        /// <param name="m"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int CountCombination(this int m, int r)
        {
            int count = 0;
            for (int i = 0; i <= r; i++)
            {
                var unit = m.CountFactorial();
                var divider = i.CountFactorial() * (m - i).CountFactorial();
                count += unit / divider;
            }
            return count;
        }

        public static string ListToString(this List<int> list)
        {
            return list.Select(x => x.ToString()).ToList().Aggregate((x,y) => x + y);
        }

        public static string StringListToString(this List<string> list)
        {
            return string.Join("", list);
        }
        
        public static string ListToCommaSeparatedString(this List<int> list)
        {
            var stringList = list.Select(x => x.ToString()).ToList();
            return string.Join(", ", stringList);
        }

        public static List<int> StringToIntList(this string str)
        {
            return str.ToCharArray().Select(x => int.Parse(x.ToString())).ToList();
        }
    }
}
