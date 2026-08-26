using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lianxi8yue26ri
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Bangding();
        }


        //绑定事件
        public void Bangding()
        {
            label1.MouseEnter += Monilianjie_true;//光标触摸文本控件事件
            label1.MouseLeave += Monilianjie_flase;//光标不触碰文本控件事件
            this.MouseMove += Mouse;//光标移动事件
        }


        public void Monilianjie_true(object sender,EventArgs e)
        {
            //触碰时字体色为橙色
            label1.ForeColor = Color.Orange;
            //文本的 字体、大小、样式（有下划线）、单位
            label1.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
        }


        public void Monilianjie_flase(object sender,EventArgs e)
        {
            //不触碰时字体色为蓝色
            label1.ForeColor = Color.Blue;
            //文本的 字体、大小、样式（无下划线）、单位
            label1.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
        }


        public void Mouse(object sender,EventArgs e)
        {
            MouseEventArgs wz = (MouseEventArgs)e;//光标位置转换参数时的专属写法
            label2.Text = $"x轴坐标的位置：{wz.X.ToString()}";//label2显示光标x轴位置文本
            label3.Text = $"y轴坐标的位置：{wz.Y.ToString()}";//label3显示光标y轴位置文本
        }
    }
}
