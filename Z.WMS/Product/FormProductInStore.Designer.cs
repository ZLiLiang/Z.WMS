using System;
using Z.WMS.UControls;

namespace Z.WMS.Product
{
    partial class FormProductInStore
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
            this.lblTypeName = new System.Windows.Forms.Label();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnInstoreRecords = new System.Windows.Forms.Button();
            this.dgvProductInstores = new System.Windows.Forms.DataGridView();
            this.ProStoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInstore = new System.Windows.Forms.Button();
            this.txtProductCount = new System.Windows.Forms.NumericUpDown();
            this.cboSRegionList = new System.Windows.Forms.ComboBox();
            this.cboStores = new System.Windows.Forms.ComboBox();
            this.cboProductList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uPanel1 = new Z.WMS.UControls.UPanel();
            this.btnRefresh = new Z.WMS.UControls.UCircleButton();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInstores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCount)).BeginInit();
            this.uPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTypeName.ForeColor = System.Drawing.Color.White;
            this.lblTypeName.Location = new System.Drawing.Point(14, 100);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(84, 20);
            this.lblTypeName.TabIndex = 16;
            this.lblTypeName.Text = "入库记录：";
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(122)))), ((int)(((byte)(200)))));
            this.btnProductList.FlatAppearance.BorderSize = 0;
            this.btnProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductList.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnProductList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductList.Location = new System.Drawing.Point(163, 89);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(184, 39);
            this.btnProductList.TabIndex = 17;
            this.btnProductList.Text = " 产品库存列表";
            this.btnProductList.UseVisualStyleBackColor = false;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnInstoreRecords
            // 
            this.btnInstoreRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btnInstoreRecords.FlatAppearance.BorderSize = 0;
            this.btnInstoreRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstoreRecords.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInstoreRecords.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInstoreRecords.Location = new System.Drawing.Point(368, 90);
            this.btnInstoreRecords.Name = "btnInstoreRecords";
            this.btnInstoreRecords.Size = new System.Drawing.Size(184, 39);
            this.btnInstoreRecords.TabIndex = 17;
            this.btnInstoreRecords.Text = " 产品入库记录";
            this.btnInstoreRecords.UseVisualStyleBackColor = false;
            this.btnInstoreRecords.Click += new System.EventHandler(this.btnInstoreRecords_Click);
            // 
            // dgvProductInstores
            // 
            this.dgvProductInstores.AllowUserToAddRows = false;
            this.dgvProductInstores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductInstores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductInstores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductInstores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductInstores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductInstores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductInstores.ColumnHeadersHeight = 35;
            this.dgvProductInstores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductInstores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProStoreId,
            this.ProductName,
            this.StoreName,
            this.SRegionName,
            this.ProductCount});
            this.dgvProductInstores.EnableHeadersVisualStyles = false;
            this.dgvProductInstores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.dgvProductInstores.Location = new System.Drawing.Point(3, 147);
            this.dgvProductInstores.Name = "dgvProductInstores";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductInstores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductInstores.RowHeadersWidth = 51;
            this.dgvProductInstores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.dgvProductInstores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductInstores.RowTemplate.Height = 27;
            this.dgvProductInstores.Size = new System.Drawing.Size(619, 434);
            this.dgvProductInstores.TabIndex = 18;
            // 
            // ProStoreId
            // 
            this.ProStoreId.DataPropertyName = "ProStoreId";
            this.ProStoreId.FillWeight = 60F;
            this.ProStoreId.HeaderText = "编号";
            this.ProStoreId.MinimumWidth = 6;
            this.ProStoreId.Name = "ProStoreId";
            this.ProStoreId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 150F;
            this.ProductName.HeaderText = "产品名称";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.HeaderText = "仓库";
            this.StoreName.MinimumWidth = 6;
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // SRegionName
            // 
            this.SRegionName.DataPropertyName = "SRegionName";
            this.SRegionName.HeaderText = "分区";
            this.SRegionName.MinimumWidth = 6;
            this.SRegionName.Name = "SRegionName";
            this.SRegionName.ReadOnly = true;
            // 
            // ProductCount
            // 
            this.ProductCount.DataPropertyName = "ProductCount";
            this.ProductCount.HeaderText = "库存数量";
            this.ProductCount.MinimumWidth = 6;
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnInstore);
            this.groupBox1.Controls.Add(this.txtProductCount);
            this.groupBox1.Controls.Add(this.cboSRegionList);
            this.groupBox1.Controls.Add(this.cboStores);
            this.groupBox1.Controls.Add(this.cboProductList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(639, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 366);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "产品入库设置";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(176, 306);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(62, 33);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInstore
            // 
            this.btnInstore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnInstore.FlatAppearance.BorderSize = 0;
            this.btnInstore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInstore.Location = new System.Drawing.Point(73, 306);
            this.btnInstore.Name = "btnInstore";
            this.btnInstore.Size = new System.Drawing.Size(62, 33);
            this.btnInstore.TabIndex = 7;
            this.btnInstore.Text = "入库";
            this.btnInstore.UseVisualStyleBackColor = false;
            this.btnInstore.Click += new System.EventHandler(this.btnInstore_Click);
            // 
            // txtProductCount
            // 
            this.txtProductCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.txtProductCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProductCount.ForeColor = System.Drawing.Color.White;
            this.txtProductCount.Location = new System.Drawing.Point(120, 232);
            this.txtProductCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.Size = new System.Drawing.Size(182, 27);
            this.txtProductCount.TabIndex = 6;
            // 
            // cboSRegionList
            // 
            this.cboSRegionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.cboSRegionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSRegionList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSRegionList.ForeColor = System.Drawing.Color.White;
            this.cboSRegionList.FormattingEnabled = true;
            this.cboSRegionList.Location = new System.Drawing.Point(119, 176);
            this.cboSRegionList.Name = "cboSRegionList";
            this.cboSRegionList.Size = new System.Drawing.Size(183, 28);
            this.cboSRegionList.TabIndex = 5;
            // 
            // cboStores
            // 
            this.cboStores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.cboStores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStores.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStores.ForeColor = System.Drawing.Color.White;
            this.cboStores.FormattingEnabled = true;
            this.cboStores.Location = new System.Drawing.Point(120, 114);
            this.cboStores.Name = "cboStores";
            this.cboStores.Size = new System.Drawing.Size(183, 28);
            this.cboStores.TabIndex = 5;
            this.cboStores.SelectedIndexChanged += new System.EventHandler(this.cboStores_SelectedIndexChanged);
            // 
            // cboProductList
            // 
            this.cboProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.cboProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProductList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboProductList.ForeColor = System.Drawing.Color.White;
            this.cboProductList.FormattingEnabled = true;
            this.cboProductList.Location = new System.Drawing.Point(119, 54);
            this.cboProductList.Name = "cboProductList";
            this.cboProductList.Size = new System.Drawing.Size(183, 28);
            this.cboProductList.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(28, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "入库数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(28, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "仓库分区：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "入库仓库：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "入库产品：";
            // 
            // uPanel1
            // 
            this.uPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uPanel1.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanel1.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel1.BorderColor = System.Drawing.Color.Red;
            this.uPanel1.Controls.Add(this.btnRefresh);
            this.uPanel1.Controls.Add(this.lblInfo);
            this.uPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel1.Location = new System.Drawing.Point(0, 0);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Radius = 5;
            this.uPanel1.Size = new System.Drawing.Size(996, 60);
            this.uPanel1.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.btnRefresh.BgColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefresh.BgColor2 = System.Drawing.Color.MidnightBlue;
            this.btnRefresh.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnRefresh.Location = new System.Drawing.Point(882, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Radius = 5;
            this.btnRefresh.Size = new System.Drawing.Size(60, 33);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(126, 25);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "产品入库页面";
            // 
            // FrmProductInStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductInstores);
            this.Controls.Add(this.btnInstoreRecords);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.uPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmProductInStore";
            this.ShowIcon = false;
            this.Text = "产品入库页面";
            this.Load += new System.EventHandler(this.FrmProductInStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInstores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCount)).EndInit();
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UControls.UPanel uPanel1;
        private UControls.UCircleButton btnRefresh;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnInstoreRecords;
        private System.Windows.Forms.DataGridView dgvProductInstores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProStoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboProductList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSRegionList;
        private System.Windows.Forms.ComboBox cboStores;
        private System.Windows.Forms.NumericUpDown txtProductCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInstore;
    }
}