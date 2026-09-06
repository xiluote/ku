using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zuoye9yue2ri.Book
{
    public partial class Showbook : Form
    {
        //使用在Mysql定义的方法，把库名发过去
        private Mysql Mysql { get; set; } = new Mysql("diyiku");
        public Showbook()
        {
            InitializeComponent();
            Showshu();//调用展示图书目录的方法
        }

        //展示图书方法
        private async void Showshu()
        {
            await Mysql.Sjkff("select * from book", Cmd =>
            {
                //建适配器
                MySqlDataAdapter shipei = new MySqlDataAdapter(Cmd);
                //建内存表
                DataTable ncb = new DataTable();
                //注入数据
                shipei.Fill(ncb);
                //使用数据,把被注入内存表的数据，当作控件table1的数据源
                table1.DataSource = ncb;

                return true;
            });
        }

        //设置显示数据的表的内容格式的方法
        private void Biaogeshi()
        {
            table1.Columns.Clear();//先清除掉table1本来的内容
            //将本来应该直接显示的数据库的内容替换
            table1.Columns = new AntdUI.ColumnCollection()
            {
                new AntdUI.Column("id","编号")
                {
                    Render =(object val,object cel ,int xuhao)=> xuhao+1
                },
                new AntdUI.Column("name","书名"),
                new AntdUI.Column("author","作者"),
                new AntdUI.Column("price","价格"),
                new AntdUI.Column("label","类型"),
                new AntdUI.Column("is_borrow","借阅状态")
                {
                    Render =(object val,object cel ,int zt)=> val.ToString()=="1"?"已借出":"在书架"
                }

            };
        }

        //新增按钮绑定的事件
        private void button1_Click(object sender, EventArgs e)
        {
            // 把文本“新增”传去Addbook.cs让它显示新增图书的页面
            Addbook BA = new Addbook("新增");
            BA.Show();//展开新窗体
            this.Hide();//隐藏当前窗体
            BA.FormClosing += BA_FormClosing;//绑定刷新事件
        }

        private void BA_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            Showshu();
        }


    }
}
