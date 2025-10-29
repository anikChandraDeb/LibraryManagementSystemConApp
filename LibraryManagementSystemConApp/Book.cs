using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemConApp
{
    class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(string title, int itemId, string author, bool isAvailable = true)
            : base(title, itemId, isAvailable)
        {
            Author = author;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Book] ID: {ItemId}, Title: {Title}, Author: {Author}, Available: {IsAvailable}");
        }
    }
}
