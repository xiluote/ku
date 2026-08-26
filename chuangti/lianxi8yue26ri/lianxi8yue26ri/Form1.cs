using System.Collections.Generic;

namespace lianxi8yue26ri
{
    public partial class Form1 : Form
    {

        //要显示的图片路径
        public string[] tupian = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];
        private int index = 0;
        private List<Button> btnList = new();


        public Form1()
        {
            InitializeComponent();
            InitLunBo();
        }


        private void InitLunBo()
        {

            // 初始化 将 按钮添加到 btnList中
            btnList.AddRange([button1, button2, button3]);

            Label[] labs = [label1, label2];

            foreach (Label lab in labs) lab.Click += Lab_Click;

            foreach (Button btn in btnList) btn.Click += Btn_Click;

            LunBo();

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            //Button btn = (sender as Button);
            //int i = btnList.IndexOf(btn);
            //index = i;
            index = btnList.IndexOf(sender as Button);

            //pictureBox1.Image = Image.FromFile(tupian[index]);

            //btnList.ForEach(btn =>
            //{
            //    btn.BackColor = Color.DarkGray;
            //    btn.ForeColor = Color.Black;
            //});

            //btnList[index].BackColor = Color.Orange;
            //btnList[index].ForeColor = Color.White;
            LunBo();

        }


        private void Lab_Click(object sender, EventArgs e)
        {
            Label lab = (sender as Label);
            if (lab.Text == ">")
            {
                //if (index == tupian.Length - 1) index = 0;
                //else index++;
                index = (index == tupian.Length - 1) ? 0 : (++index);

                //pictureBox1.Image = Image.FromFile(tupian[index]);

                //btnList.ForEach(btn =>
                //{
                //    btn.BackColor = Color.DarkGray;
                //    btn.ForeColor = Color.Black;
                //});

                //btnList[index].BackColor = Color.Orange;
                //btnList[index].ForeColor = Color.White;

            }
            else
            {
                index = (index == 0) ? tupian.Length - 1 : (--index);
                //pictureBox1.Image = Image.FromFile(tupian[index]);

                //btnList.ForEach(btn =>
                //{
                //    btn.BackColor = Color.DarkGray;
                //    btn.ForeColor = Color.Black;
                //});

                //btnList[index].BackColor = Color.Orange;
                //btnList[index].ForeColor = Color.White;
            }
            //pictureBox1.Image = Image.FromFile(tupian[index]);

            //btnList.ForEach(btn =>
            //{
            //    btn.BackColor = Color.DarkGray;
            //    btn.ForeColor = Color.Black;
            //});

            //btnList[index].BackColor = Color.Orange;
            //btnList[index].ForeColor = Color.White;

            LunBo();
        }


        private void LunBo()
        {
            pictureBox1.Image = Image.FromFile(tupian[index]);

            btnList.ForEach(btn =>
            {
                btn.BackColor = Color.DarkGray;
                btn.ForeColor = Color.Black;
            });

            btnList[index].BackColor = Color.Orange;
            btnList[index].ForeColor = Color.White;
        }
    }
}
