namespace CodaTip
{
    partial class Cmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cmd));
            this.txbOut = new System.Windows.Forms.TextBox();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tspTools = new System.Windows.Forms.ToolStrip();
            this.tsbMode = new System.Windows.Forms.ToolStripButton();
            this.tssMode = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbSimplify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tslTip = new System.Windows.Forms.ToolStripLabel();
            this.txbTip = new System.Windows.Forms.TextBox();
            this.tspTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbOut
            // 
            this.txbOut.BackColor = System.Drawing.Color.White;
            this.txbOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbOut.Font = new System.Drawing.Font("MiSans", 10F);
            this.txbOut.Location = new System.Drawing.Point(12, 34);
            this.txbOut.Multiline = true;
            this.txbOut.Name = "txbOut";
            this.txbOut.ReadOnly = true;
            this.txbOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbOut.Size = new System.Drawing.Size(488, 260);
            this.txbOut.TabIndex = 0;
            this.txbOut.TabStop = false;
            this.txbOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbOut_KeyPress);
            // 
            // txbInput
            // 
            this.txbInput.AcceptsReturn = true;
            this.txbInput.BackColor = System.Drawing.Color.White;
            this.txbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txbInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbInput.Font = new System.Drawing.Font("MiSans", 10F);
            this.txbInput.Location = new System.Drawing.Point(12, 300);
            this.txbInput.MaxLength = 300;
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(368, 30);
            this.txbInput.TabIndex = 1;
            this.txbInput.TabStop = false;
            this.txbInput.TextChanged += new System.EventHandler(this.txbInput_TextChanged);
            this.txbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbInput_KeyDown);
            this.txbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInput_KeyPress);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("MiSans", 9F);
            this.btnEnter.Location = new System.Drawing.Point(446, 300);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(54, 30);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.TabStop = false;
            this.btnEnter.Text = "确认";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MiSans", 9F);
            this.btnClear.Location = new System.Drawing.Point(386, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tspTools
            // 
            this.tspTools.BackColor = System.Drawing.SystemColors.Control;
            this.tspTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMode,
            this.tssMode,
            this.tsbClear,
            this.tsbSimplify,
            this.toolStripSeparator2,
            this.tsbHelp,
            this.tslTip});
            this.tspTools.Location = new System.Drawing.Point(0, 0);
            this.tspTools.Name = "tspTools";
            this.tspTools.Size = new System.Drawing.Size(512, 27);
            this.tspTools.TabIndex = 4;
            this.tspTools.Text = "toolStrip1";
            // 
            // tsbMode
            // 
            this.tsbMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbMode.Image")));
            this.tsbMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMode.Name = "tsbMode";
            this.tsbMode.Size = new System.Drawing.Size(29, 24);
            this.tsbMode.Text = "结束特殊模式";
            this.tsbMode.Visible = false;
            this.tsbMode.Click += new System.EventHandler(this.tsbMode_Click);
            // 
            // tssMode
            // 
            this.tssMode.Name = "tssMode";
            this.tssMode.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbClear
            // 
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(29, 24);
            this.tsbClear.Text = "toolStripButton1";
            this.tsbClear.ToolTipText = "清空";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // tsbSimplify
            // 
            this.tsbSimplify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSimplify.Image = ((System.Drawing.Image)(resources.GetObject("tsbSimplify.Image")));
            this.tsbSimplify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSimplify.Name = "tsbSimplify";
            this.tsbSimplify.Size = new System.Drawing.Size(29, 24);
            this.tsbSimplify.Text = "toolStripButton1";
            this.tsbSimplify.ToolTipText = "整理";
            this.tsbSimplify.Click += new System.EventHandler(this.tsbSimplify_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbHelp
            // 
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(29, 24);
            this.tsbHelp.Text = "toolStripButton1";
            this.tsbHelp.ToolTipText = "帮助";
            this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
            // 
            // tslTip
            // 
            this.tslTip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tslTip.Name = "tslTip";
            this.tslTip.Size = new System.Drawing.Size(80, 24);
            this.tslTip.Text = "Loading...";
            this.tslTip.Visible = false;
            // 
            // txbTip
            // 
            this.txbTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTip.Font = new System.Drawing.Font("Mongolian Baiti", 11F);
            this.txbTip.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbTip.Location = new System.Drawing.Point(12, 336);
            this.txbTip.Multiline = true;
            this.txbTip.Name = "txbTip";
            this.txbTip.ReadOnly = true;
            this.txbTip.Size = new System.Drawing.Size(488, 73);
            this.txbTip.TabIndex = 5;
            this.txbTip.TabStop = false;
            // 
            // Cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(512, 338);
            this.Controls.Add(this.txbTip);
            this.Controls.Add(this.tspTools);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.txbOut);
            this.Font = new System.Drawing.Font("MiSans", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cmd";
            this.ShowInTaskbar = false;
            this.Text = "CodaTip-cmd++";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cmd_FormClosing);
            this.Load += new System.EventHandler(this.Cmd_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmd_KeyPress);
            this.tspTools.ResumeLayout(false);
            this.tspTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOut;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStrip tspTools;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.ToolStripButton tsbSimplify;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.ToolStripButton tsbMode;
        private System.Windows.Forms.ToolStripSeparator tssMode;
        private System.Windows.Forms.TextBox txbTip;
        private System.Windows.Forms.ToolStripLabel tslTip;
    }
}