using MySqlConnector;
using System.Data;


namespace lianxi9yue1ri
{
    public partial class Form1 : Form
    {
        private string ConnStr = "server=127.0.0.1;port=3306;database=diyiku;uid=root;pwd=root;charset=utf8";
        //127.0.0.1代表本地计算机                                  库名在这位置

        public Form1()
        {
            InitializeComponent();
            Gengxin();
        }

        private void Gengxin()
        {
            //建一个数据库连接，使用using可以自动关闭连接，否则还需要手动关闭
            using (MySqlConnection Lianjie = new MySqlConnection(ConnStr))
            {
                //打开连接
                Lianjie.Open();

                string cx = "select * from students";//定义一个字符串，内容为mysql里的查询语句
                //这里的students是我在数据库中的表名

                //定义命令对象
                using (MySqlCommand cmd = new MySqlCommand(cx, Lianjie))
                {
                    //建个适配器
                    MySqlDataAdapter shipei = new MySqlDataAdapter(cmd);
                    //建个内存表
                    DataTable ncbiao = new DataTable();
                    //数据填充
                    shipei.Fill(ncbiao);
                    //使用数据
                    dataGridView1.DataSource = ncbiao;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //得到文本框里的内容
            string shuru = textBox1.Text;

            using (MySqlConnection Cxm = new MySqlConnection(ConnStr))
            {
                Cxm.Open();//打开

                //通过表中的键名“name”实现通过学生姓名查询信息的功能
                //固定语句                  表名           键名          占位符 @键名 占位符
                string sql = "select * from students where name like CONCAT('%',@name,'%')";

                //命令对象
                using (MySqlCommand cmd = new MySqlCommand(sql, Cxm))
                {
                    //把文本框接收到的内容填充
                    cmd.Parameters.AddWithValue("@name", shuru);

                    //建个适配器
                    MySqlDataAdapter shipei = new MySqlDataAdapter(cmd);
                    //建个内存表
                    DataTable ncbiao = new DataTable();
                    //数据填充
                    shipei.Fill(ncbiao);
                    //使用数据
                    dataGridView1.DataSource = ncbiao;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = tname.Text;
            string gender = tgender.Text;
            string age = tage.Text;
            string high = thigh.Text;
            string banji = tbanji.Text;


            using (MySqlConnection Jxs = new MySqlConnection(ConnStr))
            {
                Jxs.Open();//打开


                string sql =
     "insert into students(name, gender, age, high, class_name) values(@name, @gender, @age, @high, @class)";

                //命令对象
                using (MySqlCommand cmd = new MySqlCommand(sql, Jxs))
                {
                    //新生信息的参数
                    //cmd.Parameters.AddWithValue("@name", "孙悟空");
                    //cmd.Parameters.AddWithValue("@gender", "男");
                    //cmd.Parameters.AddWithValue("@age", 500);
                    //cmd.Parameters.AddWithValue("@high", 176);
                    //cmd.Parameters.AddWithValue("@class", "高一3班");

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@high", high);
                    cmd.Parameters.AddWithValue("@class", banji);

                    // 命令对象.ExecuteNonQuery()  执行非查询语句
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("添加成功");
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Tongji = new MySqlConnection(ConnStr))
            {
                Tongji.Open();

                //sql语句
                string sql = "select count(*) from students";

                //命令对象
                using (MySqlCommand zrs = new MySqlCommand(sql, Tongji))
                {
                    // 用 ExecuteScalar:获取聚合查询结果
                    object result = zrs.ExecuteScalar();
                    label1.Text = "总人数: " + result.ToString();
                }

                
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Gengxin();
        }
    }
}
