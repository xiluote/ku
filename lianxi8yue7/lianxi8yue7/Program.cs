namespace lianxi8yue7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1、先声明后赋值
            //int[] a = new int[7];
            //a[0] = 10;

            ////2、声明并初始化
            //int[] b = new int[5] { 1, 2, 3, 4, 5 };

            ////3、省略长度
            //int[] c = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            ////4.简写
            //int[] d = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////5.新版写法
            //int[] e = [1, 2, 3];
            //List<int> f  = [1, 2, 3, 4, 5, 6, 7];


            //List去重
            //List<int> a = new() { 1, 2, 4, 8, 7, 4, 6, 6, 1, 3, 1, 2, 4, 8, 7, 9, 4, 1, 3, 7, 5 };
            //for (int i = 0; i < a.Count; i++)
            //{
            //    for(int j = i+1;j<a.Count;j++)
            //    {
            //        if(a[j] == a[i])
            //        {
            //            a.RemoveAt(j);
            //            j--;
            //        }
            //    }
            //}
            //foreach(int b in a) Console.WriteLine(b);

            //冒泡排序（比较大小，交换顺序）
            //List<int> a = new() { 1, 4, 8, 7, 6, 3, 2, 5, 9, };
            //for (int i = 0; i < a.Count - 1; i++)
            //{
            //    for(int j=0;j<a.Count - 1-i; j++)
            //    {
            //        if (a[j] > a[j+1])
            //        {
            //            int jh = a[j];
            //            a[j] = a[j+1];
            //            a[j+1] = jh;
            //        }
            //    }
            //}
            //foreach (int b in a) Console.WriteLine(b);

            //以下为8月7日作业*****************************************

            //List<Dictionary<string, dynamic>> sp = new List<Dictionary<string, dynamic>>
            //{
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "机械键盘"},
            //        {"price", 299.99},
            //        {"code", "G001"},
            //        {"stock", 120}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "无线鼠标"},
            //        {"price", 89.50},
            //        {"code", "G002"},
            //        {"stock", 356}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "27寸显示器"},
            //        {"price", 1299.00},
            //        {"code", "G003"},
            //        {"stock", 48}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电竞耳机"},
            //        {"price", 199.00},
            //        {"code", "G004"},
            //        {"stock", 85}
            //    },
            //    new Dictionary<string, dynamic>
            //    {
            //        {"name", "电脑支架"},
            //        {"price", 69.90},
            //        {"code", "G005"},
            //        {"stock", 210}
            //    }
            //};
            //Console.WriteLine("请输入排序类型：（price/stock）");
            //string a=Console.ReadLine();
            //Console.WriteLine("请输入排序顺序：（升序/降序）");
            //string b = Console.ReadLine();
            //for (int i = 0; i < sp.Count-1; i++)
            //{
            //    for (int j = 0; j < sp.Count-1-i; j++)
            //    {
            //        if (b == "升序")
            //        {
            //            if (a == "price")
            //            {
            //                if (sp[j]["price"] > sp[j + 1]["price"])
            //                {
            //                    dynamic tmp = sp[j];
            //                    sp[j] = sp[j + 1];
            //                    sp[j + 1] = tmp;
            //                }
            //            }
            //            else if (a == "stock")
            //            {
            //                if (sp[j]["stock"] > sp[j + 1]["stock"])
            //                {
            //                    dynamic tmp = sp[j];
            //                    sp[j] = sp[j + 1];
            //                    sp[j + 1] = tmp;
            //                }
            //            }
            //            else { Console.WriteLine("输入失败"); }
            //        }
            //        else if(b=="降序")
            //        {
            //            if (a == "price")
            //            {
            //                if (sp[j]["price"] < sp[j + 1]["price"])
            //                {
            //                    dynamic tmp = sp[j];
            //                    sp[j] = sp[j + 1];
            //                    sp[j + 1] = tmp;
            //                }
            //            }
            //            else if (a == "stock")
            //            {
            //                if (sp[j]["stock"] < sp[j + 1]["stock"])
            //                {
            //                    dynamic tmp = sp[j];
            //                    sp[j] = sp[j + 1];
            //                    sp[j + 1] = tmp;
            //                }
            //            }
            //            else { Console.WriteLine("输入失败"); }
            //        }
            //    }
            //}
            //foreach (dynamic n in sp) Console.WriteLine($"{n["name"]}--{n["price"]}元--{n["stock"]} 件");

            /******************************************************************/
            List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1004},
                    {"singerName", "薛之谦"},
                    {"genre", "抒情流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1005},
                    {"singerName", "毛不易"},
                    {"genre", "民谣流行"}
                }
            };

            List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"songId", 10001},
                    {"singerId", 1001},
                    {"songName", "青花瓷"},
                    {"duration", 239}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10002},
                    {"singerId", 1001},
                    {"songName", "发如雪"},
                    {"duration", 253}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10003},
                    {"singerId", 1001},
                    {"songName", "东风破"},
                    {"duration", 215}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1004},
                    {"singerId", 3002},
                    {"songName", "不为谁而作的歌"},
                    {"duration", 296}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1005},
                    {"singerId", 1002},
                    {"songName", "背对背拥抱"},
                    {"duration", 262}
                }
            };

            // 用户输入歌曲名：通过这个名将这歌曲的所有演唱者都找出来
            Console.WriteLine("请输入歌曲名：");
            string song = Console.ReadLine();

            
            int targetSingerId = 0;

            // 遍历歌曲集合 根据歌曲名字 获取这首歌的singerId
            foreach (Dictionary<string, dynamic> item in songList)
            {
                if (item["songName"] == song)
                {
                    targetSingerId = item["singerId"];
                    
                    break;
                }
            }


            // 拿着歌手id，去歌手表找对应歌手
            var singerSongs = new List<Dictionary<string, dynamic>>();
            foreach (Dictionary<string, dynamic> item in singerList)
            {
                if (item["singerId"] == targetSingerId)
                {
                    singerSongs.Add(item);
                }
            }

            Console.WriteLine($"唱过{song}的人：");
            if (singerSongs.Count == 0)
            {
                Console.WriteLine("没有该歌曲对应的歌手信息");
            }
            else
            {
                foreach (var item in singerSongs)
                {
                    Console.WriteLine(item["singerName"]);
                }
            }
        }
    }
}
                
            

























