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

namespace Z.WMS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUName.Clear();
            txtUPwd.Clear();
        }

        /// <summary>
        /// 登录过程处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //接收页面输入
            string uName = txtUName.Text.Trim();
            string uPwd = txtUPwd.Text.Trim();
            //检查信息  ---非空检查
            if (string.IsNullOrEmpty(uName))
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "账号不能为空！");
                txtUName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(uPwd))
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "密码不能为空！");
                txtUPwd.Focus();
                return;
            }

            //登录过程----检查用户的存在性   ui---bll---dal,检查（select ）----核心
            UserBLL userBLL = new UserBLL();
            bool blLogin = userBLL.LoginSystem(uName, uPwd);
            //检查结果，作处理：存在  ---成功，显示主页面；不存在，中断
            if (blLogin)//登录成功
            {
                //显示系统主页
                FormMain fMain = new FormMain();
                fMain.Tag = uName;
                fMain.Show();
                this.Hide();

            }
            else
            {
                MsgBoxHelper.MsgErrorShow("登录系统", "账号或密码输入，请检查！");
                txtUName.Focus();
                return;
            }
        }

        /// <summary>
        /// 登录页关闭   ---退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBoxHelper.MsgBoxConfirm("退出系统", "您确定要退出系统吗？") == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }
    }
}
