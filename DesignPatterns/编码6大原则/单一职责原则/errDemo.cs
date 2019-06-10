using System;
namespace DesignPatterns.编码6大原则.单一职责原则
{
    /// <summary>
    /// Error demo.
    /// </summary>
    public class errDemo : UserOpr
    {
        public errDemo()
        {

        }

        /// <summary>
        /// Designs the patterns.编码6大原则.单一职责原则. user opr. user info modity.
        /// </summary>
        /// <returns><c>true</c>, if patterns.编码6大原则.单一职责原则. user opr. user info modity was designed, <c>false</c> otherwise.</returns>
        /// <param name="modifyType">Modify type.</param>
        bool UserOpr.UserInfoModity(ModifyType modifyType)
        {
            if (modifyType == ModifyType.Modify_UserName)
            {
                //这里是更新用户名的具体操作方法
            }
            else if (modifyType == ModifyType.Modify_CellPhone)
            {
                //这里是更新联系方式的具体操作方法
            }
            return true;
        }
    }


    /// <summary>
    /// 资料更新类型
    /// </summary>
    enum ModifyType
    {
        /// <summary>
        /// The name of the modify user.
        /// </summary>
        Modify_UserName,

        /// <summary>
        /// The modify cell phone.
        /// </summary>
        Modify_CellPhone
    }

    /// <summary>
    /// 定义了一个用户操作的接口
    /// </summary>
    interface UserOpr
    {

        /// <summary>
        /// 修改用户资料，比如用户名或者联系手机号
        /// </summary>
        /// <returns><c>true</c>, if info modity was usered, <c>false</c> otherwise.</returns>
        /// <param name="modifyType">Modify type.</param>
        Boolean UserInfoModity(ModifyType modifyType);
    }

}
