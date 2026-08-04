using System.Net.Sockets;

namespace dier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list数据集合
            // 加强版的数组: list列表集合 可以新增 可以删除
            List<string> zu = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };
            // list集合中的数据 也是通过下标访问的
            //Console.WriteLine(zu[0]);
            //Console.WriteLine(zu[1]);
            //Console.WriteLine(zu[2]);
            //Console.WriteLine(zu[3]);
            //下标超出范围就报错

            // 修改
            //zu[0] = "nn";
            //Console.WriteLine(zu[0]);

            // 获取长度
            //Console.WriteLine(zu.Count);

            // 不能访问 范围外的下标
            //zu[5] = "nn"; // 报错

            //增加
            //zu.Add("F");
            //Console.WriteLine(zu[5]);

            //增加多个
            //zu.AddRange(new List<string>() { "GG", "HH" }); //增加多个必须是一个集合
            //Console.WriteLine(zu[5]);

            //在任意下标位置新增数据
            //list集合.Insert(插入的下标位置,要插入的数据)
            //zu.Insert(2, "YY");
            //Console.WriteLine(zu[2]);

            //将List中指定的数据删除
            //zu.Remove("A");//直接写数据，而不是顺序，会删除相同的所有数据
            //Console.WriteLine(zu[0]);

            //将List中指定下标的数据删除
            //zu.RemoveAt(0);//写的是顺序
            //Console.WriteLine(zu[0]);

            //删除数组中指定的多个数据
            //list集合.RemoveRange(下标,个数) // 从下标开始删除指定个数
            //zu.RemoveRange(0, 3);
            //Console.WriteLine(zu[0]);

            //清空所有数据
            //zu.Clear();

            //Contains判断List中是否包含某个数据
            //Console.WriteLine(zu.Contains("A"));

            //IndexOf：查找某个数据在List中第一次出现的下标，结果找到就是下标，找不到就是-1
            //Console.WriteLine(zu.IndexOf("A"));
            //LastIndexOf：找某个数据在List中最后一次出现的下标，找到就得到下标，找不到就是-1

            //从List中获取多个数据
            // GetRange(开始下标, 个数) 返回一个list集合

            //翻转
            //zu.Reverse();
            //Console.WriteLine(zu[0]);
        }
    }
}
