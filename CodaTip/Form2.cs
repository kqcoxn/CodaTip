using CodaTip.Properties;
using CSharpFormApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static CSharpFormApplication.AutoResizeForm;

namespace CodaTip
{
    public partial class InfoPanel : Form
    {
        #region 数据
        string mottoPos = @".\stg\motto.txt";  //格言库位置
        #endregion

        #region 初始化
        //构造函数
        AutoResizeForm asc = new AutoResizeForm();//调用自适应类
        public InfoPanel()
        {
            InitializeComponent();
            asc.controllInitializeSize(this);//自适应
        }
        //初始化
        AppPanel note;    //应用界面
        Cmd cmd;    //命令行工具
        private void InfoPanel_Load(object sender, EventArgs e)
        {
            //设置位置
            this.Top = (int)(Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Height / 2 - this.Height / 2);
            //检测格言长度
            string testString = "这是一段测试文本，它用于测试当前分辨率下格言的每行最多字数。" +
                "他其实还能再多一点，我是我不认为有显示器能放下这么多文字。";
            labMotto.Text = "";
            for (int i = 0; (labMotto.Right < (pnlHead.Width - labMotto.Left)) && (i < testString.Length); i++)
            {
                labMotto.Text += testString[mottoLength++];
            }
            mottoLength--;
            labMotto.Text = GetMotto();
            //检查主题色
            if (Settings.Default.isAutoTheme)
            {
                Settings.Default.isWhite = true;
                int nowHour = Convert.ToInt32(DateTime.Now.ToShortTimeString().Split(':')[0]);
                if (nowHour >= 6 && nowHour < 18) this.ChangeTheme(true);
                else if (nowHour < 6 || nowHour >= 18) this.ChangeTheme(false);
            }
            else if (!Settings.Default.isWhite)
            {
                Settings.Default.isWhite = true;
                this.ChangeTheme(false);
            }
            else ShowPanel(EaseStyle.EaseOut);
            //绑定应用界面
            note = Form1.mainForm.note;
            cmd = Form1.mainForm.cmd;
        }
        #endregion

