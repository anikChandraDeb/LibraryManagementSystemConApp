using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemConApp
{
    class LibraryItem
    {
        public string Title { get; set; }
        public int ItemId { get; set; }
        public bool IsAvailable { get; set; }

        public LibraryItem(string title, int itemId, bool isAvailable = true)
        {
            Title = title;
            ItemId = itemId;
            IsAvailable = isAvailable;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {ItemId}, Title: {Title}, Available: {IsAvailable}");
        }
    }
}
