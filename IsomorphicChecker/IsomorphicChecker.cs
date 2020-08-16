using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Windows.Markup;

namespace IsomorphicChecker
{
    public class IsomorphicChecker
    {
        public static bool AreIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> alphabetForS = new Dictionary<char, int>(28);
            Dictionary<char, int> alphabetForT = new Dictionary<char, int>(28);

            for (int i = 0; i < s.Length; i++)
            {
                if (alphabetForS.ContainsKey(s[i]))
                {
                    alphabetForS.TryGetValue(s[i], out int repeatsNb);
                    repeatsNb += i;
                    alphabetForS.Remove(s[i]);
                    alphabetForS.Add(s[i], repeatsNb);
                }
                else
                {
                    alphabetForS.Add(s[i], 1);
                }

                if (alphabetForT.ContainsKey(t[i]))
                {
                    alphabetForT.TryGetValue(t[i], out int repeatsNb);
                    repeatsNb += i;
                    alphabetForT.Remove(t[i]);
                    alphabetForT.Add(t[i], repeatsNb);
                }
                else
                {
                    alphabetForT.Add(t[i], 1);
                }
            }

            for (int i = 0; i < alphabetForS.Count; i++)
            {
                int valS = alphabetForS.ElementAt(i).Value;
                int valT = alphabetForT.ElementAt(i).Value;
                if (valS != valT) return false;
            }
            return true;
        }



    }
}
