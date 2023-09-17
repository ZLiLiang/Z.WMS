namespace Z.WMS.StoreTemper
{
    partial class FormSetSRegionTemperature
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkWayList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSetType = new System.Windows.Forms.Label();
            this.lbMsg = new System.Windows.Forms.ListBox();
            this.txtTemperature = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(146, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(52, 297);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(66, 31);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkWayList
            // 
            this.chkWayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.chkWayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkWayList.CheckOnClick = true;
            this.chkWayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkWayList.ForeColor = System.Drawing.Color.White;
            this.chkWayList.FormattingEnabled = true;
            this.chkWayList.Items.AddRange(new object[] {
            "上调空调温度",
            "打开暖气",
            "关闭窗户"});
            this.chkWayList.Location = new System.Drawing.Point(52, 156);
            this.chkWayList.Name = "chkWayList";
            this.chkWayList.Size = new System.Drawing.Size(179, 92);
            this.chkWayList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "调整方式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "目标室温：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "调温方法：";
            // 
            // lblSetType
            // 
            this.lblSetType.AutoSize = true;
            this.lblSetType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lblSetType.ForeColor = System.Drawing.Color.Red;
            this.lblSetType.Location = new System.Drawing.Point(112, 26);
            this.lblSetType.Name = "lblSetType";
            this.lblSetType.Size = new System.Drawing.Size(39, 19);
            this.lblSetType.TabIndex = 0;
            this.lblSetType.Text = "升温";
            // 
            // lbMsg
            // 
            this.lbMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.lbMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMsg.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.lbMsg.ForeColor = System.Drawing.Color.White;
            this.lbMsg.FormattingEnabled = true;
            this.lbMsg.ItemHeight = 24;
            this.lbMsg.Location = new System.Drawing.Point(292, 26);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(377, 290);
            this.lbMsg.TabIndex = 4;
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.txtTemperature.DecimalPlaces = 2;
            this.txtTemperature.ForeColor = System.Drawing.Color.White;
            this.txtTemperature.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txtTemperature.Location = new System.Drawing.Point(115, 69);
            this.txtTemperature.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(120, 25);
            this.txtTemperature.TabIndex = 2;
            this.txtTemperature.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // FormSetSRegionTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(688, 367);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.lblSetType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkWayList);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetSRegionTemperature";
            this.ShowIcon = false;
            this.Text = "调整仓库分区温度";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSetSRegionTemperature_FormClosing);
            this.Load += new System.EventHandler(this.FormSetSRegionTemperature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckedListBox chkWayList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSetType;
        private System.Windows.Forms.ListBox lbMsg;
        private System.Windows.Forms.NumericUpDown txtTemperature;
    }
}