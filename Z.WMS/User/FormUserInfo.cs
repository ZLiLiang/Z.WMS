using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Common;
using Z.Models.DModels;

namespace Z.WMS.User
{
    public partial class FormUserInfo : Form
    {
        public FormUserInfo()
        {
            InitializeComponent();
        }

        public UserInfo TxtUserInfo { get; set; }

        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            if (this.TxtUserInfo != null)
            {
                txtUserName.Text = TxtUserInfo.UserName;
                txtUserPwd.Text = TxtUserInfo.UserPwd;
                txtUserState.Text = TxtUserInfo.UserState.ToString();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearTB();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.TxtUserInfo != null)
            {
                this.TxtUserInfo.UserName = txtUserName.Text;
                this.TxtUserInfo.UserPwd = txtUserPwd.Text;
                this.TxtUserInfo.UserState = txtUserState.Text.GetInt();
            }
            else
            {
                this.TxtUserInfo = new UserInfo
                {
                    UserName = txtUserName.Text,
                    UserPwd = txtUserPwd.Text,
                    UserState = txtUserState.Text.GetInt()
                };
            }
            DialogResult = DialogResult.OK;
        }

        private void FormUserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ClearTB();
        }

        /// <summary>
        /// 清除文本框内容
        /// </summary>
        private void ClearTB()
        {
            txtUserName.Clear();
            txtUserPwd.Clear();
            txtUserState.Clear();
        }
    }
}
