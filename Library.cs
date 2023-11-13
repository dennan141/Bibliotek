class Library
{
    // ------------------ PROPERTIES ------------------------
    private List<Book> Collection = new List<Book>();



    // ------------------ CONSTRUCTOR ------------------------
    public Library()
    {
        // Creating example books 
        Book book1 = new Book("Japansk Grillning", "Jonas Cramby", 9789127148055);
        Book book2 = new Book("Morthaug", "James Callingway", 9789127148056);
        Book book3 = new Book("Fysik 1, grunderna", "Anders Andersson", 9789127148057);
        Book book4 = new Book("titel", "författare", 1);

        addBook(book1);
        addBook(book2);
        addBook(book3);
        addBook(book4);
    }


    // ------------------ METHODS ------------------------

    public void addBook(Book newBook)
    {
        Collection.Add(newBook);
    }

    public void removeBookByISBN(long ISBN)
    {
        Book searchedBook = findBookByISBN(ISBN);
        if (searchedBook != null)
        {
            Collection.Remove(searchedBook);
        }
        return;
    }
    public void removeBook(Book bookToRemove)
    {
        Collection.Remove(bookToRemove);
    }

    /// <summary>
    /// Returns a book in one is found or null
    /// </summary>
    /// <param name="ISBN">An exclusive int for each book</param>
    /// <returns>the first book of class Book</returns>
    public Book findBookByISBN(long? ISBN)
    {
        return Collection.Find(book => book.ISBN == ISBN);
    }

    public void printAllBooks()
    {
        foreach (Book book in Collection)
        {
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Title: " + book.getTitle());
            System.Console.WriteLine("Author : " + book.Author);
            System.Console.WriteLine("ISBN: " + book.ISBN);
            if (book.Borrowed == true)
            {
                System.Console.WriteLine("Not in Library");
            }
            else
                System.Console.WriteLine("In library");
            System.Console.WriteLine("--------------------------");
        }
    }

    public void printBook(Book book)
    {
        System.Console.WriteLine("--------------------------");
        System.Console.WriteLine("Title: " + book.getTitle());
        System.Console.WriteLine("Author : " + book.Author);
        System.Console.WriteLine("ISBN: " + book.ISBN);
        if (book.Borrowed == true)
        {
            System.Console.WriteLine("Not in Library");
        }
        else
            System.Console.WriteLine("In library");
        System.Console.WriteLine("--------------------------");

    }



}