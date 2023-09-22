using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.WMS.Product;
using Z.WMS.Store;
using Z.WMS.StoreTemper;
using Z.WMS.UControls;
using static System.Windows.Forms.AxHost;

namespace Z.WMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer = null;
        BttonPage bttonPage = new BttonPage();

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                InitStatusInfo();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBoxHelper.MsgBoxConfirm("退出系统", "您确定要退出系统吗？") == DialogResult.Yes)
            {
                if (timer != null)
                    timer.Stop();
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }

        /// <summary>
        /// 状态栏信息初始化
        /// </summary>
        private void InitStatusInfo()
        {
            string uName = this.Tag.ToString();
            lblLoginUser.Text = uName;

            //时间  动态时间条--- 计时器  （Timers.Timer）
            lblLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                this.lblLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }));
        }


        Point point = new Point();
        bool isMove = false;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;//按住的点
            isMove = true;

        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMove)
            {
                Point pointNew = e.Location;//按住的点拖动到的位置
                Point fPointNew = new Point(pointNew.X - point.X, pointNew.Y - point.Y);//相对于原来起点的距离点的描述
                this.Location += new Size(fPointNew);
            }
        }

        /// <summary>
        /// 关闭即退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStoreManage_Click(object sender, EventArgs e)
        {
            InitBtnCheck();
            btnStoreManage.IsCheck = true;
            panelPageTop.Controls.Clear();
            panelPageTop.Controls.Add(bttonPage.BtnStorePage);
            panelPageTop.Controls.Add(bttonPage.BtnSRegionPage);
            InitBtnPage();
            RegisterPageBtnClick();
        }

        private void btnProductManage_Click(object sender, EventArgs e)
        {
            InitBtnCheck();
            btnProductManage.IsCheck = true;
            panelPageTop.Controls.Clear();
            panelPageTop.Controls.Add(bttonPage.BtnProductPage);
            panelPageTop.Controls.Add(bttonPage.BtnProductInStorePage);
            InitBtnPage();
            RegisterPageBtnClick();
        }

        private void btnStoreTemperManage_Click(object sender, EventArgs e)
        {
            InitBtnCheck();
            btnStoreTemperManage.IsCheck = true;
            panelPageTop.Controls.Clear();
            panelPageTop.Controls.Add(bttonPage.BtnStoreTemperPage);
            InitBtnPage();
            RegisterPageBtnClick();
        }

        private void btnReportManager_Click(object sender, EventArgs e)
        {
            InitBtnCheck();
            btnStoreTemperManage.IsCheck = true;
            panelPageTop.Controls.Clear();
            panelPageTop.Controls.Add(bttonPage.BtnVPSPage);
            panelPageTop.Controls.Add(bttonPage.BtnVSRTPage);
            panelPageTop.Controls.Add(bttonPage.BtnVSRPage);
            InitBtnPage();
            RegisterPageBtnClick();
        }

        private void btnUserManager_Click(object sender, EventArgs e)
        {
            InitBtnCheck();
            btnUserManager.IsCheck = true;
            panelPageTop.Controls.Clear();
            panelPageTop.Controls.Add(bttonPage.BtnUserListPage);
            InitBtnPage();
            RegisterPageBtnClick();
        }

        /// <summary>
        /// 对侧边按钮进行初始化
        /// </summary>
        private void InitBtnCheck()
        {
            btnStoreManage.IsCheck = false;
            btnStoreManage.BackColor = Color.FromArgb(45, 50, 116);
            btnProductManage.IsCheck = false;
            btnProductManage.BackColor = Color.FromArgb(45, 50, 116);
            btnStoreTemperManage.IsCheck = false;
            btnStoreTemperManage.BackColor = Color.FromArgb(45, 50, 116);
            btnUserManager.IsCheck = false;
            btnUserManager.BackColor = Color.FromArgb(45, 50, 116);
        }

        /// <summary>
        /// 初始化分页按钮
        /// </summary>
        private void InitBtnPage()
        {
            foreach (var item in panelPageTop.Controls)
            {
                if (item is UPageButton btnPage)
                {
                    btnPage.ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// 注册二级按钮点击事件
        /// </summary>
        private void RegisterPageBtnClick()
        {
            foreach (var item in panelPageTop.Controls)
            {
                if (item is UPageButton btnPage)
                {
                    btnPage.Click += btnPage_Click;
                }
            }
        }

        /// <summary>
        /// 分页按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPage_Click(object sender, EventArgs e)
        {
            Color topSelColor = Color.FromArgb(45, 50, 116);//点击时或显示相关页面时
            Color topUnSelColor = Color.White;//默认或没有显示页面时

            UPageButton clickBtn = sender as UPageButton;

            foreach (var item in panelPageTop.Controls)
            {
                if (item is UPageButton btn)
                {
                    if (btn.Name != clickBtn.Name)
                    {
                        btn.ForeColor = topUnSelColor;
                    }
                    else
                    {
                        btn.ForeColor = topSelColor;
                    }
                }
            }

            if (clickBtn.Tag != null)
            {
                string formFullName = clickBtn.Tag.ToString();
                string formName = formFullName.Split('.').Last();
                Form form = FormUtility.GetOpenForm(formName);
                if (form == null)
                {
                    form = (Form)Activator.CreateInstance(Type.GetType(formFullName));
                }
                panelPage.AddPanelForm(form);
            }
        }
    }
}

