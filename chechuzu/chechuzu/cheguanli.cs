using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace chechuzu
{
    internal class cheguanli
    {
        //定义文件路径
        public string lujing = "./car.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };


        //录入新车辆信息的方法
        public string Addcard(string card,string king,double money)
        {
            // 定义一个空的 list 
            List<Class>car = new ();//Class是我自己定义的类型
            // 判断存储文件是否存在 ==> 存在 -----》读取文件内容，并反序列化并将得到的数据列表赋值给list
            if(File.Exists(lujing))
            {
                car = JsonSerializer.Deserialize<List<Class>>(File.ReadAllText(this.lujing));//反序列化方法名.类型.全部文本（这个路径）
                //判断车牌号是否已经有了
                if (car.Exists(item => item.card == card)) return "该车已经被录入过";
            }
            // 将接受的数据组装成Car实例对象，然后添加到list中 ---> 序列化list---》写入json文件
            Class adc = new Class(car.Count + 1, card,king, money, true);//每辆车录入时默认空闲“true”

            // 写入json文件
            car.Add(adc);
            File.WriteAllText(this.lujing, JsonSerializer.Serialize(car, this.JsonOpt));//序列化

            return "录入车辆信息成功";
        }


        //显示所有车辆信息的方法
        public void Allcar()
        {
            //判断路径下是否存在车辆信息，没有就提示先创建文件
            if(!File.Exists(lujing))
            {
                Console.WriteLine("没有车辆信息，请先录入至少一台车");
                return;
            }
            // 判断文件是否存在===存在，读取文件，反序列化 ===遍历输出
            string jsonStr = File.ReadAllText(this.lujing);
            List<Class> cars = JsonSerializer.Deserialize<List<Class>>(jsonStr);
            foreach (Class item in cars)
            {
                //string statusStr = item.Status ? "空闲" : "已出租";
                Console.WriteLine($"id : {item.id} -- 车牌 : {item.card} -- 类型 : {item.king}  -- 时租费 : {item.money} ");
            }
        }


        //显示具体某辆车信息的方法
        public void Yicar(int n)//int n为形参，接收的参数类型只能是整形
        {
            //判断路径下是否存在车辆信息，没有就提示先创建文件
            if (!File.Exists(lujing))
            {
                Console.WriteLine("没有车辆信息，请先录入至少一台车");
                return;
            }
            // 判断文件是否存在===存在，读取文件，反序列化 ,输出
            string jsonStr = File.ReadAllText(this.lujing);
            List<Class> cars = JsonSerializer.Deserialize<List<Class>>(jsonStr);
            //  找到了===>将查找到的列表返回
            Class fanhui = cars.Find(item => item.id == n);
            if (fanhui == null)
            {
                Console.WriteLine("没有找到该车辆的信息，请检查输入是否正确");
                return;
            }
            else
            {
                //string statusStr = fanhui.Status ? "空闲" : "已出租";
                Console.WriteLine($"id : {fanhui.id} -- 车牌 : {fanhui.card} -- 类型 : {fanhui.king}  -- 时租费 : {fanhui.money} ");
            }
        }


        //显示所有空闲车信息的方法
        public void Allxian()
        {
            //判断文件是否存在，之后读取，反序列化，输出
            string jsonStr = File.ReadAllText(this.lujing);
            List<Class> cars = JsonSerializer.Deserialize<List<Class>>(jsonStr);
            //找到后，将符合状态空闲条件的车信息列表返回
            Class kongcar =cars.Find(item => item.kongxian == true);
            if (kongcar == null) Console.WriteLine("当前没有空闲车辆");
            else Console.WriteLine($"id : {kongcar.id} -- 车牌 : {kongcar.card} -- 类型 : {kongcar.king}  -- 时租费 : {kongcar.money} -- 当前状态：空闲");
        }


        // 根据id修改车辆状态 方法
        // 返回多个值 元组  第一个是提示信息，第二个是成功与否的状态
        public (string, bool) UpdateStatus(int id)
        {
            // 不存在====》没有车辆信息，请先添加
            if (!File.Exists(this.lujing)) return ("暂无车辆！！！", false);
            // 判断文件是否存在===存在，读取文件，反序列化 ===》根据id查找车辆对象===》找不到则提示
            string jsonStr = File.ReadAllText(this.lujing);
            List<Class> cars = JsonSerializer.Deserialize<List<Class>>(jsonStr);
            // 使用列表的Find 实现查找
            Class carObj = cars.Find(item => item.id == id);
            if (carObj == null) return ("没有对应ID的车辆！！！", false);
            if (!carObj.kongxian) return ("该车辆已被租出！！！", false);
            // 修改车辆状态
            carObj.kongxian = false;
            // 将修改后的 cars列表 序列化 写回文件
            string resStr = JsonSerializer.Serialize(cars, this.JsonOpt);
            File.WriteAllText(this.lujing, resStr);
            return ("租车成功！！！", true);
        }

        // 修改状态并获取 时租费
        public double UpAndGetInfo(int id)
        {
            // 读文件---》 反序列化 ---》车辆列表 ---》根据id查找---》修改状态 并获取数据返回
            string jsonStr = File.ReadAllText(this.lujing);
            List<Class> cars = JsonSerializer.Deserialize<List<Class>>(jsonStr);

            Class carObj = cars.Find(item => item.id == id);

            // 修改车辆状态
            carObj.kongxian = true;
            // 将修改后的 cars列表 序列化 写回文件
            string resStr = JsonSerializer.Serialize(cars, this.JsonOpt);
            File.WriteAllText(this.lujing, resStr);

            return carObj.money;
        }
    }
}
