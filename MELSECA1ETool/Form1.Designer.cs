namespace MELSECA1ETool
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_CheckConnect = new System.Windows.Forms.Button();
            this.btn_StopThreadRead = new System.Windows.Forms.Button();
            this.cb_ThreadReadOpen = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_IsNotUDWord = new System.Windows.Forms.CheckBox();
            this.cb_IsNotUWord = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_WriteDWord = new System.Windows.Forms.Button();
            this.btn_ReadDWord = new System.Windows.Forms.Button();
            this.tb_WriteDWordValue = new System.Windows.Forms.TextBox();
            this.tb_WriteDWordAddress = new System.Windows.Forms.TextBox();
            this.tb_ReadDWordLength = new System.Windows.Forms.TextBox();
            this.tb_ReadDWordAddress = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_WriteWord = new System.Windows.Forms.Button();
            this.btn_WriteBool = new System.Windows.Forms.Button();
            this.btn_ReadWord = new System.Windows.Forms.Button();
            this.tb_WriteWordValue = new System.Windows.Forms.TextBox();
            this.tb_WriteWordAddress = new System.Windows.Forms.TextBox();
            this.tb_WriteBoolValue = new System.Windows.Forms.TextBox();
            this.tb_WriteBoolAddress = new System.Windows.Forms.TextBox();
            this.tb_ReadWordLength = new System.Windows.Forms.TextBox();
            this.tb_ReadWordAddress = new System.Windows.Forms.TextBox();
            this.tb_ReadBoolLength = new System.Windows.Forms.TextBox();
            this.tb_ReadBoolAddress = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.btn_ReadBool = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(1218, 48);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(343, 850);
            this.listBox2.TabIndex = 78;
            // 
            // btn_CheckConnect
            // 
            this.btn_CheckConnect.Location = new System.Drawing.Point(711, 87);
            this.btn_CheckConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CheckConnect.Name = "btn_CheckConnect";
            this.btn_CheckConnect.Size = new System.Drawing.Size(140, 34);
            this.btn_CheckConnect.TabIndex = 77;
            this.btn_CheckConnect.Text = "连接测试";
            this.btn_CheckConnect.UseVisualStyleBackColor = true;
            this.btn_CheckConnect.Click += new System.EventHandler(this.btn_CheckConnect_Click);
            // 
            // btn_StopThreadRead
            // 
            this.btn_StopThreadRead.Location = new System.Drawing.Point(711, 536);
            this.btn_StopThreadRead.Margin = new System.Windows.Forms.Padding(4);
            this.btn_StopThreadRead.Name = "btn_StopThreadRead";
            this.btn_StopThreadRead.Size = new System.Drawing.Size(140, 34);
            this.btn_StopThreadRead.TabIndex = 76;
            this.btn_StopThreadRead.Text = "停止线程";
            this.btn_StopThreadRead.UseVisualStyleBackColor = true;
            this.btn_StopThreadRead.Click += new System.EventHandler(this.btn_StopThreadRead_Click);
            // 
            // cb_ThreadReadOpen
            // 
            this.cb_ThreadReadOpen.AutoSize = true;
            this.cb_ThreadReadOpen.Location = new System.Drawing.Point(612, 542);
            this.cb_ThreadReadOpen.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ThreadReadOpen.Name = "cb_ThreadReadOpen";
            this.cb_ThreadReadOpen.Size = new System.Drawing.Size(88, 22);
            this.cb_ThreadReadOpen.TabIndex = 75;
            this.cb_ThreadReadOpen.Text = "线程读";
            this.cb_ThreadReadOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_ThreadReadOpen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(27, 516);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(825, 2);
            this.label7.TabIndex = 74;
            this.label7.Text = "label7";
            // 
            // cb_IsNotUDWord
            // 
            this.cb_IsNotUDWord.AutoSize = true;
            this.cb_IsNotUDWord.Location = new System.Drawing.Point(400, 414);
            this.cb_IsNotUDWord.Margin = new System.Windows.Forms.Padding(4);
            this.cb_IsNotUDWord.Name = "cb_IsNotUDWord";
            this.cb_IsNotUDWord.Size = new System.Drawing.Size(88, 22);
            this.cb_IsNotUDWord.TabIndex = 73;
            this.cb_IsNotUDWord.Text = "有符号";
            this.cb_IsNotUDWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_IsNotUDWord.UseVisualStyleBackColor = true;
            // 
            // cb_IsNotUWord
            // 
            this.cb_IsNotUWord.AutoSize = true;
            this.cb_IsNotUWord.Location = new System.Drawing.Point(400, 288);
            this.cb_IsNotUWord.Margin = new System.Windows.Forms.Padding(4);
            this.cb_IsNotUWord.Name = "cb_IsNotUWord";
            this.cb_IsNotUWord.Size = new System.Drawing.Size(88, 22);
            this.cb_IsNotUWord.TabIndex = 72;
            this.cb_IsNotUWord.Text = "有符号";
            this.cb_IsNotUWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_IsNotUWord.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 69;
            this.label5.Text = "端口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 68;
            this.label4.Text = "IP";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(30, 390);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(825, 2);
            this.label3.TabIndex = 67;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(30, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(825, 2);
            this.label2.TabIndex = 66;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(30, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(825, 2);
            this.label1.TabIndex = 65;
            this.label1.Text = "label1";
            // 
            // btn_WriteDWord
            // 
            this.btn_WriteDWord.Location = new System.Drawing.Point(711, 466);
            this.btn_WriteDWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_WriteDWord.Name = "btn_WriteDWord";
            this.btn_WriteDWord.Size = new System.Drawing.Size(140, 34);
            this.btn_WriteDWord.TabIndex = 64;
            this.btn_WriteDWord.Text = "写入DWord(32)";
            this.btn_WriteDWord.UseVisualStyleBackColor = true;
            this.btn_WriteDWord.Click += new System.EventHandler(this.btn_WriteDWord_Click);
            // 
            // btn_ReadDWord
            // 
            this.btn_ReadDWord.Location = new System.Drawing.Point(711, 410);
            this.btn_ReadDWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ReadDWord.Name = "btn_ReadDWord";
            this.btn_ReadDWord.Size = new System.Drawing.Size(140, 34);
            this.btn_ReadDWord.TabIndex = 63;
            this.btn_ReadDWord.Text = "读取DWord(32)";
            this.btn_ReadDWord.UseVisualStyleBackColor = true;
            this.btn_ReadDWord.Click += new System.EventHandler(this.btn_ReadDWord_Click);
            // 
            // tb_WriteDWordValue
            // 
            this.tb_WriteDWordValue.Location = new System.Drawing.Point(214, 466);
            this.tb_WriteDWordValue.Margin = new System.Windows.Forms.Padding(4);
            this.tb_WriteDWordValue.Name = "tb_WriteDWordValue";
            this.tb_WriteDWordValue.Size = new System.Drawing.Size(466, 28);
            this.tb_WriteDWordValue.TabIndex = 62;
            // 
            // tb_WriteDWordAddress
            // 
            this.tb_WriteDWordAddress.Location = new System.Drawing.Point(30, 466);
            this.tb_WriteDWordAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tb_WriteDWordAddress.Name = "tb_WriteDWordAddress";
            this.tb_WriteDWordAddress.Size = new System.Drawing.Size(148, 28);
            this.tb_WriteDWordAddress.TabIndex = 61;
            this.tb_WriteDWordAddress.Text = "d100";
            // 
            // tb_ReadDWordLength
            // 
            this.tb_ReadDWordLength.Location = new System.Drawing.Point(214, 410);
            this.tb_ReadDWordLength.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ReadDWordLength.Name = "tb_ReadDWordLength";
            this.tb_ReadDWordLength.Size = new System.Drawing.Size(148, 28);
            this.tb_ReadDWordLength.TabIndex = 60;
            // 
            // tb_ReadDWordAddress
            // 
            this.tb_ReadDWordAddress.Location = new System.Drawing.Point(30, 410);
            this.tb_ReadDWordAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ReadDWordAddress.Name = "tb_ReadDWordAddress";
            this.tb_ReadDWordAddress.Size = new System.Drawing.Size(148, 28);
            this.tb_ReadDWordAddress.TabIndex = 59;
            this.tb_ReadDWordAddress.Text = "d100";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(864, 48);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 850);
            this.listBox1.TabIndex = 58;
            // 
            // btn_WriteWord
            // 
            this.btn_WriteWord.Location = new System.Drawing.Point(711, 340);
            this.btn_WriteWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_WriteWord.Name = "btn_WriteWord";
            this.btn_WriteWord.Size = new System.Drawing.Size(140, 34);
            this.btn_WriteWord.TabIndex = 57;
            this.btn_WriteWord.Text = "写入Word(16)";
            this.btn_WriteWord.UseVisualStyleBackColor = true;
            this.btn_WriteWord.Click += new System.EventHandler(this.btn_WriteWord_Click);
            // 
            // btn_WriteBool
            // 
            this.btn_WriteBool.Location = new System.Drawing.Point(711, 206);
            this.btn_WriteBool.Margin = new System.Windows.Forms.Padding(4);
            this.btn_WriteBool.Name = "btn_WriteBool";
            this.btn_WriteBool.Size = new System.Drawing.Size(140, 34);
            this.btn_WriteBool.TabIndex = 56;
            this.btn_WriteBool.Text = "写入bool";
            this.btn_WriteBool.UseVisualStyleBackColor = true;
            this.btn_WriteBool.Click += new System.EventHandler(this.btn_WriteBool_Click);
            // 
            // btn_ReadWord
            // 
            this.btn_ReadWord.Location = new System.Drawing.Point(711, 284);
            this.btn_ReadWord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ReadWord.Name = "btn_ReadWord";
            this.btn_ReadWord.Size = new System.Drawing.Size(140, 34);
            this.btn_ReadWord.TabIndex = 55;
            this.btn_ReadWord.Text = "读取Word(16)";
            this.btn_ReadWord.UseVisualStyleBackColor = true;
            this.btn_ReadWord.Click += new System.EventHandler(this.btn_ReadWord_Click);
            // 
            // tb_WriteWordValue
            // 
            this.tb_WriteWordValue.Location = new System.Drawing.Point(214, 340);
            this.tb_WriteWordValue.Margin = new System.Windows.Forms.Padding(4);
            this.tb_WriteWordValue.Name = "tb_WriteWordValue";
            this.tb_WriteWordValue.Size = new System.Drawing.Size(466, 28);
            this.tb_WriteWordValue.TabIndex = 54;
            // 
            // tb_WriteWordAddress
            // 
            this.tb_WriteWordAddress.Location = new System.Drawing.Point(30, 340);
            this.tb_WriteWordAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tb_WriteWordAddress.Name = "tb_WriteWordAddress";
            this.tb_WriteWordAddress.Size = new System.Drawing.Size(148, 28);
            this.tb_WriteWordAddress.TabIndex = 53;
            this.tb_WriteWordAddress.Text = "d100";
            // 
            // tb_WriteBoolValue
            // 
            this.tb_WriteBoolValue.Location = new System.Drawing.Point(214, 206);
            this.tb_WriteBoolValue.Margin = new System.Windows.Forms.Padding(4);
            this.tb_WriteBoolValue.Name = "tb_WriteBoolValue";
            this.tb_WriteBoolValue.Size = new System.Drawing.Size(466, 28);
            this.tb_WriteBoolValue.TabIndex = 52;
            // 
            // tb_WriteBoolAddress
            // 
            this.tb_WriteBoolAddress.Location = new System.Drawing.Point(30, 206);
            this.tb_WriteBoolAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tb_WriteBoolAddress.Name = "tb_WriteBoolAddress";
            this.tb_WriteBoolAddress.Size = new System.Drawing.Size(148, 28);
            this.tb_WriteBoolAddress.TabIndex = 51;
            this.tb_WriteBoolAddress.Text = "d100";
            // 
            // tb_ReadWordLength
            // 
            this.tb_ReadWordLength.Location = new System.Drawing.Point(214, 284);
            this.tb_ReadWordLength.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ReadWordLength.Name = "tb_ReadWordLength";
            this.tb_ReadWordLength.Size = new System.Drawing.Size(148, 28);
            this.tb_ReadWordLength.TabIndex = 50;
            // 
            // tb_ReadWordAddress
            // 
            this.tb_ReadWordAddress.Location = new System.Drawing.Point(30, 284);
            this.tb_ReadWordAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ReadWordAddress.Name = "tb_ReadWordAddress";
            this.tb_ReadWordAddress.Size = new System.Drawing.Size(148, 28);
            this.tb_ReadWordAddress.TabIndex = 49;
            this.tb_ReadWordAddress.Text = "d100";
            // 
            // tb_ReadBoolLength
            // 
            this.tb_ReadBoolLength.Enabled = false;
            this.tb_ReadBoolLength.Location = new System.Drawing.Point(214, 148);
            this.tb_ReadBoolLength.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ReadBoolLength.Name = "tb_ReadBoolLength";
            this.tb_ReadBoolLength.Size = new System.Drawing.Size(148, 28);
            this.tb_ReadBoolLength.TabIndex = 48;
            // 
            // tb_ReadBoolAddress
            // 
            this.tb_ReadBoolAddress.Location = new System.Drawing.Point(30, 148);
            this.tb_ReadBoolAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ReadBoolAddress.Name = "tb_ReadBoolAddress";
            this.tb_ReadBoolAddress.Size = new System.Drawing.Size(148, 28);
            this.tb_ReadBoolAddress.TabIndex = 47;
            this.tb_ReadBoolAddress.Text = "d100";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(214, 51);
            this.tb_port.Margin = new System.Windows.Forms.Padding(4);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(148, 28);
            this.tb_port.TabIndex = 46;
            this.tb_port.Text = "6000";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(30, 51);
            this.tb_ip.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(148, 28);
            this.tb_ip.TabIndex = 45;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // btn_ReadBool
            // 
            this.btn_ReadBool.Location = new System.Drawing.Point(711, 148);
            this.btn_ReadBool.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ReadBool.Name = "btn_ReadBool";
            this.btn_ReadBool.Size = new System.Drawing.Size(140, 34);
            this.btn_ReadBool.TabIndex = 44;
            this.btn_ReadBool.Text = "读取bool";
            this.btn_ReadBool.UseVisualStyleBackColor = true;
            this.btn_ReadBool.Click += new System.EventHandler(this.btn_ReadBool_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(711, 48);
            this.connect.Margin = new System.Windows.Forms.Padding(4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(140, 34);
            this.connect.TabIndex = 43;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 927);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_CheckConnect);
            this.Controls.Add(this.btn_StopThreadRead);
            this.Controls.Add(this.cb_ThreadReadOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_IsNotUDWord);
            this.Controls.Add(this.cb_IsNotUWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_WriteDWord);
            this.Controls.Add(this.btn_ReadDWord);
            this.Controls.Add(this.tb_WriteDWordValue);
            this.Controls.Add(this.tb_WriteDWordAddress);
            this.Controls.Add(this.tb_ReadDWordLength);
            this.Controls.Add(this.tb_ReadDWordAddress);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_WriteWord);
            this.Controls.Add(this.btn_WriteBool);
            this.Controls.Add(this.btn_ReadWord);
            this.Controls.Add(this.tb_WriteWordValue);
            this.Controls.Add(this.tb_WriteWordAddress);
            this.Controls.Add(this.tb_WriteBoolValue);
            this.Controls.Add(this.tb_WriteBoolAddress);
            this.Controls.Add(this.tb_ReadWordLength);
            this.Controls.Add(this.tb_ReadWordAddress);
            this.Controls.Add(this.tb_ReadBoolLength);
            this.Controls.Add(this.tb_ReadBoolAddress);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.btn_ReadBool);
            this.Controls.Add(this.connect);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_CheckConnect;
        private System.Windows.Forms.Button btn_StopThreadRead;
        private System.Windows.Forms.CheckBox cb_ThreadReadOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_IsNotUDWord;
        private System.Windows.Forms.CheckBox cb_IsNotUWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_WriteDWord;
        private System.Windows.Forms.Button btn_ReadDWord;
        private System.Windows.Forms.TextBox tb_WriteDWordValue;
        private System.Windows.Forms.TextBox tb_WriteDWordAddress;
        private System.Windows.Forms.TextBox tb_ReadDWordLength;
        private System.Windows.Forms.TextBox tb_ReadDWordAddress;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_WriteWord;
        private System.Windows.Forms.Button btn_WriteBool;
        private System.Windows.Forms.Button btn_ReadWord;
        private System.Windows.Forms.TextBox tb_WriteWordValue;
        private System.Windows.Forms.TextBox tb_WriteWordAddress;
        private System.Windows.Forms.TextBox tb_WriteBoolValue;
        private System.Windows.Forms.TextBox tb_WriteBoolAddress;
        private System.Windows.Forms.TextBox tb_ReadWordLength;
        private System.Windows.Forms.TextBox tb_ReadWordAddress;
        private System.Windows.Forms.TextBox tb_ReadBoolLength;
        private System.Windows.Forms.TextBox tb_ReadBoolAddress;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Button btn_ReadBool;
        private System.Windows.Forms.Button connect;
    }
}

