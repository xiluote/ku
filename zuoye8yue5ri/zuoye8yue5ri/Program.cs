namespace zuoye8yue5ri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入账号：");
            //string zh = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string mm = Console.ReadLine();
            //if (zh != "admin")
            //{
            //    Console.WriteLine("账号不存在");
            //}
            //else if (mm != "123456") 
            //{
            //    Console.WriteLine("密码错误");
            //}
            //else
            //{
            //    Console.WriteLine("登陆成功");
            //}

            /***********************************/
            //Console.WriteLine("请选择要进行的操作：add  edit  del");
            //string cz = Console.ReadLine();
            //string res = cz switch
            //{
            //    "add" => "新增成功",
            //    "edit"=>"编辑成功",
            //    "del"=>"删除成功",
            //    _=>"操作失败"
            //};
            //Console.WriteLine(res);

            /***********************************/
            //Console.WriteLine("请问您是vip还是user");
            //string sf = Console.ReadLine();
            //Console.WriteLine("消费金额为：");
            //double je = double.Parse(Console.ReadLine());
            //double sj;
            //if(sf == "vip")
            //{
            //    if (je >= 1000)
            //    {
            //        sj = je * 0.9;
            //    }
            //    else { sj = je; }
            //}
            //else
            //{
            //    if (je >= 2000)
            //    {
            //        sj = je * 0.95;
            //    }
            //    else { sj = je; }
            //}
            //Console.WriteLine($"你一共需要支付{sj}元");

            /*********************************/
            //Console.WriteLine("请输入月份：");
            //int yf = int.Parse(Console.ReadLine());
            //switch(yf)
            //{
            //    case 1:
            //    case 2:
            //    case 3: Console.WriteLine("现在是春季");break;
            //    case 4:
            //    case 5:
            //    case 6: Console.WriteLine("现在是夏季"); break;
            //    case 7:
            //    case 8:
            //    case 9: Console.WriteLine("现在是秋季"); break;
            //    case 10:
            //    case 11:
            //    case 12: Console.WriteLine("现在是冬季"); break;
            //}

            /*****************************************/
            //Console.WriteLine("请输入快递的重量：（kg）");
            //double zl = double.Parse(Console.ReadLine());
            //if (zl < 1)
            //{
            //    Console.WriteLine("快递费10元");
            //}
            //else if(1 <= zl &&  zl <= 5)
            //{
            //    Console.WriteLine("快递费20元");
            //}
            //else
            //{
            //    Console.WriteLine("快递费50元");
            //}

            /*****************************************/
            //Console.WriteLine("请输入会员等级：（3到5）");
            //int dj = int.Parse(Console.ReadLine());
            //string res = dj switch
            //{
            //     3 => "购物打9折",
            //     4 => "每月可领优惠券",
            //     5 => "终身免运费",
            //     _=>"没有福利"
            //};
            //Console.WriteLine($"{res}");

            /*****************************************/
            //Console.WriteLine("请输入商品编号：（3到5）");
            //int dj = int.Parse(Console.ReadLine());
            //string res = dj switch
            //{
            //    1 => "已购买可乐",
            //    2 => "已购买雪碧",
            //    3 => "已购买矿泉水",
            //    _ => "没有此商品"
            //};
            //Console.WriteLine($"{res}");

            /*****************************************/
            Console.WriteLine("请输入当前速度：");
            double sd = double.Parse(Console.ReadLine());
            if (sd > 0 && sd < 30)
            {
                Console.WriteLine("低速通过");
            }
            else if(sd >= 30 && sd < 60)
            {
                Console.WriteLine("中速通过");
            }
            else if (sd >= 60 && sd < 100)
            {
                Console.WriteLine("高速通过");
            }
            else if (sd >= 100 )
            {
                Console.WriteLine("超速通过");
            }









        }
    }
}
