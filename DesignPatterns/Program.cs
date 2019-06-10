using System;
using DesignPatterns.编码6大原则.依赖倒置原则;
using DesignPatterns.编码6大原则.接口隔离原则;
using DesignPatterns.编码6大原则.迪米特法则;
using DesignPatterns.编码6大原则.里氏替换原则;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("编码6大原则.里氏替换原则.begin...");

            P p = new P();
            p.Ribs();

            Liskov liskov = new Liskov();
            liskov.Ribs();

            //上面的这种写法已经导致了一个结果：儿子会的，老子居然不会？因为儿子改写了老子的排骨做法

            LiskovOK liskovOK = new LiskovOK();
            liskovOK.Ribs();
            liskovOK.SweetRibs();

            Console.WriteLine("编码6大原则.里氏替换原则.end...");


            Console.WriteLine("编码6大原则.依赖倒置原则.begin...");

            StaffA sa = new StaffA("张三");
            StaffB sb = new StaffB("李四");

            BossHe he = new BossHe(sa);
            BossJiang jiang = new BossJiang(sb);

            he.AskForHelp(jiang);

            sa.AskForHelp(jiang);

            //这里我们思考一个问题？加入a或b员工离职了，，难道我们要写若干了Staff....n
            //问题出在哪里呢？老板们的员工没有用员工的抽象类，破坏了细节依赖抽象这一点！


            Staff2 sc = new Staff2A("张三");
            Staff2 sd = new Staff2A("李四");

            Boss2 p1 = new Boss2Pan(sc);
            Boss2 p2 = new Boss2Pan(sd);

            sc.AskForHelp(p2);
            p1.AskForHelp(p2);

            //这时候，我要换员工了～～～～"李四不做，王二来
            Staff2 se = new Staff2A("王二");
            p2.staff2 = se;
            sc.AskForHelp(p2);

            Console.WriteLine("编码6大原则.依赖倒置原则.end...");



            Console.WriteLine("编码6大原则.接口隔离原则.begin...");

            // 这是老父亲的做法
            StaffSegregationA staffSegregationA = new StaffSegregationA();
            staffSegregationA.Step1();
            staffSegregationA.Step2();
            staffSegregationA.Step3();

            StaffSegregationB staffSegregationB = new StaffSegregationB();
            staffSegregationB.Step1();
            staffSegregationB.Step2();
            staffSegregationB.Step3();

            // 这是儿子的做法


            StaffSegregationA2 a2 = new StaffSegregationA2();
            StaffSegregationA3 a3 = new StaffSegregationA3();
            StaffSegregationA4 a4 = new StaffSegregationA4();
            a3.Step1();
            a2.Step2();
            a4.Step3();

            Console.WriteLine("编码6大原则.接口隔离原则.end...");


            Console.WriteLine("编码6大原则.迪米特法则.begin...");

            Law_Phone law_Phone = new Law_Phone();
            law_Phone.readBook();

            Law_Phone2 law_Phone2 = new Law_Phone2();
            law_Phone2.readBook();

            Console.WriteLine("编码6大原则.迪米特法则.end...");


            Console.ReadKey();
        }
    }
}
