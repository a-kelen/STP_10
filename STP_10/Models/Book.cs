using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STP_10.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }

        public static int counter = 0;
        public Book()
        {
            this.Id = ++counter;
        }

        public static List<Book> BooksDB()
        {
            var res = new List<Book>();
            res.Add(new Book { Name = "Book 1", Description = "Description for Book 1", Year = 2004 });
            res.Add(new Book { Name = "Book 2", Description = "Description for Book 2", Year = 2022 });
            res.Add(new Book { Name = "Book 3", Description = "Description for Book 3", Year = 2011 });
            res.Add(new Book { Name = "Book 4", Description = "Description for Book 4", Year = 2007 });
            res.Add(new Book { Name = "Book 5", Description = "Description for Book 5", Year = 1995 });
            res.Add(new Book { Name = "Book 6", Description = "Description for Book 6", Year = 2017 });

            return res;
        }
    }
}