namespace PPJulieGeir;

public class Book
{
    string Title { get; set; } = string.Empty;
    string Author { get; set; } = string.Empty;
    string Publisher  { get; set; } = string.Empty;
    string Description { get; set; } = string.Empty;
    int PublishYear { get; set; }
    int PageCount { get; set; }

    public Book(
        string title, 
        string author, 
        string publisher, 
        string description, 
        int publishYear, 
        int pageCount)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        Description = description;
        PublishYear = publishYear;
        PageCount = pageCount;
    }

   

    public void DisplayBook(Book book)
    {
        Console.Clear();
        Console.WriteLine(@"
    ______ _        ______       _        
    |  _  (_)       | ___ \     | |     _ 
    | | | |_ _ __   | |_/ / ___ | | __ (_)
    | | | | | '_ \  | ___ \/ _ \| |/ /    
    | |/ /| | | | | | |_/ | (_) |   <   _ 
    |___/ |_|_| |_| \____/ \___/|_|\_\ (_)                                                                        
");
        Console.WriteLine($"Title: {book.Title}");
        Console.WriteLine($"Author: {book.Author}");
        Console.WriteLine($"Publisher: {book.Publisher}");
        Console.WriteLine($"Description: {book.Description}");
        Console.WriteLine($"Publish Date: {book.PublishYear}");
        Console.WriteLine($"Page Count: {book.PageCount}");
    }
}