namespace zuoye9yue2ri.Book
{
    partial class Addbook
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
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            input2 = new AntdUI.Input();
            input3 = new AntdUI.Input();
            inputNumber1 = new AntdUI.InputNumber();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1233, 87);
            label1.TabIndex = 1;
            label1.Text = "";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(325, 140);
            label2.Name = "label2";
            label2.Size = new Size(149, 50);
            label2.TabIndex = 2;
            label2.Text = "图书名称";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(325, 249);
            label3.Name = "label3";
            label3.Size = new Size(149, 50);
            label3.TabIndex = 3;
            label3.Text = "图书作者";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(325, 352);
            label4.Name = "label4";
            label4.Size = new Size(149, 50);
            label4.TabIndex = 4;
            label4.Text = "图书价格";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(325, 468);
            label5.Name = "label5";
            label5.Size = new Size(149, 50);
            label5.TabIndex = 5;
            label5.Text = "图书标签";
            // 
            // input1
            // 
            input1.Location = new Point(492, 122);
            input1.Name = "input1";
            input1.Size = new Size(293, 82);
            input1.TabIndex = 6;
            input1.TextAlign = HorizontalAlignment.Center;
            // 
            // input2
            // 
            input2.Location = new Point(492, 238);
            input2.Name = "input2";
            input2.Size = new Size(293, 82);
            input2.TabIndex = 7;
            input2.TextAlign = HorizontalAlignment.Center;
            // 
            // input3
            // 
            input3.Location = new Point(492, 468);
            input3.Multiline = true;
            input3.Name = "input3";
            input3.Size = new Size(293, 163);
            input3.TabIndex = 8;
            input3.TextAlign = HorizontalAlignment.Center;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(492, 342);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(293, 82);
            inputNumber1.TabIndex = 9;
            inputNumber1.Text = "0";
            inputNumber1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(546, 686);
            button1.Name = "button1";
            button1.Size = new Size(178, 70);
            button1.TabIndex = 10;
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 790);
            Controls.Add(button1);
            Controls.Add(inputNumber1);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Addbook";
            Text = "Addbook";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Input input1;
        private AntdUI.Input input2;
        private AntdUI.Input input3;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Button button1;
    }
}