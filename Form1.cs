using System;
using System.Windows.Forms;

// TODO：自定义工作时间和休息时间
// TODO：增加系统托盘图标
// TODO：退出程序前提示今天完成的番茄钟数量

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region 1. 常量、变量

        // 调试用
        private const int TIME_WORK = 10;
        private const int TIME_SHORT_BREAK = 12;
        private const int TIME_LONG_BREAK = 15;

        //private const int TIME_WORK = 25 * 60; // 工作时间25分钟
        //private const int TIME_SHORT_BREAK = 5 * 60; // 短休息时间5分钟
        //private const int TIME_LONG_BREAK = 15 * 60; // 长休息时间15分钟

        private int totalSeconds = TIME_WORK;
        private int currentSeconds; // 剩余时间

        private enum PomodoroMode // 番茄钟模式决定 totalSeconds 变量的值
        {
            Work,
            ShortBreak,
            LongBreak
        }

        private PomodoroMode currentMode = PomodoroMode.Work;
        private PomodoroMode breakMode; // 由单选框决定休息模式

        private enum TimerState // 计时器状态决定标签和按钮文本
        {
            Stopped,
            Running,
            Paused
        }

        private TimerState timerState = TimerState.Stopped;

        #endregion

        #region 2. 初始化与加载
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; // 禁止缩放
            MaximizeBox = false; // 禁止最大化            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTimer();
            lblStatus.Text = "准备工作"; // 每次打开默认准备工作
            rbtnShortBreak.Checked = true; // 默认短休息
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss"); // 显示当前时间，消除启动延迟
        }

        #endregion

        #region 3. 业务逻辑

        private void ResetTimer()
        {
            tmrMain.Stop();
            timerState = TimerState.Stopped;
            currentSeconds = totalSeconds;

            pgbTimer.Maximum = totalSeconds;
            pgbTimer.Value = totalSeconds;

            btnStartPause.Text = "开始";
            RefreshLabel();
        }

        private void RefreshLabel()  // 刷新时间标签，主要由定时器触发
        {
            lblTime.Text = string.Format("{0:D2}:{1:D2}", currentSeconds / 60, currentSeconds % 60);
        }

        private void SwitchMode(PomodoroMode newMode)
        {
            currentMode = newMode; // 自动或手动改变模式

            switch (currentMode)
            {
                case PomodoroMode.Work:
                    totalSeconds = TIME_WORK;
                    lblStatus.Text = "准备工作";
                    break;
                case PomodoroMode.ShortBreak:
                    totalSeconds = TIME_SHORT_BREAK;
                    lblStatus.Text = "准备休息（短）";
                    break;
                case PomodoroMode.LongBreak:
                    totalSeconds = TIME_LONG_BREAK;
                    lblStatus.Text = "准备休息（长）";
                    break;
            }

            ResetTimer();
        }

        #endregion

        #region 4. UI事件

        /// <summary>
        /// “重新计时”按钮不仅重置时间，还要刷新状态标签文本
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SwitchMode(currentMode); // 重置定时器，刷新标签内容
        }

        /// <summary>
        /// 定时期间更新时间标签和进度条
        /// 定时结束后弹出提示框，切换模式并重置定时器
        /// </summary>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (currentSeconds > 0) // 该部分每秒执行一次
            {
                currentSeconds--;
                RefreshLabel();
                if (currentSeconds <= pgbTimer.Maximum)
                {
                    pgbTimer.Value = currentSeconds; // 更新进度条
                }
            }
            else // 时间到
            {
                tmrMain.Stop();
                timerState = TimerState.Stopped;
                btnStartPause.Text = "开始"; // 立即更新提示文本，避免轮询

                if (currentMode == PomodoroMode.Work) // 一段工作时间结束
                {
                    MessageBox.Show("时间到，休息一下吧！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SwitchMode(breakMode);
                }
                else // 一段休息时间结束
                {
                    MessageBox.Show("时间到，准备工作吧！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SwitchMode(PomodoroMode.Work);
                }
            }
        }

        /// <summary>
        /// 开始/暂停/继续按钮
        /// 由定时器状态决定显示文本和标签内容
        /// </summary>
        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (timerState == TimerState.Running)
            {
                tmrMain.Stop();
                timerState = TimerState.Paused;
                btnStartPause.Text = "继续"; // 定时器等待继续
                lblStatus.Text = "已暂停";
            }
            else
            {
                tmrMain.Start();
                timerState = TimerState.Running;
                btnStartPause.Text = "暂停"; // 定时器等待暂停
                switch (currentMode)
                {
                    case PomodoroMode.Work:
                        lblStatus.Text = "专注中...";
                        break;
                    default:
                        lblStatus.Text = "休息中...";
                        break;
                }
            }
        }

        /// <summary>
        /// 计时中切换休息模式在计时结束后生效
        /// 计时结束后可自由更改休息模式，同步更新状态标签文本
        /// </summary>
        private void rbtnShortBreak_CheckedChanged(object sender, EventArgs e)
        {
            breakMode = PomodoroMode.ShortBreak;

            if (timerState == TimerState.Stopped && currentMode != PomodoroMode.Work)
            {
                SwitchMode(PomodoroMode.ShortBreak);
            }
        }

        /// <summary>
        /// 计时中切换休息模式在计时结束后生效
        /// 计时结束后可自由更改休息模式，同步更新状态标签文本
        /// </summary>
        private void rbtnLongBreak_CheckedChanged(object sender, EventArgs e)
        {
            breakMode = PomodoroMode.LongBreak;

            if (timerState == TimerState.Stopped && currentMode != PomodoroMode.Work)
            {
                SwitchMode(PomodoroMode.LongBreak);
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        #endregion

    }
}
