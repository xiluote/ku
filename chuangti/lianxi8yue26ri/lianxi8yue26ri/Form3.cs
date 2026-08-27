using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            this.KeyPreview = true;//让窗体得到按键信息，防止有其它抢占光标的控件时，esc关闭窗体的方法失效
        }


        //绑定事件
        public void Bangding()
        {
            label1.MouseEnter += Monilianjie_true;//光标触摸文本控件事件
            label1.MouseLeave += Monilianjie_flase;//光标不触碰文本控件事件
            this.MouseMove += Mouse;//光标移动事件
            this.KeyDown += KeyTest_KeyDown;// 按下esc退出
            textBox1.GotFocus += Yinchang;//文本框获得焦点时隐藏提示信息
            textBox1.Leave += Panduan;//文本框失去焦点时判断文本内容
            textBox2.GotFocus += Gaoliang;//文本框获得焦点时高亮
            textBox2.Leave += Buliang;//文本框获得焦点时高亮
            xiala.GotFocus += Lakai;//下拉框获得焦点时自动展开
            xiala.Leave += Guanbi;//下拉框获得焦点时自动展开
            textBox1.KeyUp += Tijiao;//按下键并抬起时提交
            textBox1.KeyDown += Zuhe;//组合键 
            textBox1.KeyPress += Lanjie;//拦截输入，限制只能输入什么
        }

        //拦截数字以外的内容
        private void Lanjie(object sender, KeyPressEventArgs e)//注意键入相关的是KeyPressEventArgs
        {
            if (e.KeyChar == '\b') return;//如果已经输入的内容都是数字，就不拦截，这样可以让删除键生效
            //如果要输入数字以外的，就拦截，下面这段必须在上一句的后面，不然会拦截删除键
            if (Regex.IsMatch(e.KeyChar.ToString(), @"\D"))
            {
                e.Handled = true;
            }

        }



        //组合按键，例：ctrl键加c键或v键
        private void Zuhe(object sender, KeyEventArgs e)//注意键相关的是KeyEventArgs
        {
            if (e.KeyCode == Keys.C && e.Control)
            {
                MessageBox.Show("按下了ctrl+c");
            }
            else if (e.KeyCode == Keys.V && e.Control)
            {
                MessageBox.Show("按下了ctrl+v");
            }
        }


        //获取到的按键内容为回车键时，报出弹窗
        private void Tijiao(object sender,KeyEventArgs e)//注意键相关的是KeyEventArgs
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("这个弹窗模拟提交");
            }

        }


        //展开
        private void Lakai(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = true;

        }

        //关闭
        private void Guanbi(object sender, EventArgs e)
        {
            (sender as ComboBox).DroppedDown = false;

        }


        //失去焦点时文本框不亮（相当于重置状态）
        private void Buliang(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
            (sender as TextBox).ForeColor = Color.Black;
            (sender as TextBox).BorderStyle = BorderStyle.None;

        }



        //获得焦点时文本框高亮
        private void Gaoliang (object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Orange;
            (sender as TextBox).ForeColor = Color.Blue;
            (sender as TextBox).BorderStyle = BorderStyle.FixedSingle;

        }


        //获取焦点时，隐藏提示信息，没有这个方法，提示信息出现后就不会消失了
        private void Yinchang(object sender, EventArgs e)
        {
            tongguo.Visible = false;
            butong.Visible = false;
        }


        //失去焦点时才判断文本框中的内容格式，不然还没打完就先显示错误提示
        private void Panduan(object sender,EventArgs e)
        {
            string nr = (sender as TextBox).Text;
            if (Regex.IsMatch(nr, @"1[345789]\d{9}"))
            {
                tongguo.Visible = true;
            }
            else
            {
                butong.Visible = true;
            }

        }



        //esc按下后退出窗体
        private void KeyTest_KeyDown(object sender, KeyEventArgs e)
        {
            // e.KeyCode 是否是 Escape
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // 关闭窗体
            }

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
