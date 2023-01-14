using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Result1
    {
        /*
         * Complete the 'findSubstring' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. INTEGER k
         */

        public static string findSubstring(string s, int k)
        {
            string vowels = "aeiou";
            string result = "Not found!";
            int imax = 0;
            int idx = -1;
            string ss;

            for (int i = 0; i <= s.Length - k; i++)
            {
                ss = s.Substring(i, k);
                //if (ss.Length >= k)
                //{
                var max = 0;
                //foreach (var item in ss)
                //{
                //    if (vowels.Contains(item))
                //    {
                //        max++;
                //    }
                //}
                max += ss.Count(v => vowels.Contains(Char.ToLower(v)));
                if (imax < max)
                {
                    imax = max;
                    idx = i;
                }
                //}
            }
            if (idx != -1)
                result = s.Substring(idx, k);
            return result;



        }
    }
}
