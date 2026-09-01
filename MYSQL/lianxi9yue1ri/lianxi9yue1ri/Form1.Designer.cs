namespace lianxi9yue1ri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tname = new TextBox();
            tgender = new TextBox();
            tage = new TextBox();
            thigh = new TextBox();
            tbanji = new TextBox();
            button4 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(742, 470);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 488);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "请输入要查询的学生姓名";
            textBox1.Size = new Size(350, 30);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(96, 524);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "条件查询";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(827, 448);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "添加新生";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(404, 524);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "统计总人数";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tname
            // 
            tname.Location = new Point(810, 148);
            tname.Name = "tname";
            tname.Size = new Size(150, 30);
            tname.TabIndex = 5;
            // 
            // tgender
            // 
            tgender.Location = new Point(810, 213);
            tgender.Name = "tgender";
            tgender.Size = new Size(150, 30);
            tgender.TabIndex = 6;
            // 
            // tage
            // 
            tage.Location = new Point(810, 276);
            tage.Name = "tage";
            tage.Size = new Size(150, 30);
            tage.TabIndex = 7;
            // 
            // thigh
            // 
            thigh.Location = new Point(810, 338);
            thigh.Name = "thigh";
            thigh.Size = new Size(150, 30);
            thigh.TabIndex = 8;
            // 
            // tbanji
            // 
            tbanji.Location = new Point(810, 395);
            tbanji.Name = "tbanji";
            tbanji.Size = new Size(150, 30);
            tbanji.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(827, 524);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 10;
            button4.Text = "返回表格";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 529);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 608);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(tbanji);
            Controls.Add(thigh);
            Controls.Add(tage);
            Controls.Add(tgender);
            Controls.Add(tname);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox tname;
        private TextBox tgender;
        private TextBox tage;
        private TextBox thigh;
        private TextBox tbanji;
        private Button button4;
        private Label label1;
    }
}
