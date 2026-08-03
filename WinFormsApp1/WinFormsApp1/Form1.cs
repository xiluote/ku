namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 倒序删除（必须从后往前删，不然索引错乱）
            for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
            {
                // 排除自动新增的空白行
                if (!dataGridView1.SelectedRows[i].IsNewRow)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1", "烤鸭", "烤类", "小明", "13xxxxxx", "一号桌", "已下单");
            dataGridView1.Rows.Add("1", "烤鸭", "烤类", "小明", "13xxxxxx", "一号桌", "已下单");
            dataGridView1.Rows.Add("1", "烤鸭", "烤类", "小明", "13xxxxxx", "一号桌", "已下单");
        }
    }
}
