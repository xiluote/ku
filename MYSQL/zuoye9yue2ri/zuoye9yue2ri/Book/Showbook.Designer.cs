namespace zuoye9yue2ri.Book
{
    partial class Showbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new AntdUI.Label();
            table1 = new AntdUI.Table();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1278, 87);
            label1.TabIndex = 0;
            label1.Text = "图书目录展示";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // table1
            // 
            table1.Gap = 12;
            table1.Location = new Point(0, 153);
            table1.Name = "table1";
            table1.Size = new Size(1278, 316);
            table1.TabIndex = 1;
            table1.Text = "table1";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(556, 529);
            button1.Name = "button1";
            button1.Size = new Size(169, 58);
            button1.TabIndex = 2;
            button1.Text = "新增图书";
            button1.Click += button1_Click;
            // 
            // Showbook
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1278, 744);
            Controls.Add(button1);
            Controls.Add(table1);
            Controls.Add(label1);
            Name = "Showbook";
            Text = "Showbook";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Table table1;
        private AntdUI.Button button1;
    }
}