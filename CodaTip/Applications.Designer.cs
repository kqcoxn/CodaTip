namespace CodaTip
{
    partial class AppPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppPanel));
            this.txbNote = new System.Windows.Forms.TextBox();
            this.labTip = new System.Windows.Forms.Label();
            this.timTip = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txbNote
            // 
            this.txbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbNote.Font = new System.Drawing.Font("MiSans", 11F);
            this.txbNote.Location = new System.Drawing.Point(0, 0);
            this.txbNote.Multiline = true;
            this.txbNote.Name = "txbNote";
            this.txbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbNote.Size = new System.Drawing.Size(313, 199);
            this.txbNote.TabIndex = 0;
            this.txbNote.TabStop = false;
            this.txbNote.SizeChanged += new System.EventHandler(this.txbNote_SizeChanged);
            this.txbNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNote_KeyDown);
            // 
            // labTip
            // 
            this.labTip.AutoSize = true;
            this.labTip.BackColor = System.Drawing.Color.Transparent;
            this.labTip.Font = new System.Drawing.Font("MiSans", 9F);
            this.labTip.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labTip.Location = new System.Drawing.Point(6, 171);
            this.labTip.Margin = new System.Windows.Forms.Padding(1);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(88, 20);
            this.labTip.TabIndex = 1;
            this.labTip.Text = "文本已保存!";
            this.labTip.Visible = false;
            // 
            // timTip
            // 
            this.timTip.Interval = 1000;
            this.timTip.Tick += new System.EventHandler(this.timTip_Tick);
            // 
            // AppPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(313, 199);
            this.Controls.Add(this.labTip);
            this.Controls.Add(this.txbNote);
            this.Font = new System.Drawing.Font("MiSans", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppPanel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CodaTip-Note";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppPanel_FormClosing);
            this.Load += new System.EventHandler(this.AppPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbNote;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.Timer timTip;
    }
}