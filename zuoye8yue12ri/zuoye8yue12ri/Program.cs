using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace zuoye8yue12ri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。计算这个半径的圆装修一半需要多少钱？
            //Console.WriteLine("请输入要装修的圆的半径：（米）");
            //double R = double.Parse(Console.ReadLine());
            //double yuan(double r)
            //{
            //    double s = Math.PI*r*r;
            //    double money = s * 200;
            //    Console.WriteLine($"装修一半的总价为{money/2:F2}元");
            //    return money;
            //}
            //yuan(R);


            /***************************************************************************************/
            //计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。
            //string str = "qwerysssssqqqqwwweee";
            //Console.WriteLine("请输入要查找的字符：");
            //char cha = char.Parse(Console.ReadLine());

            //int sum(string a, char b)
            //{
            //    string guize = $@"{b}";
            //    MatchCollection tiqu = Regex.Matches(a, guize);//多次提取的写法
            //    return tiqu.Count;
            //}
            //int cishu = sum(str, cha);
            //Console.WriteLine($"该字符出现的次数为：{cishu}");


            /***************************************************************************************/
            //计算一个整型数组中，最小值第一次出现的下标。
            //int[] arr = [10, 20, 5, 30, 50, 6,5, 4,7];
            //int a (int[] b)
            //{
            //    int min = 0;
            //    for (int i = 1; i < b.Length-1; i++)
            //    {
            //        if (b[i] < b[min])
            //        {
            //            min = i;
            //        }
            //    }
            //    Console.WriteLine(min);
            //    return min;
            //}
            //a(arr);

            /***********************************************************************************/
            //判断一个字符串是否为回文，返回布尔值类型
            string str = "abcdcba";
            bool fanhui(string a)
            {
                int left = 0;
                int right = a.Length - 1;//下标比个数少1，比如第一个数下标是0
                while (left < right)
                {
                    if (a[left] != a[right])
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
                return true;
            }

            bool res = fanhui(str);
            Console.WriteLine(res);






        }
    }
}
