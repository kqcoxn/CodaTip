namespace CodaTip
{
    partial class InfoPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPanel));
            this.timShowPanel = new System.Windows.Forms.Timer(this.components);
            this.pnlHead = new System.Windows.Forms.Panel();
            this.labMotto = new System.Windows.Forms.Label();
            this.labHead = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labOpenTime = new System.Windows.Forms.Label();
            this.labUsingTime = new System.Windows.Forms.Label();
            this.labTipTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCloseScreen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSoon = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.clbTasks = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.PictureBox();
            this.btnCmd = new System.Windows.Forms.PictureBox();
            this.btnMoreApp = new System.Windows.Forms.PictureBox();
            this.btnSleep = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSynchronization = new System.Windows.Forms.Button();
            this.btnUpdateProcess = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timHidePanel = new System.Windows.Forms.Timer(this.components);
            this.timStopCount = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labSoonDays = new System.Windows.Forms.Label();
            this.labSoonTask = new System.Windows.Forms.Label();
            this.pnlHead.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoreApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSleep)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timShowPanel
            // 
            this.timShowPanel.Interval = 10;
            this.timShowPanel.Tick += new System.EventHandler(this.timShowPanel_Tick);
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.White;
            this.pnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHead.Controls.Add(this.labMotto);
            this.pnlHead.Controls.Add(this.labHead);
            this.pnlHead.Location = new System.Drawing.Point(12, 22);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(404, 135);
            this.pnlHead.TabIndex = 0;
            this.pnlHead.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.pnlHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // labMotto
            // 
            this.labMotto.AutoSize = true;
            this.labMotto.Font = new System.Drawing.Font("MiSans", 10F);
            this.labMotto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labMotto.Location = new System.Drawing.Point(21, 63);
            this.labMotto.Name = "labMotto";
            this.labMotto.Size = new System.Drawing.Size(367, 46);
            this.labMotto.TabIndex = 2;
            this.labMotto.Text = "这里会是一条格言信息，请在设置界面更新格言\r\n库！";
            this.labMotto.Click += new System.EventHandler(this.labMotto_Click);
            this.labMotto.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.labMotto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // labHead
            // 
            this.labHead.AutoSize = true;
            this.labHead.Font = new System.Drawing.Font("MiSans", 16F);
            this.labHead.Location = new System.Drawing.Point(19, 18);
            this.labHead.Name = "labHead";
            this.labHead.Size = new System.Drawing.Size(231, 36);
            this.labHead.TabIndex = 1;
            this.labHead.Text = "在这里将会打招呼";
            this.labHead.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.labHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labOpenTime);
            this.panel2.Controls.Add(this.labUsingTime);
            this.panel2.Controls.Add(this.labTipTime);
            this.panel2.Location = new System.Drawing.Point(12, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 142);
            this.panel2.TabIndex = 1;
            this.panel2.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // labOpenTime
            // 
            this.labOpenTime.AutoSize = true;
            this.labOpenTime.Location = new System.Drawing.Point(20, 58);
            this.labOpenTime.Name = "labOpenTime";
            this.labOpenTime.Size = new System.Drawing.Size(182, 27);
            this.labOpenTime.TabIndex = 2;
            this.labOpenTime.Text = "本次开机使用: 1:30";
            this.labOpenTime.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.labOpenTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // labUsingTime
            // 
            this.labUsingTime.AutoSize = true;
            this.labUsingTime.Location = new System.Drawing.Point(20, 93);
            this.labUsingTime.Name = "labUsingTime";
            this.labUsingTime.Size = new System.Drawing.Size(183, 27);
            this.labUsingTime.TabIndex = 1;
            this.labUsingTime.Text = "今日使用时间: 2:32";
            this.labUsingTime.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.labUsingTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // labTipTime
            // 
            this.labTipTime.AutoSize = true;
            this.labTipTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labTipTime.Location = new System.Drawing.Point(20, 22);
            this.labTipTime.Name = "labTipTime";
            this.labTipTime.Size = new System.Drawing.Size(203, 27);
            this.labTipTime.TabIndex = 0;
            this.labTipTime.Text = "距离下次休息: 45min";
            this.labTipTime.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.labTipTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCloseScreen);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnSoon);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Location = new System.Drawing.Point(12, 317);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 134);
            this.panel3.TabIndex = 2;
            this.panel3.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // btnCloseScreen
            // 
            this.btnCloseScreen.Font = new System.Drawing.Font("MiSans", 11F);
            this.btnCloseScreen.Location = new System.Drawing.Point(127, 70);
            this.btnCloseScreen.Name = "btnCloseScreen";
            this.btnCloseScreen.Size = new System.Drawing.Size(110, 45);
            this.btnCloseScreen.TabIndex = 3;
            this.btnCloseScreen.TabStop = false;
            this.btnCloseScreen.Text = "关闭屏幕";
            this.btnCloseScreen.UseVisualStyleBackColor = true;
            this.btnCloseScreen.Click += new System.EventHandler(this.btnCloseScreen_Click);
            this.btnCloseScreen.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.btnCloseScreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MiSans", 11F);
            this.btnReset.Location = new System.Drawing.Point(16, 70);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "重置时间";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.btnReset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // btnSoon
            // 
            this.btnSoon.Font = new System.Drawing.Font("MiSans", 11F);
            this.btnSoon.Location = new System.Drawing.Point(127, 16);
            this.btnSoon.Name = "btnSoon";
            this.btnSoon.Size = new System.Drawing.Size(110, 45);
            this.btnSoon.TabIndex = 1;
            this.btnSoon.TabStop = false;
            this.btnSoon.Text = "稍后提醒";
            this.btnSoon.UseVisualStyleBackColor = true;
            this.btnSoon.Click += new System.EventHandler(this.btnSoon_Click);
            this.btnSoon.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.btnSoon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("MiSans", 11F);
            this.btnStop.Location = new System.Drawing.Point(16, 16);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 45);
            this.btnStop.TabIndex = 0;
            this.btnStop.TabStop = false;
            this.btnStop.Text = "暂离";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.btnStop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // clbTasks
            // 
            this.clbTasks.BackColor = System.Drawing.Color.White;
            this.clbTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbTasks.Font = new System.Drawing.Font("MiSans", 10F);
            this.clbTasks.FormattingEnabled = true;
            this.clbTasks.Items.AddRange(new object[] {
            "云端维护中",
            "暂时无法使用"});
            this.clbTasks.Location = new System.Drawing.Point(5, 38);
            this.clbTasks.Name = "clbTasks";
            this.clbTasks.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbTasks.Size = new System.Drawing.Size(131, 200);
            this.clbTasks.TabIndex = 3;
            this.clbTasks.TabStop = false;
            this.clbTasks.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.clbTasks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSet);
            this.panel4.Controls.Add(this.btnCmd);
            this.panel4.Controls.Add(this.btnMoreApp);
            this.panel4.Controls.Add(this.btnSleep);
            this.panel4.Location = new System.Drawing.Point(12, 461);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 71);
            this.panel4.TabIndex = 4;
            this.panel4.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.BackColor = System.Drawing.Color.Transparent;
            this.btnSet.Image = ((System.Drawing.Image)(resources.GetObject("btnSet.Image")));
            this.btnSet.Location = new System.Drawing.Point(183, 8);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(50, 50);
            this.btnSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSet.TabIndex = 8;
            this.btnSet.TabStop = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            this.btnSet.MouseEnter += new System.EventHandler(this.btnSleep_MouseEnter);
            this.btnSet.MouseLeave += new System.EventHandler(this.btnSleep_MouseLeave);
            // 
            // btnCmd
            // 
            this.btnCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCmd.BackColor = System.Drawing.Color.Transparent;
            this.btnCmd.Image = ((System.Drawing.Image)(resources.GetObject("btnCmd.Image")));
            this.btnCmd.Location = new System.Drawing.Point(127, 8);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(50, 50);
            this.btnCmd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCmd.TabIndex = 7;
            this.btnCmd.TabStop = false;
            this.btnCmd.Click += new System.EventHandler(this.btnRepair_Click);
            this.btnCmd.MouseEnter += new System.EventHandler(this.btnSleep_MouseEnter);
            this.btnCmd.MouseLeave += new System.EventHandler(this.btnSleep_MouseLeave);
            // 
            // btnMoreApp
            // 
            this.btnMoreApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoreApp.BackColor = System.Drawing.Color.Transparent;
            this.btnMoreApp.Image = ((System.Drawing.Image)(resources.GetObject("btnMoreApp.Image")));
            this.btnMoreApp.Location = new System.Drawing.Point(71, 8);
            this.btnMoreApp.Name = "btnMoreApp";
            this.btnMoreApp.Size = new System.Drawing.Size(50, 50);
            this.btnMoreApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMoreApp.TabIndex = 6;
            this.btnMoreApp.TabStop = false;
            this.btnMoreApp.Click += new System.EventHandler(this.btnNote_Click);
            this.btnMoreApp.MouseEnter += new System.EventHandler(this.btnSleep_MouseEnter);
            this.btnMoreApp.MouseLeave += new System.EventHandler(this.btnSleep_MouseLeave);
            // 
            // btnSleep
            // 
            this.btnSleep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSleep.BackColor = System.Drawing.Color.Transparent;
            this.btnSleep.Image = ((System.Drawing.Image)(resources.GetObject("btnSleep.Image")));
            this.btnSleep.Location = new System.Drawing.Point(15, 8);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(50, 50);
            this.btnSleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSleep.TabIndex = 4;
            this.btnSleep.TabStop = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            this.btnSleep.MouseEnter += new System.EventHandler(this.btnSleep_MouseEnter);
            this.btnSleep.MouseLeave += new System.EventHandler(this.btnSleep_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSynchronization);
            this.panel5.Controls.Add(this.btnUpdateProcess);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.clbTasks);
            this.panel5.Location = new System.Drawing.Point(274, 165);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(142, 286);
            this.panel5.TabIndex = 2;
            this.panel5.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // btnSynchronization
            // 
            this.btnSynchronization.Font = new System.Drawing.Font("MiSans", 8F);
            this.btnSynchronization.Location = new System.Drawing.Point(73, 251);
            this.btnSynchronization.Name = "btnSynchronization";
            this.btnSynchronization.Size = new System.Drawing.Size(63, 26);
            this.btnSynchronization.TabIndex = 5;
            this.btnSynchronization.TabStop = false;
            this.btnSynchronization.Text = "同步";
            this.btnSynchronization.UseVisualStyleBackColor = true;
            this.btnSynchronization.Click += new System.EventHandler(this.btnSynchronization_Click);
            this.btnSynchronization.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.btnSynchronization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // btnUpdateProcess
            // 
            this.btnUpdateProcess.Font = new System.Drawing.Font("MiSans", 8F);
            this.btnUpdateProcess.Location = new System.Drawing.Point(4, 251);
            this.btnUpdateProcess.Name = "btnUpdateProcess";
            this.btnUpdateProcess.Size = new System.Drawing.Size(63, 26);
            this.btnUpdateProcess.TabIndex = 4;
            this.btnUpdateProcess.TabStop = false;
            this.btnUpdateProcess.Text = "上传";
            this.btnUpdateProcess.UseVisualStyleBackColor = true;
            this.btnUpdateProcess.Click += new System.EventHandler(this.btnUpdateProcess_Click);
            this.btnUpdateProcess.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.btnUpdateProcess.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "任务清单";
            this.label5.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            // 
            // timHidePanel
            // 
            this.timHidePanel.Interval = 10;
            this.timHidePanel.Tick += new System.EventHandler(this.timHidePanel_Tick);
            // 
            // timStopCount
            // 
            this.timStopCount.Interval = 1000;
            this.timStopCount.Tick += new System.EventHandler(this.timStopCount_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labSoonDays);
            this.panel1.Controls.Add(this.labSoonTask);
            this.panel1.Location = new System.Drawing.Point(274, 461);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 71);
            this.panel1.TabIndex = 3;
            // 
            // labSoonDays
            // 
            this.labSoonDays.AutoSize = true;
            this.labSoonDays.Font = new System.Drawing.Font("MiSans", 10F);
            this.labSoonDays.Location = new System.Drawing.Point(26, 36);
            this.labSoonDays.Name = "labSoonDays";
            this.labSoonDays.Size = new System.Drawing.Size(84, 23);
            this.labSoonDays.TabIndex = 7;
            this.labSoonDays.Text = "by Codax";
            // 
            // labSoonTask
            // 
            this.labSoonTask.AutoSize = true;
            this.labSoonTask.Font = new System.Drawing.Font("MiSans", 10F);
            this.labSoonTask.Location = new System.Drawing.Point(14, 11);
            this.labSoonTask.Name = "labSoonTask";
            this.labSoonTask.Size = new System.Drawing.Size(113, 23);
            this.labSoonTask.TabIndex = 6;
            this.labSoonTask.Text = "CodaTip-1.1.2";
            // 
            // InfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(428, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHead);
            this.Font = new System.Drawing.Font("MiSans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoPanel";
            this.Opacity = 0.01D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InfoPanel_Load);
            this.SizeChanged += new System.EventHandler(this.InfoPanel_SizeChanged);
            this.MouseEnter += new System.EventHandler(this.InfoPanel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.InfoPanel_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InfoPanel_MouseMove);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMoreApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSleep)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timShowPanel;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label labMotto;
        private System.Windows.Forms.Label labHead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labUsingTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSoon;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckedListBox clbTasks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUpdateProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labOpenTime;
        private System.Windows.Forms.Button btnSynchronization;
        private System.Windows.Forms.Timer timHidePanel;
        public System.Windows.Forms.Timer timStopCount;
        public System.Windows.Forms.Label labTipTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labSoonTask;
        private System.Windows.Forms.Label labSoonDays;
        private System.Windows.Forms.PictureBox btnSet;
        private System.Windows.Forms.PictureBox btnCmd;
        private System.Windows.Forms.PictureBox btnMoreApp;
        public System.Windows.Forms.PictureBox btnSleep;
        public System.Windows.Forms.Button btnCloseScreen;
    }
}