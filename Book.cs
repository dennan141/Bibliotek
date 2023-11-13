//This is the class for a single book
class Book
{
    // ------------------ PROPERTIES ------------------------
    public long ISBN { get; }
    public string Title;
    public string Author;
    public bool Borrowed;
    // ------------------ CONSTRUCTORS ------------------------
    public Book(string newTitle, string newAuthor, long newISBN)
    {
        ISBN = newISBN;
        Title = newTitle;
        Author = newAuthor;
        Borrowed = false;
    }
    public Book()
    {
        ISBN = 00000000000000;
        Title = "noTitle";
        Author = "Anonymous";
        Borrowed = false;
    }

    public string getTitle()
    {
        return Title;
    }

    public void printTitle()
    {
        System.Console.WriteLine("Title is: " + Title);
    }

    public void borrowBook()
    {
        Borrowed = true;
    }
    public void returnBook()
    {
        Borrowed = false;
    }

}