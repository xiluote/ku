using Class;

namespace moneyguanli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            Manager CM = new Manager();

            while (num != "0")
            {
                Tips();
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine("请输入员工编号：");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("请输入姓名：");
                        string Name = Console.ReadLine();
                        Console.WriteLine("请输入部门：");
                        string Bumen = Console.ReadLine();
                        Console.WriteLine("请输入薪资:");
                        double Salary = double.Parse(Console.ReadLine());
                        string resAdd = CM.Add(Id, Name, Bumen, Salary);
                        Console.WriteLine(resAdd);
                        break;

                    case "2":
                        Console.WriteLine("查看所有员工信息");
                        CM.All();
                        break;

                    case "3":
                        Console.WriteLine("根据编号调整薪资（改）");
                        Console.WriteLine("请输入员工编号");
                        int id = int.Parse(Console.ReadLine());
                        CM.Tiaoxin(id);
                        break;

                    case "4":
                        Console.WriteLine("根据编号删除员工（删）");
                        Console.WriteLine("请输入员工编号");
                        int id2 = int.Parse(Console.ReadLine());
                        CM.Shanchu(id2);
                        break;

                    case "5":
                        Console.WriteLine("按薪资条件筛选员工（查-条件）");
                        Console.WriteLine("请输入要大于多少薪资");
                        double money = double.Parse(Console.ReadLine());
                        CM.Shai(money);
                        break;

                    case "0":
                        Console.WriteLine("退出系统");
                        break;
                    default:
                        Console.WriteLine("输入编号有误，请重新输入！！！");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void Tips()
        {
            Console.WriteLine("==欢迎来到员工管理系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("0：退出系统");
            Console.WriteLine("1：新增员工（增）");
            Console.WriteLine("2：查看全部员工（查-全部）");
            Console.WriteLine("3：根据编号调整薪资（改）");
            Console.WriteLine("4：根据编号删除员工（删）");
            Console.WriteLine("5：按薪资条件筛选员工（查-条件）");
        }
    }
}