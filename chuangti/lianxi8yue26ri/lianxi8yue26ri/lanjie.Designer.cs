namespace lianxi8yue26ri
{
    partial class lanjie
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
            kuang = new TextBox();
            TextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // kuang
            // 
            kuang.Location = new Point(192, 67);
            kuang.Name = "kuang";
            kuang.Size = new Size(454, 30);
            kuang.TabIndex = 0;
            // 
            // TextBox
            // 
            TextBox.Location = new Point(192, 121);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(454, 261);
            TextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(668, 73);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 2;
            label1.Text = "请输入";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 523);
            Controls.Add(label1);
            Controls.Add(TextBox);
            Controls.Add(kuang);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox kuang;
        private TextBox TextBox;
        private Label label1;
    }
}