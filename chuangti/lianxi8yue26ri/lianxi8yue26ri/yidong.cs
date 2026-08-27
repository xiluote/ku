using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lianxi8yue26ri
{
    public partial class yidong : Form
    {
        public yidong()
        {
            InitializeComponent();
            this.KeyDown += Yidong;//按键按下时移动
            this.KeyUp += Jishi;//按键抬起时计时
        }

        private int speed = 15;//相当于是面板控件移动的速度，逻辑为按下一次键移动距离是15

        private DateTime StartTime { get; set; }// 获得按键按下的时间

        private int n = 0;//一个计数器，用来递增记录移动的次数

        private bool flag = true;// 定义一个开关属性
        private void Jishi(object sender, KeyEventArgs e)
        {
            // 打开开关
            flag = true;

            // 在键盘松开事件中 获取 结束时间 
            DateTime EndTime = DateTime.Now;
            // 并计算时差 展示在label中
            TimeSpan diff = EndTime - StartTime;
            // 转成秒
            labeltime.Text = $"移动时间：{diff.TotalSeconds.ToString()}秒";
            label2.Text = $"移动次数：{n.ToString()}";
        }

        private void Yidong(object sender, KeyEventArgs e)
        {
            if (flag)  // 开关打开才执行
            {
                n++;
                // 按键按下时间功能
                StartTime = DateTime.Now;
                // 关闭开关
                flag = false;
            }



            // 按键控制移动
            Point bl = mianban.Location;
            // 获取窗体的尺寸
            int formWidth = this.Width;
            int formHeight = this.Height;
            // 获取 移动控件的尺寸
            int mianbanWidth = mianban.Width;
            int mianbanHeight = mianban.Height;
            // 计算最大运动距离
            int xMax = formWidth - mianbanWidth;
            int yMax = formHeight - mianbanHeight;


            switch (e.KeyCode)
            {
                case Keys.Up:
                    bl.Y -= speed;
                    if (bl.Y <= 0) bl.Y = 0;
                    break;
                case Keys.Down:
                    bl.Y += speed;
                    if (bl.Y >= yMax) bl.Y = yMax;
                    break;
                case Keys.Left:
                    bl.X -= speed;
                    if (bl.X <= 0) bl.X = 0;
                    break;
                case Keys.Right:
                    bl.X += speed;
                    if (bl.X >= xMax) bl.X = xMax;
                    break;
                default:
                    break;
            }
            mianban.Location = bl;


            // 判断键盘按下的是否是ESC 是就退出窗体
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        


    }
}
