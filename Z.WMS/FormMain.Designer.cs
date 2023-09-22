using System;
using System.Windows.Forms;

namespace Z.WMS
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLoginTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPageTop = new System.Windows.Forms.Panel();
            this.panelPage = new System.Windows.Forms.Panel();
            this.uPanel1 = new Z.WMS.UControls.UPanel();
            this.btnUserManager = new Z.WMS.UControls.UMenuButton();
            this.btnStoreTemperManage = new Z.WMS.UControls.UMenuButton();
            this.btnProductManage = new Z.WMS.UControls.UMenuButton();
            this.btnStoreManage = new Z.WMS.UControls.UMenuButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new Z.WMS.UControls.UIconButton();
            this.btnMax = new Z.WMS.UControls.UIconButton();
            this.btnMin = new Z.WMS.UControls.UIconButton();
            this.btnReportManager = new Z.WMS.UControls.UMenuButton();
            this.panel2.SuspendLayout();
            this.uPanel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.lblLoginTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblLoginUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(3, 739);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 59);
            this.panel2.TabIndex = 7;
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.AutoSize = true;
            this.lblLoginTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginTime.ForeColor = System.Drawing.Color.White;
            this.lblLoginTime.Location = new System.Drawing.Point(435, 14);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(0, 24);
            this.lblLoginTime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(321, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "登录时间：";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginUser.ForeColor = System.Drawing.Color.White;
            this.lblLoginUser.Location = new System.Drawing.Point(107, 14);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(0, 24);
            this.lblLoginUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录者：";
            // 
            // panelPageTop
            // 
            this.panelPageTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPageTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panelPageTop.Location = new System.Drawing.Point(312, 100);
            this.panelPageTop.Name = "panelPageTop";
            this.panelPageTop.Size = new System.Drawing.Size(1015, 40);
            this.panelPageTop.TabIndex = 8;
            // 
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.Location = new System.Drawing.Point(312, 157);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(1015, 573);
            this.panelPage.TabIndex = 10;
            // 
            // uPanel1
            // 
            this.uPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uPanel1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel1.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel1.BorderColor = System.Drawing.Color.Red;
            this.uPanel1.Controls.Add(this.btnReportManager);
            this.uPanel1.Controls.Add(this.btnUserManager);
            this.uPanel1.Controls.Add(this.btnStoreTemperManage);
            this.uPanel1.Controls.Add(this.btnProductManage);
            this.uPanel1.Controls.Add(this.btnStoreManage);
            this.uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel1.Location = new System.Drawing.Point(8, 100);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 8;
            this.uPanel1.Size = new System.Drawing.Size(276, 630);
            this.uPanel1.TabIndex = 1;
            // 
            // btnUserManager
            // 
            this.btnUserManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnUserManager.BtnImg = global::Z.WMS.Properties.Resources._05;
            this.btnUserManager.BtnText = "用户管理";
            this.btnUserManager.IsCheck = false;
            this.btnUserManager.Location = new System.Drawing.Point(1, 262);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(274, 60);
            this.btnUserManager.TabIndex = 0;
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // btnStoreTemperManage
            // 
            this.btnStoreTemperManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStoreTemperManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnStoreTemperManage.BtnImg = global::Z.WMS.Properties.Resources._04;
            this.btnStoreTemperManage.BtnText = "仓库温控管理";
            this.btnStoreTemperManage.IsCheck = false;
            this.btnStoreTemperManage.Location = new System.Drawing.Point(1, 142);
            this.btnStoreTemperManage.Name = "btnStoreTemperManage";
            this.btnStoreTemperManage.Size = new System.Drawing.Size(274, 60);
            this.btnStoreTemperManage.TabIndex = 0;
            this.btnStoreTemperManage.Click += new System.EventHandler(this.btnStoreTemperManage_Click);
            // 
            // btnProductManage
            // 
            this.btnProductManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnProductManage.BtnImg = global::Z.WMS.Properties.Resources._03;
            this.btnProductManage.BtnText = "产品管理";
            this.btnProductManage.IsCheck = false;
            this.btnProductManage.Location = new System.Drawing.Point(1, 80);
            this.btnProductManage.Name = "btnProductManage";
            this.btnProductManage.Size = new System.Drawing.Size(274, 60);
            this.btnProductManage.TabIndex = 0;
            this.btnProductManage.Click += new System.EventHandler(this.btnProductManage_Click);
            // 
            // btnStoreManage
            // 
            this.btnStoreManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStoreManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnStoreManage.BtnImg = global::Z.WMS.Properties.Resources._02;
            this.btnStoreManage.BtnText = "仓库管理";
            this.btnStoreManage.IsCheck = false;
            this.btnStoreManage.Location = new System.Drawing.Point(1, 18);
            this.btnStoreManage.Name = "btnStoreManage";
            this.btnStoreManage.Size = new System.Drawing.Size(274, 60);
            this.btnStoreManage.TabIndex = 0;
            this.btnStoreManage.Click += new System.EventHandler(this.btnStoreManage_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::Z.WMS.Properties.Resources.logo;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1376, 89);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(1319, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "r";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.btnMax.ForeColor = System.Drawing.Color.Silver;
            this.btnMax.Location = new System.Drawing.Point(1270, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "1";
            this.btnMax.UseVisualStyleBackColor = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Webdings", 10.8F);
            this.btnMin.ForeColor = System.Drawing.Color.Silver;
            this.btnMin.Location = new System.Drawing.Point(1222, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 0;
            this.btnMin.Text = "0";
            this.btnMin.UseVisualStyleBackColor = false;
            // 
            // btnReportManager
            // 
            this.btnReportManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnReportManager.BtnImg = ((System.Drawing.Image)(resources.GetObject("btnReportManager.BtnImg")));
            this.btnReportManager.BtnText = "报表管理";
            this.btnReportManager.IsCheck = false;
            this.btnReportManager.Location = new System.Drawing.Point(1, 202);
            this.btnReportManager.Name = "btnReportManager";
            this.btnReportManager.Size = new System.Drawing.Size(274, 60);
            this.btnReportManager.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1382, 800);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.panelPageTop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.uPanel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "仓库温控系统主页面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.uPanel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private UControls.UPanel uPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPageTop;
        private System.Windows.Forms.Panel panelPage;
        private UControls.UMenuButton btnStoreManage;
        private UControls.UIconButton btnClose;
        private UControls.UIconButton btnMax;
        private UControls.UIconButton btnMin;
        private UControls.UMenuButton btnStoreTemperManage;
        private UControls.UMenuButton btnProductManage;
        private UControls.UMenuButton btnUserManager;
        private UControls.UMenuButton btnReportManager;
    }
}

