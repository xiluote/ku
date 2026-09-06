using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace zuoye9yue2ri.Book
{
    public partial class Addbook : Form
    {
        private Mysql MySql = new Mysql("diyiku");
        private string Id { get; set; }
        private string Title { get; set; }

        public Addbook()
        {
            InitializeComponent();
        }

        // 重写构造方法(新增)
        public Addbook(string title)
        {
            InitializeComponent();
            //文本显示初始为空，这一步可以接收别的代码传来的文本，显示相应功能的标题和按钮文本
            label1.Text = "图书" + title;
            button1.Text = title;

            this.Title = title;
        }

        // 重写构造方法(编辑)
        public Addbook(string title, string id)
        {
            InitializeComponent();
            label1.Text = "图书" + title;
            button1.Text = title;

            this.Title = title;
            this.Id = id;

            // 查询数据并回显(回填到界面)
            Showbook();//这并不是指Showbook.cs那边的方法，而是指下面那个
        }


        //根据传过来的图书`Id`，去数据库查询这本图书信息，自动填充到页面各个输入框，打开编辑页面就自动显示原来旧的数据，方便用户修改
        private async void Showbook()
        {
            //定义文本，写上mysql查询语句
            string sql = "select * from book where id = @id";

            await MySql.Sjkff(sql, Cmd =>
            {
                // 参数填充
                Cmd.Parameters.AddWithValue("@id", Id);
                MySqlDataReader Reader = Cmd.ExecuteReader();

                //判断数据库里是否有这本书
                bool IsRead = Reader.Read();
                if (!IsRead)
                {
                    MessageBox.Show("编辑失败，该书不在书数据库中");
                    this.Close();
                    return false;
                }
                // Reader读到的数据 回填到窗体中
                input1.Text = Reader.GetString("name");
                input2.Text = Reader.GetString("author");
                // inputNumber控件的值 必须通过 Value设置  decimal 类型的值
                inputNumber1.Value = (decimal)Reader.GetDouble("price");
                //每个标签用 | 符号隔开
                input3.Text = Reader.GetString("label").Replace(" | ", "\n");

                return true;
            });
        }

        // 点击按钮实现 新增或编辑
        //代码没写完，直接运行Application.Run(new Book.Showbook());看效果时，记得把该段代码的
        //private async和await修改、去掉
        private async void button1_Click(object sender, EventArgs e)
        {
            // 获取用户打在文本框里的数据
            string name = input1.Text;
            string author = input2.Text;
            // inputNumber控件的值 必须通过 Value设置  decimal 类型的值
            double price = (double)inputNumber1.Value;
            string lable = input3.Text.Replace("\n", " | ");

            //还是定义一个文本，先不写，看要实现什么功能再赋值相对应的语句
            string sql = "";
            if (this.Title == "新增")
            {
                sql = "insert into book(name,author,price,label) value(@name,@author,@price,@label)";
            }
            else //if (this.Title == "编辑")
            {
                sql = "update  book set name=@name,author=@author,price=@price,label=@label where id=@id";

            }
            // 后面的操作是一样的
            await MySql.Sjkff(sql, Cmd =>
            {
                // 填充参数
                Cmd.Parameters.AddWithValue("@name", name);
                Cmd.Parameters.AddWithValue("@author", author);
                Cmd.Parameters.AddWithValue("@price", price);
                Cmd.Parameters.AddWithValue("@label", lable);
                if (this.Title == "编辑") Cmd.Parameters.AddWithValue("@id", Id);

                //ExecuteNonQuery的返回值是受影响的行数，大于0说明至少有数据变动，否则就是没有变化
                int rows = Cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show(this.Title + "成功");
                    this.Close();// 成功则关闭当前窗体
                }
                else
                {
                    //失败不关窗体，让用户重新使用
                    MessageBox.Show(this.Title + "失败");
                }

                return true;

            });
        }
    }
}
