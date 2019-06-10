using System;
namespace DesignPatterns.编码6大原则.迪米特法则
{
    public class LawOk
    {
        public LawOk()
        {
        }
    }


    public class Law_Book2
    {
        public Law_Book2(string title)
        {
            this.Title = title;
        }

        public string Title { get; set; }

    }

    public class Law_App2
    {
        private Law_Book2 book2 = new Law_Book2("设计模式-迪米特法则");

        public void read()
        {
            Console.WriteLine("read:" + book2.Title);
        }

    }

    public class Law_Phone2
    {

        private Law_App2 app2 = new Law_App2();

        public void readBook()
        {
            app2.read();
        }

    }

}
