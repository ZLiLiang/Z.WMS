using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.DAL.Base;
using Z.Models.DModels;

namespace Z.DAL
{
    public class UserDAL : BaseDAL<UserInfo>
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="uName"></param>
        /// <param name="uPwd"></param>
        /// <returns></returns>
        public int LoginSystem(string uName, string uPwd)
        {
            string strWhere = "UserName=@userName and UserPwd=@userPwd and UserState=1 and IsDeleted=0";
            SqlParameter[] paras =
            {
                new SqlParameter("@userName",uName),
                 new SqlParameter("@userPwd",uPwd)
            };
            UserInfo user = GetModel(strWhere, "UserId", paras);
            if (user != null)
                return user.UserId;
            else
                return 0;
        }

        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetUserInfos()
        {
            List<UserInfo> userInfos = GetModelList("UserId,UserName,UserPwd,UserState,IsDeleted", 0);
            return userInfos;
        }

        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="IsGetId">0 不返回 1 返回   id</param>
        /// <returns></returns>
        public int AddUserInfo(UserInfo userInfo, int IsGetId)
        {
            string cols = "UserName,UserPwd,UserState,IsDeleted";
            return base.Add(userInfo, cols, IsGetId);

        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool UpdateUserInfo(UserInfo userInfo)
        {
            string cols = CreateSql.GetColsString<UserInfo>("IsDeleted");
            return base.Update(userInfo, cols);
        }
    }
}
