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

    //该代码作用“焦点拦截：当上一个文本框无内容时，光标不能到另一个文本框中”
{
    public partial class lanjie : Form
    {
        public lanjie()
        {
            InitializeComponent();
            Bangding();
        }

        public void Bangding()
        {
            //判断光标离开
            kuang.Leave += Kuang_Leave;
            //判断文本框内容改变
            kuang.TextChanged += kuang_TextChanged;

            // kuang 是我给窗体中的文本输入框起的名
        }




        //             获取触发事件的控件（事件源），控件里可以获得的值
        //                                |                |
        public void kuang_TextChanged(object sender, EventArgs e)
        {
            //获取框的输入内容
            TextBox zh = (sender as TextBox);//先转换获取的实参数的格式
            string neirong = zh.Text;//再定义一个字符串接收文本
            if (!string.IsNullOrEmpty(neirong))
                label1.Visible = false;//放在输入框旁的label，当文本框里没有内容时，显示false提醒

        }

        //上面的方法判断文本框中有无内容后，下面的方法可以让光标离开
        public void Kuang_Leave(object sender, EventArgs e)
        {
            //一样获取框的输入内容
            TextBox zh = (sender as TextBox);//先转换获取的实参数的格式
            string neirong = zh.Text;//再定义一个字符串接收文本
            //一样判断内容是否为空
            if (string.IsNullOrEmpty(neirong))
            {
                zh.Focus();//让输入控件获取光标
                label1.Visible = true;
            }




        }




    }
}
