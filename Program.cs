
//Creating my objects of the classes
Library library = new Library();
UI ui = new UI();
string userInput = "";


//A loop where the menu is displyed and reacts to the users input
while (userInput != "6")
{
    //Printing the menu
    Console.WriteLine("------------------");
    Console.WriteLine("Welcome to the Library!");
    Console.WriteLine("To choose a option, please choose a number below and press Enter.");
    Console.WriteLine("1. Add a book");
    Console.WriteLine("2. Remove a book");
    Console.WriteLine("3. List all books in the library");
    Console.WriteLine("4. Borrow a book");
    Console.WriteLine("5. Return a book");
    Console.WriteLine("6. Exit the program.");
    Console.WriteLine("------------------");


    //Switches trough the users option, by default clears and prints the menu again.
    userInput = Console.ReadLine()!;
    switch (userInput)
    {
        case "1":
            Book newBook = ui.updateUIAddBook();
            library.addBook(newBook);
            Console.WriteLine("Your book has been added!");
            library.printBook(newBook);
            ui.displayReturnInfo();
            break;
        case "2":
            ui.updateUIRemoveBook(library);
            ui.displayReturnInfo();
            break;
        case "3":
            Console.WriteLine("You have choosen to list all books");
            library.printAllBooks();
            ui.displayReturnInfo();
            break;
        case "4":
            ui.updateUIBorrowBook(library);
            ui.displayReturnInfo();
            break;
        case "5":
            ui.updateUIReturnBook(library);
            ui.displayReturnInfo();
            break;
        case "6":
            break;
        default:
            Console.Clear();
            Console.WriteLine("Incorrect input, please press a single number and Enter.");
            break;
    }
}