namespace Z.WMS.Store
{
    partial class FormStoreList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStoreList = new System.Windows.Forms.DataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegionCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddRegion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.uPanel2 = new Z.WMS.UControls.UPanel();
            this.chkShowDel = new System.Windows.Forms.CheckBox();
            this.btnDelete = new Z.WMS.UControls.UCircleButton();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uPanel1 = new Z.WMS.UControls.UPanel();
            this.btnRefresh = new Z.WMS.UControls.UCircleButton();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).BeginInit();
            this.uPanel2.SuspendLayout();
            this.uPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStoreList
            // 
            this.dgvStoreList.AllowUserToAddRows = false;
            this.dgvStoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStoreList.BackgroundColor = System.Drawing.Color.White;
            this.dgvStoreList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStoreList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStoreList.ColumnHeadersHeight = 35;
            this.dgvStoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.StoreId,
            this.StoreNo,
            this.StoreName,
            this.RegionCount,
            this.Remark,
            this.colAddRegion,
            this.colEdit,
            this.colDel,
            this.colRecover,
            this.colRemove});
            this.dgvStoreList.EnableHeadersVisualStyles = false;
            this.dgvStoreList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.dgvStoreList.Location = new System.Drawing.Point(2, 122);
            this.dgvStoreList.Name = "dgvStoreList";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStoreList.RowHeadersWidth = 51;
            this.dgvStoreList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.dgvStoreList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStoreList.RowTemplate.Height = 27;
            this.dgvStoreList.Size = new System.Drawing.Size(993, 460);
            this.dgvStoreList.TabIndex = 2;
            this.dgvStoreList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreList_CellContentClick);
            // 
            // colChk
            // 
            this.colChk.FillWeight = 60F;
            this.colChk.HeaderText = "选择";
            this.colChk.MinimumWidth = 6;
            this.colChk.Name = "colChk";
            // 
            // StoreId
            // 
            this.StoreId.DataPropertyName = "StoreId";
            this.StoreId.FillWeight = 60F;
            this.StoreId.HeaderText = "编号";
            this.StoreId.MinimumWidth = 6;
            this.StoreId.Name = "StoreId";
            this.StoreId.ReadOnly = true;
            // 
            // StoreNo
            // 
            this.StoreNo.DataPropertyName = "StoreNo";
            this.StoreNo.HeaderText = "仓库编码";
            this.StoreNo.MinimumWidth = 6;
            this.StoreNo.Name = "StoreNo";
            this.StoreNo.ReadOnly = true;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.FillWeight = 150F;
            this.StoreName.HeaderText = "仓库名称";
            this.StoreName.MinimumWidth = 6;
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // RegionCount
            // 
            this.RegionCount.DataPropertyName = "RegionCount";
            this.RegionCount.FillWeight = 80F;
            this.RegionCount.HeaderText = "分区数";
            this.RegionCount.MinimumWidth = 6;
            this.RegionCount.Name = "RegionCount";
            this.RegionCount.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 200F;
            this.Remark.HeaderText = "描述";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // colAddRegion
            // 
            this.colAddRegion.ActiveLinkColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.NullValue = "添加分区";
            this.colAddRegion.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAddRegion.HeaderText = "添加分区";
            this.colAddRegion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colAddRegion.MinimumWidth = 6;
            this.colAddRegion.Name = "colAddRegion";
            this.colAddRegion.TrackVisitedState = false;
            // 
            // colEdit
            // 
            this.colEdit.ActiveLinkColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.NullValue = "修改";
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle3;
            this.colEdit.FillWeight = 60F;
            this.colEdit.HeaderText = "修改";
            this.colEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.TrackVisitedState = false;
            // 
            // colDel
            // 
            this.colDel.ActiveLinkColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.NullValue = "删除";
            this.colDel.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDel.FillWeight = 60F;
            this.colDel.HeaderText = "删除";
            this.colDel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.TrackVisitedState = false;
            // 
            // colRecover
            // 
            this.colRecover.ActiveLinkColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.NullValue = "恢复";
            this.colRecover.DefaultCellStyle = dataGridViewCellStyle5;
            this.colRecover.FillWeight = 60F;
            this.colRecover.HeaderText = "恢复";
            this.colRecover.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRecover.MinimumWidth = 6;
            this.colRecover.Name = "colRecover";
            this.colRecover.TrackVisitedState = false;
            // 
            // colRemove
            // 
            this.colRemove.ActiveLinkColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.NullValue = "移除";
            this.colRemove.DefaultCellStyle = dataGridViewCellStyle6;
            this.colRemove.FillWeight = 60F;
            this.colRemove.HeaderText = "移除";
            this.colRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRemove.MinimumWidth = 6;
            this.colRemove.Name = "colRemove";
            this.colRemove.TrackVisitedState = false;
            // 
            // uPanel2
            // 
            this.uPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanel2.Controls.Add(this.chkShowDel);
            this.uPanel2.Controls.Add(this.btnDelete);
            this.uPanel2.Controls.Add(this.txtKeyWords);
            this.uPanel2.Controls.Add(this.btnAdd);
            this.uPanel2.Controls.Add(this.btnFind);
            this.uPanel2.Controls.Add(this.label2);
            this.uPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.uPanel2.Location = new System.Drawing.Point(4, 58);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Radius = 0;
            this.uPanel2.Size = new System.Drawing.Size(988, 58);
            this.uPanel2.TabIndex = 1;
            // 
            // chkShowDel
            // 
            this.chkShowDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowDel.AutoSize = true;
            this.chkShowDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShowDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowDel.ForeColor = System.Drawing.Color.Chocolate;
            this.chkShowDel.Location = new System.Drawing.Point(866, 18);
            this.chkShowDel.Name = "chkShowDel";
            this.chkShowDel.Size = new System.Drawing.Size(72, 24);
            this.chkShowDel.TabIndex = 10;
            this.chkShowDel.Text = "已删除";
            this.chkShowDel.UseVisualStyleBackColor = true;
            this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(122)))));
            this.btnDelete.BgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnDelete.Location = new System.Drawing.Point(539, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 15;
            this.btnDelete.Size = new System.Drawing.Size(65, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.txtKeyWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyWords.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKeyWords.ForeColor = System.Drawing.Color.White;
            this.txtKeyWords.Location = new System.Drawing.Point(245, 17);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(142, 27);
            this.txtKeyWords.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(103)))), ((int)(((byte)(246)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(26, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(422, 15);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(62, 30);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.label2.Location = new System.Drawing.Point(119, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "仓库名称/编码：";
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
            this.uPanel1.TabIndex = 0;
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
            this.btnRefresh.Location = new System.Drawing.Point(902, 16);
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
            this.lblInfo.Text = "仓库管理页面";
            // 
            // FrmStoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.dgvStoreList);
            this.Controls.Add(this.uPanel2);
            this.Controls.Add(this.uPanel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(996, 585);
            this.Name = "FrmStoreList";
            this.ShowIcon = false;
            this.Text = "仓库信息管理页面";
            this.Load += new System.EventHandler(this.FormStoreList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreList)).EndInit();
            this.uPanel2.ResumeLayout(false);
            this.uPanel2.PerformLayout();
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UControls.UPanel uPanel1;
        private UControls.UPanel uPanel2;
        private UControls.UCircleButton btnRefresh;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox chkShowDel;
        private UControls.UCircleButton btnDelete;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStoreList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewLinkColumn colAddRegion;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDel;
        private System.Windows.Forms.DataGridViewLinkColumn colRecover;
        private System.Windows.Forms.DataGridViewLinkColumn colRemove;
    }
}