using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.BLL;
using Z.Common;
using Z.DAL;
using Z.Models.DModels;

namespace Z.WMS.User
{
    public partial class FormUserList : Form
    {
        public FormUserList()
        {
            InitializeComponent();
        }

        UserBLL userBLL = new UserBLL();
        FormUserInfo formUserInfo = new FormUserInfo();

        private void FormUserList_Load(object sender, EventArgs e)
        {
            this.DGVRefresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AddUserInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.DGVRefresh();
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var currentCell = dgvUserList.SelectedRows[e.RowIndex].Cells[e.ColumnIndex];
            //var cellValue = currentCell.Value.ToString();
            var currentCell = dgvUserList.SelectedCells[0].EditedFormattedValue.ToString();
            var user = dgvUserList.Rows[e.RowIndex].DataBoundItem;
            var mapper = user.Mapper<UserInfo>();
            switch (currentCell)
            {
                case "修改":
                    formUserInfo.TxtUserInfo = mapper;
                    this.UpdateUserInfo();
                    break;
                case "删除":
                    this.DeleteUserInfo(mapper.UserId);
                    break;
            }
        }

        #region 非事件方法

        /// <summary>
        /// 刷新获取数据
        /// </summary>
        private void DGVRefresh()
        {
            dgvUserList.DataSource = userBLL.GetUserInfos()
                .Select(x => new
                {
                    UserId = x.UserId,
                    UserName = x.UserName,
                    UserPwd = x.UserPwd,
                    UserState = x.UserState
                })
                .ToList();
        }

        /// <summary>
        /// 新增用户信息
        /// </summary>
        private void AddUserInfo()
        {
            if (formUserInfo.ShowDialog() == DialogResult.OK)
            {
                UserInfo userInfo = formUserInfo.TxtUserInfo;
                userBLL.AddUserInfo(userInfo);
            }
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        private void UpdateUserInfo()
        {
            if (formUserInfo.ShowDialog() == DialogResult.OK)
            {
                UserInfo userInfo = formUserInfo.TxtUserInfo;
                userBLL.UpdateUserInfo(userInfo);
                formUserInfo.TxtUserInfo = null;
            }
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="userId"></param>
        private void DeleteUserInfo(int userId)
        {
            if (MsgBoxHelper.MsgBoxConfirm("警告", "确认删除？") == DialogResult.Yes)
            {
                userBLL.DeleteUserInfo(userId);
            }
        }

        #endregion


    }
}
