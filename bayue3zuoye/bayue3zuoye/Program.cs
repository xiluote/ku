namespace bayue3zuoye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数字");

            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double sum = c + d;
            Console.WriteLine($"它们的和为{sum}");



            Console.WriteLine("请输入华氏度");
            double a = double.Parse(Console.ReadLine());
            double b = 5 / 9.0 * (a - 32);
            Console.WriteLine($"华氏度{a}对应的摄氏度为{b:F3}");


            Console.WriteLine("请输入两个整数");
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine($"你输入的第一个数为{e}，第二个数为{f}");
            e = e + f;
            f = e - f;
            e = e - f;
            Console.WriteLine($"交换后的第一个数为{e}，第二个数为{f}");



            Console.WriteLine("请输入已经过了多少个小时");
            int g = int.Parse(Console.ReadLine());
            int res1 = g / 24;
            int res2 = g % 24;
            Console.WriteLine($"已经经过了{res1}天{res2}小时");
        }
    }
}
