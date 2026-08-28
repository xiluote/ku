using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lianxi8yue28ri
{
    //以下代码功能为练习 二级联动
    public partial class erji : Form
    {
        //定义要放进两个下拉框的信息
        private List<Dictionary<string, dynamic>> xinxi{ get; set; }
        public erji()
        {
            InitializeComponent();
            xinxi = new List<Dictionary<string, dynamic>>()
            {
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 1,
                    ["name"] = "广东省",
                    ["congshu"] = 0
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 2,
                    ["name"] = "深圳市",
                    ["congshu"] = 1
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 3,
                    ["name"] = "潮汕市",
                    ["congshu"] = 1
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 4,
                    ["name"] = "广西省",
                    ["congshu"] = 0
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 5,
                    ["name"] = "桂林市",
                    ["congshu"] = 4
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 6,
                    ["name"] = "南宁市",
                    ["congshu"] = 4
                }
            };

            //再定义一个新的列表装进筛选后的信息
            List<Dictionary<string,dynamic>> shai = xinxi.FindAll(item =>  item["congshu"] == 0);
            //定义一个函数装载筛选后的信息的其中的名字
            var shengname = shai.Select(item =>item["name"]);
            //清空下拉框1
            comboBox1.Items.Clear();
            //转换shengname的信息格式，然后加进下拉框1中
            comboBox1.Items.AddRange(shengname.ToArray());
            //给下拉框1绑定事件
            comboBox1.SelectedIndexChanged += change;



        }
        private void change(object a, EventArgs b)
        {
            // 找到当前选中项的内容
            string nr = comboBox1.SelectedItem.ToString();
            // 从xinxi中获取到这个省份的id
            Dictionary<string, dynamic> zhaoid = xinxi.Find(item => item["name"] == nr);
            // 根据省份id 筛选出所有从属的城市，城市的congshu项等于省份的id项
            List<Dictionary<string, dynamic>> city = xinxi.FindAll(item => item["congshu"] == zhaoid["id"]);
            var chengname = city.Select(item => item["name"]);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(chengname.ToArray());
            comboBox2.Text = "此处选择城市";
            comboBox2.DroppedDown = true;//选择省份后，城市的下拉框自动展开
        }

        
    }
}
