namespace lianxi8yue28ri
{
    //以下代码的功能为练习 全选反选
    public partial class qxfx : Form
    {
        public qxfx()
        {
            InitializeComponent();
            //为全选框绑定事件
            All.CheckedChanged += Allxuan;

            //遍历容器中的所有复选框，为它们绑定事件
            foreach(Control bang in zipanel1.Controls)
            {
                (bang as CheckBox).CheckedChanged += Danxuan;
            }
        }


        //当点击全选框时运行的方法
        private void Allxuan (object sender, EventArgs e)
        {
            //判断点击全选框时，它当前是什么状态
            bool zt = All.CheckState == CheckState.Checked ? true : false;//全选了就返回true，否则返回false
            if (All.CheckState != CheckState.Indeterminate)//不是半选状态，就让所有的框和全选框变得一样
            {
                foreach (Control bang in zipanel1.Controls)
                {
                    (bang as CheckBox).Checked = zt ;
                }
            }
        }

        //当单选某个复选框时运行的方法
        private void Danxuan(object sender, EventArgs e)
        {
            //  OfType<> 过滤方法得到Control类型的集合
            List<Control> list = zipanel1.Controls.OfType<Control>().ToList();

            //判断是否所有的框都被选了
            bool allxz = list.All(item =>
            {
                return (item as CheckBox).Checked;
            }
            );

            //判断是否选中了一个以上的框,是上面的简写版
            bool anyxz = list.Any(item =>(item as CheckBox).Checked);

            if (allxz)
            {
                All.CheckState = CheckState.Checked;//让全选框显示勾表示全选
            }
            else
            {
                if (anyxz)
                {
                    All.CheckState = CheckState.Indeterminate;//显示方块表示选了部分
                }
                else
                {
                    All.CheckState = CheckState.Unchecked;//不显示表示一个都没选
                }
            }
        }

    }
}
