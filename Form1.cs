using CodaTip.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodaTip
{
    public partial class Form1 : Form
    {
        #region 数据
        string ID = "CodaTip";//程序名
        string ver = "1.0.0";//版本
        #endregion

        #region 初始化
        //构造函数
        public Form1()
        {
            InitializeComponent();
        }
        //初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            //更新时间
            try { if (Settings.Default.lastRunDay.Date == DateTime.Now.Date) Settings.Default.runTime = 0; }
            catch { }
            Settings.Default.lastRunDay = DateTime.Now;
            //更新文本
            TipUpdate();
            //布置数据
            this.Close();
        }
        #endregion

        #region 发生器
        //发生函数
        int tipTime = Settings.Default.TipInterval;
        private void timGenerater_Tick(object sender, EventArgs e)
        {
            //数据更新
            tipTime--;
            Settings.Default.runTime++;
            //计时结束
            if (tipTime == 0)
            {
                //提醒
                if (Settings.Default.IsBallTip) nficMain.ShowBalloonTip(10000, "速去休息呀!!!", ID, ToolTipIcon.None);
                if (Settings.Default.IsMsbTip) MessageBox.Show("速去休息呀!!!", ID);
                //重置
                ResetTime();
            }
            //更新文本
            TipUpdate();
        }
        //更新文本
        void TipUpdate()
        {
            nficMain.Text = string.Format("{0} - {1}\r\n距离下次休息: {2}\r\n今日使用时长: {3}",
                ID, ver, GetTime(tipTime), GetTime(Settings.Default.runTime));
        }
        //获取标准时间格式文本
        string GetTime(int min)
        {
            //处理时间
            int hour = min / 60;
            min %= 60;
            //合成文本
            string time = "";
            if (hour > 0)
            {
                if (hour < 10) time = "0";
                time += hour + ":";
                if (min < 10) time += "0";
            }
            time += min;
            if (hour == 0) time += "min";

            return time;
        }
        #endregion

        #region 右键
        //稍后提醒
        private void tsmiTipSoon_Click(object sender, EventArgs e)
        {
            if (Settings.Default.TipInterval > 5) tipTime = 5;
            else tipTime = 1;
        }
        //重置时间
        private void tsmiReset_Click(object sender, EventArgs e)
        {
            ResetTime();
        }
        void ResetTime()
        {
            tipTime = Settings.Default.TipInterval;
            TipUpdate();
        }
        //勿扰模式
        bool isDND = false;
        bool isBallTipRec = Settings.Default.IsBallTip, isMsbTipRec = Settings.Default.IsMsbTip;
        private void tsmiDND_Click(object sender, EventArgs e)
        {
            //设置模式
            isDND = !isDND;
            //进入勿扰
            if (isDND)
            {
                //更改设置
                Settings.Default.IsBallTip = false;  //右下角提醒
                Settings.Default.IsMsbTip = false;    //弹窗提醒
                //修改文本
                tsmiDND.Text = "退出勿扰";
            }
            //解除勿扰
            else
            {
                //还原设置
                Settings.Default.IsBallTip = isBallTipRec;  //右下角提醒
                Settings.Default.IsMsbTip = isMsbTipRec;    //弹窗提醒
                Settings.Default.Save();
                //修改文本
                tsmiDND.Text = "勿扰模式";
            }
        }
        //设置
        private void tsmiSet_Click(object sender, EventArgs e)
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
        bool isStop = false;
        private void tsmiStop_Click(object sender, EventArgs e)
        {
            //更改设置
            isStop = !isStop;
            //暂停
            if (isStop)
            {
                timGenerater.Enabled = false;
                tsmiStop.Text = "继续";
            }
            //继续
            else
            {
                timGenerater.Enabled = true;
                tsmiStop.Text = "暂停";
            }
        }
        #endregion

        #region 设置界面
        //关闭页面
        bool isRealClose = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //关闭
            if (isRealClose)
            {
                //更新数据
                if (isDND)
                {
                    Settings.Default.IsBallTip = isBallTipRec;  //右下角提醒
                    Settings.Default.IsMsbTip = isMsbTipRec;    //弹窗提醒
                }
                Settings.Default.Save();
                //退出
                return;
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
            ResetTime();
            //右下角提醒、弹窗提醒
            if (isDND)
            {
                isBallTipRec = Settings.Default.IsBallTip;  //右下角提醒
                isMsbTipRec = Settings.Default.IsMsbTip;    //弹窗提醒
            }
            else
            {
                Settings.Default.IsBallTip = ckbIsBallTip.Checked;  //右下角提醒
                Settings.Default.IsMsbTip = ckbIsMsbTip.Checked;    //弹窗提醒
            }
            Settings.Default.Save();
            //提示
            MessageBox.Show("保存成功！", ID);
            //关闭
            this.Close();
        }
        #endregion
    }
}