        #region 响应
        //动画属性
        public enum EaseStyle
        {
            EaseOut,
            none
        }
        struct AnimateHelper
        {
            public int distance;
            public int leftProcess;
            public int maxVelocity;
            public int minVelocity;
            public int nowVelocity;
            public bool isToLeft;
            public EaseStyle es;
        }
        AnimateHelper formAH = new AnimateHelper();
        public enum FormState
        {
            Showing,
            Hiding,
            InMotion
        }
        public static FormState formState = FormState.Hiding;
        //出现
        private void InfoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (formState == FormState.Hiding) ShowPanel(EaseStyle.EaseOut);
            hidingTime = Settings.Default.hideCount;
        }
        private void InfoPanel_MouseEnter(object sender, EventArgs e)
        {
            this.TopMost = true;
            if (formState == FormState.Hiding) ShowPanel(EaseStyle.EaseOut);
            hidingTime = Settings.Default.hideCount;
        }
        public void ShowPanel(EaseStyle es)
        {
            if (formState == FormState.InMotion) return;
            //格言更新
            labMotto.Text = GetMotto();
            //窗体显示
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.Left = Settings.Default.ParkSide == 1 ?
                Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Right
                : Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Left - this.Width;
            this.Opacity = 1;
            //动画设置
            formAH.leftProcess = formAH.distance = this.Width;
            formAH.isToLeft = Settings.Default.ParkSide == 1;
            formAH.es = es;
            switch (es)
            {
                //缓出
                case EaseStyle.EaseOut:
                    formAH.nowVelocity = formAH.maxVelocity = 50;
                    formAH.minVelocity = 5;
                    break;
            }
            //重新置顶
            this.TopMost = true;
            //开启动画
            formState = FormState.InMotion;
            timShowPanel.Enabled = true;
        }
        //出现发生器
        private void timShowPanel_Tick(object sender, EventArgs e)
        {
            if ((Settings.Default.ParkSide == 1 && this.Right > Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Right)
                || (Settings.Default.ParkSide == 0 && this.Left < Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Left))
            {
                //进度迭代
                formAH.leftProcess -= formAH.nowVelocity;
                //运动
                switch (formAH.es)
                {
                    //缓出
                    case EaseStyle.EaseOut:
                        if (Settings.Default.ParkSide == 1) this.Left -= formAH.nowVelocity;
                        else this.Left += formAH.nowVelocity;
                        formAH.nowVelocity = (int)(formAH.maxVelocity * formAH.leftProcess / formAH.distance);
                        if (formAH.nowVelocity < formAH.minVelocity) formAH.nowVelocity = formAH.minVelocity;
                        break;
                    //瞬间
                    case EaseStyle.none:
                        this.Left = Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Right - this.Width;
                        break;
                }
            }
            else
            {
                //修正位置
                if (Settings.Default.ParkSide == 1)
                    this.Left = Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Right - this.Width;
                else
                    this.Left = Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Left;
                formState = FormState.Showing; //更新状态
                timShowPanel.Enabled = false;   //结束函数
                if (Cursor.Position.X < this.Left || Cursor.Position.Y < this.Top || Cursor.Position.Y > this.Bottom)
                    HidePanel(EaseStyle.EaseOut);   //检查指针
                hidingTime = Settings.Default.hideCount;    //设置隐藏计时
            }
        }
        //更改主题
        public void ChangeTheme(bool isWhite)
        {
            //白色主题
            if (!Settings.Default.isWhite && isWhite)
            {
                //更改背景色
                this.BackColor = Color.FromArgb(248, 251, 252);
                //更改子控件颜色
                ChangeControlColor(this, isWhite);
                //更新状态
                Settings.Default.isWhite = true;
                Form1.mainForm.cmbTheme.SelectedIndex = 0;
            }
            //黑色主题
            else if (Settings.Default.isWhite && !isWhite)
            {
                //更改背景色
                this.BackColor = Color.FromArgb(32, 33, 42);
                //更改子控件颜色
                ChangeControlColor(this, isWhite);
                //更新状态
                Settings.Default.isWhite = false;
                Form1.mainForm.cmbTheme.SelectedIndex = 1;
            }
            //颜色规避
            if (Form1.mainForm.tipTime <= Settings.Default.prepareTime)
                labTipTime.ForeColor = Color.FromKnownColor(KnownColor.DeepPink);
            //预加载动画
            ShowPanel(EaseStyle.EaseOut);
        }
        //修改颜色
        void ChangeControlColor(Control control, bool isWhite)
        {
            //白色主题
            if (isWhite)
            {
                //控件颜色
                foreach (Control sonControl in control.Controls)
                {
                    if (sonControl is Panel)//模块
                    {
                        //修改背景色
                        sonControl.BackColor = Color.White;
                        //递归
                        ChangeControlColor(sonControl, true);
                    }
                    else if (sonControl is Label) sonControl.ForeColor = Color.FromKnownColor(KnownColor.ControlText);    //文本
                }
                //格言
                labMotto.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
                //清单
                clbTasks.BackColor = Color.White;
                clbTasks.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
            //黑色主题
            else
            {
                //控件颜色
                foreach (Control sonControl in control.Controls)
                {
                    if (sonControl is Panel)//模块
                    {
                        //修改背景色
                        sonControl.BackColor = Color.FromArgb(40, 42, 50);
                        //递归
                        ChangeControlColor(sonControl, false);
                    }
                    else if (sonControl is Label) sonControl.ForeColor = Color.White;    //文本
                }
                //格言
                labMotto.ForeColor = Color.FromArgb(125, 127, 183);
                //清单
                clbTasks.BackColor = Color.FromArgb(40, 42, 50);
                clbTasks.ForeColor = Color.White;
            }
        }
        //隐藏
        public bool isTempLock = false, isStaticClock = false;
        private void InfoPanel_MouseLeave(object sender, EventArgs e)
        {
            hidingTime = Settings.Default.hideCount;
            HidePanel(EaseStyle.EaseOut);
        }
        public void HidePanel(EaseStyle es)
        {
            //前置
            if (formState == FormState.InMotion || isStaticClock) return;
            if (isTempLock)
            {
                isTempLock = false;
                return;
            }
            //动画设置
            formAH.leftProcess = formAH.distance = this.Width;
            formAH.es = es;
            switch (es)
            {
                //缓出
                case EaseStyle.EaseOut:
                    formAH.nowVelocity = formAH.maxVelocity = 50;
                    formAH.minVelocity = 5;
                    break;
            }
            //开启动画
            formState = FormState.InMotion;
            isCouting = true;
            timHidePanel.Enabled = true;
        }
        //隐藏发生器
        int hidingTime = Settings.Default.hideCount;
        bool isCouting = true;
        public bool PositionLock = true;
        private void timHidePanel_Tick(object sender, EventArgs e)
        {
            //固定锁
            if (isStaticClock)
            {
                //更新状态
                formState = FormState.Showing;
                PositionLock = true;
                //结束函数
                timHidePanel.Enabled = false;
                return;
            }
            //倒计时
            if (hidingTime > 0 && isCouting)
            {
                hidingTime -= timHidePanel.Interval;
                return;
            }
            //位置锁
            if (PositionLock &&
                ((Settings.Default.ParkSide == 1 && (Cursor.Position.X < this.Left || Cursor.Position.Y < this.Top || Cursor.Position.Y > this.Bottom))
                || (Settings.Default.ParkSide == 0 && (Cursor.Position.X > this.Right || Cursor.Position.Y < this.Top || Cursor.Position.Y > this.Bottom))))
                PositionLock = false;
            if (PositionLock) return;
            if (isCouting) isCouting = false;
            //动画
            if ((Settings.Default.ParkSide == 1 && this.Left < Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Right)
                || (Settings.Default.ParkSide == 0 && this.Right > Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Left))
            {
                //进度迭代
                formAH.leftProcess -= formAH.nowVelocity;
                //运动
                switch (formAH.es)
                {
                    //缓出
                    case EaseStyle.EaseOut:
                        if (Settings.Default.ParkSide == 1) this.Left += formAH.nowVelocity;
                        else this.Left -= formAH.nowVelocity;
                        formAH.nowVelocity = (int)(formAH.maxVelocity * formAH.leftProcess / formAH.distance);
                        if (formAH.nowVelocity < formAH.minVelocity) formAH.nowVelocity = formAH.minVelocity;
                        break;
                }
            }
            else
            {
                //位置修正
                this.Opacity = 0.01;
                if (Settings.Default.ParkSide == 1)
                    this.Left = Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Right - 1;
                else
                    this.Left = Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Left - this.Width + 1;
                //更新状态
                formState = FormState.Hiding;
                PositionLock = true;
                //结束函数
                timHidePanel.Enabled = false;
            }
        }
        #endregion

        #region 交互
        //暂停
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Focus();
            Form1.mainForm.SetStop();
        }
        public void btnStopChange()
        {
            this.Focus();
            btnStop.Text = Form1.mainForm.isStop ? "继续" : "暂离";
        }
        //稍后提醒
        private void btnSoon_Click(object sender, EventArgs e)
        {
            this.Focus();
            Form1.mainForm.TipSoon();
        }
        //重置时间
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Focus();
            Form1.mainForm.ResetTime();
        }
        //关闭屏幕
        private void btnCloseScreen_Click(object sender, EventArgs e)
        {
            this.Focus();
            Form1.mainForm.CloseScreen();
        }
        //打开设置
        private void btnSet_Click(object sender, EventArgs e)
        {
            this.Focus();
            Form1.mainForm.OpenSet();
        }
        //更新格言
        private void labMotto_Click(object sender, EventArgs e)
        {
            labMotto.Text = GetMotto();
        }
        //打开命令行
        private void btnRepair_Click(object sender, EventArgs e)
        {
            OpenCmd();
            this.Focus();
            if (!isStaticClock) this.HidePanel(EaseStyle.EaseOut);
            cmd.Focus();
            cmd.txbInput.Focus();
        }
        void OpenCmd()
        {
            //隐藏
            if (cmd.Visible) cmd.Close();
            else cmd.ShowCmd();
        }
        //笔记
        private void btnNote_Click(object sender, EventArgs e)
        {
            OpenNote();
            this.Focus();
            if (!isStaticClock) this.HidePanel(EaseStyle.EaseOut);
            note.Focus();
        }
        void OpenNote()
        {
            //隐藏
            if (note.Visible) note.Close();
            else note.ShowAppsPanel();
        }
        //勿扰模式
        private void btnSleep_Click(object sender, EventArgs e)
        {
            Form1.mainForm.SetDND();
        }
        //放大动画
        int changeSize = 4;
        private void btnSleep_MouseEnter(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            button.Left -= (int)(changeSize / 2);
            button.Top -= (int)(changeSize / 2);
            button.Width += changeSize;
            button.Height += changeSize;
        }
        //缩小动画
        private void btnSleep_MouseLeave(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            button.Left += (int)(changeSize / 2);
            button.Top += (int)(changeSize / 2);
            button.Width -= changeSize;
            button.Height -= changeSize;
        }
        #endregion

        #region 任务清单
        //上传任务进度
        private void btnUpdateProcess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("云端维护中，暂时无法使用！", "CodaTip");
        }
        //同步web任务
        private void btnSynchronization_Click(object sender, EventArgs e)
        {
            MessageBox.Show("云端维护中，暂时无法使用！", "CodaTip");
        }
        #endregion

        #region 后端
        //位置修复
        public void RepairPlace()
        {
            this.Top = (int)(Screen.AllScreens[Settings.Default.screenNum - 1].Bounds.Height / 2 - this.Height / 2);
            ShowPanel(EaseStyle.EaseOut);
        }
        //信息更新
        public void InfoUpdate()
        {
            //信息区
            labTipTime.Text = "距离下次休息: " + Form1.mainForm.GetStanderdTime(Form1.mainForm.tipTime);
            labUsingTime.Text = "今日使用时间: " + Form1.mainForm.GetStanderdTime(Settings.Default.runTime);
            labOpenTime.Text = "本次开机使用: " + Form1.mainForm.GetStanderdTime(Form1.mainForm.openTime);
            //标题
            int nowHour = Convert.ToInt32((DateTime.Now.ToShortTimeString().Split(':')[0]));
            labHead.Text = (nowHour >= 0 && nowHour < 6) ? string.Format("凌晨了, {0}, 注意休息", Settings.Default.userName) :
                (nowHour < 12) ? string.Format("上午好, {0}", Settings.Default.userName) :
                (nowHour < 14) ? string.Format("中午好, {0}", Settings.Default.userName) :
                (nowHour < 18) ? string.Format("下午好, {0}", Settings.Default.userName) :
                (nowHour < 23) ? string.Format("晚上好, {0}", Settings.Default.userName) :
                string.Format("该休息了, {0}", Settings.Default.userName);
        }
        //随机格言
        int mottoLength = 0;//每行格言字数
        public string GetMotto()
        {
            if (mottoLength < 3) return "";
            //调用文件
            string[] mottos = File.ReadAllLines(mottoPos);
            Random random = new Random();
            //选择文本
            string motto = "";
            while (true)
            {
                motto = mottos[random.Next(0, mottos.Length)];
                if (motto.Length / mottoLength < 2) break;
            }
            //文字分段
            string tempString = "";
            while (true)
            {
                //截取长度
                tempString += motto.Substring(0, motto.Length > mottoLength ? mottoLength : motto.Length);
                if (motto.Length > mottoLength) motto = motto.Substring(mottoLength, motto.Length - mottoLength);
                else break;
                //标点回退
                if (motto[0] == '。' || motto[0] == '，' || motto[0] == ',' || motto[0] == '；' || motto[0] == ':' || motto[0] == '》'
                    || motto[0] == '”' || motto[0] == '"' || motto[0] == '·')
                {
                    tempString += motto[0];
                    if (motto.Length > 1) motto = motto.Substring(1, motto.Length - 1);
                    else break;
                }
                //换行
                tempString += "\r\n";
            }
            return tempString;
        }
        //自适应分辨率
        private void InfoPanel_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        //状态计时
        public int stoppedTime = 0;
        private void timStopCount_Tick(object sender, EventArgs e)
        {
            if (Form1.mainForm.isStop)
            {
                stoppedTime++;
                labTipTime.Text = "已离开时间: " + GetStanderdTimeWithSec(stoppedTime);
            }
            else if (Form1.mainForm.isDND)
            {
                stoppedTime++;
                labTipTime.Text = "已静默时间: " + GetStanderdTimeWithSec(stoppedTime);
            }
        }
        //标准时间
        string GetStanderdTimeWithSec(int sec)
        {
            //处理时间
            int min = sec / 60;
            sec %= 60;
            int hour = min / 60;
            min %= 60;
            //合成文本
            string time = ((hour > 0) ? hour.ToString() : "00") + ":";
            if (min < 10) time += "0";
            time += min + ":";
            if (sec < 10) time += "0";
            time += sec;

            return time;
        }
        #endregion
    }
}
