using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace zuoye9yue8
{
    public partial class WriteWord : Form
    {
        // 游戏控制
        private System.Windows.Forms.Timer shengtimer;   // 用于生成新字
        private System.Windows.Forms.Timer xiatimer;         // 用于下落
        private bool isPlaying = false;


        // 生成参数：间隔随机在 800~1500 毫秒
        private Random rand = new Random();
        public WriteWord()
        {
            InitializeComponent();
            //确保窗体可以获得焦点，对按下键盘按键时及时反馈
            this.KeyPreview = true;

            this.KeyPress += KeyPress1;
            button1.Click += Button1_Click;

            // 初始化定时器
            shengtimer = new System.Windows.Forms.Timer();
            shengtimer.Tick += Shengtimer_Tick;
            xiatimer = new System.Windows.Forms.Timer();
            xiatimer.Interval = 30;//字下落速度 ms为单位
            xiatimer.Tick += Xialuozi;
        }

        // 点击按钮：开始/重置游戏
        private void Button1_Click(object sender, EventArgs e)
        {
            StopGame();
            //清屏
            panel1.Controls.Clear();
            isPlaying = true;
            // 立即生成第一个字
            Shengzi();
            shengtimer.Interval = rand.Next(800, 1500);
            shengtimer.Start();
            xiatimer.Start();
        }

        // 生成定时器：定时产生一个新字
        private void Shengtimer_Tick(object sender, EventArgs e)
        {
            if (!isPlaying) return;
            
            Shengzi();
            // 每次生成后随机调整下次间隔（短间隔）
            shengtimer.Interval = rand.Next(800, 1500);
        }

        // 生成一个字
        private void Shengzi()
        {
            // 创建所有字字符串
            string AllWords = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            // 创建随机下标
            Random Rand = new Random();
            int index = Rand.Next(AllWords.Length);
            // 获取随机字符
            char Word = AllWords[index];

            Label lbl = new Label
            {
                Text = Word.ToString(),
                AutoSize = true,
                Font = new Font("微软雅黑", 16, FontStyle.Bold),
                BackColor = Color.Transparent,   // 透明背景，避免遮挡
                Location = new Point(
                    rand.Next(0, panel1.Width - 30), // 粗略保留宽度
                    0
                )
            };
            panel1.Controls.Add(lbl);
        }

        // 下落定时器：移动所有字，检测触底
        private void Xialuozi(object sender, EventArgs e)
        {
            if (!isPlaying) return;

            // 从后往前遍历，安全移除
            for (int i = panel1.Controls.Count - 1; i >= 0; i--)
            {
                if (panel1.Controls[i] is Label lbl)
                {
                    lbl.Top += 2;//下落的距离，像素为单位

                    // 触底检测（考虑高度）
                    if (lbl.Top + lbl.Height >= panel1.Height)
                    {
                        GameOver(false);
                        return;
                    }
                }
            }

        }

        // 键盘事件：消除匹配的字
        private void KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (!isPlaying) return;
            char key = e.KeyChar;
            if (!char.IsLetterOrDigit(key)) return;
            string target = char.ToUpper(key).ToString();

            // 查找第一个匹配的 Label 并移除
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Label lbl && lbl.Text == target)
                {
                    panel1.Controls.Remove(lbl);
                    lbl.Dispose();
                    break;
                }
            }
        }

        // 游戏结束处理
        private void GameOver(bool isWin)
        {
            StopGame();
            if (!isWin)
            {
                MessageBox.Show("字触底，游戏失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // 胜利时不弹窗，仅停止并清空（可根据需要增加成功提示）
            panel1.Controls.Clear();
        }

        // 停止所有定时器
        private void StopGame()
        {
            isPlaying = false;
            shengtimer.Stop();
            xiatimer.Stop();
        }

        
    }
}
