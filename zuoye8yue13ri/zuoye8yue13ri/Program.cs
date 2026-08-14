using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace zuoye8yue13ri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, dynamic>> list = new() {
            new Dictionary<string, dynamic>(){
                ["name"] = "zs",
                ["age"] = 29,
                ["isMan"] = true,
                ["isSingle"] = true,
                ["salary"] = 4200
            },
            new Dictionary<string, dynamic>(){
                ["name"] = "ls",
                ["age"] = 20,
                ["isMan"] = false,
                ["isSingle"] = true,
                ["salary"] = 3400
            },
            new Dictionary<string, dynamic>(){
                ["name"] = "ww",
                ["age"] = 19,
                ["isMan"] = true,
                ["isSingle"] = false,
                ["salary"] = 6000
            },
            new Dictionary<string, dynamic>(){
                ["name"] = "zl",
                ["age"] = 14,
                ["isMan"] = false,
                ["isSingle"] = true,
                ["salary"] = 2000
            },
            new Dictionary<string, dynamic>(){
                ["name"] = "sq",
                ["age"] = 35,
                ["isMan"] = true,
                ["isSingle"] = false,
                ["salary"] = 7000
            },
            new Dictionary<string, dynamic>(){
                ["name"] = "zb",
                ["age"] = 27,
                ["isMan"] = false,
                ["isSingle"] = true,
                ["salary"] = 2900
                },
            };

            // 作业1
            // Find: 要求查找年龄小于20的（第一个元素）
            //Dictionary<string, dynamic> res = list.Find(item =>
            //{
            //    return item["age"] < 20;
            //}
            //);
            //Console.WriteLine(JsonSerializer.Serialize(res["age"]));


            // FindLast: 要求查找年龄大于25的（最后一个元素）
            //Dictionary<string, dynamic> res2 = list.FindLast(litm =>
            //{
            //    return litm["age"] > 25;
            //}
            //);
            //Console.WriteLine(JsonSerializer.Serialize(res2["age"]));


            //FindAll: 找出性别男的（全部元素）
            //  List<Dictionary<string, dynamic>> res3 = list.FindAll(litm =>
            //  {
            //      return litm["isMan"] == true;

            //  }
            //  );
            // foreach (var kan in res3)
            // {
            //     Console.WriteLine(JsonSerializer.Serialize(kan["name"]));
            // }

            /*******************上面和元素相关，下面和下标相关***********************/

            // FindIndex: 找出薪水大于5000(找第一个满足条件的元素下标)

            //int res4 = list.FindIndex(item => item["salary"] > 5000);
            //if (res4 != -1)//找不到返回-1
            //{
            //    Dictionary<string, dynamic> item = list[res4];
            //    Console.WriteLine(JsonSerializer.Serialize(item["salary"]));
            //}

            //// FindLastIndex: 找出薪水小于3000(找最后一个满足条件的元素下标)

            //int res5 = list.FindLastIndex(item => item["salary"] < 5000);
            //if (res5 != -1)//找不到返回-1
            //{
            //    Dictionary<string, dynamic> item = list[res5];
            //    Console.WriteLine(JsonSerializer.Serialize(item["salary"]));
            //}

            // Exists: 判断是否有薪水大于5000

            //bool res6 = list.Exists(item => item["salary"] > 5000);
            //if (res6 = true)
            //{
            //    Console.WriteLine("有薪水大于5000");
            //}
            //else { Console.WriteLine("无薪水大于5000"); }

            // ForEach: 输出每个的 名字-年龄-薪水

            //list.ForEach(item =>
            //{
            //    Console.WriteLine($"{item["name"]}-{item["age"]}-{item["salary"]}");
            //});


            // ConvertAll: 映射得到一个所有薪水的list

            //List<dynamic> res8 = list.ConvertAll(item =>
            //{
            //    return item["salary"];
            //});
            //foreach (dynamic kan in res8)
            //{
            //    Console.WriteLine(kan);
            //}


            //TrueForAll: 判断是否都成年

            //bool res9 = list.TrueForAll(item => item["age"] >= 18);
            //if (res9 = false)
            //{
            //    Console.WriteLine("有未成年");
            //}
            //else { Console.WriteLine("都成年"); }


            /***************************************************************/
            //封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数

            Func<string, Dictionary<char, int>> getCount = str =>
            {
                //定义一个字典
                Dictionary<char, int> resDic = new();
                for (int i = 0;i<str.Length;i++)
                {
                    //判断 str[i] 这个字符在resDic中是否存在这个键
                    //不存在，则给resDic中添加这个键并赋值为1
                    //存在，则给resDic中这个键的值++
                    if (resDic.ContainsKey(str[i])) resDic[str[i]]++;
                    else resDic[str[i]] = 1;

                }

                return resDic;
            };

            var res = getCount("aaaaaaaaaajjjjjjjjwwwwwwwwwwwwbbbbbbbbccccccccii");
            foreach (var item in res) Console.WriteLine($"{item.Key}:{item.Value}");
           
            














        }
    }
    
}
