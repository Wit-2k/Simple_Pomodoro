namespace WindowsFormsApp1
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pgbTimer = new System.Windows.Forms.ProgressBar();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbtnShortBreak = new System.Windows.Forms.RadioButton();
            this.rbtnLongBreak = new System.Windows.Forms.RadioButton();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
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
            // pgbTimer
            // 
            this.pgbTimer.Location = new System.Drawing.Point(94, 440);
            this.pgbTimer.Maximum = 1500;
            this.pgbTimer.Name = "pgbTimer";
            this.pgbTimer.Size = new System.Drawing.Size(1246, 10);
            this.pgbTimer.TabIndex = 2;
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
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 904);
            this.Controls.Add(this.rbtnLongBreak);
            this.Controls.Add(this.rbtnShortBreak);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.pgbTimer);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "简易番茄钟";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ProgressBar pgbTimer;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbtnShortBreak;
        private System.Windows.Forms.RadioButton rbtnLongBreak;
        private System.Windows.Forms.Timer tmrMain;
    }
}

