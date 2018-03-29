using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TipsTricks.SampleClass
{
    public class YieldSample
    {
        public static IEnumerable<string> AllPalindromes(string pal)
        {
            char chr;
            for (int i = 0; i < pal.Length; i++)
            {
                chr = pal[i];
                int indx = pal.IndexOf(chr, i + 1);
                if (indx > i)
                {
                    string probPalindrome = pal.Substring(i, indx - i + 1);
                    if (IsPalindrome(probPalindrome))
                    {
                        yield return probPalindrome;
                    }
                }
            }
        }
        public static bool IsPalindrome(string v)
        {

            if (v.ToArray().SequenceEqual(v.ToArray().Reverse().ToArray()))
            {
                return true;
            }
            if (v == new string(v.ToArray().Reverse().ToArray()))
            {
                return true;
            }

            if (v == new string(v.Reverse().ToArray()))
            {
                return true;
            }
            return false;
        }

        public static IEnumerable<int> GetItems()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 500; i++)
            {
                list.Add(i);
                Thread.Sleep(200);
            }
            return list;
        }
        public static IEnumerable<int> GetItemsYield()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 500; i++)
            {
                yield return i;
                Thread.Sleep(200);
            }
        }
    }
}
