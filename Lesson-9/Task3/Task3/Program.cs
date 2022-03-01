using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoBook book = new PhotoBook();
            Console.WriteLine(book.GetNumberPages(233));
            PhotoBook book2= new PhotoBook();
            Console.WriteLine(book.GetNumberPages(24));
            PhotoBook book3= new PhotoBook();
            Console.WriteLine(book.GetNumberPages(600));
        }
    }
    public class PhotoBook
    {
        public int pages { get; set; }
        
        public int GetNumberPages(int page)
        {
            pages = page;
            return pages;
        }
    }
}
