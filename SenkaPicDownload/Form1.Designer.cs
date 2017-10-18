namespace SenkaPicDownload
{
    partial class Form1
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.btnDownload = new System.Windows.Forms.Button();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "起始时间";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(208, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "结束时间";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 61);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "镇守府";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(116, 98);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(157, 39);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "下载";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "yyyy/MM";
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(83, 16);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(96, 26);
            this.dateStart.TabIndex = 1;
            this.dateStart.Value = new System.DateTime(2013, 7, 1, 15, 47, 0, 0);
            // 
            // dateEnd
            // 
            this.dateEnd.Checked = false;
            this.dateEnd.CustomFormat = "yyyy/MM";
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(279, 16);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(96, 26);
            this.dateEnd.TabIndex = 3;
            // 
            // cmbServer
            // 
            this.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(83, 58);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(292, 28);
            this.cmbServer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 149);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(label1);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.btnDownload);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "战果人事表下载";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.ComboBox cmbServer;
    }
}

