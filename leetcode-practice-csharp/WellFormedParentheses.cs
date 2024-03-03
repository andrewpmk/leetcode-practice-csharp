using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/generate-parentheses/
// 16 min 32 sec

namespace leetcode_practice_csharp
{
    public class WellFormedParentheses
    {
        private static bool CheckWellFormedParentheses(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char chr = s[i];
                if (chr == '(')
                {
                    count++;
                }
                else if (chr == ')')
                {
                    count--;
                }
                else
                {
                    return false;
                }

                if (count < 0)
                {
                    return false;
                }
            }

            return count == 0;
        }

        private static List<string> AddMoreCombos(List<string> combos)
        {
            List<string> output = new List<string>();
            foreach (char chr in new[] { '(', ')' })
            {
                foreach (string s in combos)
                {
                    output.Add(s + chr);
                }
            }

            return output;
        }

        private static List<string> GenerateParenthesisCombinations(int num)
        {
            List<string> output = new List<string> { "" };
            for (int i = 0; i < num; i++)
            {
                output = AddMoreCombos(output);
            }

            return output;
        }

        public static IList<string> GenerateParenthesis(int num)
        {
            var combos = GenerateParenthesisCombinations(num * 2);
            var output = new List<string>();
            for (int i = 0; i < combos.Count; i++)
            {
                if (CheckWellFormedParentheses(combos[i]))
                {
                    output.Add(combos[i]);
                }
            }

            return output;
        }
    }
}
