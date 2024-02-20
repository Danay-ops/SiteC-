using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperSite0.Models
{
    public class BookInfo
    {
       public  int Id { get; set; }
        public string Title { get; set;}
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }

        public string Path { get; set; }
    }
}