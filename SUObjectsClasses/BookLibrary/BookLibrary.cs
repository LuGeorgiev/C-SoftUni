using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int booksNumbers = int.Parse(Console.ReadLine());
            var books = new List<Book>();
            for (int i = 0; i < booksNumbers; i++)
            {
                string[] newBook = Console.ReadLine().Split(' ').ToArray();
                string title = newBook[0];
                string author = newBook[1];
                string publisher = newBook[2];
                string releaseDate = newBook[3];
                string isbn = newBook[4];
                double price = double.Parse(newBook[5]);

                books.Add(new Book(title,author,publisher,releaseDate,isbn,price));
            }

            //// 5.Book Library
            //var authorsByPrice = new Dictionary<string, double>();
            //foreach (var book in books)
            //{
            //    if (authorsByPrice.ContainsKey(book.Autor))
            //    {
            //        authorsByPrice[book.Autor] += book.Price;
            //    }
            //    else
            //    {
            //        authorsByPrice.Add(book.Autor, book.Price);
            //    }
            //}
            //var sortedBYAutors = authorsByPrice
            //    .OrderByDescending(x => x.Value)
            //    .ThenBy(x => x.Key);
            //foreach (var author in sortedBYAutors)
            //{
            //    Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            //}

            //6.Book Library Modification
            string format = "dd.MM.yyyy";
            var releasedAfter = DateTime.ParseExact(Console.ReadLine(), format,
                CultureInfo.InvariantCulture);

            var booksAfterDate = new Dictionary<string, DateTime>();
            foreach (var book in books)
            {
                if (book.ReleaseDate > releasedAfter)
                {
                    booksAfterDate.Add(book.Title, book.ReleaseDate);
                }
            }
            var sortedByDateBooks = booksAfterDate
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key);
            foreach (var book in sortedByDateBooks)
            {
                Console.WriteLine($"{book.Key} -> {book.Value.ToString(format)}");
            }
        }
    }
    public class Book
    {
        private string title;
        private string autor;
        private string publisher;
        private DateTime releaseDate;
        private string isbnNumb;
        private double price;

        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                this.title = value;
            }
        }
        public string Autor
        {
            get
            {
                return this.autor;
            }
            private set
            {
                this.autor = value;
            }
        }
        public string Publisher
        {
            get
            {
                return this.publisher;
            }
            private set
            {
                this.publisher = value;
            }
        }
        public DateTime ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }
            private set
            {
                this.releaseDate = value;
            }
        }
        public string IsbnNumb
        {
            get
            {
                return this.isbnNumb;
            }
            private set
            {
                this.isbnNumb = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public Book(string title, string autor, string publisher, string releaseDate, string isbn, double price)
        {
            string format = "dd.MM.yyyy";

            this.Title = title;
            this.Autor = autor;
            this.Publisher = publisher;
            this.ReleaseDate = DateTime.ParseExact(releaseDate, format, CultureInfo.InvariantCulture);
            this.IsbnNumb = isbn;
            this.Price = price;
        }
    }
    public class Library
    {
        private string name;
        private List<Book> books;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public List<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }

        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }
    }
}
