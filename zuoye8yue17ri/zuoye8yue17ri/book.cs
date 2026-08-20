using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace zuoye8yue17ri
{
    internal class book
    {
        //属性
        //数据文件路径
        public string path {  get;  }

        //json序列化配置项
        public JsonSerializerOptions JsonOpts { get; }

        //新增数据：强制要求 ==>将list写入文件中
        public string AddBook(Dictionary<string,dynamic>bookDic)
        {
            // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)
            // 新增的逻辑处理
            // 判断path路径是存在===> 不存在, 组装书籍list,序列化后 写入文件
            // 如果存在 =====> 先读取文件内容
            // 反序列化为list ====> 添加bookDic到list中
            // 序列化list ====> 写入文件
            List<Dictionary<string,dynamic>> bookList = new ();
            if (File.Exists(path))
            {
                // 读取文件===>反序列化
                var json = File.ReadAllText(path);
                // 反序列化
                bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
                bool resbool = bookList.Exists(item => item["name"].ToString() == bookDic["name"]);
                if (resbool) return "该书籍已存在";
            }

            bookList.Add(bookDic);
            //序列化
            string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
            // 写入文件
            File.WriteAllText(path, jsonStr);

            return "新增数据成功!!!";
        }

        // 编辑数据
         public string EditBook(string bookName)
        {
            //定义一个list
            List<Dictionary<string, dynamic>> editbook = new();
            //判断文件是否存在===>不存在，返回空list
            if (!File.Exists(path)) return "没有书籍可编辑";
            //存在===>读取文件===>反序列化
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            //查找要编辑的书籍
            Dictionary<string, dynamic> bookToEdit = list.Find(item => item["name"].ToString() == bookName);
            if (bookToEdit == null) return "未找到该书籍";

            //输入新信息
            Console.WriteLine("请输入新的书名（直接回车保留原值）：");
            string newName = Console.ReadLine();
            Console.WriteLine("请输入新的作者（直接回车保留原值）：");
            string newAuthor = Console.ReadLine();
            Console.WriteLine("请输入新的标签（直接回车保留原值）：");
            string newMark = Console.ReadLine();
            Console.WriteLine("请输入新的价格（直接回车保留原值）：");
            string newPrice = Console.ReadLine();

            //更新数据,IsNullOrEmpty判断是否为空的方法
            if (!string.IsNullOrEmpty(newName)) bookToEdit["name"] = newName;
            if (!string.IsNullOrEmpty(newAuthor)) bookToEdit["author"] = newAuthor;
            if (!string.IsNullOrEmpty(newMark)) bookToEdit["mark"] = newMark;
            if (!string.IsNullOrEmpty(newPrice)) bookToEdit["price"] = double.Parse(newPrice);

            //保存
            string jsonStr = JsonSerializer.Serialize(list, JsonOpts);
            File.WriteAllText(path, jsonStr);

            return "编辑成功！！！";
        }

        // 删除数据
        public string RemoveBook(string bookName)
        {
            // 判断图书是否已存在===>根据图书名判断(一个书名只有一本)
            // 删除的逻辑处理
            // 判断path路径是存在===> 不存在, 返回空字典
            List<Dictionary<string, dynamic>> bookList = new();
            if (!File.Exists(path))
            {
                return "文件不存在，没有图书数据";
            }
            //读取反序列化
            var json = File.ReadAllText(path);
            bookList = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            //查找是否存在这本书
            bool cunzai = bookList.Exists(item => item["name"].ToString() == bookName);
            if (!cunzai)               return "要删除的书籍不存在";
            // 删除匹配书名的元素
            bookList.RemoveAll(item => item["name"].ToString() == bookName);
            // 写回文件
            //string jsonStr = JsonSerializer.Serialize(bookList, JsonOpts);
            //File.WriteAllText(path, jsonStr);
            File.WriteAllText(path, JsonSerializer.Serialize(bookList, JsonOpts));//两句合到一起

            return "删除图书成功!!!";
        }


        // 查询所有数据
        public List<Dictionary<string,dynamic>> SearchBook() // 返回值根据情况修改
        {
            // 查询所有的逻辑处理
            // 定义一个list
            List<Dictionary<string, dynamic>> list = new();
            // 判断文件是否存在====>不存在，返回空list
            if (!File.Exists(path)) return list;
            // 存在===> 读取文件====>反序列化===>将list返回
            var json = File.ReadAllText(path);
            list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            return list;

        }
        // 根据图书名称查询当前图书数据：强制要求
        public Dictionary<string,dynamic> SearchBook(string bookName) // 返回值根据情况修改
        {
            // 查询单个图书的逻辑处理
            // 定义一个图书字典
            Dictionary<string, dynamic> danben = new();
            // 判断文件是否存在====>不存在，返回空字典
            if (!File.Exists(path))return danben;
            // 存在===> 读取文件====>反序列化===>根据名称查找====>找不到 ===> 返回空字典
            var json2 = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json2);
            Dictionary<string, dynamic> fanhui = list.Find(item => item["name"].ToString() == bookName);
            //  找到了===>将查找到的字典返回
            if (fanhui == null) return danben;
            return fanhui;
        }



        // 根据图书名称借阅图书，并记录数据
        public string jieBook(string bookName)
        {
            if (!File.Exists(path))
                return "没有图书数据";
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            Dictionary<string, dynamic> zhuangtai = list.Find(item => item["name"].ToString() == bookName);
            if (zhuangtai == null)
                return "找不到该书籍";

            // 取出JsonElement，获取真正布尔值
            JsonElement ele = (JsonElement)zhuangtai["isBorrow"];
            bool isBor = ele.GetBoolean();

            if (isBor)
            {
                return "该书已经被借出，无法再次借阅";
            }
            zhuangtai["isBorrow"] = true;
            File.WriteAllText(path, JsonSerializer.Serialize(list, JsonOpts));
            return "借阅成功！";
        }


        // 根据图书名称归还图书，并记录数据
        public string huanBook(string bookName)
        {
            if (!File.Exists(path))
                return "没有图书数据";
            var json = File.ReadAllText(path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(json);
            Dictionary<string, dynamic> zhuangtai = list.Find(item => item["name"].ToString() == bookName);
            if (zhuangtai == null)
                return "找不到该书籍";

            JsonElement ele = (JsonElement)zhuangtai["isBorrow"];
            bool isBor = ele.GetBoolean();

            if (!isBor)
            {
                return "该书并未借出，无需归还";
            }
            zhuangtai["isBorrow"] = false;
            File.WriteAllText(path, JsonSerializer.Serialize(list, JsonOpts));
            return "还书成功！";
        }



        // 自定义实例构造函数
        public book(string bookPath, JsonSerializerOptions Opts)
        {
            // 实例化初始化属性
            path = bookPath;
            JsonOpts = Opts;
        }
    }
}

