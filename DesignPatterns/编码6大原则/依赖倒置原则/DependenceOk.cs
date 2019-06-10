using System;
namespace DesignPatterns.编码6大原则.依赖倒置原则
{
    public class DependenceOk
    {
        public DependenceOk()
        {

        }
    }
    /// <summary>
    ///   员工抽象类
    /// </summary>
    public abstract class Staff2
    {
        public string Name { get; set; }

        public abstract void Service();

        public abstract void AskForHelp(Boss2 boss);
    }

    /// <summary>
    /// 老板抽象类，用了抽象员工
    /// </summary>
    public abstract class Boss2
    {
        public Staff2 staff2 { get; set; }

        public abstract void Support();

        public abstract void AskForHelp(Boss2 boss);
    }

    /// <summary>
    /// 员工-张三
    /// </summary>
    public class Staff2A : Staff2
    {
        public Staff2A(string name)
        {
            this.Name = name;
        }
        public override void AskForHelp(Boss2 boss)
        {
            boss.Support();
        }

        public override void Service()
        {
            Console.WriteLine(this.Name + " service for you!");
        }
    }


    public class Boss2Pan : Boss2
    {
        public Boss2Pan(Staff2 staff2)
        {
            this.staff2 = staff2;
        }


        public override void AskForHelp(Boss2 boss)
        {
            boss.Support();
        }

        public override void Support()
        {
            this.staff2.Service();
        }
    }




}
