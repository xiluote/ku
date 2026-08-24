using Car;
using System.Diagnostics;

namespace chechuzu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num = "";
            cheguanli CM = new cheguanli();// 实例化车辆管理对象
            manguanli UM = new manguanli();// 实例化客户管理对象
            RentReturnClass RRC = new RentReturnClass();// 实例化客户管理对象


            while (num != "0")
            {
                Console.WriteLine("==欢迎来到租车系统==");
                Console.WriteLine("请选择操作编号：");
                Console.WriteLine("0：退出系统");
                Console.WriteLine("1：新增车辆");
                Console.WriteLine("2：查看所有车辆信息");
                Console.WriteLine("3：查看某辆车");
                Console.WriteLine("4：查看所有空闲车辆");
                Console.WriteLine("5：新增客户");
                Console.WriteLine("6：查看所有客户");
                Console.WriteLine("7：查看某个客户");
                Console.WriteLine("8：租车");
                Console.WriteLine("9：还车");
                Console.WriteLine("10：查看所有租车记录");

                //接收要进行的操作的编号
                 num = Console.ReadLine();


                switch (num)
                {
                    //新增车辆
                    case "1":
                        //接收录入关于车的所有参数
                        Console.WriteLine("请输入车牌号");
                        string card = Console.ReadLine();
                        Console.WriteLine("请输入车型");
                        string king = Console.ReadLine();
                        Console.WriteLine("请输入该车出租每小时多少钱");
                        double money = double.Parse(Console.ReadLine());
                        string resadd = CM.Addcard(card, king, money);
                        Console.WriteLine(resadd);

                        break;


                    //查看所有车辆信息
                    case "2":
                        Console.WriteLine("所有车辆的信息如下");
                        CM.Allcar();

                        break;


                    //查看某辆车信息
                    case "3":
                        Console.WriteLine("请输入车辆ID");
                        int ids = int.Parse(Console.ReadLine());
                        CM.Yicar(ids);//和2一样，所有的步骤都在方法里完成了，传入实参就行

                        break;


                    //查看所有空闲车辆
                    case "4":
                        Console.WriteLine("所有空闲车辆的信息如下");
                        CM.Allxian();

                        break;

                    //新增客户
                    case "5":
                        //接收录入关于用户的所有参数
                        Console.WriteLine("请输入姓名");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入身份证号");
                        string mancard = Console.ReadLine();
                        Console.WriteLine("请输入性别");
                        string gender = Console.ReadLine();
                        Console.WriteLine("请输入手机号");
                        string shouji = Console.ReadLine();
                        string useradd = UM.Adduesr(name, mancard, gender,shouji);
                        Console.WriteLine(useradd);

                        break;


                    //查看所有客户
                    case "6":
                        UM.Alluser();

                        break;

                    //查看某个客户
                    case "7":
                        Console.WriteLine("请输入查询用户id");
                        int id = int.Parse(Console.ReadLine());
                        UM.One(id);

                        break;

                    //租车
                    case "8":
                        RRC.RentCar();
                        break;


                    //换车
                    case "9":
                        RRC.ReturnCar();
                        break;

                    //查看所有租车记录
                    case "10":
                        RRC.SearchAll();
                        break;

                    default:
                        Console.WriteLine("输入有误，请重新输入！！！");
                        break;
                }
            }

        }
    }
}
