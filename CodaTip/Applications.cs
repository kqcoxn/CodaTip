using CodaTip.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodaTip
{
    public partial class AppPanel : Form
    {
        #region 初始化
        //构造函数
        public AppPanel()
        {
            InitializeComponent();
        }
        //初始化
        Cmd cmd;
        private void AppPanel_Load(object sender, EventArgs e)
        {
            //隐藏
            this.Visible = false;
            //位置与属性
            txbNote.Text = Settings.Default.noteText;
            this.Size = Settings.Default.noteSize;
            this.Location = Settings.Default.notePos;
            //关联cmd
            cmd = Form1.mainForm.cmd;
        }
        #endregion

        #region 后端
        //关闭
        public bool isRealClose = false;
        private void AppPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存
            SaveNote();
            //关闭
            if (isRealClose) return;
            //隐藏
            e.Cancel = true;
            this.ShowInTaskbar = false;
            this.Visible = false;
        }
        //打开
        public void ShowAppsPanel()
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
        }
        //快捷键
        private void txbNote_KeyDown(object sender, KeyEventArgs e)
        {
            //保存
            if (e.Control && e.KeyCode == Keys.S)
            {
                labTip.Visible = true;
                tipShowCount = 1;
                timTip.Enabled = true;
                SaveNote();
                e.Handled = true;
            }
            //查找
            else if (e.Control && e.KeyCode == Keys.F)
            {
                cmd.txbInput.Text = "findtext ";
                cmd.txbInput.Select(cmd.txbInput.Text.Length, 0);
                cmd.txbInput.Focus();
                if (!cmd.Visible) cmd.Visible = true;
                e.Handled = true;
            }
        }
        public void SaveNote()
        {
            Settings.Default.noteSize = this.Size;
            Settings.Default.notePos = this.Location;
            Settings.Default.noteText = txbNote.Text;
        }
        //大小改变
        private void txbNote_SizeChanged(object sender, EventArgs e)
        {
            labTip.Top = txbNote.Height - 28;
        }
        //保存提示
        int tipShowCount = 1;
        private void timTip_Tick(object sender, EventArgs e)
        {
            if (tipShowCount > 0) tipShowCount--;
            else
            {
                labTip.Visible = false;
                timTip.Enabled = false;
            }
        }

        #endregion
    }
}
