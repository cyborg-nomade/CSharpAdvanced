using System;
using System.Linq;

namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            switch (numberOfWords)
            {
                case < 0:
                    throw new ArgumentOutOfRangeException(nameof(numberOfWords), "number of words should be equal or greater than 0");
                case 0:
                    return "";
                default:
                    {
                        var words = str.Split(' ');

                        return words.Length <= numberOfWords ? str : string.Join(" ", words.Take(numberOfWords)) + "...";
                    }
            }
        }
    }
}