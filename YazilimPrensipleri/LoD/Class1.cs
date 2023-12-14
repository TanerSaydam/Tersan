namespace LoD;

// Bad Example
public class Book
{
    public string Title { get; set; }
}

public class Shelf
{
    public Book Book { get; set; }
}

public class Library
{
    public Shelf Shelf { get; set; }

    public string GetBookTitle()
    {
        return Shelf.Book.Title;
    }
}

// Good Example
public class Shelf_2
{
    public Book Book { get; set; }
    public string GetBookTitle()
    {
        return Book.Title;
    }
}

public class Library_2
{
    public Shelf_2 Shelf { get; set; }

    public string GetBookTitle()
    {
        return Shelf.GetBookTitle();
    }
}