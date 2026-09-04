using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zuoye9yue3
{
    //以下代码为显示距离国庆倒计时代码
    public partial class Guoqing : Form
    {
        private System.Windows.Forms.Timer timer { get; set; }

        public Guoqing()
        {
            InitializeComponent();
            Dingshi();
            Huoqu();   // 立即显示一次
        }

        private void Dingshi()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (object sender, EventArgs e) => Huoqu();
            timer.Start();
        }

        private void Huoqu()
        {
            //计算距离今年或明年国庆的剩余时间
            DateTime now = DateTime.Now;
            int year = now.Year;
            DateTime nationalDay = new DateTime(year, 10, 1, 0, 0, 0); // 今年国庆

            // 如果今年国庆已过，则计算明年国庆
            if (now > nationalDay)
                nationalDay = nationalDay.AddYears(1);

            TimeSpan remaining = nationalDay - now;

            //提取天、时、分、秒（Hours/Minutes/Seconds 是取余后的,整形不显示小数，控件有限）
            int days = remaining.Days;
            int hours = remaining.Hours;
            int minutes = remaining.Minutes;
            int seconds = remaining.Seconds;

            //格式化为字符串，补零
            string dayStr = days.ToString().PadLeft(3, '0');   // 365天，至少三位
            string hourStr = hours.ToString().PadLeft(2, '0');
            string minuteStr = minutes.ToString().PadLeft(2, '0');
            string secondStr = seconds.ToString().PadLeft(2, '0');

            //拼接所有数字
            string allDigits = dayStr + hourStr + minuteStr + secondStr;
            // allDigits 长度为 3+2+2+2 = 9

            //设置所有数字 PictureBox
            //原有的 pictureBox1~8 现在对应：时十位、时个位、分十位、分个位、秒十位、秒个位
            //新增的 pictureBox9~11 对应天百、天十、天个
            //pictureBox3 和 pictureBox6 是冒号

            //控件数组（按天到具体时间从左到右）
            var digitBoxes = new PictureBox[]
            {
                pictureBox9,pictureBox10,pictureBox11,
                pictureBox1,pictureBox2,pictureBox4,pictureBox5,pictureBox7,pictureBox8   
            };

            //遍历放入图片
            for (int i = 0; i < digitBoxes.Length; i++)
            {
                digitBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                digitBoxes[i].Image = Image.FromFile(@"./images/" + allDigits[i] + ".png");
            }

            //冒号图片
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile(@"./images/maohao.png"); 

            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile(@"./images/maohao.png"); 

            // ‘天’字图片
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.Image = Image.FromFile(@"./images/tian.png");
        }
    }
}
