namespace SIM800L_PHONE
{
    partial class Form_Phone
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Screen = new System.Windows.Forms.Panel();
            this.panel_Keyboard = new System.Windows.Forms.Panel();
            this.button_Dial = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_Screen.SuspendLayout();
            this.panel_Keyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Screen
            // 
            this.panel_Screen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Screen.Controls.Add(this.textBox1);
            this.panel_Screen.Location = new System.Drawing.Point(13, 13);
            this.panel_Screen.Name = "panel_Screen";
            this.panel_Screen.Size = new System.Drawing.Size(257, 150);
            this.panel_Screen.TabIndex = 0;
            // 
            // panel_Keyboard
            // 
            this.panel_Keyboard.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Keyboard.Controls.Add(this.button2);
            this.panel_Keyboard.Controls.Add(this.button_Dial);
            this.panel_Keyboard.Location = new System.Drawing.Point(13, 170);
            this.panel_Keyboard.Name = "panel_Keyboard";
            this.panel_Keyboard.Size = new System.Drawing.Size(257, 278);
            this.panel_Keyboard.TabIndex = 1;
            // 
            // button_Dial
            // 
            this.button_Dial.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Dial.Location = new System.Drawing.Point(4, 4);
            this.button_Dial.Name = "button_Dial";
            this.button_Dial.Size = new System.Drawing.Size(120, 60);
            this.button_Dial.TabIndex = 0;
            this.button_Dial.Text = "拨  号";
            this.button_Dial.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(129, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "挂  断";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 144);
            this.textBox1.TabIndex = 0;
            // 
            // Form_Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 460);
            this.Controls.Add(this.panel_Keyboard);
            this.Controls.Add(this.panel_Screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Phone";
            this.Text = "SIM800L上位机";
            this.panel_Screen.ResumeLayout(false);
            this.panel_Screen.PerformLayout();
            this.panel_Keyboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Screen;
        private System.Windows.Forms.Panel panel_Keyboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Dial;
        private System.Windows.Forms.TextBox textBox1;
    }
}

