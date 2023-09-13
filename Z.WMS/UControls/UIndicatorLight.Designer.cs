using System.Drawing;
using System.Windows.Forms;

namespace Z.WMS.UControls
{
    partial class UIndicatorLight
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uCircleLight = new UCircle();
            this.lblState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uCircleLight
            //
            this.uCircleLight.ForeColor = Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.uCircleLight.Location = new Point(13, 12);
            this.uCircleLight.Name = "uCircleLight";
            this.uCircleLight.Size = new Size(16, 16);
            this.uCircleLight.TabIndex = 0;
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            this.lblState.Location = new Point(30, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new Size(59, 40);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "低温";
            this.lblState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UIndicatorLight
            //
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.uCircleLight);
            this.Name = "UIndicatorLight";
            this.Size = new System.Drawing.Size(91, 40);
            this.ResumeLayout(false);
        }

        #endregion

        private UCircle uCircleLight;
        private System.Windows.Forms.Label lblState;
    }
}
