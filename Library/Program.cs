class Book
{


    //Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // Constructor for book object
    //add a new instance of the book class
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

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
        Book book = new Book("C# for beginners", "Bill Gates", "1234567", 200);

        //another instance
        //title = "visual studio 2022"
        //Author = "Microsoft"
        //ISBN = "123"
        //No of pages = 70

        Book book2 = new Book("Visual Studio 2022", "Microsoft", "123", 70);

        // ooutput book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();

    }

}

