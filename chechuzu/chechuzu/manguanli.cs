using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace chechuzu
{
    internal class manguanli
    {
        //定义文件路径
        public string lujing = "./user.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };


        //录入新用户信息的方法
        public string Adduesr(string name, string mancard, string gender,string shouji)
        {
            //正则验证输入内容
            string res = @"^\d{17}[0-9X]$";
            string res2 = @"^[1]\d{10}$";
            bool dui = Regex.IsMatch(mancard, res);
            if (!dui) return "身份证号格式有误";
            bool dui2 = Regex.IsMatch(shouji, res2);
            if (!dui2) return "手机号格式有误";

                // 定义一个空的 list 
                List<Man> man = new();//Man是我自己定义的类型
            // 判断存储文件是否存在 ==> 存在 -----》读取文件内容，并反序列化并将得到的数据列表赋值给list
            if (File.Exists(lujing))
            {
                man = JsonSerializer.Deserialize<List<Man>>(File.ReadAllText(this.lujing));//反序列化方法名.类型.全部文本（这个路径）
                //判断身份证号是否已经有了
                if (man.Exists(item => item.card == mancard)) return "该用户已经被录入过";
            }
            // 将接受的数据组装成Car实例对象，然后添加到list中 ---> 序列化list---》写入json文件
            Man adc = new Man(man.Count + 1, name, mancard, gender, shouji);

            // 写入json文件
            man.Add(adc);
            File.WriteAllText(this.lujing, JsonSerializer.Serialize(man, this.JsonOpt));//序列化

            return "录入用户信息成功";
        }



        //查看所有用户
        public void Alluser()
        {
            //判断路径下是否存在用户信息，没有就提示先创建文件
            if (!File.Exists(lujing))
            {
                Console.WriteLine("没有用户信息，请先录入至少一位用户");
                return;
            }
            // 判断文件是否存在===存在，读取文件，反序列化 ===遍历输出
            string jsonStr = File.ReadAllText(this.lujing);
            List<Man> user = JsonSerializer.Deserialize<List<Man>>(jsonStr);
            Console.WriteLine("所有用户的信息如下");
            foreach (Man item in user)
            {
                //string statusStr = item.Status ? "空闲" : "已出租";
                Console.WriteLine($"id : {item.id} -- 姓名 : {item.name} -- 身份证号 : {item.card} -- 性别 : {item.gender} -- 手机号 : {item.shouji}");
            }
        }


        //显示具体某用户信息的方法
        public void One(int n)//int n为形参，接收的参数类型只能是整形
        {
            //判断路径下是否存在用户信息，没有就提示先创建文件
            if (!File.Exists(lujing))
            {
                Console.WriteLine("没有此用户id，请先录入");
                return;
            }
            // 判断文件是否存在===存在，读取文件，反序列化 ,输出
            string jsonStr = File.ReadAllText(this.lujing);
            List<Man> user = JsonSerializer.Deserialize<List<Man>>(jsonStr);
            //  找到了===>将查找到的列表返回
            Man fanhui = user.Find(item => item.id == n);
            if (fanhui == null)
            {
                Console.WriteLine("没有找到该用户的信息，请检查输入是否正确");
                return;
            }
            else
                Console.WriteLine("该用户信息如下");
            {
                //string statusStr = fanhui.Status ? "空闲" : "已出租";
                Console.WriteLine($"id : {fanhui.id} -- 姓名 : {fanhui.name} -- 身份证号 : {fanhui.card} -- 性别 : {fanhui.gender} -- 手机号 : {fanhui.shouji}");
            }
        }

    }
}
