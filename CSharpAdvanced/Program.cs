using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very very very very long post and all";
            var shortenedPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            var max = numbers.Max();
            Console.WriteLine(max);
            Console.WriteLine(shortenedPost);
        }
    }
}
