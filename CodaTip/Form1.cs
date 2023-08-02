using CodaTip.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using CSharpFormApplication;
using System.IO;
using Microsoft.Win32;
using System.Threading;
using static CSharpFormApplication.AutoResizeForm;
using System.Collections.Specialized;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;

namespace CodaTip
{
    public partial class Form1 : Form
    {
        #region 数据
        //固定信息
        string ID = "CodaTip";  //程序名
        string ver = "1.1.0";   //版本
        string imgPos = @".\img\";   //图片文件位置
        #endregion

        #region 初始化
        //构造函数
        AutoResizeForm asc = new AutoResizeForm();  //调用自适应类
        public Form1()
        {
            InitializeComponent();
            asc.controllInitializeSize(this);   //自适应
        }
        //初始化
        public static Form1 mainForm = null;    //主窗体
        public InfoPanel infoPanel = new InfoPanel();   //信息面板
        public AppPanel note = new AppPanel();    //更多应用
        public Cmd cmd = new Cmd();  //命令行工具
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置主窗体
            mainForm = this;
            //检查显示器
            for (int i = 1; i <= Screen.AllScreens.Length; i++)
            {
                cmbScreen.Items.Add(i);
            }
            if (Settings.Default.screenNum > Screen.AllScreens.Length)
                Settings.Default.screenNum = Screen.AllScreens.Length;
            //设置子窗体
            infoPanel.Show();
            if (!Settings.Default.isShowPanel)
            {
                infoPanel.Visible = false;
                infoPanel.WindowState = FormWindowState.Minimized;
            }
            //更新时间
            if (Settings.Default.lastRunDay != DateTime.Now.Date.ToShortDateString())
            {
                Settings.Default.runTime = 0;
                Settings.Default.lastRunDay = DateTime.Now.Date.ToShortDateString();
            }
            //更新文本
            InfoUpdate();
            //布置数据
            this.Close();
        }
        #endregion

        #region 发生器
        //发生函数
        public int tipTime = Settings.Default.TipInterval, openTime = 0;
        private void timGenerater_Tick(object sender, EventArgs e)
        {
            //检查主题色
            if (Settings.Default.isAutoTheme) SetTheme();
            //暂停
            if (isStop) return;
            //数据更新
            openTime++;
            Settings.Default.runTime++;
            Settings.Default.Save();
            //勿扰
            if (isDND) return;
            tipTime--;
            //预备提醒
            if (tipTime == Settings.Default.prepareTime && Settings.Default.isPreTip)
            {
                //提醒
                if (Settings.Default.IsBallTip) nficMain.ShowBalloonTip(5000, "准备休息了！", ID, ToolTipIcon.None);
                else if (Settings.Default.IsMsbTip) MessageBox.Show("准备休息了！", ID);
            }
            //计时结束
            if (tipTime <= 0)
            {
                //重置时间
                ResetTime();
                //信息窗
                if (Settings.Default.IsBallTip) nficMain.ShowBalloonTip(10000, "速去休息呀!!!", ID, ToolTipIcon.None);
                if (Settings.Default.IsMsbTip) MessageBox.Show("速去休息呀!!!", ID);
                //暂停
                if (!isStop) SetStop();
                //显示页面
                infoPanel.isTempLock = true;
                if (Settings.Default.isShowPanel) infoPanel.ShowPanel(InfoPanel.EaseStyle.EaseOut);
            }
            //更新显示
            InfoUpdate();
        }
        //检查主题色
        public void SetTheme()
        {
            int nowHour = Convert.ToInt32(DateTime.Now.ToShortTimeString().Split(':')[0]);
            if ((nowHour >= 6 && nowHour < 18) && !Settings.Default.isWhite) infoPanel.ChangeTheme(true);
            else if ((nowHour < 6 || nowHour >= 18) && Settings.Default.isWhite) infoPanel.ChangeTheme(false);
        }
        //更新信息
        enum IconState
        {
            Normal,
            Stop,
            Soon,
            Sleep
        }
        IconState iconState = IconState.Normal;
        void InfoUpdate()
        {
            //更新图标
            if (isStop && iconState != IconState.Stop)
            {
                nficMain.Icon = new Icon(imgPos + "icon_stop.ico");
                iconState = IconState.Stop;
            }
            else if (isDND && iconState != IconState.Sleep)
            {
                nficMain.Icon = new Icon(imgPos + "icon_sleep.ico");
                iconState = IconState.Sleep;
            }
            else if (!isStop && !isDND)
            {
                if (tipTime <= Settings.Default.prepareTime && iconState != IconState.Soon)
                {
                    nficMain.Icon = new Icon(imgPos + "icon_soon.ico");
                    iconState = IconState.Soon;
                }
                else if (tipTime > Settings.Default.prepareTime && iconState != IconState.Normal)
                {
                    nficMain.Icon = new Icon(imgPos + "icon_normal.ico");
                    iconState = IconState.Normal;
                }
            }
            //设置字体颜色
            if (!isDND && !isStop)
            {
                Color nowColor = infoPanel.labTipTime.ForeColor;
                Color themeColor = Settings.Default.isWhite ? Color.FromKnownColor(KnownColor.ControlText) : Color.White;
                if (tipTime <= Settings.Default.prepareTime && nowColor != Color.FromKnownColor(KnownColor.DeepPink))
                    infoPanel.labTipTime.ForeColor = Color.FromKnownColor(KnownColor.DeepPink);
                else if (tipTime > Settings.Default.prepareTime && nowColor != themeColor)
                    infoPanel.labTipTime.ForeColor = themeColor;
            }
            //更新文本
            infoPanel.InfoUpdate();
            nficMain.Text = string.Format("{0}-{1}\r\n距离下次休息: {2}",
                ID, ver, GetStanderdTime(tipTime));
        }
        //获取标准时间格式文本
        public string GetStanderdTime(int min)
        {
            //处理时间
            int hour = min / 60;
            min %= 60;
            //合成文本
            string time = "";
            if (hour > 0)
            {
                time = hour + ":";
                if (min < 10) time += "0";
            }
            time += min;
            if (hour == 0) time += "min";

            return time;
        }
        #endregion

