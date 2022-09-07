using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_library
{
    public delegate void FirstDelegate(string len);

    public static class StringMethod
    {
        public static string CapitalizeFirst(this string s)
        {
            bool IsNewSentence = true;
            var result = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (IsNewSentence && char.IsLetter(s[i]))
                {
                    result.Append(char.ToUpper(s[i]));
                    IsNewSentence = false;
                }
                else
                    result.Append(s[i]);

                if (s[i] == '!' || s[i] == '?' || s[i] == '.')
                {
                    IsNewSentence = true;
                }
            }

            return result.ToString();
        }
    }
