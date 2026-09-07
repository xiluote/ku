using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace zuoye9yue7
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer; // 明确使用 WinForms Timer

        public Form1()
        {
            InitializeComponent();

            //开启双缓冲，消除闪烁
            this.SetStyle(ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            // 绑定画图方法
            this.Paint += Form1_Paint;

            // 初始化定时器
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;//间隔1秒
            timer.Tick += Timer_Tick;//绑定执行函数
            timer.Start();//开始执行
        }

        // 每秒触发：更新时间并重绘
        private void Timer_Tick(object? sender, EventArgs e)
        {
            this.Invalidate(); // 触发 Paint 事件
        }

        // 画图方法
        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            // 获取画图对象
            Graphics g = e.Graphics;
            // 配置抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 获取当前时间
            DateTime now = DateTime.Now;
            int hour = now.Hour % 12;      // 例如17点除以12余5，会指向5，早上2点除以12等于0余2，指向2
            int minute = now.Minute;
            int second = now.Second;

            // 计算表盘中心坐标和半径
            int cx = this.ClientSize.Width / 2;//获取工作区宽的一半
            int cy = this.ClientSize.Height / 2;//获取工作区高的一半
            //取更小的一边的数值作为半径画图，确保一定能显示，减去30让图不要接触边缘
            int r = Math.Min(this.ClientSize.Width, this.ClientSize.Height) / 2 - 30;
            if (r < 20) r = 20; // 防止太小

            // 画个空心圆
            using (Pen kongPen = new Pen(Color.Black, 2))
            {
                //椭圆，宽高相等就是圆
                g.DrawEllipse(kongPen, cx - r, cy - r, r * 2, r * 2);
            }
            //画个实心圆
            using (Brush shiBrush = new SolidBrush(Color.White))
            {
                // x,y：圆外接矩形左上角； 宽=高=半径乘2
                g.FillEllipse(shiBrush, cx - r, cy - r, r * 2, r * 2);
            }

            // 画小时刻度（长）和分钟刻度（短）
            for (int i = 0; i < 60; i++)
            {
                double jiao = i * 6.0; // 每分钟6度
                double hu = jiao * Math.PI / 180.0;

                // 刻度长度判断
                float qi = (i % 5 == 0) ? r * 0.85f : r * 0.90f;//大刻度线起点更近
                float zhong = r * 0.95f;//终点一致

                //计算每个刻度线的起点和终点坐标
                int x1 = cx + (int)(qi * Math.Cos(hu - Math.PI / 2)); 
                int y1 = cy + (int)(qi * Math.Sin(hu - Math.PI / 2));
                int x2 = cx + (int)(zhong * Math.Cos(hu - Math.PI / 2));
                int y2 = cy + (int)(zhong * Math.Sin(hu - Math.PI / 2));

                //除以5为0判断大刻度线画更粗
                using (Pen tickPen = new Pen(Color.Black, (i % 5 == 0) ? 3 : 1))
                {
                    g.DrawLine(tickPen, x1, y1, x2, y2);
                }
            }

            // 画数字1~12
            //定义字体和字大小
            Font numFont = new Font("微软雅黑", r / 10);
            //文字对齐方式
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            for (int i = 1; i <= 12; i++)
            {
                //每个数字对应的角度
                double jiao = i * 30.0; // 每小时30度
                //对应的弧度
                double hu = jiao * Math.PI / 180.0;
                // 数字放在距中心约半径的0.78倍处
                float shuweizhi = r * 0.78f;
                int x = cx + (int)(shuweizhi * Math.Cos(hu - Math.PI / 2));
                int y = cy + (int)(shuweizhi * Math.Sin(hu - Math.PI / 2));
                using (Brush shuBrush = new SolidBrush(Color.Black))
                {
                    g.DrawString(i.ToString(), numFont, shuBrush, x, y, sf);
                }
            }

        }

        
    }
}