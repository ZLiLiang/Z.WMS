using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.DAL;
using Z.Models.DModels;

namespace Z.BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="uPwd"></param>
        /// <returns></returns>
        public bool LoginSystem(string uName, string uPwd)
        {
            int userId = userDAL.LoginSystem(uName, uPwd);
            if (userId > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取所有用户实体
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetUserInfos()
        {
            return userDAL.GetUserInfos();
        }

        /// <summary>
        /// 根据用户实体添加用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool AddUserInfo(UserInfo userInfo)
        {
            return userDAL.AddUserInfo(userInfo, 0) > 0;
        }

        /// <summary>
        /// 根据实体添加用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool UpdateUserInfo(UserInfo userInfo)
        {
            return userDAL.UpdateUserInfo(userInfo);
        }

        /// <summary>
        /// 逻辑删除用户信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public bool DeleteUserInfo(int userId)
        {
            return userDAL.Delete(userId, 0, 1);
        }
    }
}