        #region 托盘
        //重置面板
        private void tsmiReSetForm_Click(object sender, EventArgs e)
        {
            infoPanel.RepairPlace();
        }
        //呼出面板
        private void nficMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            infoPanel.isTempLock = true;
            infoPanel.ShowPanel(InfoPanel.EaseStyle.EaseOut);
        }
        //稍后提醒
        private void tsmiTipSoon_Click(object sender, EventArgs e)
        {
            TipSoon();
        }
        public void TipSoon()
        {
            if (isStop) SetStop();
            if (isDND) SetDND();
            tipTime = Settings.Default.soonTime;
            InfoUpdate();
        }
        //重置时间
        private void tsmiReset_Click(object sender, EventArgs e)
        {
            ResetTime();
        }
        public void ResetTime()
        {
            tipTime = Settings.Default.TipInterval;
            if (isStop) SetStop();
            if (isDND) SetDND();
            if (isScreenNeedClose) CloseScreen();
            InfoUpdate();
        }
        //勿扰模式
        public bool isDND = false;
        private void tsmiDND_Click(object sender, EventArgs e)
        {
            SetDND();
        }
        int leftTimeRec;
        public void SetDND()
        {
            //检查
            if (isStop) SetStop();
            //更改配置
            isDND = !isDND;
            //更新图标文本
            if (isDND)
            {
                leftTimeRec = tipTime;
                infoPanel.btnSleep.Image = Image.FromFile(@".\img\sleep_on.png");
                tsmiDND.Text = "退出勿扰";
                infoPanel.stoppedTime = 0;
                infoPanel.timStopCount.Enabled = true;
                infoPanel.labTipTime.ForeColor = Color.Red;
            }
            else
            {
                tipTime = leftTimeRec;
                infoPanel.btnSleep.Image = Image.FromFile(@".\img\sleep_off.png");
                tsmiDND.Text = "勿扰模式";
                infoPanel.timStopCount.Enabled = false;
                infoPanel.labTipTime.ForeColor =
                    (cmbTheme.SelectedIndex == 0) ? Color.FromKnownColor(KnownColor.ControlText) : Color.White;
            }
            //更新信息
            InfoUpdate();
            //勿扰计时
            if (isDND) infoPanel.labTipTime.Text = "已静默时间: 00:00:00";
        }
        //设置
        private void tsmiSet_Click(object sender, EventArgs e)
        {
            OpenSet();
        }
        public void OpenSet()
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }
        //退出
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            isRealClose = true;
            this.Close();
        }
        //暂停
        private void tsmiStop_Click(object sender, EventArgs e)
        {
            SetStop();
        }
        //暂停函数
        public bool isStop = false;
        public void SetStop()
        {
            if (isDND) SetDND();
            //更改设置
            isStop = !isStop;
            //暂停
            if (isStop)
            {
                infoPanel.isStaticClock = true;
                tsmiStop.Text = "继续";
                //暂离提醒
                if (Settings.Default.isStopCount)
                {
                    infoPanel.stoppedTime = 0;
                    infoPanel.timStopCount.Enabled = true;
                    infoPanel.labTipTime.ForeColor = Color.Red;
                }
            }
            //继续
            else
            {
                infoPanel.isTempLock = infoPanel.isStaticClock = false;
                tsmiStop.Text = "暂离";
                //关闭暂离提醒
                if (infoPanel.timStopCount.Enabled) infoPanel.timStopCount.Enabled = false;
                if (infoPanel.labTipTime.ForeColor == Color.Red) infoPanel.labTipTime.ForeColor =
                        (cmbTheme.SelectedIndex == 0) ? Color.FromKnownColor(KnownColor.ControlText) : Color.White;
            }
            //更新信息
            InfoUpdate();
            infoPanel.btnStopChange();
            if (isStop && Settings.Default.isStopCount) infoPanel.labTipTime.Text = "已离开时间: 00:00:00";
        }
        //息屏
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, uint wParam, int lParam);
        private const uint WM_SYSCOMMAND = 0x0112;
        private const uint SC_MONITORPOWER = 0xF170;
        /*
        关闭显示器：SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER,2);
        打开显示器：SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, -1);
        */
        private void tsmiRestScreen_Click(object sender, EventArgs e)
        {
            CloseScreen();
        }
        bool isScreenNeedClose = false;
        public void CloseScreen()
        {
            if (isScreenNeedClose)
            {
                infoPanel.btnCloseScreen.Text = "关闭屏幕";
                timScreenCloser.Stop();
                timScreenCloser.Enabled = false;
                if (isStop) SetStop();
            }
            else
            {
                infoPanel.btnCloseScreen.Text = "解除息屏";
                Thread.Sleep(600);
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
                timScreenCloser.Enabled = true;
                timScreenCloser.Start();
                if (!isStop) SetStop();
                mousePoint = Cursor.Position;
            }
            isScreenNeedClose = !isScreenNeedClose;
        }
        Point mousePoint = new Point(0, 0);
        private void timScreenCloser_Tick(object sender, EventArgs e)
        {
            if (mousePoint != Cursor.Position)
            {
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
                mousePoint = Cursor.Position;
            }
        }
        #endregion

        #region 设置界面
        //关闭页面
        bool isRealClose = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关机
            if (e.CloseReason == CloseReason.WindowsShutDown) isRealClose = true;
            //关闭
            if (isRealClose)
            {
                Settings.Default.Save();//更新数据
                note.SaveNote();
                cmd.SaveSet();
                return;//退出
            }
            //取消关闭
            e.Cancel = true;
            //隐藏界面
            this.Hide();
            this.ShowInTaskbar = false;
            //数据还原
            txbTipInterval.Text = Settings.Default.TipInterval.ToString();  //提醒间隔
            ckbIsBallTip.Checked = Settings.Default.IsBallTip;  //右下角提醒
            ckbIsMsbTip.Checked = Settings.Default.IsMsbTip;    //弹窗提醒
            txbSoonTime.Text = Settings.Default.soonTime.ToString();  //稍后提醒时间
            txbUserName.Text = Settings.Default.userName;   //用户名
            ckbIsAutoTheme.Checked = Settings.Default.isAutoTheme;  //自动主题
            cmbTheme.SelectedItem = cmbTheme.Items[Settings.Default.isWhite ? 0 : 1];   //主题色
            txbHideWaitingTime.Text = (Settings.Default.hideCount * 0.001).ToString();  //回弹等待
            ckbIsShowPanel.Checked = Settings.Default.isShowPanel;  //主控面板
            txbPrepareTime.Text = Settings.Default.prepareTime.ToString();   //预备时间
            ckbIsPreTip.Checked = Settings.Default.isPreTip; //预先提醒
            ckbIsStopCount.Checked = Settings.Default.isStopCount;   //暂离计时
            cmbScreen.SelectedItem = Settings.Default.screenNum;    //显示位置
            cmbSide.SelectedIndex = Settings.Default.ParkSide;   //停靠位置
        }
        //主控禁用
        private void ckbIsShowPanel_CheckedChanged(object sender, EventArgs e)
        {
            //启用面板  
            if (ckbIsShowPanel.Checked)
            {
                txbUserName.Enabled = txbHideWaitingTime.Enabled = cmbTheme.Enabled = ckbIsAutoTheme.Enabled
                    = cmbScreen.Enabled = cmbSide.Enabled = true;
                //主题
                if (ckbIsAutoTheme.Checked) cmbTheme.Enabled = false;
            }
            //禁用面板
            else txbUserName.Enabled = txbHideWaitingTime.Enabled = cmbTheme.Enabled = ckbIsAutoTheme.Enabled
                    = cmbScreen.Enabled = cmbSide.Enabled = false;
        }
        //提醒禁用
        private void ckbIsBallTip_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbIsBallTip.Checked && !ckbIsMsbTip.Checked && ckbIsPreTip.Enabled) ckbIsPreTip.Enabled = false;
            else if (!ckbIsPreTip.Enabled) ckbIsPreTip.Enabled = true;
        }
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            //提醒间隔
            try { Settings.Default.TipInterval = Convert.ToInt32(txbTipInterval.Text); }
            catch
            {
                MessageBox.Show("请输入三位数以内的整数！", ID);
                txbTipInterval.Focus();
            }
            //右下角提醒
            Settings.Default.IsBallTip = ckbIsBallTip.Checked;
            //弹窗提醒
            Settings.Default.IsMsbTip = ckbIsMsbTip.Checked;
            //稍后提醒时间
            try { Settings.Default.soonTime = Convert.ToInt32(txbSoonTime.Text); }
            catch
            {
                MessageBox.Show("请输入三位数以内的整数！", ID);
                txbTipInterval.Focus();
            }
            //用户名
            Settings.Default.userName = txbUserName.Text;
            //显示主控面板
            Settings.Default.isShowPanel = ckbIsShowPanel.Checked;
            if (ckbIsShowPanel.Checked && infoPanel.WindowState == FormWindowState.Minimized)
            {
                infoPanel.WindowState = FormWindowState.Normal;
                infoPanel.Visible = true;
                infoPanel.Show();
            }
            if (!ckbIsShowPanel.Checked && infoPanel.WindowState == FormWindowState.Normal)
            {
                infoPanel.Visible = false;
                infoPanel.WindowState = FormWindowState.Minimized;
            }
            //自动主题
            Settings.Default.isAutoTheme = ckbIsAutoTheme.Checked;
            if (Settings.Default.isAutoTheme) SetTheme();
            //主题色
            else infoPanel.ChangeTheme(cmbTheme.SelectedIndex == 0);
            //回弹等待时间
            try { Settings.Default.hideCount = (int)(Convert.ToDouble(txbHideWaitingTime.Text) * 1000); }
            catch
            {
                MessageBox.Show("请输入0.01~1000之间的实数！", ID);
                txbHideWaitingTime.Focus();
            }
            //预备时间
            try { Settings.Default.prepareTime = Convert.ToInt32(txbPrepareTime.Text); }
            catch
            {
                MessageBox.Show("请输入三位数以内的整数！", ID);
                txbPrepareTime.Focus();
            }
            //是否预备提醒
            Settings.Default.isPreTip = ckbIsPreTip.Checked;
            //是否暂离提醒
            Settings.Default.isStopCount = ckbIsStopCount.Checked;
            //显示位置
            Settings.Default.screenNum = Convert.ToInt32(cmbScreen.Text);
            //停靠位置
            Settings.Default.ParkSide = cmbSide.SelectedIndex;
            //更新信息
            InfoUpdate();
            //保存配置
            Settings.Default.Save();
            //提示
            MessageBox.Show("保存成功！", ID);
            //关闭
            this.Close();
        }
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region 后端
        //自适应分辨率
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        #endregion
    }
}
