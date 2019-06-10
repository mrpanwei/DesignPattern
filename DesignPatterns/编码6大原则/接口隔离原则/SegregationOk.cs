using System;
namespace DesignPatterns.编码6大原则.接口隔离原则
{
    public class SegregationOk
    {
        public SegregationOk()
        {
        }
    }


    interface IStep1
    {
        void Step1();
    }

    interface IStep2
    {
        void Step2();
    }

    interface IStep3
    {
        void Step3();
    }

    public class StaffSegregationA2 : IStep2
    {
        public void Step2()
        {
            Console.WriteLine("StaffA2 loading Step2");
        }
    }

    public class StaffSegregationA3 : IStep1
    {
        public void Step1()
        {
            Console.WriteLine("Staff3 loading Step1");
        }
    }

    public class StaffSegregationA4 : IStep3
    {
        public void Step3()
        {
            Console.WriteLine("Staff4 loading Step3");
        }
    }


}
