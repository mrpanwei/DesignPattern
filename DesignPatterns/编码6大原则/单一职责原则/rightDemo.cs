using System;
namespace DesignPatterns.编码6大原则.单一职责原则
{
    /// <summary>
    /// Right demo.
    /// </summary>
    public class rightDemo:UserOpr2
    {
        public rightDemo()
        {
        }

        /// <summary>
        /// Designs the patterns.编码6大原则.单一职责原则. user opr2. modity cell phone.
        /// </summary>
        /// <returns><c>true</c>, if patterns.编码6大原则.单一职责原则. user opr2. modity cell phone was designed, <c>false</c> otherwise.</returns>
        /// <param name="cellphone">Cellphone.</param>
        bool UserOpr2.ModityCellPhone(string cellphone)
        {
            //这里是更新用户名的具体操作方法
            return true;
        }

        /// <summary>
        /// Designs the name of the patterns.编码6大原则.单一职责原则. user opr2. modity user.
        /// </summary>
        /// <returns><c>true</c>, if patterns.编码6大原则.单一职责原则. user opr2. modity user name was designed, <c>false</c> otherwise.</returns>
        /// <param name="username">Username.</param>
        bool UserOpr2.ModityUserName(string username)
        {
            //这里是更新联系方式的具体操作方法
            return true;
        }
    }

    /// <summary>
    /// 定义了一个用户操作的接口2
    /// </summary>
    interface UserOpr2
    {
        /// <summary>
        /// Modities the name of the user.
        /// </summary>
        /// <returns><c>true</c>, if user name was modityed, <c>false</c> otherwise.</returns>
        /// <param name="username">Username.</param>
        Boolean ModityUserName(string username);

        /// <summary>
        /// Modities the cell phone.
        /// </summary>
        /// <returns><c>true</c>, if cell phone was modityed, <c>false</c> otherwise.</returns>
        /// <param name="cellphone">Cellphone.</param>
        Boolean ModityCellPhone(string cellphone);
    }

}
