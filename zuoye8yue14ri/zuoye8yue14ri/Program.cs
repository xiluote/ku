using System.Text.Json;
using System.Text.RegularExpressions;

namespace zuoye8yue14ri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业:  使用读写文件配合命令行窗口  模拟实现注册功能
            //要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中, 一行一个用户信息 数据之间通过 === 分隔)

            Console.WriteLine("请选择操作：1.注册 2.登录 0.退出");
            int cd = int.Parse(Console.ReadLine());
            if (cd == 1 || cd == 2)
            {

                Console.WriteLine("请输入账号：");
                string zh = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                string mm = Console.ReadLine();

                if (cd == 1)
                {
                    Func<string, string, string> zhuce = (zh2, mm2) =>
                    {
                        string arr = $"账号：{zh2}，密码：{mm2}";//其实直接写zh和mm也可以接收到委托外的信息，不过现在练习委托用法
                        return arr;
                    };

                    string jsfh = zhuce(zh, mm);
                    Console.WriteLine($"注册成功 {jsfh}");
                    var path1 = @".\user.txt";
                    File.AppendAllText(path1, $"{jsfh}\r\n");// \r\n的效果是换行
                    File.AppendAllText(path1, "================================================================");// \r\n的效果是换行
                }
                else
                {
                    string text = File.ReadAllText("user.txt");
                    string chazhao = @$"{zh}";
                    string chazhao2 = @$"{zh}，密码：{mm}";
                    bool res = Regex.IsMatch(text, chazhao);
                    bool res2 = Regex.IsMatch(text, chazhao2);
                    if (res == false) Console.WriteLine("账号不存在");
                    else if (res2 == false) Console.WriteLine("密码错误");
                    else Console.WriteLine("登陆成功");

                }
            }
            else
            {
                return;
            }


            /*老师写的*************************************************************************/
            // 定义变量
            string num = "3"; // 输入的指令
            string userReg = @"^[a-zA-Z][a-zA-Z0-9]{3,14}$";
            string pwdReg = @"^\S{4,12}$";
            string path = "./user.json";
            var JsonOpt = new JsonSerializerOptions
            {
                WriteIndented = true,
                AllowTrailingCommas = true,
            };
            string[] optArr = ["退出", "注册", "登录", "输入执行有误"];


            // 定义的函数
            // 用户注册函数
            Func<string, string, string> register = (userName, pwd) =>
            {
                // 正则校验用户名和密码
                if (!Regex.IsMatch(userName, userReg) || !Regex.IsMatch(pwd, pwdReg)) return "用户名或密码格式错误!";

                List<Dictionary<string, dynamic>> userList = new();
                //组装用户信息字典
                Dictionary<string, dynamic> userDic = new Dictionary<string, dynamic>()
                {
                    ["username"] = userName,
                    ["password"] = pwd,
                    ["dateTime"] = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
                };

                // 判断文件是否存在
                if (File.Exists(path))
                {
                    // 判断文件是否存在====>存在读取文件内容
                    //  反序列化转为List列表 ===> 组装用户信息字典
                    //  判断用户名是否已经注册===>如果注册过则返回信息
                    //  未注册===>将用户字典添加到List列表中
                    //  序列化List列表  =====> 写会回(覆盖)
                    var jsonStr = File.ReadAllText(path);
                    userList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonStr);
                    // 判断用户名是否已经注册
                    bool isRegister = userList.Exists(item => item["username"].ToString() == userName); // **
                    if (isRegister) return "用户已经存在!!!";


                }
                // 添加到list
                userList.Add(userDic);
                var newJsonStr = JsonSerializer.Serialize(userList, JsonOpt);
                // 写入文件
                File.WriteAllText(path, newJsonStr);

                return "注册成功";
            };

            // 用户登录函数
            Func<string, string, string> login = (userName, pwd) => {
                // 正则校验用户名和密码
                // 正则校验用户名和密码
                if (!Regex.IsMatch(userName, userReg) || !Regex.IsMatch(pwd, pwdReg)) return "用户名或密码格式错误!";

                // 判断文件是否存在===>不存在, 请先注册
                // 判断文件是否存在
                if (!File.Exists(path)) return "请先注册!!!";
                //  读文件 ====> 反序列化 list
                var jsonStr = File.ReadAllText(path);
                var userList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(jsonStr);
                // 使用输入的用户名 去list中查找(用户名和密码查找)
                var resUser = userList.Find(item => item["username"].ToString() == userName && item["password"].ToString() == pwd);
                // 找不到====>用户名或密码错误
                if (resUser == null) return "用户名或密码错误";
                // 密码一致===>登录成功
                return "登录成功";
            };

            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("=====欢迎来到用户管理=====");
                Console.WriteLine("1: 用户注册");
                Console.WriteLine("2: 用户登录");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();

                string username = "youke";
                string result = "";

                switch (num)
                {
                    case "1":
                        Console.WriteLine("--用户注册--");
                        Console.WriteLine("请输入用户名(4~15)");
                        username = Console.ReadLine();
                        Console.WriteLine("请输入密码(4~12)");
                        var password = Console.ReadLine();
                        result = register(username, password);
                        Console.WriteLine(result);
                        break;
                    case "2":
                        Console.WriteLine("--用户登录--");
                        Console.WriteLine("请输入用户名(4~15)");
                        username = Console.ReadLine();
                        Console.WriteLine("请输入密码(4~12)");
                        var loginPpassword = Console.ReadLine();
                        result = login(username, loginPpassword);
                        Console.WriteLine(result);
                        break;
                    case "0":
                        Console.WriteLine("--退出--");
                        break;
                    default:
                        num = "3";
                        Console.WriteLine("输入有误");
                        break;
                }


                // 写日志: 用户名 操作类型 时间 操作结果

                string optStr = $"{username}---{optArr[int.Parse(num)]}---{DateTime.Now}---{result}\n";
                File.AppendAllText("./user.log", optStr);

                //// 读取日志文件
                //var res = File.ReadAllText("./user.log");
                //Console.WriteLine("+++++++++++++++");
                //Console.WriteLine(res);
                //Console.WriteLine("+++++++++++++++");
            }


        }
    }
}
