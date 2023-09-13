namespace Z.WMS.UControls
{
    partial class UStoreRegionBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetTemperature = new UCircleButton();
            this.lblRegionName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uTemperValue = new UThermometer();
            this.SRTemperLight = new UCircle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTemperRange = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSRTemperature = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.btnSetTemperature);
            this.panel1.Controls.Add(this.lblRegionName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnSetTemperature
            // 
            this.btnSetTemperature.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(118)))));
            this.btnSetTemperature.BgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.btnSetTemperature.FlatAppearance.BorderSize = 0;
            this.btnSetTemperature.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetTemperature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTemperature.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetTemperature.ForeColor = System.Drawing.Color.White;
            this.btnSetTemperature.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnSetTemperature.Location = new System.Drawing.Point(251, 9);
            this.btnSetTemperature.Name = "btnSetTemperature";
            this.btnSetTemperature.Radius = 10;
            this.btnSetTemperature.Size = new System.Drawing.Size(53, 26);
            this.btnSetTemperature.TabIndex = 2;
            this.btnSetTemperature.Text = "升温";
            this.btnSetTemperature.UseVisualStyleBackColor = true;
            this.btnSetTemperature.Click += new System.EventHandler(this.btnSetTemperature_Click);
            // 
            // lblRegionName
            // 
            this.lblRegionName.AutoSize = true;
            this.lblRegionName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRegionName.ForeColor = System.Drawing.Color.White;
            this.lblRegionName.Location = new System.Drawing.Point(129, 9);
            this.lblRegionName.Name = "lblRegionName";
            this.lblRegionName.Size = new System.Drawing.Size(68, 26);
            this.lblRegionName.TabIndex = 1;
            this.lblRegionName.Text = "01-01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库分区";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.uTemperValue);
            this.panel2.Controls.Add(this.SRTemperLight);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTemperRange);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblSRTemperature);
            this.panel2.Controls.Add(this.lblProductCount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 168);
            this.panel2.TabIndex = 1;
            // 
            // uTemperValue
            // 
            this.uTemperValue.BMaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.uTemperValue.BMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uTemperValue.Font = new System.Drawing.Font("宋体", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uTemperValue.ForeColor = System.Drawing.Color.White;
            this.uTemperValue.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.uTemperValue.LeftTemperatureUnit = UThermometer.TemperatureUnit.C;
            this.uTemperValue.Location = new System.Drawing.Point(254, 6);
            this.uTemperValue.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.uTemperValue.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.uTemperValue.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uTemperValue.Name = "uTemperValue";
            this.uTemperValue.Size = new System.Drawing.Size(79, 150);
            this.uTemperValue.SpCount = 5;
            this.uTemperValue.TabIndex = 3;
            this.uTemperValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uTemperValue.ValueColor = System.Drawing.Color.White;
            this.uTemperValue.ValueFont = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // SRTemperLight
            // 
            this.SRTemperLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.SRTemperLight.Location = new System.Drawing.Point(110, 117);
            this.SRTemperLight.Name = "SRTemperLight";
            this.SRTemperLight.Size = new System.Drawing.Size(20, 20);
            this.SRTemperLight.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "当前状态：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "温度范围：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "室内温度：";
            // 
            // lblTemperRange
            // 
            this.lblTemperRange.AutoSize = true;
            this.lblTemperRange.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTemperRange.ForeColor = System.Drawing.Color.White;
            this.lblTemperRange.Location = new System.Drawing.Point(106, 85);
            this.lblTemperRange.Name = "lblTemperRange";
            this.lblTemperRange.Size = new System.Drawing.Size(100, 19);
            this.lblTemperRange.TabIndex = 1;
            this.lblTemperRange.Text = "22.5  ~ 29 ℃";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(150, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "℃";
            // 
            // lblSRTemperature
            // 
            this.lblSRTemperature.AutoSize = true;
            this.lblSRTemperature.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSRTemperature.ForeColor = System.Drawing.Color.Yellow;
            this.lblSRTemperature.Location = new System.Drawing.Point(106, 51);
            this.lblSRTemperature.Name = "lblSRTemperature";
            this.lblSRTemperature.Size = new System.Drawing.Size(40, 19);
            this.lblSRTemperature.TabIndex = 1;
            this.lblSRTemperature.Text = "25.9";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProductCount.ForeColor = System.Drawing.Color.White;
            this.lblProductCount.Location = new System.Drawing.Point(106, 14);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(36, 19);
            this.lblProductCount.TabIndex = 1;
            this.lblProductCount.Text = "500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "产品数量：";
            // 
            // UStoreRegionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UStoreRegionBox";
            this.Size = new System.Drawing.Size(348, 210);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UCircleButton btnSetTemperature;
        private System.Windows.Forms.Label lblRegionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private UThermometer uTemperValue;
        private UCircle SRTemperLight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTemperRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSRTemperature;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Label label2;
    }
}
