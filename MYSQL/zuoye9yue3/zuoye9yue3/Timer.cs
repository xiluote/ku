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
    //以下为显示时间的代码
    public partial class Timer : Form
    {
        //声明一个timer属性，用来储存定时器
        private System.Windows.Forms.Timer timer { get; set; }
        public Timer()
        {
            InitializeComponent();
            Dingshi();
            Huoqu();
        }

        //定时器方法
        private void Dingshi()
        {
            //实例化一个新的System.Windows.Forms.Timer对象，赋值给timer
            timer = new System.Windows.Forms.Timer();
            //决定时间间隔 为1000ms，也就是1秒
            timer.Interval = 1000;
            //执行的函数
            timer.Tick += (object sender, EventArgs e) => Huoqu();//添加一个匿名方法作为事件处理程序，Huoqu方法是获取当前时间的方法
            //开始执行
            timer.Start();
        }

        //获取当前事件方法
        private void Huoqu()
        {
            //定义一个变量sj储存当前时间
            DateTime sj = DateTime.Now;

            //分别定义变量以字符串的形式储存当前时间的秒数、分数、小时数
            var second = sj.Second.ToString();
            var minute = sj.Minute.ToString();
            var hour = sj.Hour.ToString();

            //拼接字符串，因为时间的显示是00：00：00 无论如何都是两位，所以用PadLeft方法从左补足两位，不够的位数用字符0补足
            string sjxx = hour.PadLeft(2, '0') + minute.PadLeft(2, '0') + second.PadLeft(2, '0');

            //让两张冒号图先适应控件大小，然后放进控件显示
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile(@"./images/maohao.png");

            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile(@"./images/maohao.png");

            //创建一个数组，存放显示数字图片的控件，3和6显示冒号，不用放进来
            var tuji = new PictureBox[]
            {
                pictureBox1, pictureBox2, pictureBox4, pictureBox5, pictureBox7,pictureBox8
            };

            //遍历将对应数字的图片放入控件中
            for (int i = 0; i < tuji.Length; i++)
            {
                tuji[i].SizeMode = PictureBoxSizeMode.StretchImage;

                tuji[i].Image = Image.FromFile(@"./images/" + sjxx[i] + ".png");

            }
        }

    }
}
