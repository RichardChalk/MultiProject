using Project1;

namespace MultiProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, from project 1!");

            Book book = new Book("Harry Potter", "J.K. Rowling");
            // Changed my mind. Let's use the full name.
            book.SetTitle("Harry Potter and the Half-Blood Prince.");
            // Now I forgot. What was the title again?
            Console.WriteLine(book.GetTitle());

            // Calling a "static" method from Book
            Console.WriteLine(Book.GetTotalBooks());


        }
    }
}