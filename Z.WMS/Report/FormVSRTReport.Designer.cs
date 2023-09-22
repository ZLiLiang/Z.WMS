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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uPanel1 = new Z.WMS.UControls.UPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.uPanel2 = new Z.WMS.UControls.UPanel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvVPSList = new System.Windows.Forms.DataGridView();
            this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowLowTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowHighTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPanel1.SuspendLayout();
            this.uPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVPSList)).BeginInit();
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
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvVPSList
            // 
            this.dgvVPSList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVPSList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVPSList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvVPSList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVPSList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVPSList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVPSList.ColumnHeadersHeight = 29;
            this.dgvVPSList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVPSList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreId,
            this.SRegionId,
            this.SRegionName,
            this.SRTemperature,
            this.AllowLowTemperature,
            this.AllowHighTemperature,
            this.TotalCount});
            this.dgvVPSList.EnableHeadersVisualStyles = false;
            this.dgvVPSList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.dgvVPSList.Location = new System.Drawing.Point(2, 123);
            this.dgvVPSList.Name = "dgvVPSList";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVPSList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVPSList.RowHeadersWidth = 51;
            this.dgvVPSList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.dgvVPSList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVPSList.RowTemplate.Height = 27;
            this.dgvVPSList.Size = new System.Drawing.Size(993, 460);
            this.dgvVPSList.TabIndex = 6;
            // 
            // StoreId
            // 
            this.StoreId.DataPropertyName = "StoreId";
            this.StoreId.HeaderText = "仓库标识";
            this.StoreId.MinimumWidth = 6;
            this.StoreId.Name = "StoreId";
            // 
            // SRegionId
            // 
            this.SRegionId.DataPropertyName = "SRegionId";
            this.SRegionId.HeaderText = "仓库区域标识";
            this.SRegionId.MinimumWidth = 6;
            this.SRegionId.Name = "SRegionId";
            // 
            // SRegionName
            // 
            this.SRegionName.DataPropertyName = "SRegionName";
            this.SRegionName.HeaderText = "仓库区域名称";
            this.SRegionName.MinimumWidth = 6;
            this.SRegionName.Name = "SRegionName";
            // 
            // SRTemperature
            // 
            this.SRTemperature.DataPropertyName = "SRTemperature";
            this.SRTemperature.HeaderText = "仓库区域温度";
            this.SRTemperature.MinimumWidth = 6;
            this.SRTemperature.Name = "SRTemperature";
            // 
            // AllowLowTemperature
            // 
            this.AllowLowTemperature.DataPropertyName = "AllowLowTemperature";
            this.AllowLowTemperature.HeaderText = "最低温度线";
            this.AllowLowTemperature.MinimumWidth = 6;
            this.AllowLowTemperature.Name = "AllowLowTemperature";
            // 
            // AllowHighTemperature
            // 
            this.AllowHighTemperature.DataPropertyName = "AllowHighTemperature";
            this.AllowHighTemperature.HeaderText = "最高温度线";
            this.AllowHighTemperature.MinimumWidth = 6;
            this.AllowHighTemperature.Name = "AllowHighTemperature";
            // 
            // TotalCount
            // 
            this.TotalCount.DataPropertyName = "TotalCount";
            this.TotalCount.HeaderText = "总数";
            this.TotalCount.MinimumWidth = 6;
            this.TotalCount.Name = "TotalCount";
            // 
            // FormVSRTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.dgvVPSList);
            this.Controls.Add(this.uPanel2);
            this.Controls.Add(this.uPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(996, 585);
            this.Name = "FormVSRTReport";
            this.ShowIcon = false;
            this.Text = "仓库分区温度报表页面";
            this.Load += new System.EventHandler(this.FormVSRTReport_Load);
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.uPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVPSList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UControls.UPanel uPanel1;
        private System.Windows.Forms.Label lblInfo;
        private UControls.UPanel uPanel2;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvVPSList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowLowTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowHighTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCount;
    }
}