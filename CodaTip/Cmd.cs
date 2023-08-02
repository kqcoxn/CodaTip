using CodaTip.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Windows.Forms;

namespace CodaTip
{
    public partial class Cmd : Form
    {
        #region 初始化
        //构造函数
        public Cmd()
        {
            InitializeComponent();
        }
        //初始化
        AppPanel note;
        private void Cmd_Load(object sender, EventArgs e)
        {
            //隐藏
            this.Visible = false;
            //位置与属性
            this.Location = Settings.Default.cmdPos;
            //绑定笔记
            note = Form1.mainForm.note;
        }
        #endregion

        #region 命令行
        //单行命令
        public void ProcCmd(string cmd)
        {
            tslTip.Text = "Loading...";
            if (!tslTip.Visible) tslTip.Visible = true;
            TimeSpan ts = new TimeSpan(DateTime.Now.Ticks);
            try
            {
                //初始化命令解析
                string[] part = cmd.Split(' ');
                string key = part[0];
                //记录留存
                AddRecord(cmd);
                //问候
                if (key == "hello")
                {
                    Print("Hello!");
                }
                //关机
                else if (key == "shutdown")
                {
                    //取消关机
                    if (part[1] == "-a")
                    {
                        RunCmd("shutdown -a");
                        Print("已通过cmd成功执行\"shutdown\"指令，关机进程已取消");
                    }
                    //关机
                    else
                    {
                        int sec = Convert.ToInt32((Convert.ToDouble(part[1]) * 60).ToString());
                        RunCmd("shutdown -s -t " + sec);
                        Print("已通过cmd成功执行\"shutdown\"指令，系统将在" + part[1] + "分钟(" + sec + "s)后关机");
                    }
                }
                //翻译
                else if (key == "trans")
                {
                    //解析命令
                    string p = string.Empty;
                    string from = "auto";
                    string to = "en";
                    string[] temp = cmd.Split('*');
                    if (temp.Length > 1 && (temp[1].Substring(0, 2) == "en" || temp[1].Substring(0, 2) == "zh"))
                    {
                        for (int i = 2; i < part.Length - 2; i++)
                        {
                            p += part[i] + ' ';
                        }
                        p += part[part.Length - 1];
                        if (temp[1].Substring(0, 2) == "en")
                        {
                            from = "zh";
                            to = "en";
                        }
                        else if (temp[1].Substring(0, 2) == "zh")
                        {
                            from = "en";
                            to = "zh";
                        }
                    }
                    else
                    {
                        for (int i = 1; i < part.Length - 2; i++)
                        {
                            p += part[i] + ' ';
                        }
                        p += part[part.Length - 1];
                        from = DetectLang(p);
                        if (from == "auto") to = "en";
                        else to = (from == "zh") ? "en" : "zh";
                    }
                    //接入百度api
                    string appId = "20230202001548142";
                    Random rd = new Random();
                    string salt = rd.Next(100000).ToString();
                    string secretKey = "ZgdJ1S_7FwYnOHC6Ktc7";
                    string sign = EncryptString(appId + p + salt + secretKey);
                    string url = "http://api.fanyi.baidu.com/api/trans/vip/translate?" + "q=" + HttpUtility.UrlEncode(p)
                        + "&from=" + from + "&to=" + to + "&appid=" + appId + "&salt=" + salt + "&sign=" + sign;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    request.Method = "GET";
                    request.ContentType = "text/html;charset=UTF-8";
                    request.UserAgent = null;
                    request.Timeout = 6000;
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream myResponseStream = response.GetResponseStream();
                    StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    string retStrs = DecodeUnicode(myStreamReader.ReadToEnd().Split('\"')[17]);
                    myStreamReader.Close();
                    myResponseStream.Close();
                    //输出
                    Print(string.Format(">\"{0}\"", retStrs));
                }
                //结束所有模式
                else if (key == "modefalse")
                {
                    mode = Mode.None;
                    tsbMode.Visible = tssMode.Visible = false;
                    ForecastCmd();
                    Print("模式: 常规");
                }
                //常驻翻译模式
                else if (key == "transmode")
                {
                    SetMode(Mode.Transmode);
                    Print("模式: 常驻翻译");
                    Print("直接发送需要翻译的字符串即可进行翻译");
                }
                //查找笔记文本
                else if (key == "findtext")
                {
                    int index = note.txbNote.Text.IndexOf(part[1]);
                    if (index == -1) Print("未查询到结果!");
                    else
                    {
                        note.txbNote.Select(index, part[1].Length);
                        Print("已查询到结果!");
                        note.Focus();
                    }
                }
                //打开文件夹
                else if (key == "openfile")
                {
                    //本地文件夹
                    if (part.Length == 1)
                    {
                        Process.Start(@".\");
                        Print("已打开程序根目录");
                    }
                    else
                    {
                        string[] urls = File.ReadAllLines(@".\stg\urls.txt");
                        //目录法
                        try
                        {
                            int index = Convert.ToInt32(part[1]) - 1;
                            if (index > -1 && index < urls.Length)
                            {
                                Process.Start(urls[index].Split(' ')[1]);
                                Print("已打开文件夹!");
                            }
                            else Print("不存在该序号!");
                        }
                        //文本法
                        catch
                        {
                            try
                            {
                                foreach (string url in urls)
                                {
                                    if (part[1] == url.Split(' ')[0])
                                    {
                                        Process.Start(url.Split(' ')[1]);
                                        Print("已打开文件夹!");
                                        return;
                                    }
                                }
                                Print("不存在该文件夹!");
                            }
                            catch { Print("原文件夹已被移除!"); }
                        }
                    }
                }
                //保存文件夹
                else if (key == "savefile")
                {
                    File.WriteAllText(@".\stg\urls.txt", File.ReadAllText(@".\stg\urls.txt") + part[2] + " " + part[1] + "\r\n");
                    Print("已成功保存文件夹!");
                }
                //删除文件夹
                else if (key == "deletefile")
                {
                    string[] urls = File.ReadAllLines(@".\stg\urls.txt");
                    string[] newUrls = new string[urls.Length - 1];
                    int i;
                    bool isSearched = false;
                    for (i = 0; i < urls.Length; i++)
                    {
                        if (part[1] == urls[i].Split(' ')[0])
                        {
                            isSearched = true;
                            break;
                        }
                        newUrls[i] = urls[i];
                    }
                    if (isSearched)
                    {
                        for (i++; i < urls.Length; i++)
                        {
                            newUrls[i - 1] = urls[i];
                        }
                        File.WriteAllText(@".\stg\urls.txt", string.Join("\r\n", newUrls));
                        Print("已删除该文件夹!");
                    }
                    else Print("不存在该文件夹!");
                }
                //查询文件夹
                else if (key == "lookupfile")
                {
                    string[] urls = File.ReadAllLines(@".\stg\urls.txt");
                    if (urls.Length > 0)
                    {
                        Print("已保存的文件夹:");
                        for (int i = 0; i < urls.Length; i++)
                        {
                            Print(string.Format(" [{0}] {1}", i + 1, urls[i]));
                        }
                    }
                    else Print("未保存任何文件夹!");
                }
                //打开机器人控制台
                else if(key == "bottest")
                {
                    var process = new Process();
                    process.StartInfo.FileName = @"powershell.exe";
                    process.StartInfo.Arguments = @"-noexit cd D:\Packet\QQAiBot\CodaAlpha";
                    process.Start();
                }

                //无效
                else { Print("Error101: 错误的命令，请仔细查看帮助或重试"); }
            }
            catch { Print("Error102: 错误的命令，请仔细查看帮助或重试"); }
            tslTip.Text = "执行速度: " + new TimeSpan(DateTime.Now.Ticks).Subtract(ts).Duration().TotalSeconds.ToString("f3") + "s";
        }
        //启用模式
        enum Mode
        {
            None,
            Transmode
        }
        Mode mode = Mode.None;
        void SetMode(Mode setting)
        {
            mode = setting;
            tssMode.Visible = tsbMode.Visible = true;
        }
        //解码Unicode字符串
        private string DecodeUnicode(string s)
        {
            Regex reUnicode = new Regex(@"\\u([0-9a-fA-F]{4})", RegexOptions.Compiled);

            return reUnicode.Replace(s, m =>
            {
                short c;
                if (short.TryParse(m.Groups[1].Value, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out c))
                {
                    return "" + (char)c;
                }
                return m.Value;
            });
        }
        //调用cmd
        void RunCmd(string cmd)
        {
            //启动cmd
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            //向cmd窗口发送输入信息
            p.StandardInput.WriteLine(cmd + "&exit");
            p.StandardInput.AutoFlush = true;
            //获取cmd窗口的输出信息
            string output = p.StandardOutput.ReadToEnd();
            //等待程序执行完退出进程
            p.WaitForExit();
            p.Close();
        }
        // 计算MD5值
        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }
        //判断文本语言
        public string DetectLang(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            char[] chars = Encoding.UTF8.GetChars(bytes);
            int[] langP = new int[3] { 0, 0, 0 };
            for (int i = 0; i < chars.Length; i++)
            {
                langP[DetectLangChar(chars[i])] += 1;
            }
            int lang = -1; int max = 0;
            for (int i = 0; i < langP.Length; i++)
            {
                if (langP[i] > max)
                {
                    max = langP[i]; lang = i;
                }
            }
            switch (lang)
            {
                case 1:
                    return "en";
                case 2:
                    return "zh";
                default:
                    return "auto";
            }
        }
        //判断字符语言
        private int DetectLangChar(char c)
        {
            int index = Convert.ToInt32(c);
            if (index > 13312 && index < 40895) return 2;
            else if (index > 65 && index < 122) return 1;
            else return 0;
        }

