using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() // 构造函数
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; // 禁止缩放
            MaximizeBox = false; // 禁止最大化            
        }

        private const int TIME_WORK = 25 * 60; // 工作时间25分钟
        private const int TIME_SHORT_BREAK = 5 * 60; // 短休息时间5分钟
        private const int TIME_LONG_BREAK = 15 * 60; // 长休息时间15分钟

        private enum PomodoroMode
        {
            Work,
            ShortBreak,
            LongBreak
        }

        private PomodoroMode currentMode = PomodoroMode.Work;
        private PomodoroMode breakMode; // 由单选框决定

        private int totalSeconds = TIME_WORK; // 默认工作时间25分钟，允许修改
        private int currentSeconds; // 剩余时间
        private enum TimerState
        {
            Stopped,
            Running,
            Paused
        }

        private TimerState timerState = TimerState.Stopped;

        // 窗口加载完成后的准备工作
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTimer();
            lblStatus.Text = "准备工作";
            rbtnShortBreak.Checked = true; // 默认短休息
        }

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

        // 刷新时间标签
        private void RefreshLabel()
        {
            lblTime.Text = string.Format("{0:D2}:{1:D2}", currentSeconds / 60, currentSeconds % 60);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (timerState == TimerState.Stopped)
            {
                return; // 已停止状态下点击重置无效
            }

            SwitchMode(currentMode); // 重置模式，刷新标签内容
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (currentSeconds > 0)
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
                btnStartPause.Text = "开始";

                if (currentMode == PomodoroMode.Work)
                {
                    MessageBox.Show("时间到，休息一下吧！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SwitchMode(breakMode);
                }
                else
                {
                    MessageBox.Show("时间到，准备工作吧！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SwitchMode(PomodoroMode.Work);
                }
            }
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (timerState == TimerState.Running)
            {
                tmrMain.Stop();
                timerState = TimerState.Paused;
                btnStartPause.Text = "继续";
                lblStatus.Text = "已暂停";
            }
            else
            {
                tmrMain.Start();
                timerState = TimerState.Running;
                btnStartPause.Text = "暂停";
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

        private void rbtnShortBreak_CheckedChanged(object sender, EventArgs e)
        {
            breakMode = PomodoroMode.ShortBreak;

            if (timerState == TimerState.Stopped && currentMode != PomodoroMode.Work)
            {
                SwitchMode(PomodoroMode.ShortBreak);
            }
        }

        private void rbtnLongBreak_CheckedChanged(object sender, EventArgs e)
        {
            breakMode = PomodoroMode.LongBreak;

            if (timerState == TimerState.Stopped && currentMode != PomodoroMode.Work)
            {
                SwitchMode(PomodoroMode.LongBreak);
            }
        }
    }
}

