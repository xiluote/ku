using System.Text.Json;

namespace zuoye8yue17ri
{
    internal class Program
    {
        static void Main(string[] args)
        {                                         
            book BM = new book("./book.json", new JsonSerializerOptions
            {
                WriteIndented = true, // 美化格式内容
                AllowTrailingCommas = true,
            }
            );

            string num = "";
            while (num != "0")
            {
                // 提示信息
                Console.WriteLine("======欢迎来到图书管理系统======");
                Console.WriteLine("1: 新增图书");
                Console.WriteLine("2: 删除图书");
                Console.WriteLine("3: 编辑图书");
                Console.WriteLine("4: 查询所有图书");
                Console.WriteLine("5: 查询单个图书");
                Console.WriteLine("6: 借阅图书");
                Console.WriteLine("7: 归还图书");
                Console.WriteLine("0: 退出");
                num = Console.ReadLine();


                switch (num)
                {
                    case "1":
                        Console.WriteLine("----新增图书----");
                        Console.WriteLine("请输入书名");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("请输入作者");
                        string author = Console.ReadLine();
                        Console.WriteLine("请输入标签");
                        string mark = Console.ReadLine();
                        Console.WriteLine("请输入价格");
                        double price = double.Parse(Console.ReadLine());
                        // 组装 书籍 字典
                        Dictionary<string, dynamic> bookDic = new()
                        {
                            ["name"] = bookName,
                            ["author"] = author,
                            ["isBorrow"] = false,
                            ["id"] = new Random().NextDouble(),
                            ["mark"] = mark,
                            ["price"] = price
                        };
                        // 调用实例方法  实现 添加书籍
                        string res = BM.AddBook(bookDic);
                        Console.WriteLine(res);
                        break;
                    case "2":
                        Console.WriteLine("----删除图书----");
                        Console.WriteLine("请输入书名");
                        string bookName2 = Console.ReadLine();
                        var res2 = BM.RemoveBook(bookName2);
                        Console.WriteLine(res2);

                        break;
                    case "3":
                        Console.WriteLine("----编辑图书----");
                        Console.WriteLine("请输入书名");
                        string bookName3 = Console.ReadLine();
                        var res3 = BM.EditBook(bookName3);
                        Console.WriteLine(res3);

                        break;
                    case "4":
                        Console.WriteLine("----查询所有图书----");
                        var res4 = BM.SearchBook();
                        if(res4.Count==0)
                        {
                            Console.WriteLine("没有书籍，请先添加");
                        }
                        else 
                        {
                            foreach(var item in res4)
                            {
                                Console.WriteLine($"书名：{item["name"]}-作者：{item["author"]}-标签：{item["mark"]}-价格：{item["price"]}-状态：{item["isBorrow"]}");
                            }
                        }

                            break;
                    case "5":
                        Console.WriteLine("----查询单个图书----");
                        Console.WriteLine("请输入查询的书名：");
                        string shuname = Console.ReadLine();
                        var res5 = BM.SearchBook(shuname);
                        if (res5.Count == 0) 
                        {
                            Console.WriteLine("没有找到该书籍，请添加");
                        }
                        else
                        {
                               Console.WriteLine($"书名：{res5["name"]}-作者：{res5["author"]}-标签：{res5["mark"]}-价格：{res5["price"]}-状态：{res5["isBorrow"]}");
                        }

                        break;

                    case "6":
                        Console.WriteLine("----借阅图书----");
                        //现实所有可借阅的书籍
                        var allBooks1 = BM.SearchBook();
                        bool resBook1 = false;
                        Console.WriteLine("可借阅的书籍列表：");
                        foreach (var book in allBooks1)
                        {
                            //将isBorrow转换为bool再比较
                            bool isBorrow = book["isBorrow"].GetBoolean();
                            if (isBorrow == false)
                            {
                                Console.WriteLine($"书名：{book["name"]}-作者：{book["author"]}-标签：{book["mark"]}-价格{book["price"]}");
                                resBook1 = true;
                            }
                        }
                        if (!resBook1)
                        {
                            Console.WriteLine("当前没有可借阅的书籍");
                            break;
                        }
                        Console.WriteLine("请输入要借阅的书名：");
                        string listbook1 = Console.ReadLine();
                        var ListBook1 = BM.jieBook(listbook1);
                        Console.WriteLine(ListBook1);
                        break;

                    case "7":
                        Console.WriteLine("----归还图书----");
                        //显示所有已借出的书籍
                        var allBooks2 = BM.SearchBook();
                        bool resBook2 = false;
                        Console.WriteLine("已借出的书籍列表：");
                        foreach (var book in allBooks2)
                        {
                            bool isBorrow = book["isBorrow"].GetBoolean();
                            if (isBorrow == true)
                            {
                                Console.WriteLine($"书名：{book["name"]}-作者：{book["author"]}-标签：{book["mark"]}-价格{book["price"]}");
                                resBook2 = true;
                            }
                        }
                        if (!resBook2)
                        {
                            Console.WriteLine("当前没有已借出的书籍");
                            break;
                        }
                        Console.WriteLine("请输入要还的书名：");
                        string listbook2 = Console.ReadLine();
                        string ListBook2 = BM.huanBook(listbook2);
                        Console.WriteLine(ListBook2);
                        break;




                    case "0":
                        Console.WriteLine("--**退出**--");
                        break;
                    default:
                        Console.WriteLine("****输入有误****");
                        break;
                }

                /*
                后续同学自行完善 方向
                    1. 对所有输入的数据进行校验
                        - 可以先取出首尾两端的空白
                        - 不为空，长度要求校验
                        - 正则校验
                */

            }
        }
    }
}
