using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zuoye9yue2ri
{
    internal class Mysql
    {
        //定义MySql的连接属性，用来指向具体哪个库
        public string Server { get; set; } = "127.0.0.1";
        public string Port { get; set; } = "3306";
        public string Database { get; set; }
        public string Uid { get; set; } = "root";
        public string Password { get; set; } = "root";
        public string Charset { get; set; } = "utf8";

        // 连接数据库字符串
        private string ConnStr { get; set; }

        //写一个构造函数，用来接收别的代码发过来的窗体名
        public Mysql (string kuming)
        {
            this.Database = kuming;//把这个窗体名赋值给到唯一没有写上具体值的连接属性了
        }

        ////数据库的连接还有操作方法，别的代码访问数据库都靠这个了
        //public async void Sjkff(string sql,Action<MySqlCommand> cuanlaiff)//被当作参数传过来的数据库方法
        //{
        //    // 拼接 数据库连接字符串
        //    ConnStr = $"server={Server};port={Port};database={Database};uid={Uid};password={Password};charset={Charset}";
        //    // 连接数据库
        //    using (MySqlConnection Conn = new MySqlConnection(ConnStr))
        //    {
        //        // 打开连接
        //        await Conn.OpenAsync();
        //        // 创建命令对象
        //        using (MySqlCommand Cmd = new MySqlCommand(sql, Conn))
        //        {
        //            cuanlaiff(Cmd); // 执行后续操作
        //        }
        //    }
        //}

        //数据库的连接还有操作方法，别的代码访问数据库都靠这个了
        public async Task<bool> Sjkff(string sql, Func<MySqlCommand,bool> cuanlaiff)//被当作参数传过来的数据库方法
        {
            // 拼接 数据库连接字符串
            ConnStr = $"server={Server};port={Port};database={Database};uid={Uid};password={Password};charset={Charset}";
            // 连接数据库
            using (MySqlConnection Conn = new MySqlConnection(ConnStr))
            {
                // 打开连接
                await Conn.OpenAsync();
                // 创建命令对象
                using (MySqlCommand Cmd = new MySqlCommand(sql, Conn))
                {
                    return cuanlaiff(Cmd); // 执行后续操作
                }
            }
        }

    }
}
