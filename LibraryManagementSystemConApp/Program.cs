namespace LibraryManagementSystemConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Valo Achi", 101, "AC. Deb");
            Book book2 = new Book("Valo Theko", 102, "AC. Deb");

            Magazine mag1 = new Magazine("Tech Today", 201, 45);

            Console.WriteLine("=== Library Items ===");
            book1.DisplayInfo();
            book2.DisplayInfo();
            mag1.DisplayInfo();

            Console.WriteLine("\nBorrowing");
            book2.IsAvailable = false;

            Console.WriteLine("\n=== Updated Library Items ===");
            book1.DisplayInfo();
            book2.DisplayInfo();
            mag1.DisplayInfo();
        }
    }
}
