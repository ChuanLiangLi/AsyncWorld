namespace AsyncFirst
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
            if (disposing && (components != null))
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
            this.btnSync = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEAP = new System.Windows.Forms.Button();
            this.btnTAP = new System.Windows.Forms.Button();
            this.btnMoreAsyncSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(32, 33);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(109, 62);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "同步";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(253, 33);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(109, 62);
            this.btnAsync.TabIndex = 1;
            this.btnAsync.Text = "异步";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnEAP
            // 
            this.btnEAP.Location = new System.Drawing.Point(32, 141);
            this.btnEAP.Name = "btnEAP";
            this.btnEAP.Size = new System.Drawing.Size(109, 62);
            this.btnEAP.TabIndex = 3;
            this.btnEAP.Text = "基于事件的异步模式EAP";
            this.btnEAP.UseVisualStyleBackColor = true;
            this.btnEAP.Click += new System.EventHandler(this.btnEAP_Click);
            // 
            // btnTAP
            // 
            this.btnTAP.Location = new System.Drawing.Point(253, 136);
            this.btnTAP.Name = "btnTAP";
            this.btnTAP.Size = new System.Drawing.Size(122, 67);
            this.btnTAP.TabIndex = 4;
            this.btnTAP.Text = "TAP";
            this.btnTAP.UseVisualStyleBackColor = true;
            this.btnTAP.Click += new System.EventHandler(this.btnTAP_Click);
            // 
            // btnMoreAsyncSort
            // 
            this.btnMoreAsyncSort.Location = new System.Drawing.Point(253, 226);
            this.btnMoreAsyncSort.Name = "btnMoreAsyncSort";
            this.btnMoreAsyncSort.Size = new System.Drawing.Size(132, 64);
            this.btnMoreAsyncSort.TabIndex = 5;
            this.btnMoreAsyncSort.Text = "多个异步顺序执行";
            this.btnMoreAsyncSort.UseVisualStyleBackColor = true;
            this.btnMoreAsyncSort.Click += new System.EventHandler(this.btnMoreAsyncSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 373);
            this.Controls.Add(this.btnMoreAsyncSort);
            this.Controls.Add(this.btnTAP);
            this.Controls.Add(this.btnEAP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnSync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEAP;
        private System.Windows.Forms.Button btnTAP;
        private System.Windows.Forms.Button btnMoreAsyncSort;
    }
}

