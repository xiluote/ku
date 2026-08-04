namespace zuoye8yue4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //数据字典
            //Dictionary<键名的类型,键值的类型> 变量名 = new Dictionary<数据类型,数据类型> {初始值}
            Dictionary<string, dynamic> man = new Dictionary<string, dynamic>()
            {
                ["name"] = "小红",
                ["age"] = 20,
                ["gender"] = "女",
                ["friend"] = new Dictionary<string, dynamic>()//键值也可以是个字典
                {
                    ["name"] = "小张",
                    ["age"] = 22,
                    ["gender"] = "男",
                }
            };
            //访问
            //Console.WriteLine(man["age"]);//输出键名对应的键值
            //Console.WriteLine(man["age"].GetType());//输出键值的类型
            //Console.WriteLine(man["friend"]["name"]);//输出作为字典的键值里的键值

            // 了解: 通过方法获取 字典的键值 
            // 语法: 字典.TryGetValue(键名, out 类型 接受键值的变量)
            // 返回值: 布尔值
            //Console.WriteLine(man.TryGetValue("name", out dynamic a));//先通过这句查找键名，有就定义了a
            //Console.WriteLine(a);//然后输出a

            // 获取字典中的元素个数  字典.Count
            //Console.WriteLine(man.Count);
            //Console.WriteLine(man["friend"].Count);//字典中的字典元素个数

            // 可以修改键值，直接赋值新的就行
            //man["friend"]["name"] = "流流";
            //Console.WriteLine(man["friend"]["name"]);

            // 添加 (键名不存在就是添加)
            //man["height"] = 180;
            //Console.WriteLine(man["height"]);

            // 删除 
            //man.Remove("gender");
            //Console.WriteLine(man.TryGetValue("gender", out dynamic b));//已经删除了键名，也就无法定义b

            // 清空 .Clear()
            //man.Clear();
            //Console.WriteLine(man.TryGetValue("name", out dynamic v1));
            //Console.WriteLine(man.TryGetValue("age", out dynamic v2));//删除了所有，只会返回错误

        }
    }
}
