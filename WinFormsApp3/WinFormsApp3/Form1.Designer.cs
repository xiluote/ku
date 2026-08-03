namespace WinFormsApp3
{
    partial class txtUrl
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
            cboMethod = new ComboBox();
            textBox1 = new TextBox();
            btnSend = new Button();
            lblHeaderTitle = new Label();
            lblBodyTitle = new Label();
            btnAddHeader = new Button();
            btnDelHeader = new Button();
            SuspendLayout();
            // 
            // cboMethod
            // 
            cboMethod.FormattingEnabled = true;
            cboMethod.Items.AddRange(new object[] { "Get", "Post" });
            cboMethod.Location = new Point(2, 1);
            cboMethod.Name = "cboMethod";
            cboMethod.Size = new Size(182, 32);
            cboMethod.TabIndex = 0;
            cboMethod.Text = "Post";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(909, 30);
            textBox1.TabIndex = 1;
            textBox1.Text = "http://localhost/api/mgr/signin";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(1105, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 2;
            btnSend.Text = "发送";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Location = new Point(120, 54);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(64, 24);
            lblHeaderTitle.TabIndex = 3;
            lblHeaderTitle.Text = "消息头";
            // 
            // lblBodyTitle
            // 
            lblBodyTitle.AutoSize = true;
            lblBodyTitle.Location = new Point(877, 54);
            lblBodyTitle.Name = "lblBodyTitle";
            lblBodyTitle.Size = new Size(64, 24);
            lblBodyTitle.TabIndex = 4;
            lblBodyTitle.Text = "消息体";
            // 
            // btnAddHeader
            // 
            btnAddHeader.Location = new Point(337, 49);
            btnAddHeader.Name = "btnAddHeader";
            btnAddHeader.Size = new Size(112, 34);
            btnAddHeader.TabIndex = 5;
            btnAddHeader.Text = "+";
            btnAddHeader.UseVisualStyleBackColor = true;
            // 
            // btnDelHeader
            // 
            btnDelHeader.Location = new Point(587, 49);
            btnDelHeader.Name = "btnDelHeader";
            btnDelHeader.Size = new Size(112, 34);
            btnDelHeader.TabIndex = 6;
            btnDelHeader.Text = "-";
            btnDelHeader.UseVisualStyleBackColor = true;
            btnDelHeader.Click += btnDelHeader_Click;
            // 
            // txtUrl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 450);
            Controls.Add(btnDelHeader);
            Controls.Add(btnAddHeader);
            Controls.Add(lblBodyTitle);
            Controls.Add(lblHeaderTitle);
            Controls.Add(btnSend);
            Controls.Add(textBox1);
            Controls.Add(cboMethod);
            Name = "txtUrl";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboMethod;
        private TextBox textBox1;
        private Button btnSend;
        private Label lblHeaderTitle;
        private Label lblBodyTitle;
        private Button btnAddHeader;
        private Button btnDelHeader;
    }
}
