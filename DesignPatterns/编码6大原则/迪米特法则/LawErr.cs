using System;
namespace DesignPatterns.编码6大原则.迪米特法则
{
    public class LawErr
    {
        public LawErr()
        {
        }
    }




    public class Law_Book
    {
        public Law_Book(string title)
        {
            this.Title = title;
        }

        public string Title { get; set; }

    }

    public class Law_App
    {
        public void read(Law_Book book)
        {
            Console.WriteLine("read:" + book.Title);
        }

    }

    public class Law_Phone
    {
        Law_App app = new Law_App();
        Law_Book book = new Law_Book("设计模式-迪米特法则");
        public void readBook()
        {
            app.read(book);
        }

    }

















}
