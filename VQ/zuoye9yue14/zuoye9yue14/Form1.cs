using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zuoye9yue14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Title = "请选择检测硬币数量的图片";
                OFD.Filter = "图片|*.jpg;*.jpeg;*.png;*.gif;*.bmp;";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    //设置图片控件某些属性
                    pictureBox1.Image = Image.FromFile(OFD.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    // 使用visionPro库处理图片，才能得到一张能被visionPro方案处理的图片
                    CogImageFileTool CFT = new CogImageFileTool();
                    CFT.Operator.Open(OFD.FileName, CogImageFileModeConstants.Read);
                    CFT.Run();//运行

                    //加载导出的vpp方案文件，绝对路径拼接
                    string VppFilePath = Path.Combine(Application.StartupPath, "vpps", "zhengyingbi.vpp");
                    string Vpp2 = Path.Combine(Application.StartupPath, "vpps", "meizhong.vpp");


                    // 将vpp文件中的视觉方案读取到 C#中 
                    object LOF = CogSerializer.LoadObjectFromFile(VppFilePath);
                    object LOF2 = CogSerializer.LoadObjectFromFile(Vpp2);

                    // 因为读取后 默认是 object 类型; 不具备Cog工具对象的运行方法,所以转给工具类型
                    CogToolBlock CTB = LOF as CogToolBlock;
                    CogToolBlock CTB2 = LOF2 as CogToolBlock;

                    // 将CogImageFileTool工具读取到的输出图像 作为(视觉方案)CTB 的 输入图像
                    CTB.Inputs["OutputImage"].Value = CFT.OutputImage;
                    CTB.Run();
                    CTB2.Inputs["OutputImage"].Value = CFT.OutputImage;
                    CTB2.Run();


                    // 获取数值并求和
                    double yiyuan = Convert.ToDouble(CTB2.Outputs["yiyuan"].Value);
                    double wujiao = Convert.ToDouble(CTB2.Outputs["wujiao"].Value);
                    double yijiao = Convert.ToDouble(CTB2.Outputs["yijiao"].Value);

                    double wuValue = Convert.ToDouble(CTB.Outputs["wu"].Value);
                    double yiValue = Convert.ToDouble(CTB.Outputs["yi"].Value);
                    double he = wuValue + yiValue;

                    // 显示结果
                    label2.Text = he.ToString();
                    label6.Text = yiyuan.ToString();
                    label7.Text = wujiao.ToString();
                    label8.Text = yijiao.ToString();

                }
            }
        }
    }
}

