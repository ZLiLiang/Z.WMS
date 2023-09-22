namespace Z.WMS.Report
{
    partial class FormVSRTReport
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uPanel2 = new Z.WMS.UControls.UPanel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.uPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.uPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uPanel1
            // 
            this.uPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uPanel1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanel1.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel1.BorderColor = System.Drawing.Color.Red;
            this.uPanel1.Controls.Add(this.lblInfo);
            this.uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel1.Location = new System.Drawing.Point(0, 0);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 5;
            this.uPanel1.Size = new System.Drawing.Size(996, 60);
            this.uPanel1.TabIndex = 0;
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
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "仓库分区温度报表";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.dataGridView1.Location = new System.Drawing.Point(2, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(993, 460);
            this.dataGridView1.TabIndex = 1;
            // 
            // uPanel2
            // 
            this.uPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.Controls.Add(this.btnExportExcel);
            this.uPanel2.Controls.Add(this.btnRefresh);
            this.uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel2.Location = new System.Drawing.Point(4, 58);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Radius = 5;
            this.uPanel2.Size = new System.Drawing.Size(988, 58);
            this.uPanel2.TabIndex = 2;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(246)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(116, 15);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 30);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "导出";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(246)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(26, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // FormVSRTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.uPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(996, 585);
            this.Name = "FormVSRTReport";
            this.ShowIcon = false;
            this.Text = "仓库分区温度报表页面";
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.uPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UControls.UPanel uPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblInfo;
        private UControls.UPanel uPanel2;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnRefresh;
    }
}