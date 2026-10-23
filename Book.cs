
using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    private bool isAvailable = true;

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine(Title + " kitabi goturuldu.");
        }
        else
        {
            Console.WriteLine(Title + " kitabi movcud deyil.");
        }
    }

    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine(Title + " kitabi qaytarildi.");
    }

    public void ShowInfo()
    {
        Console.WriteLine("Ad: " + Title);
        Console.WriteLine("Muellif: " + Author);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Movcuddur: " + isAvailable);
    }
}
