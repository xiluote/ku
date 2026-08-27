namespace lianxi8yue26ri
{
    partial class yidong
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
            mianban = new Panel();
            labeltime = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // mianban
            // 
            mianban.BackColor = Color.Black;
            mianban.Location = new Point(347, 133);
            mianban.Name = "mianban";
            mianban.Size = new Size(80, 80);
            mianban.TabIndex = 0;
            // 
            // labeltime
            // 
            labeltime.AutoSize = true;
            labeltime.Location = new Point(18, 360);
            labeltime.Name = "labeltime";
            labeltime.Size = new Size(100, 24);
            labeltime.TabIndex = 1;
            labeltime.Text = "移动时间：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 404);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 2;
            label2.Text = "移动次数：";
            // 
            // yidong
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(labeltime);
            Controls.Add(mianban);
            FormBorderStyle = FormBorderStyle.None;
            Name = "yidong";
            Text = "as";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mianban;
        private Label labeltime;
        private Label label2;
    }
}