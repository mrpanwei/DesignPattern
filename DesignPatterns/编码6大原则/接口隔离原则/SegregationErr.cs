using System;
namespace DesignPatterns.编码6大原则.接口隔离原则
{
    public class SegregationErr
    {
        public SegregationErr()
        {
        }
    }

    /// <summary>
    /// 按照工序，一步一步的完成生产
    /// </summary>
    interface IParentWorkModel
    {
        void Step1();

        void Step2();

        void Step3();
    }

    /// <summary>
    /// 实际上,a员工做step2更快速
    /// </summary>
    public class StaffSegregationA : IParentWorkModel
    {
        public void Step1()
        {
            Console.WriteLine("StaffA loading Step1");
        }

        public void Step2()
        {
            Console.WriteLine("StaffA loading Step2");
        }

        public void Step3()
        {
            Console.WriteLine("StaffA loading Step3");
        }
    }

    /// <summary>
    /// 实际上,b员工做step1更快速
    /// </summary>
    public class StaffSegregationB : IParentWorkModel
    {
        public void Step1()
        {
            Console.WriteLine("StaffB loading Step1");
        }

        public void Step2()
        {
            Console.WriteLine("StaffB loading Step2");
        }

        public void Step3()
        {
            Console.WriteLine("StaffB loading Step3");
        }
    }




}
