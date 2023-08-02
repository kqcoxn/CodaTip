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
            this.tsmiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTipSoon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRestScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDND = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReSetForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ckbIsBallTip = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTipInterval = new System.Windows.Forms.TextBox();
            this.ckbIsMsbTip = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.timGenerater = new System.Windows.Forms.Timer(this.components);
            this.txbSoonTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckbIsShowPanel = new System.Windows.Forms.CheckBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbIsAutoTheme = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbIsStopCount = new System.Windows.Forms.CheckBox();
            this.ckbIsPreTip = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPrepareTime = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSide = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbScreen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbHideWaitingTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timScreenCloser = new System.Windows.Forms.Timer(this.components);
            this.ctmsNfIc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nficMain
            // 
            this.nficMain.ContextMenuStrip = this.ctmsNfIc;
            this.nficMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nficMain.Icon")));
            this.nficMain.Visible = true;
            this.nficMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nficMain_MouseDoubleClick);
            // 
            // ctmsNfIc
            // 
            this.ctmsNfIc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsNfIc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStop,
            this.tsmiTipSoon,
            this.tsmiReset,
            this.toolStripSeparator1,
            this.tsmiRestScreen,
            this.tsmiDND,
            this.toolStripSeparator2,
            this.tsmiReSetForm,
            this.tsmiSet,
            this.tsmiExit});
            this.ctmsNfIc.Name = "ctmsNfIc";
            this.ctmsNfIc.Size = new System.Drawing.Size(139, 208);
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
            // tsmiRestScreen
            // 
            this.tsmiRestScreen.Name = "tsmiRestScreen";
            this.tsmiRestScreen.Size = new System.Drawing.Size(138, 24);
            this.tsmiRestScreen.Text = "关闭屏幕";
            this.tsmiRestScreen.Click += new System.EventHandler(this.tsmiRestScreen_Click);
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
            // tsmiReSetForm
            // 
            this.tsmiReSetForm.Name = "tsmiReSetForm";
            this.tsmiReSetForm.Size = new System.Drawing.Size(138, 24);
            this.tsmiReSetForm.Text = "重置窗口";
            this.tsmiReSetForm.Click += new System.EventHandler(this.tsmiReSetForm_Click);
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
            this.ckbIsBallTip.Location = new System.Drawing.Point(116, 165);
            this.ckbIsBallTip.Name = "ckbIsBallTip";
            this.ckbIsBallTip.Size = new System.Drawing.Size(117, 27);
            this.ckbIsBallTip.TabIndex = 2;
            this.ckbIsBallTip.TabStop = false;
            this.ckbIsBallTip.Text = "右下角提醒";
            this.ckbIsBallTip.UseVisualStyleBackColor = true;
            this.ckbIsBallTip.CheckedChanged += new System.EventHandler(this.ckbIsBallTip_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "提醒间隔(min):";
            // 
            // txbTipInterval
            // 
            this.txbTipInterval.Font = new System.Drawing.Font("MiSans", 10F);
            this.txbTipInterval.Location = new System.Drawing.Point(153, 8);
            this.txbTipInterval.MaxLength = 3;
            this.txbTipInterval.Name = "txbTipInterval";
            this.txbTipInterval.Size = new System.Drawing.Size(73, 30);
            this.txbTipInterval.TabIndex = 4;
            this.txbTipInterval.TabStop = false;
            // 
            // ckbIsMsbTip
            // 
            this.ckbIsMsbTip.AutoSize = true;
            this.ckbIsMsbTip.Font = new System.Drawing.Font("MiSans", 10F);
            this.ckbIsMsbTip.Location = new System.Drawing.Point(10, 165);
            this.ckbIsMsbTip.Name = "ckbIsMsbTip";
            this.ckbIsMsbTip.Size = new System.Drawing.Size(100, 27);
            this.ckbIsMsbTip.TabIndex = 5;
            this.ckbIsMsbTip.TabStop = false;
            this.ckbIsMsbTip.Text = "弹窗提醒";
            this.ckbIsMsbTip.UseVisualStyleBackColor = true;
            this.ckbIsMsbTip.CheckedChanged += new System.EventHandler(this.ckbIsBallTip_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(6, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 43);
            this.btnSave.TabIndex = 6;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "应用";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timGenerater
            // 
            this.timGenerater.Enabled = true;
            this.timGenerater.Interval = 60000;
            this.timGenerater.Tick += new System.EventHandler(this.timGenerater_Tick);
            // 
            // txbSoonTime
            // 
            this.txbSoonTime.Font = new System.Drawing.Font("MiSans", 10F);
            this.txbSoonTime.Location = new System.Drawing.Point(153, 85);
            this.txbSoonTime.MaxLength = 3;
            this.txbSoonTime.Name = "txbSoonTime";
            this.txbSoonTime.Size = new System.Drawing.Size(73, 30);
            this.txbSoonTime.TabIndex = 8;
            this.txbSoonTime.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "稍后时间(min):";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(130, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 43);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckbIsShowPanel
            // 
            this.ckbIsShowPanel.AutoSize = true;
            this.ckbIsShowPanel.Font = new System.Drawing.Font("MiSans", 10F);
            this.ckbIsShowPanel.Location = new System.Drawing.Point(119, 217);
            this.ckbIsShowPanel.Name = "ckbIsShowPanel";
            this.ckbIsShowPanel.Size = new System.Drawing.Size(100, 27);
            this.ckbIsShowPanel.TabIndex = 10;
            this.ckbIsShowPanel.TabStop = false;
            this.ckbIsShowPanel.Text = "主控面板";
            this.ckbIsShowPanel.UseVisualStyleBackColor = true;
            this.ckbIsShowPanel.CheckedChanged += new System.EventHandler(this.ckbIsShowPanel_CheckedChanged);
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("MiSans", 10F);
            this.txbUserName.Location = new System.Drawing.Point(68, 12);
            this.txbUserName.MaxLength = 10;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(163, 30);
            this.txbUserName.TabIndex = 12;
            this.txbUserName.TabStop = false;
            this.txbUserName.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "昵称: ";
            // 
            // cmbTheme
            // 
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheme.Font = new System.Drawing.Font("MiSans", 10F);
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            "日光白",
            "暗夜黑"});
            this.cmbTheme.Location = new System.Drawing.Point(88, 88);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(143, 31);
            this.cmbTheme.TabIndex = 13;
            this.cmbTheme.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "主题色:";
            // 
            // ckbIsAutoTheme
            // 
            this.ckbIsAutoTheme.AutoSize = true;
            this.ckbIsAutoTheme.Font = new System.Drawing.Font("MiSans", 10F);
            this.ckbIsAutoTheme.Location = new System.Drawing.Point(13, 217);
            this.ckbIsAutoTheme.Name = "ckbIsAutoTheme";
            this.ckbIsAutoTheme.Size = new System.Drawing.Size(100, 27);
            this.ckbIsAutoTheme.TabIndex = 15;
            this.ckbIsAutoTheme.TabStop = false;
            this.ckbIsAutoTheme.Text = "自动主题";
            this.ckbIsAutoTheme.UseVisualStyleBackColor = true;
            this.ckbIsAutoTheme.CheckedChanged += new System.EventHandler(this.ckbIsShowPanel_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ckbIsStopCount);
            this.panel1.Controls.Add(this.ckbIsPreTip);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbPrepareTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ckbIsBallTip);
            this.panel1.Controls.Add(this.txbTipInterval);
            this.panel1.Controls.Add(this.ckbIsMsbTip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbSoonTime);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 200);
            this.panel1.TabIndex = 16;
            // 
            // ckbIsStopCount
            // 
            this.ckbIsStopCount.AutoSize = true;
            this.ckbIsStopCount.Font = new System.Drawing.Font("MiSans", 10F);
            this.ckbIsStopCount.Location = new System.Drawing.Point(10, 132);
            this.ckbIsStopCount.Name = "ckbIsStopCount";
            this.ckbIsStopCount.Size = new System.Drawing.Size(100, 27);
            this.ckbIsStopCount.TabIndex = 12;
            this.ckbIsStopCount.TabStop = false;
            this.ckbIsStopCount.Text = "暂离计时";
            this.ckbIsStopCount.UseVisualStyleBackColor = true;
            // 
            // ckbIsPreTip
            // 
            this.ckbIsPreTip.AutoSize = true;
            this.ckbIsPreTip.Font = new System.Drawing.Font("MiSans", 10F);
            this.ckbIsPreTip.Location = new System.Drawing.Point(116, 132);
            this.ckbIsPreTip.Name = "ckbIsPreTip";
            this.ckbIsPreTip.Size = new System.Drawing.Size(100, 27);
            this.ckbIsPreTip.TabIndex = 11;
            this.ckbIsPreTip.TabStop = false;
            this.ckbIsPreTip.Text = "预备提醒";
            this.ckbIsPreTip.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "预备时间(min):";
            // 
            // txbPrepareTime
            // 
            this.txbPrepareTime.Font = new System.Drawing.Font("MiSans", 10F);
            this.txbPrepareTime.Location = new System.Drawing.Point(153, 46);
            this.txbPrepareTime.MaxLength = 3;
            this.txbPrepareTime.Name = "txbPrepareTime";
            this.txbPrepareTime.Size = new System.Drawing.Size(73, 30);
            this.txbPrepareTime.TabIndex = 10;
            this.txbPrepareTime.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cmbSide);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmbScreen);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txbHideWaitingTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbUserName);
            this.panel2.Controls.Add(this.ckbIsShowPanel);
            this.panel2.Controls.Add(this.ckbIsAutoTheme);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbTheme);
            this.panel2.Location = new System.Drawing.Point(6, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 261);
            this.panel2.TabIndex = 17;
            // 
            // cmbSide
            // 
            this.cmbSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSide.Font = new System.Drawing.Font("MiSans", 10F);
            this.cmbSide.FormattingEnabled = true;
            this.cmbSide.Items.AddRange(new object[] {
            "左侧",
            "右侧"});
            this.cmbSide.Location = new System.Drawing.Point(108, 170);
            this.cmbSide.Name = "cmbSide";
            this.cmbSide.Size = new System.Drawing.Size(123, 31);
            this.cmbSide.TabIndex = 21;
            this.cmbSide.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 27);
            this.label8.TabIndex = 20;
            this.label8.Text = "停靠方向: ";
            // 
            // cmbScreen
            // 
            this.cmbScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScreen.Font = new System.Drawing.Font("MiSans", 10F);
            this.cmbScreen.FormattingEnabled = true;
            this.cmbScreen.Location = new System.Drawing.Point(108, 129);
            this.cmbScreen.Name = "cmbScreen";
            this.cmbScreen.Size = new System.Drawing.Size(123, 31);
            this.cmbScreen.TabIndex = 19;
            this.cmbScreen.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 27);
            this.label7.TabIndex = 18;
            this.label7.Text = "显示设备: ";
            // 
            // txbHideWaitingTime
            // 
            this.txbHideWaitingTime.Font = new System.Drawing.Font("MiSans", 10F);
            this.txbHideWaitingTime.Location = new System.Drawing.Point(131, 50);
            this.txbHideWaitingTime.MaxLength = 5;
            this.txbHideWaitingTime.Name = "txbHideWaitingTime";
            this.txbHideWaitingTime.Size = new System.Drawing.Size(100, 30);
            this.txbHideWaitingTime.TabIndex = 17;
            this.txbHideWaitingTime.TabStop = false;
            this.txbHideWaitingTime.Text = "0.01";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "回弹等待(s): ";
            // 
            // timScreenCloser
            // 
            this.timScreenCloser.Interval = 20000;
            this.timScreenCloser.Tick += new System.EventHandler(this.timScreenCloser_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
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
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ctmsNfIc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripMenuItem tsmiRestScreen;
        private System.Windows.Forms.TextBox txbSoonTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox ckbIsShowPanel;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbIsAutoTheme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbHideWaitingTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPrepareTime;
        private System.Windows.Forms.CheckBox ckbIsPreTip;
        private System.Windows.Forms.CheckBox ckbIsStopCount;
        public System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.ToolStripMenuItem tsmiReSetForm;
        public System.Windows.Forms.ComboBox cmbScreen;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbSide;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timScreenCloser;
    }
}

