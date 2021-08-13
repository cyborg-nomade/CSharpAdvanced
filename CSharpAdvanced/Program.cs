using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            /*var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                {
                    cheapBooks.Add(book);
                }
            }*/

            // LINQ Query Operators
            /*var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;*/

            // LINQ Extension Methods
            /*var cheapBooks = books
                                                .Where(b => b.Price < 10)
                                                .OrderBy(b => b.Title)
                                                .Select(b => b.Title);


            foreach (var book in cheapBooks)
            {
                //Console.WriteLine(book.Title + " " + book.Price);
                Console.WriteLine(book);
            }*/

            //var single = books.Single(b => b.Title == "ASP.NET MVC");
            /*var single = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");

            Console.WriteLine(single?.Title);*/

            //var first = books.First(b => b.Title == "C# Advanced Topics");
            /*var first = books.FirstOrDefault(b => b.Title == "C# Advanced Topics++");
            Console.WriteLine(first?.Title);*/

            //var last = books.Last(b => b.Title == "C# Advanced Topics");
            /*var last = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(last?.Title);*/

            /*var pagedBooks = books.Skip(2).Take(3);

            foreach (var booker in pagedBooks)
            {
                Console.WriteLine(booker.Title);
            }*/

            /*var count = books.Count();

            Console.WriteLine(count);*/

            var enumerable = books.ToList();
            var maxPrice = enumerable.Max(b => b.Price);
            Console.WriteLine(maxPrice);
            var minPrice = enumerable.Min(b => b.Price);
            Console.WriteLine(minPrice);
            var totalPrices = enumerable.Sum(b => b.Price);
            Console.WriteLine(totalPrices);
            var averagePrice = enumerable.Average(b => b.Price);
            Console.WriteLine(averagePrice);
        }
    }
}
