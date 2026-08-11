using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace lianxi8yue11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //通过下标获取到情报内容
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "7-16-30-38-49-52-63-70";
            //string result = ""; // 最终获取到的情报

            //string[] shuzu = salt.Split("-");//转成数组，字符串的内容用-做分隔隔开
            //for (int i = 0; i < shuzu.Length; i++)
            //{
            //    int res = int.Parse(shuzu[i]);//转换为整数 才能作为下标使用 //生成密文的程序若是对下标 -1 了，此处就该 +1 ，找到正确的下标
            // 判断下标是奇数还是偶数，奇数就 -1，偶数就 +1，和生成密文时一样的操作，相对应
            //res += res % 2 == 0 ? 1 : -1;
            //    result = result + text[res];
            //}
            //Console.WriteLine(result);

            //通过情报内容获取到下标
            //string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            //string salt = "午夜渡口交换情报";
            //List<int> suoyin = [];//储存用
            //for (int i = 0; i < salt.Length; i++)
            //{
            //    int duiying = text.IndexOf(salt[i]);//在此末尾加上 -1 ，也可以增加下标的变化，这是最简单的一种
            //    // 处理index  奇数就-1，偶数就+1
            //    //duiying += duiying % 2 == 0 ? 1 : -1;//三元运算写的条件判断
            //    suoyin.Add(duiying);
            //}
            //string miwen = string.Join("-", suoyin);
            //Console.WriteLine(miwen);


            //难难难难难，多练***************************************************************************
            int money = 900054;
            string str = money.ToString();
            // 对应关系：数字当作下标，从下面的集合中用下标获取汉字
            // 创建汉字数组
            string[] hanzi = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            // 创建单位数组
            string[] danwei = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            string a = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                int idx = int.Parse(str[i].ToString());
                // 找单位的下标
                int index = str.Length - 1 - i;
                // 获取单位
                string unit = danwei[index];
                if (idx != 0)
                {
                    a = hanzi[idx] + unit + a;
                }
                else
                {
                    if (str.Length - 5 == i)
                    {
                        a = hanzi[idx] + danwei[4] + a;
                    }
                    else
                    {
                        a = hanzi[idx] + a;
                    }
                }
            }
            // 零万 => 万   零零万=>万 零零零万=>万
            a = Regex.Replace(a, @"零+萬", "萬");
            // 多个零都换成一个零
            a = Regex.Replace(a, @"零+", "零");
            // 结尾是零的判断
            if (a.EndsWith("零"))
            {
                // 将零截取掉
                a = a.Substring(0, a.Length - 1);
            }

            Console.WriteLine(a);















        }
    }
}
