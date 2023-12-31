﻿namespace Z.WMS.Report
{
    partial class FormVSRReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVSRList = new System.Windows.Forms.DataGridView();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowLowTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowHighTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperStateText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPanel2 = new Z.WMS.UControls.UPanel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.uPanel1 = new Z.WMS.UControls.UPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVSRList)).BeginInit();
            this.uPanel2.SuspendLayout();
            this.uPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVSRList
            // 
            this.dgvVSRList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVSRList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVSRList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVSRList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvVSRList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVSRList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVSRList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVSRList.ColumnHeadersHeight = 29;
            this.dgvVSRList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVSRList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreName,
            this.StoreId,
            this.SRegionId,
            this.SRegionName,
            this.SRegionNo,
            this.SRTemperature,
            this.AllowLowTemperature,
            this.AllowHighTemperature,
            this.TemperStateText,
            this.Remark});
            this.dgvVSRList.EnableHeadersVisualStyles = false;
            this.dgvVSRList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.dgvVSRList.Location = new System.Drawing.Point(2, 123);
            this.dgvVSRList.Name = "dgvVSRList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVSRList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVSRList.RowHeadersWidth = 51;
            this.dgvVSRList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.dgvVSRList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVSRList.RowTemplate.Height = 27;
            this.dgvVSRList.Size = new System.Drawing.Size(993, 460);
            this.dgvVSRList.TabIndex = 6;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.HeaderText = "仓库名称";
            this.StoreName.MinimumWidth = 6;
            this.StoreName.Name = "StoreName";
            this.StoreName.Width = 97;
            // 
            // StoreId
            // 
            this.StoreId.DataPropertyName = "StoreId";
            this.StoreId.HeaderText = "仓库标识";
            this.StoreId.MinimumWidth = 6;
            this.StoreId.Name = "StoreId";
            this.StoreId.Width = 97;
            // 
            // SRegionId
            // 
            this.SRegionId.DataPropertyName = "SRegionId";
            this.SRegionId.HeaderText = "仓库区域标识";
            this.SRegionId.MinimumWidth = 6;
            this.SRegionId.Name = "SRegionId";
            this.SRegionId.Width = 127;
            // 
            // SRegionName
            // 
            this.SRegionName.DataPropertyName = "SRegionName";
            this.SRegionName.HeaderText = "仓库区域名字";
            this.SRegionName.MinimumWidth = 6;
            this.SRegionName.Name = "SRegionName";
            this.SRegionName.Width = 127;
            // 
            // SRegionNo
            // 
            this.SRegionNo.DataPropertyName = "SRegionNo";
            this.SRegionNo.HeaderText = "仓库区域编号";
            this.SRegionNo.MinimumWidth = 6;
            this.SRegionNo.Name = "SRegionNo";
            this.SRegionNo.Width = 127;
            // 
            // SRTemperature
            // 
            this.SRTemperature.DataPropertyName = "SRTemperature";
            this.SRTemperature.HeaderText = "仓库区域温度";
            this.SRTemperature.MinimumWidth = 6;
            this.SRTemperature.Name = "SRTemperature";
            this.SRTemperature.Width = 127;
            // 
            // AllowLowTemperature
            // 
            this.AllowLowTemperature.DataPropertyName = "AllowLowTemperature";
            this.AllowLowTemperature.HeaderText = "最低温度线";
            this.AllowLowTemperature.MinimumWidth = 6;
            this.AllowLowTemperature.Name = "AllowLowTemperature";
            this.AllowLowTemperature.Width = 112;
            // 
            // AllowHighTemperature
            // 
            this.AllowHighTemperature.DataPropertyName = "AllowHighTemperature";
            this.AllowHighTemperature.HeaderText = "最高温度线";
            this.AllowHighTemperature.MinimumWidth = 6;
            this.AllowHighTemperature.Name = "AllowHighTemperature";
            this.AllowHighTemperature.Width = 112;
            // 
            // TemperStateText
            // 
            this.TemperStateText.DataPropertyName = "TemperStateText";
            this.TemperStateText.HeaderText = "温度状态";
            this.TemperStateText.MinimumWidth = 6;
            this.TemperStateText.Name = "TemperStateText";
            this.TemperStateText.Width = 97;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "注释";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.Width = 67;
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
            this.lblInfo.Size = new System.Drawing.Size(118, 24);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "仓库分区报表";
            // 
            // FormVSRReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.dgvVSRList);
            this.Controls.Add(this.uPanel2);
            this.Controls.Add(this.uPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(996, 585);
            this.Name = "FormVSRReport";
            this.ShowIcon = false;
            this.Text = "仓库分区报表页面";
            this.Load += new System.EventHandler(this.FormVSRReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVSRList)).EndInit();
            this.uPanel2.ResumeLayout(false);
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UControls.UPanel uPanel1;
        private System.Windows.Forms.Label lblInfo;
        private UControls.UPanel uPanel2;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvVSRList;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowLowTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowHighTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperStateText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}