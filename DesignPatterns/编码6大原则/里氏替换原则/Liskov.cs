using System;
namespace DesignPatterns.编码6大原则.里氏替换原则
{
    /// <summary>
    /// 父
    /// </summary>
    public class P
    {
        public void Ribs() => Console.WriteLine("排骨");
    }

    /// <summary>
    /// 子1 wrong
    /// </summary>
    public class Liskov : P
    {
        public new void Ribs() => Console.WriteLine("红烧排骨");
    }

    /// <summary>
    /// 子2 right
    /// </summary>
    public class LiskovOK : P
    {
        public new void Ribs() => Console.WriteLine("排骨");
        public void SweetRibs() => Console.WriteLine("糖醋排骨");
    }
}
