namespace PPJulieGeir;

public class MainMenu
{
    public void Menu()
    {
        Console.Clear();
        Console.WriteLine("Velkommen to Get-Biblioteket: ");
        Console.WriteLine("1.) Legg til bok:");
        Console.WriteLine("q.) Avslutt programmet!");
        bool running = true;
        while (running)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
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
                Console.WriteLine("Add Publish Year:");
                int publishYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add Page Count:");
                int pageCount = int.Parse(Console.ReadLine());
                var book1 = new Book(title, author, publisher, description, publishYear,pageCount);
                Console.WriteLine("Trykk en tast for å se boken!");
                Console.ReadKey();
                book1.DisplayBook(book1);
            }
        }
    }




}