using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFour.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Friend> Friends { get; set; }
    }
    public class Friend
    {
        public string Name { get; set; }
    }
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
    }

}
