// Functions or Methods to updating the user 
// interface without cluttering the main program.

using System.Net.WebSockets;

class UI
{
    public Book updateUIAddBook()
    {
        string? userInput;
        long newISBN;
        string? newTitle;
        string? newAuthor;

        Console.Write("Title: ");
        userInput = Console.ReadLine();
        while (!isValidTextInput(userInput))
        {
            Console.Write("Please provide a valid title: ");
            userInput = Console.ReadLine();
        }
        newTitle = userInput;
        userInput = "";

        Console.Write("Author: ");
        userInput = Console.ReadLine();
        while (!isValidTextInput(userInput))
        {
            Console.Write("Please provide a valid Author: ");
            userInput = Console.ReadLine();
        }
        newAuthor = userInput;
        userInput = "";

        Console.Write("ISBN: ");
        userInput = Console.ReadLine();
        while (!isValidISBN(userInput))
        {
            Console.Write("Please provide a valid ISBN: ");
            userInput = Console.ReadLine();
        }
        newISBN = Convert.ToInt64(userInput);


        Book newBook = new Book(newTitle, newAuthor, newISBN);

        return newBook;
    }

    /// <summary>
    /// Returns true if no problems are detected.
    /// </summary>
    /// <param name="userInput">Lines from the user</param>
    /// <returns>Returns true if no problems are detected</returns>
    private bool isValidTextInput(string? userInput)
    {
        return userInput != null && userInput.Length > 0 && userInput.Length < 250;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="userInput">Lines from the user</param>
    /// <returns>Returns true if no problems are detected</returns>
    private bool isValidISBN(string? userInput)
    {
        return long.TryParse(userInput, out _);
    }


    public void updateUIBorrowBook(Library library)
    {
        System.Console.Write("Write ISBN of book you want to borrow: ");
        string userInput = Console.ReadLine();
        if (isValidISBN(userInput))
        {
            Book foundBook = library.findBookByISBN(Convert.ToInt64(userInput));
            if (foundBook != null)
            {
                System.Console.WriteLine("You've borrowed this book!");
                foundBook.printTitle();
                foundBook.borrowBook();
            }
            else
                System.Console.WriteLine("No book with that ISBN number.");
        }
        else
        {
            System.Console.WriteLine("Invalid input, please input an ISBN.");
        }

    }


    public void updateUIReturnBook(Library library)
    {
        System.Console.Write("Write ISBN of book you want to return: ");
        string userInput = Console.ReadLine();
        if (isValidISBN(userInput))
        {
            Book foundBook = library.findBookByISBN(Convert.ToInt64(userInput));
            if (foundBook != null)
            {
                System.Console.WriteLine("You've returned this book!");
                foundBook.printTitle();
                foundBook.returnBook();
            }
            else
                System.Console.WriteLine("No book with that ISBN number.");
        }
        else
        {
            System.Console.WriteLine("Invalid input, please input an ISBN.");
        }

    }
    public void updateUIRemoveBook(Library library)
    {
        Console.WriteLine("You have choosen to REMOVE a book");
        Console.Write("ISBN number: ");
        string? userAnswer = Console.ReadLine();

        if (isValidISBN(userAnswer))
        {
            Book foundBook = library.findBookByISBN(Convert.ToInt64(userAnswer));
            if (foundBook == null)
            {
                System.Console.WriteLine("No book with that ISBN found.");
                return;
            }

            Console.WriteLine("Are you sure you want to remove this book?");
            library.printBook(foundBook);
            Console.Write("Press Y/N and Enter for Yes or No: ");
            userAnswer = Console.ReadLine();


            if (userAnswer == "Y" || userAnswer == "y")
            {
                library.removeBook(foundBook);
                Console.WriteLine("This book was removed!");
                return;
            }
            else if (userAnswer == "N" || userAnswer == "n")
            {
                Console.WriteLine("This book was NOT removed!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, that is not an ISBN, returning to menu.");
        }

    }



    public void displayReturnInfo()
    {
        Console.WriteLine("Press Enter to return to the menu");
        Console.ReadKey();
        Console.Clear();
    }


}