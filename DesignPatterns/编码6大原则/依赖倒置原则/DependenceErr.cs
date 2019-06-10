using System;
namespace DesignPatterns.编码6大原则.依赖倒置原则
{
    public class DependenceErr
    {
        public DependenceErr()
        {
        }
    }


    /// <summary>
    /// Boss.老板抽象类
    /// </summary>
    public abstract class Boss
    {
        public abstract void Support();

        public abstract void AskForHelp(Boss boss);
    }

    /// <summary>
    /// Staff.员工抽象类
    /// </summary>
    public abstract class Staff
    {
        public string Name { get; set; }

        public abstract void Service();

        public abstract void AskForHelp(Boss boss);
    }

    /// <summary>
    /// Staff a.员工a
    /// </summary>
    public class StaffA : Staff
    {
        public StaffA(string name)
        {
            this.Name = name;
        }

        public override void AskForHelp(Boss boss)
        {
            boss.Support();
        }

        public override void Service()
        {
            Console.WriteLine(this.Name + " service for you!");
        }
    }

    /// <summary>
    /// Staff b.员工b
    /// </summary>
    public class StaffB : Staff
    {
        public StaffB(string name)
        {
            this.Name = name;
        }

        public override void AskForHelp(Boss boss)
        {
            boss.Support();
        }

        public override void Service()
        {
            Console.WriteLine(this.Name + " service for you!");
        }
    }


    /// <summary>
    /// Boss he.何老板有下属员工a
    /// </summary>
    public class BossHe : Boss
    {
        private StaffA staffa;

        public BossHe(StaffA staffa)
        {
            this.staffa = staffa;
        }

        public override void AskForHelp(Boss boss)
        {
            boss.Support();
        }

        public override void Support()
        {
            staffa.Service();
        }
    }

    /// <summary>
    /// Boss jiang.姜老板有下属员工b
    /// </summary>
    public class BossJiang : Boss
    {
        private StaffB staffb;

        public BossJiang(StaffB staffb)
        {
            this.staffb = staffb;
        }

        public override void AskForHelp(Boss boss)
        {
            boss.Support();
        }

        public override void Support()
        {
            staffb.Service();
        }
    }



}
