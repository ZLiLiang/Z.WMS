using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Z.WMS.UControls
{
    partial class UMenuButton
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
            this.lblBtnText = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBtnText
            // 
            this.lblBtnText.AutoSize = true;
            this.lblBtnText.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBtnText.ForeColor = System.Drawing.Color.White;
            this.lblBtnText.Location = new System.Drawing.Point(76, 13);
            this.lblBtnText.Name = "lblBtnText";
            this.lblBtnText.Size = new System.Drawing.Size(115, 33);
            this.lblBtnText.TabIndex = 1;
            this.lblBtnText.Text = "仓库管理";
            this.lblBtnText.Click += new System.EventHandler(this.lblBtnText_Click);
            this.lblBtnText.MouseEnter += new System.EventHandler(this.lblBtnText_MouseEnter);
            // 
            // pbImg
            // 
            this.pbImg.Image = global::Z.WMS.Properties.Resources._02;
            this.pbImg.Location = new System.Drawing.Point(23, 5);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(50, 50);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pbImg_Click);
            this.pbImg.MouseEnter += new System.EventHandler(this.pbImg_MouseEnter);
            // 
            // UMenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.Controls.Add(this.lblBtnText);
            this.Controls.Add(this.pbImg);
            this.Name = "UMenuButton";
            this.Size = new System.Drawing.Size(257, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbImg;
        private Label lblBtnText;
    }
}
