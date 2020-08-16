using System;

namespace IsomorphicChecker
{
    class Program
    {
        public static void Main()
        {
            string s = "worek";
            string t ="palto";

            Console.WriteLine($"- Computer, tell me if words {s} and {t} are isomorhpic?");
            string result = IsomorphicChecker.AreIsomorphic(s, t) == true ? "- Yes, they are." : "- No, they ain't";
            Console.WriteLine(result);
        }
    }
}
