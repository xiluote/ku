namespace zuoye9yue8
{
    public partial class Form1 : Form
    {
        //以下代码功能为练习递归函数

        public Form1()
        {
            InitializeComponent();
            Zhanshi();
        }
        
        //递归函数：在一个函数中调用这个函数本身，需要有终止条件，否则会死循环

        //n的结合可看作n加上（n-1）的阶和，一直减至n=1为止，结束循环，进而得到n的阶和
        public static int Qiujiehe(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            // n的阶和=n+(n-1)的阶和
            return n + Qiujiehe(n - 1);
        }

        //求斐波那契数列的第几个数是多少
        public static int Feibo(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Feibo(n - 1)+ Feibo(n - 2);//一直减到1或者2就知道(n-1)和(n-2)的值了
        }


        //求按照1-1/2+1/3-1/4+1/5…………(+-1/n)的规律运算,到n为几时的结果是多少
        public static double Zhengfu(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            double i;
            //要把数值写精确点，至少带1位小数，不然double也只会得到整数结果
            i = (n % 2 == 1 )?  1.0 / n : -1.0 / n ;
            //都是从后往前算，到1为止
            return i + Zhengfu(n - 1);

        }


        //展示出弹窗
        private void Zhanshi()
        {
            //求6的阶和
            int sum = Qiujiehe(6);
            MessageBox.Show($"{sum}");

            int fei = Feibo(7);
            MessageBox.Show($"{fei}");

            double fenhe = Zhengfu(100);
            MessageBox.Show($"{fenhe}");
        }
    }
}
