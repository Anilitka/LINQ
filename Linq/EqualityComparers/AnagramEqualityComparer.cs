using System;
using System.Collections.Generic;

namespace Linq.EqualityComparers
{
    /// <summary>
    /// Compares two strings to see if they are anagrams.
    /// Anagrams are pairs of words formed from the same letters.
    /// </summary>
    public class AnagramEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y) => GetCanonicalString(x) == GetCanonicalString(y);

        public int GetHashCode(string obj) => GetCanonicalString(obj).GetHashCode();

        private string GetCanonicalString(string word)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort<char>(wordChars);
            return new string(wordChars);
        }
    }
}