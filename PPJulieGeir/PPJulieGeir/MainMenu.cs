namespace PPJulieGeir;

public class MainMenu
{
    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Biblioteket: ");
        Console.WriteLine("1.) Legg til bok:");
        Console.WriteLine("2.) Legg til bok:");
        Console.WriteLine("3.) Legg til bok:");
        Console.WriteLine("q.) Avslutt programmet!");
        bool running = true;
        while (running)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    //Book book = new Book("Hallo", "Hallo", "Hallo", "Hallo", new DateTime(24, 12, 12), 112);
                    AddBook();
                    break;
                case "q":
                    running = false;
                    break;
            }

            void AddBook()
            {
                Console.WriteLine("Add Title:");
                string title = Console.ReadLine();
                Console.WriteLine("Add Author:");
                string author = Console.ReadLine();
                Console.WriteLine("Add Publisher:");
                string publisher = Console.ReadLine();
                Console.WriteLine("Add Description:");
                string description = Console.ReadLine();
                /*Console.WriteLine("Add Publish Date:");
                DateTime publishDate = DateTime.Parse(Console.ReadLine());*/
                Console.WriteLine("Add Page Count:");
                int pageCount = int.Parse(Console.ReadLine());
                var book1 = new Book(title, author, publisher, description, pageCount);
                Console.WriteLine("Trykk en tast for å se boken!");
                Console.ReadKey();
                book1.DisplayBook(book1);
            }
            

            
        }
    }




}