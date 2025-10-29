using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemConApp
{
    class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int itemId, int issueNumber, bool isAvailable = true)
            : base(title, itemId, isAvailable)
        {
            IssueNumber = issueNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Magazine] ID: {ItemId}, Title: {Title}, Issue: {IssueNumber}, Available: {IsAvailable}");
        }
    }
}