        #endregion

        #region 操作
        //快捷键
        int nowRecord = 0;
        private void txbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //确认
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                UploadCmd(txbInput.Text);
            }
            //补全
            else if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                e.Handled = true;
                if (!txbInput.Text.Contains(tabComplete))
                {
                    txbInput.Text = tabComplete;
                    txbInput.Select(txbInput.Text.Length, 0);
                }
            }
            //关闭
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                e.Handled = true;
                this.Close();
            }

            //非快捷键
            else
            {
                nowRecord = 0;
            }
        }
        private void txbInput_KeyDown(object sender, KeyEventArgs e)
        {
            //历史
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
                nowRecord++;
                try
                {
                    txbInput.Text = records[records.Count() - nowRecord];
                    txbInput.Select(txbInput.Text.Length, 0);
                }
                catch { nowRecord--; }
            }
            else if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                nowRecord--;
                try
                {
                    txbInput.Text = records[records.Count() - nowRecord];
                    txbInput.Select(txbInput.Text.Length, 0);
                }
                catch { nowRecord++; }
            }
            //清空
            else if (e.Control && e.KeyCode == Keys.Back)
            {
                e.Handled = true;
                txbInput.Text = string.Empty;
            }

            //非快捷键
            else
            {
                nowRecord = 0;
            }
        }
        private void txbOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            //关闭
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                e.Handled = true;
                this.Close();
            }
        }
        private void Cmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //关闭
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                e.Handled = true;
                this.Close();
            }
        }
        //确认
        private void btnEnter_Click(object sender, EventArgs e)
        {
            UploadCmd(txbInput.Text);
        }
        public void UploadCmd(string cmd)
        {
            //模式
            if (mode == Mode.Transmode) cmd = "trans " + cmd;
            //输入
            Input(cmd);
            ProcCmd(cmd);
            //清空输入框
            txbInput.Text = string.Empty;
            ForecastCmd();
            txbInput.Focus();
        }
        //清除
        private void btnClear_Click(object sender, EventArgs e)
        {
            txbInput.Text = string.Empty;
        }
        #endregion

        #region 顶部按键
        List<string> records = new List<string>();
        //保存记录
        void AddRecord(string record)
        {
            records.Add(record);
        }
        //清除记录
        private void tsbClear_Click(object sender, EventArgs e)
        {
            txbOut.Text = string.Empty;
            records.Clear();
        }
        //整理
        private void tsbSimplify_Click(object sender, EventArgs e)
        {
            isSimplifying = true;
            txbOut.Text = string.Empty;
            foreach (string str in records)
            {
                Input(str);
            }
            isSimplifying = false;
        }
        //帮助
        private void tsbHelp_Click(object sender, EventArgs e)
        {
            Print("\"CodaTip-cmd++\"是一款轻量级功能性命令行执行工具");
            Print("它支持以简洁的语言操作快速调用常用的系统指令, 优点在于可以随时查看指令的使用规则, 而且这些指令十分简单常用");
            Print("以下是目前支持的指令与格式: (空格需保留一个, []需全部忽略, 前后无空格)");
            Print("[0]结束其他特殊模式:\r\n  modefalse");
            Print("[1]快速关机:\r\n  shutdown [时间(最高精确至一位小数/min)]");
            Print("[1]取消关机:\r\n  shutdown [-a]");
            Print("[2]中英翻译:\r\n  trans [*zh/*en(目标语言)/*任意其他字符串/空(自动)] [文本字符串]");
            Print("[2]翻译模式:\r\n  transmode");
            Print("[3]保存文件夹地址:\r\n  savefile [文件夹地址(绝对路径)] [文件夹名称]");
            Print("[3]查询已保存文件夹:\r\n  lookupfile [文件夹名称]");
            Print("[3]删除已保存文件夹:\r\n  deletefile [文件夹名称]");
            Print("[3]打开已保存文件夹:\r\n  openfile [文件夹名称/序号](若为空则打开本程序文件夹)");
            Print("[4]检索CodaTip-Note内容:\r\n  findtext [文本字符串]（暂不支持多值查询）");
        }
        //模式结束
        private void tsbMode_Click(object sender, EventArgs e)
        {
            Input("modefalse");
            ProcCmd("modefalse");
        }
        #endregion

        #region 后端
        //输入预检测
        Dictionary<string, string> cmdSet = new Dictionary<string, string>() {
            { "modefalse","结束其他特殊模式" },
            {  "shutdown","通过cmd定时关机\r\n快速关机: shutdown [时间(最高精确至一位小数/min)]\r\n取消关机: shutdown [-a]" },
            { "trans","中英翻译: trans [*zh/*en(目标语言)/*任意其他字符串/空(自动)] [文本字符串]\r\n划译模式: transmode" },
            { "transmode","该模式下直接输入需要翻译的内容即可，使用\"modefalse\"退出模式"},
            {"findnotetext","检索CodaTip-Note内容: findtext [文本字符串]\r\n*暂不支持多值查询" },
            { "openfile","打开已保存文件夹: openfile [文件夹名称/*序号](若为空则打开本程序文件夹)\r\n其他相关操作: \r\n" +
                "保存/查询/删除: savefile/lookupfile/deletefile" },
            { "lookupfile","查询已保存文件夹: lookupfile [文件夹名称(若为空则打开本程序文件夹)]\r\n其他相关操作: \r\n" +
                "保存/删除/打开: savefile/deletefile/openfile" },
            { "deletefile","删除已保存文件夹: deletefile [文件夹名称(若为空则打开本程序文件夹)]\r\n其他相关操作: \r\n" +
                "保存/查询/打开: savefile/lookupfile/openfile" },
            { "savefile","保存文件夹地址: savefile [文件夹名称(若为空则打开本程序文件夹)]\r\n其他相关操作: \r\n" +
                "查询/删除/打开: lookupfile/deletefile/openfile" },
             { "bottest","打开机器人测试" },
        };
        string tabComplete = string.Empty;
        private void txbInput_TextChanged(object sender, EventArgs e)
        {
            if (mode != Mode.None) return;
            ForecastCmd();
        }
        void ForecastCmd()
        {
            if (txbInput.Text == string.Empty)
            {
                if (this.Height != 385) this.Height = 385;
            }
            else
            {
                string maxKey = string.Empty;
                double maxValue = 0;
                foreach (string cmd in cmdSet.Keys)
                {
                    if (ComputeTextSame(txbInput.Text, cmd) > maxValue)
                    {
                        maxKey = cmd;
                        maxValue = ComputeTextSame(txbInput.Text, cmd);
                    }
                }
                if (maxValue > 0)
                {
                    txbTip.Text = "* " + maxKey + "\r\n" + cmdSet[maxKey];
                    tabComplete = maxKey;
                    if (this.Height != 460) this.Height = 460;
                }
            }
        }
        double ComputeTextSame(string textX, string textY)
        {
            if (textX.Length <= 0 || textY.Length <= 0)
            {
                return (0);
            }
            int[,] dp = new int[Math.Max(textX.Length, textY.Length) + 1, Math.Max(textX.Length, textY.Length) + 1];
            for (int x = 0; x < textX.Length; x++)
            {
                for (int y = 0; y < textY.Length; y++)
                {
                    if (textX[x] == textY[y])
                    {
                        dp[x + 1, y + 1] = dp[x, y] + 1;
                    }
                    else
                    {
                        dp[x + 1, y + 1] = Math.Max(dp[x, y + 1], dp[x + 1, y]);
                    }
                }
            }
            return (Math.Round(((double)(dp[textX.Length, textY.Length]) / Math.Max(textX.Length, textY.Length)) * 100, 2));
        }
        //提示更新
        void Print(string str)
        {
            txbOut.Text += ">" + str + "\r\n";
            txbOut.SelectionStart = txbOut.Text.Length;
            txbOut.ScrollToCaret();
        }
        bool isSimplifying = false;
        void Input(string str)
        {
            if (txbOut.Text.Length != 0 && !isSimplifying) txbOut.Text += "\r\n";
            txbOut.Text += "-> " + str + "\r\n";
            txbOut.SelectionStart = txbOut.Text.Length;
            txbOut.ScrollToCaret();
        }
        //关闭
        public bool isRealClose = false;
        private void Cmd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存
            SaveSet();
            //关闭
            if (isRealClose) return;
            //隐藏
            e.Cancel = true;
            this.ShowInTaskbar = false;
            this.Visible = false;
            txbOut.Text = txbInput.Text = string.Empty;
        }
        //保存
        public void SaveSet()
        {
            Settings.Default.cmdPos = this.Location;
        }
        //打开
        public void ShowCmd()
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
        }



        #endregion


    }
}
