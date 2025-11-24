using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbtnShortBreak = new System.Windows.Forms.RadioButton();
            this.rbtnLongBreak = new System.Windows.Forms.RadioButton();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.pgbTimer = new System.Windows.Forms.ProgressBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStatus.Location = new System.Drawing.Point(584, 111);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(153, 78);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "准备";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(554, 238);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(315, 131);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "25:00";
            // 
            // btnStartPause
            // 
            this.btnStartPause.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartPause.Location = new System.Drawing.Point(285, 682);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(257, 79);
            this.btnStartPause.TabIndex = 3;
            this.btnStartPause.Text = "开始";
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(875, 682);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(257, 79);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "重新计时";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbtnShortBreak
            // 
            this.rbtnShortBreak.AutoSize = true;
            this.rbtnShortBreak.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnShortBreak.Location = new System.Drawing.Point(403, 516);
            this.rbtnShortBreak.Name = "rbtnShortBreak";
            this.rbtnShortBreak.Size = new System.Drawing.Size(168, 40);
            this.rbtnShortBreak.TabIndex = 4;
            this.rbtnShortBreak.TabStop = true;
            this.rbtnShortBreak.Text = "休息5分钟";
            this.rbtnShortBreak.UseVisualStyleBackColor = true;
            this.rbtnShortBreak.CheckedChanged += new System.EventHandler(this.rbtnShortBreak_CheckedChanged);
            // 
            // rbtnLongBreak
            // 
            this.rbtnLongBreak.AutoSize = true;
            this.rbtnLongBreak.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnLongBreak.Location = new System.Drawing.Point(855, 516);
            this.rbtnLongBreak.Name = "rbtnLongBreak";
            this.rbtnLongBreak.Size = new System.Drawing.Size(184, 40);
            this.rbtnLongBreak.TabIndex = 4;
            this.rbtnLongBreak.TabStop = true;
            this.rbtnLongBreak.Text = "休息15分钟";
            this.rbtnLongBreak.UseVisualStyleBackColor = true;
            this.rbtnLongBreak.CheckedChanged += new System.EventHandler(this.rbtnLongBreak_CheckedChanged);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 10;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentTime.Location = new System.Drawing.Point(36, 25);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(87, 36);
            this.lblCurrentTime.TabIndex = 5;
            this.lblCurrentTime.Text = "time";
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // pgbTimer
            // 
            this.pgbTimer.Location = new System.Drawing.Point(109, 438);
            this.pgbTimer.Name = "pgbTimer";
            this.pgbTimer.Size = new System.Drawing.Size(1249, 10);
            this.pgbTimer.TabIndex = 6;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cmsTray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "简易番茄钟";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cmsTray
            // 
            this.cmsTray.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tsmiExit});
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new System.Drawing.Size(153, 64);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(152, 30);
            this.tsmiShow.Text = "显示窗口";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 30);
            this.tsmiExit.Text = "退出程序";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 904);
            this.ContextMenuStrip = this.cmsTray;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rbtnShortBreak);
            this.Controls.Add(this.rbtnLongBreak);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.pgbTimer);
            this.Name = "Form1";
            this.Text = "简易番茄钟";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbtnShortBreak;
        private System.Windows.Forms.RadioButton rbtnLongBreak;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.ProgressBar pgbTimer;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip cmsTray;
        private ToolStripMenuItem tsmiShow;
        private ToolStripMenuItem tsmiExit;
    }
}

