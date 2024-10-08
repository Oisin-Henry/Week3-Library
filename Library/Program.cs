class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;



void DisplayInfo()
    {
        // Output the book information to the console
        Console.WriteLine("Book information");
        Console.WriteLine("--------------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Book pages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Create a new instance of the book class
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";
        book.NoOfPages = 200;

        Book book2 = new Book();
        book2.Title = "C# Methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "5566778";
        book2.NoOfPages = 50;

        // ooutput book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }

}

