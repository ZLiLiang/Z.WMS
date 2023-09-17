namespace Z.WMS.StoreTemper
{
    partial class FormStoreRegionTemperatureList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.uPanel1 = new Z.WMS.UControls.UPanel();
            this.uPanel2 = new Z.WMS.UControls.UPanel();
            this.uPanel3 = new Z.WMS.UControls.UPanel();
            this.uIndicatorLight1 = new Z.WMS.UControls.UIndicatorLight();
            this.uIndicatorLight2 = new Z.WMS.UControls.UIndicatorLight();
            this.uIndicatorLight3 = new Z.WMS.UControls.UIndicatorLight();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRefresh = new Z.WMS.UControls.UCircleButton();
            this.cboStores = new System.Windows.Forms.ComboBox();
            this.flpRegionList = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.uCircle1 = new Z.WMS.UControls.UCircle();
            this.uPanel1.SuspendLayout();
            this.uPanel2.SuspendLayout();
            this.uPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uPanel1
            // 
            this.uPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanel1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanel1.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel1.BorderColor = System.Drawing.Color.Red;
            this.uPanel1.Controls.Add(this.uCircle1);
            this.uPanel1.Controls.Add(this.label6);
            this.uPanel1.Controls.Add(this.uIndicatorLight3);
            this.uPanel1.Controls.Add(this.uIndicatorLight2);
            this.uPanel1.Controls.Add(this.uIndicatorLight1);
            this.uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel1.Location = new System.Drawing.Point(1, 127);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 8;
            this.uPanel1.Size = new System.Drawing.Size(993, 50);
            this.uPanel1.TabIndex = 3;
            // 
            // uPanel2
            // 
            this.uPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.Controls.Add(this.lblMsg);
            this.uPanel2.Controls.Add(this.label1);
            this.uPanel2.Controls.Add(this.cboStores);
            this.uPanel2.Controls.Add(this.btnRefresh);
            this.uPanel2.Controls.Add(this.btnCheck);
            this.uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel2.Location = new System.Drawing.Point(4, 58);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Radius = 0;
            this.uPanel2.Size = new System.Drawing.Size(988, 63);
            this.uPanel2.TabIndex = 5;
            // 
            // uPanel3
            // 
            this.uPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPanel3.BackColor = System.Drawing.Color.Transparent;
            this.uPanel3.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanel3.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel3.BorderColor = System.Drawing.Color.Red;
            this.uPanel3.Controls.Add(this.lblInfo);
            this.uPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel3.Location = new System.Drawing.Point(0, 0);
            this.uPanel3.Name = "uPanel3";
            this.uPanel3.Radius = 5;
            this.uPanel3.Size = new System.Drawing.Size(996, 60);
            this.uPanel3.TabIndex = 4;
            // 
            // uIndicatorLight1
            // 
            this.uIndicatorLight1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uIndicatorLight1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uIndicatorLight1.CireCleColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.uIndicatorLight1.LightText = "低温";
            this.uIndicatorLight1.Location = new System.Drawing.Point(655, 5);
            this.uIndicatorLight1.Name = "uIndicatorLight1";
            this.uIndicatorLight1.Size = new System.Drawing.Size(91, 40);
            this.uIndicatorLight1.TabIndex = 3;
            // 
            // uIndicatorLight2
            // 
            this.uIndicatorLight2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uIndicatorLight2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uIndicatorLight2.CireCleColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.uIndicatorLight2.LightText = "高温";
            this.uIndicatorLight2.Location = new System.Drawing.Point(762, 5);
            this.uIndicatorLight2.Name = "uIndicatorLight2";
            this.uIndicatorLight2.Size = new System.Drawing.Size(91, 40);
            this.uIndicatorLight2.TabIndex = 4;
            // 
            // uIndicatorLight3
            // 
            this.uIndicatorLight3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uIndicatorLight3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uIndicatorLight3.CireCleColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(206)))), ((int)(((byte)(244)))));
            this.uIndicatorLight3.LightText = "正常";
            this.uIndicatorLight3.Location = new System.Drawing.Point(870, 5);
            this.uIndicatorLight3.Name = "uIndicatorLight3";
            this.uIndicatorLight3.Size = new System.Drawing.Size(91, 40);
            this.uIndicatorLight3.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(396, 12);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(117, 38);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "手动检测";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.btnRefresh.BgColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefresh.BgColor2 = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnRefresh.Location = new System.Drawing.Point(910, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 33);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboStores
            // 
            this.cboStores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.cboStores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStores.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.cboStores.ForeColor = System.Drawing.Color.White;
            this.cboStores.FormattingEnabled = true;
            this.cboStores.Location = new System.Drawing.Point(153, 13);
            this.cboStores.Name = "cboStores";
            this.cboStores.Size = new System.Drawing.Size(207, 32);
            this.cboStores.TabIndex = 11;
            this.cboStores.SelectedIndexChanged += new System.EventHandler(this.cboStores_SelectedIndexChanged);
            // 
            // flpRegionList
            // 
            this.flpRegionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpRegionList.AutoScroll = true;
            this.flpRegionList.ForeColor = System.Drawing.Color.White;
            this.flpRegionList.Location = new System.Drawing.Point(4, 183);
            this.flpRegionList.Name = "flpRegionList";
            this.flpRegionList.Size = new System.Drawing.Size(988, 397);
            this.flpRegionList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "仓库选择：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "仓库分区列表：";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(154, 24);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "仓库温控管理页面";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F);
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(531, 19);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(100, 24);
            this.lblMsg.TabIndex = 12;
            this.lblMsg.Text = "检测完成！";
            // 
            // uCircle1
            // 
            this.uCircle1.BackColor = System.Drawing.Color.Transparent;
            this.uCircle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.uCircle1.Location = new System.Drawing.Point(756, 18);
            this.uCircle1.Name = "uCircle1";
            this.uCircle1.Size = new System.Drawing.Size(0, 0);
            this.uCircle1.TabIndex = 2;
            // 
            // FormStoreRegionTemperatureList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.flpRegionList);
            this.Controls.Add(this.uPanel3);
            this.Controls.Add(this.uPanel2);
            this.Controls.Add(this.uPanel1);
            this.Name = "FormStoreRegionTemperatureList";
            this.ShowIcon = false;
            this.Text = "仓库温控管理页面";
            this.Load += new System.EventHandler(this.FormStoreRegionTemperatureList_Load);
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.uPanel2.ResumeLayout(false);
            this.uPanel2.PerformLayout();
            this.uPanel3.ResumeLayout(false);
            this.uPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UControls.UPanel uPanel1;
        private UControls.UPanel uPanel2;
        private UControls.UPanel uPanel3;
        private UControls.UIndicatorLight uIndicatorLight3;
        private UControls.UIndicatorLight uIndicatorLight2;
        private UControls.UIndicatorLight uIndicatorLight1;
        private System.Windows.Forms.Button btnCheck;
        private UControls.UCircleButton btnRefresh;
        private System.Windows.Forms.ComboBox cboStores;
        private System.Windows.Forms.FlowLayoutPanel flpRegionList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private UControls.UCircle uCircle1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblInfo;
    }
}