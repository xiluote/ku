namespace lianxi8yue28ri
{
    partial class qxfx
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
            All = new CheckBox();
            zipanel1 = new Panel();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            zipanel1.SuspendLayout();
            SuspendLayout();
            // 
            // All
            // 
            All.AutoSize = true;
            All.Location = new Point(324, 78);
            All.Name = "All";
            All.Size = new Size(72, 28);
            All.TabIndex = 0;
            All.Text = "全选";
            All.UseVisualStyleBackColor = true;
            // 
            // zipanel1
            // 
            zipanel1.Controls.Add(checkBox6);
            zipanel1.Controls.Add(checkBox5);
            zipanel1.Controls.Add(checkBox4);
            zipanel1.Controls.Add(checkBox3);
            zipanel1.Controls.Add(checkBox2);
            zipanel1.Location = new Point(366, 121);
            zipanel1.Name = "zipanel1";
            zipanel1.Size = new Size(185, 299);
            zipanel1.TabIndex = 1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(39, 20);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(90, 28);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "白切鸡";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(39, 72);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(126, 28);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "麻辣小龙虾";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(39, 125);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(108, 28);
            checkBox4.TabIndex = 2;
            checkBox4.Text = "黑椒牛排";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(39, 175);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(90, 28);
            checkBox5.TabIndex = 3;
            checkBox5.Text = "酸菜鱼";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(39, 225);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(108, 28);
            checkBox6.TabIndex = 4;
            checkBox6.Text = "花季时蔬";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 666);
            Controls.Add(zipanel1);
            Controls.Add(All);
            Name = "Form1";
            Text = "Form1";
            zipanel1.ResumeLayout(false);
            zipanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox All;
        private Panel zipanel1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox6;
    }
}
