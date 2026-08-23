using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chechuzu
{
    //车信息类
    internal class Class
    {
        //车辆信息的类,储存车辆信息时的数据类型
        public int id { get; }//车序号
        public string card { get; }//车牌号
        public string king { get; }//车型
        public double money { get; set; }//车时价
        public bool kongxian { get; set; }//使用状态

        //构造函数，用于实例化时设置属性值
        public Class(int id, string card, string king, double money,bool kongxian)//构造函数和类同名
        {
            this.id = id;
            this.card = card;
            this.king = king;
            this.money = money;
            this.kongxian = kongxian;
        }



    }

    //用户信息类
    internal class Man
    {
        //用户信息的类,储存用户信息时的数据类型
        public int id { get; }//用户序号
        public string name { get; }//姓名
        public string card { get; }//身份证号
        public string gender { get; }//性别
        public string shouji { get; set; }//手机号

        //构造函数，用于实例化时设置属性值
        public Man(int id, string name, string card, string gender, string shouji)//构造函数和类同名
        {
            this.id = id;
            this.name = name;
            this.card = card;
            this.gender = gender;
            this.shouji = shouji;
        }



    }

}
