namespace ImageSharpTest
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
            this.components = new System.ComponentModel.Container();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.processBar = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQuality = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.rbMiddle = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbFileNames = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清除所有文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(103, 10);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件路径：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processBar,
            this.lbInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 281);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // processBar
            // 
            this.processBar.Name = "processBar";
            this.processBar.Size = new System.Drawing.Size(200, 16);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMiddle);
            this.groupBox1.Controls.Add(this.rbHigh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbQuality);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "压缩选项";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "质量：";
            // 
            // tbQuality
            // 
            this.tbQuality.Location = new System.Drawing.Point(68, 18);
            this.tbQuality.Name = "tbQuality";
            this.tbQuality.Size = new System.Drawing.Size(62, 21);
            this.tbQuality.TabIndex = 1;
            this.tbQuality.Text = "70";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "取值：0~100,值越小，压缩后的图片越小";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "子采样：";
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Checked = true;
            this.rbHigh.Location = new System.Drawing.Point(69, 52);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(59, 16);
            this.rbHigh.TabIndex = 4;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "高质量";
            this.rbHigh.UseVisualStyleBackColor = true;
            // 
            // rbMiddle
            // 
            this.rbMiddle.AutoSize = true;
            this.rbMiddle.Location = new System.Drawing.Point(134, 52);
            this.rbMiddle.Name = "rbMiddle";
            this.rbMiddle.Size = new System.Drawing.Size(59, 16);
            this.rbMiddle.TabIndex = 5;
            this.rbMiddle.Text = "中质量";
            this.rbMiddle.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(35, 253);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始压缩";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbFileNames
            // 
            this.lbFileNames.AllowDrop = true;
            this.lbFileNames.ContextMenuStrip = this.contextMenuStrip1;
            this.lbFileNames.FormattingEnabled = true;
            this.lbFileNames.ItemHeight = 12;
            this.lbFileNames.Location = new System.Drawing.Point(35, 37);
            this.lbFileNames.Name = "lbFileNames";
            this.lbFileNames.Size = new System.Drawing.Size(478, 112);
            this.lbFileNames.TabIndex = 6;
            this.lbFileNames.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFileNames_DragDrop);
            this.lbFileNames.DragOver += new System.Windows.Forms.DragEventHandler(this.lbFileNames_DragOver);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(122, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "压缩完成后，文件会保存在源文件的同目录";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "可以一次选择多个文件,支持直接把文件拖到下方";
            // 
            // lbInfo
            // 
            this.lbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除所有文件ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // 清除所有文件ToolStripMenuItem
            // 
            this.清除所有文件ToolStripMenuItem.Name = "清除所有文件ToolStripMenuItem";
            this.清除所有文件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清除所有文件ToolStripMenuItem.Text = "清除所有文件";
            this.清除所有文件ToolStripMenuItem.Click += new System.EventHandler(this.清除所有文件ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 303);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFileNames);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowser);
            this.Name = "Form1";
            this.Text = "图片压缩";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar processBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMiddle;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbFileNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel lbInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清除所有文件ToolStripMenuItem;
    }
}

