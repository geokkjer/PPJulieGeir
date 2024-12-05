namespace PPJulieGeir;

public class Book
{
    string Title { get; set; } = string.Empty;
    string Author { get; set; } = string.Empty;
    string Publisher  { get; set; } = string.Empty;
    string Description { get; set; } = string.Empty;
    //DateTime PublishDate { get; set; }
    int PageCount { get; set; }

    public Book(
        string title, 
        string author, 
        string publisher, 
        string description, 
        //DateTime publishDate, 
        int pageCount)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        Description = description;
        //PublishDate = publishDate;
        PageCount = pageCount;
    }

   

    public void DisplayBook(Book book)
    {
        Console.Clear();
        Console.WriteLine(@"
    __   __                ______             _       
    \ \ / /                | ___ \           | |   _  
     \ V /___  _   _ _ __  | |_/ / ___   ___ | | _(_) 
      \ // _ \| | | | '__| | ___ \/ _ \ / _ \| |/ /   
      | | (_) | |_| | |    | |_/ / (_) | (_) |   < _  
      \_/\___/ \__,_|_|    \____/ \___/ \___/|_|\_(_)                                                   
                                                  
");
        Console.WriteLine($"Title: {book.Title}");
        Console.WriteLine($"Author: {book.Author}");
        Console.WriteLine($"Publisher: {book.Publisher}");
        Console.WriteLine($"Description: {book.Description}");
        //Console.WriteLine($"Publish Date: {book.PublishDate}");
        Console.WriteLine($"Page Count: {book.PageCount}");
    }
}