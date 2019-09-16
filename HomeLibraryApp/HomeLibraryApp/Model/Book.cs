using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HomeLibraryApp.Model
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PrintDate { get; set; }
        public Image Image { get; set; }
        public Location Location { get; set; }
        public Progress ProgressAmt { get; set; }
        public BookMedium Medium { get; set; }
        public List<BookCategory> Category { get; set; } 
    }
}