using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FExam.BusinessLogic
{
    internal class Readdata
    {
        public List<Book> GetBooks()
        {
            var books = new List<Book>();
            var assembly = typeof(Readdata).Assembly;
            using (var stream = assembly.GetManifestResourceStream("MauiApp.Resources.Raw.books.txt"))
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    var book = new Book
                    {
                        Id = int.Parse(values[0]),
                        Title = values[1],
                        AuthorName = values[2],
                        Genre = values[3],
                        PublishedYear = int.Parse(values[4]),
                        Price = decimal.Parse(values[5])
                    };
                    books.Add(book);
                }
            }
            return books;
        }
    }
}

    

