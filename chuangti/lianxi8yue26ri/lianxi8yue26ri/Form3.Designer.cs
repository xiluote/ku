namespace lianxi8yue26ri
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            tongguo = new Label();
            butong = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            xiala = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(338, 213);
            label1.Name = "label1";
            label1.Size = new Size(211, 51);
            label1.TabIndex = 0;
            label1.Text = "模拟链接测试";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 5);
            label2.Name = "label2";
            label2.Size = new Size(63, 24);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 56);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 322);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 30);
            textBox1.TabIndex = 3;
            // 
            // tongguo
            // 
            tongguo.AutoSize = true;
            tongguo.ForeColor = Color.Green;
            tongguo.Location = new Point(365, 328);
            tongguo.Name = "tongguo";
            tongguo.Size = new Size(46, 24);
            tongguo.TabIndex = 4;
            tongguo.Text = "通过";
            tongguo.Visible = false;
            // 
            // butong
            // 
            butong.AutoSize = true;
            butong.ForeColor = Color.Red;
            butong.Location = new Point(219, 365);
            butong.Name = "butong";
            butong.Size = new Size(64, 24);
            butong.TabIndex = 5;
            butong.Text = "不通过";
            butong.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 325);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 6;
            label4.Text = "手机号：";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 430);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 7;
            // 
            // xiala
            // 
            xiala.FormattingEnabled = true;
            xiala.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            xiala.Location = new Point(630, 99);
            xiala.Name = "xiala";
            xiala.Size = new Size(247, 32);
            xiala.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 537);
            Controls.Add(xiala);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(butong);
            Controls.Add(tongguo);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label tongguo;
        private Label butong;
        private Label label4;
        private TextBox textBox2;
        private ComboBox xiala;
    }
}