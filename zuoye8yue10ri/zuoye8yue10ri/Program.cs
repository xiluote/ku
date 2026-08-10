using System.Text.RegularExpressions;

namespace zuoye8yue10ri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*提取一句话中所有的中文名字*/
            //string str = "hello, I am 黄路基,your name is 黄陆机?";
            //string tiqu = @"[\u4e00-\u9fa5]{2,}";
            //MatchCollection res = Regex.Matches(str, tiqu);
            //Console.WriteLine(res[0]);
            //Console.WriteLine(res[1]);

            /*替换所有多余空格*/
            //string str = "abc  dd  ee  ff  gg  HH  h j k";
            //string tihuan = @"\s*";
            //string res = Regex.Replace(str,tihuan,"");
            //Console.WriteLine(res);

            // 书写正则, 找到字符串中的身份证号及 出生年,月,日
            //string str = "我的身份证号是: 360731200111052112,你的身份证是: 42108320041119211X";
            //string zhao = @"[1-9]\d{16}[\dX]";
            //MatchCollection res = Regex.Matches(str, zhao);
            //foreach (Match jieguo in res)
            //{
            //    string card = jieguo.Value;
            //    string nian = card.Substring(6, 4);
            //    string yue = card.Substring(10, 2);
            //    string ri = card.Substring(12, 2);
            //    Console.WriteLine($"身份证号为：{card},出生在{nian}年{yue}月{ri}日");
            //}


            //密码强度检测：强中弱（字母、数字、特殊符号）
            Console.WriteLine("请输入密码（字母、数字、特殊符号）8到15位:");
            string mima = Console.ReadLine();
            string jiance1 = @"\d+";
            string jiance2 = @"[A-Za-z]+";
            string jiance3 = @"\W";
            if(mima.Length < 8 || mima.Length > 15)
            {
                Console.WriteLine("密码长度不符合要求");
            }
            else 
            {
                bool res1 = Regex.IsMatch(mima, jiance1);
                bool res2 = Regex.IsMatch(mima, jiance2);
                bool res3 = Regex.IsMatch(mima, jiance3);
                int count = 0;
                if (res1) count++;
                if (res2) count++;
                if (res3) count++;
                if (count == 1)
                {
                    Console.WriteLine("密码长度符合,密码强度：弱");
                }
                else if (count == 2)
                {
                    Console.WriteLine("密码长度符合,密码强度：中");
                }
                else if (count == 3)
                {
                    Console.WriteLine("密码长度符合,密码强度：强");
                }


            }










        }
    }
}
