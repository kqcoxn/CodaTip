namespace CodaTip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nficMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctmsNfIc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDND = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ckbIsBallTip = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTipInterval = new System.Windows.Forms.TextBox();
            this.ckbIsMsbTip = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.timGenerater = new System.Windows.Forms.Timer(this.components);
            this.tsmiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTipSoon = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsNfIc.SuspendLayout();
            this.SuspendLayout();
            // 
            // nficMain
            // 
            this.nficMain.ContextMenuStrip = this.ctmsNfIc;
            this.nficMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nficMain.Icon")));
            this.nficMain.Visible = true;
            // 
            // ctmsNfIc
            // 
            this.ctmsNfIc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsNfIc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStop,
            this.tsmiTipSoon,
            this.tsmiReset,
            this.toolStripSeparator1,
            this.tsmiDND,
            this.toolStripSeparator2,
            this.tsmiSet,
            this.tsmiExit});
            this.ctmsNfIc.Name = "ctmsNfIc";
            this.ctmsNfIc.Size = new System.Drawing.Size(139, 160);
            // 
            // tsmiReset
            // 
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.Size = new System.Drawing.Size(138, 24);
            this.tsmiReset.Text = "重置时间";
            this.tsmiReset.Click += new System.EventHandler(this.tsmiReset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmiDND
            // 
            this.tsmiDND.Name = "tsmiDND";
            this.tsmiDND.Size = new System.Drawing.Size(138, 24);
            this.tsmiDND.Text = "勿扰模式";
            this.tsmiDND.Click += new System.EventHandler(this.tsmiDND_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
            // 
            // tsmiSet
            // 
            this.tsmiSet.Name = "tsmiSet";
            this.tsmiSet.Size = new System.Drawing.Size(138, 24);
            this.tsmiSet.Text = "设置";
            this.tsmiSet.Click += new System.EventHandler(this.tsmiSet_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(138, 24);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // ckbIsBallTip
            // 
            this.ckbIsBallTip.AutoSize = true;
            this.ckbIsBallTip.Font = new System.Drawing.Font("MiSans", 10F);
            this.ckbIsBallTip.Location = new System.Drawing.Point(26, 67);
            this.ckbIsBallTip.Name = "ckbIsBallTip";
            this.ckbIsBallTip.Size = new System.Drawing.Size(117, 27);
            this.ckbIsBallTip.TabIndex = 2;
            this.ckbIsBallTip.Text = "右下角提醒";
            this.ckbIsBallTip.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "提醒间隔(min):";
            // 
            // txbTipInterval
            // 
            this.txbTipInterval.Font = new System.Drawing.Font("MiSans", 10F);
            this.txbTipInterval.Location = new System.Drawing.Point(162, 21);
            this.txbTipInterval.MaxLength = 3;
            this.txbTipInterval.Name = "txbTipInterval";
            this.txbTipInterval.Size = new System.Drawing.Size(73, 30);
            this.txbTipInterval.TabIndex = 4;
            this.txbTipInterval.Text = "70";
            // 
            // ckbIsMsbTip
            // 
            this.ckbIsMsbTip.AutoSize = true;
            this.ckbIsMsbTip.Font = new System.Drawing.Font("MiSans", 10F);
            this.ckbIsMsbTip.Location = new System.Drawing.Point(151, 67);
            this.ckbIsMsbTip.Name = "ckbIsMsbTip";
            this.ckbIsMsbTip.Size = new System.Drawing.Size(66, 27);
            this.ckbIsMsbTip.TabIndex = 5;
            this.ckbIsMsbTip.Text = "弹窗";
            this.ckbIsMsbTip.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(64, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timGenerater
            // 
            this.timGenerater.Enabled = true;
            this.timGenerater.Interval = 60000;
            this.timGenerater.Tick += new System.EventHandler(this.timGenerater_Tick);
            // 
            // tsmiStop
            // 
            this.tsmiStop.Name = "tsmiStop";
            this.tsmiStop.Size = new System.Drawing.Size(138, 24);
            this.tsmiStop.Text = "暂停";
            this.tsmiStop.Click += new System.EventHandler(this.tsmiStop_Click);
            // 
            // tsmiTipSoon
            // 
            this.tsmiTipSoon.Name = "tsmiTipSoon";
            this.tsmiTipSoon.Size = new System.Drawing.Size(138, 24);
            this.tsmiTipSoon.Text = "稍后提醒";
            this.tsmiTipSoon.Click += new System.EventHandler(this.tsmiTipSoon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 162);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ckbIsMsbTip);
            this.Controls.Add(this.txbTipInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbIsBallTip);
            this.Font = new System.Drawing.Font("MiSans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodaTip - Set";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ctmsNfIc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nficMain;
        private System.Windows.Forms.ContextMenuStrip ctmsNfIc;
        private System.Windows.Forms.ToolStripMenuItem tsmiReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDND;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSet;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.CheckBox ckbIsBallTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTipInterval;
        private System.Windows.Forms.CheckBox ckbIsMsbTip;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer timGenerater;
        private System.Windows.Forms.ToolStripMenuItem tsmiStop;
        private System.Windows.Forms.ToolStripMenuItem tsmiTipSoon;
    }
}

