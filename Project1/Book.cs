using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        // Samtliga instanser av datatyp Book dela på denna variabel!
        private static int totalBooks;
        
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            totalBooks += 1;
        }

        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
            totalBooks += 1;
        }

        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }

        public static int GetTotalBooks()
        {
            return totalBooks;
        }

        // Scope example
        public void DoSomething()
        {
            int a = 0;
            for (int x = 0; x < 10; x++)
            {
                // x only exists within this for loop!
                Console.WriteLine(x);
            }
               
            // This won't compile--the variable 'x' is "out of scope".
            // x = -5; 
        }
    }
}
