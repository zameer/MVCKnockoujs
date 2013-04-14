using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCFour.Models;

namespace MVCFour.ViewModel
{
    public class BookListing
    {
        public Book book { get; set; }
        public List<string> authors { get; set; }
    }
}