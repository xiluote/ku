using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lianxi8yue28ri
{
    //以下代码功能 练习 多控件用同一个函数处理事件
    public partial class duochuli : Form
    {
        public duochuli()
        {
            InitializeComponent();
            // 初始数据
            comboBox1.Items.AddRange(["按照价格排序", "按照数量排序"]);
            comboBox2.Items.AddRange(["按照价格排序", "按照数量排序"]);

            // 绑定事件
            comboBox1.SelectedIndexChanged += Change;
            comboBox2.SelectedIndexChanged += Change;
            //绑定焦点离开事件
            comboBox1.Leave += Change2;
            comboBox2.Leave += Change2;
        }
        private void Change(object sender, EventArgs e)
        {
            ComboBox cb = (sender as ComboBox);
            // 判断是哪个下拉框
            if (cb.Name == "comboBox1")
            {
                // 模拟排序
                if (cb.SelectedItem.ToString() == "按照价格排序")
                {
                    MessageBox.Show("按照价格升序排序");
                }
                else
                {
                    MessageBox.Show("按照数量升序排序");
                }
            }
            else
            {
                if (cb.SelectedItem.ToString() == "按照价格排序")
                {
                    MessageBox.Show("按照价格降序排序");
                }
                else
                {
                    MessageBox.Show("按照数量降序排序");
                }
            }
        }

        private void Change2(object sender, EventArgs e)
        {
            ComboBox cb = (sender as ComboBox);
            if(cb.Name =="comboBox1")
            {
                comboBox1.Text= "升序排序";
            }
            else if(cb.Name == "comboBox2")
            {
                comboBox2.Text = "降序排序";
            }
        }

    }
}
