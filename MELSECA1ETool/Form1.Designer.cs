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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_WriteString = new System.Windows.Forms.Button();
            this.btn_ReadString = new System.Windows.Forms.Button();
            this.tb_WriteStringValue = new System.Windows.Forms.TextBox();
            this.tb_WriteStringAddress = new System.Windows.Forms.TextBox();
            this.tb_ReadStringLength = new System.Windows.Forms.TextBox();
            this.tb_ReadStringAddress = new System.Windows.Forms.TextBox();
            this.cb_DoubleThreadTest = new System.Windows.Forms.CheckBox();
            this.p_BoolContorl = new System.Windows.Forms.Panel();
            this.p_Int16Contorl = new System.Windows.Forms.Panel();
            this.p_Int32Contorl = new System.Windows.Forms.Panel();
            this.p_StringContorl = new System.Windows.Forms.Panel();
            this.p_BoolContorl.SuspendLayout();
            this.p_Int16Contorl.SuspendLayout();
            this.p_Int32Contorl.SuspendLayout();
            this.p_StringContorl.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(809, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(230, 568);
            this.listBox2.TabIndex = 78;
            // 
            // btn_StopThreadRead
            // 
            this.btn_StopThreadRead.Location = new System.Drawing.Point(465, 551);
            this.btn_StopThreadRead.Name = "btn_StopThreadRead";
            this.btn_StopThreadRead.Size = new System.Drawing.Size(93, 23);
            this.btn_StopThreadRead.TabIndex = 76;
            this.btn_StopThreadRead.Text = "停止线程";
            this.btn_StopThreadRead.UseVisualStyleBackColor = true;
            this.btn_StopThreadRead.Click += new System.EventHandler(this.btn_StopThreadRead_Click);
            // 
            // cb_ThreadReadOpen
            // 
            this.cb_ThreadReadOpen.AutoSize = true;
            this.cb_ThreadReadOpen.Location = new System.Drawing.Point(297, 554);
            this.cb_ThreadReadOpen.Name = "cb_ThreadReadOpen";
            this.cb_ThreadReadOpen.Size = new System.Drawing.Size(60, 16);
            this.cb_ThreadReadOpen.TabIndex = 75;
            this.cb_ThreadReadOpen.Text = "线程读";
            this.cb_ThreadReadOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_ThreadReadOpen.UseVisualStyleBackColor = true;
            this.cb_ThreadReadOpen.CheckedChanged += new System.EventHandler(this.cb_ThreadReadOpen_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(9, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(550, 1);
            this.label7.TabIndex = 74;
            this.label7.Text = "label7";
            // 
            // cb_IsNotUDWord
            // 
            this.cb_IsNotUDWord.AutoSize = true;
            this.cb_IsNotUDWord.Location = new System.Drawing.Point(250, 15);
            this.cb_IsNotUDWord.Name = "cb_IsNotUDWord";
            this.cb_IsNotUDWord.Size = new System.Drawing.Size(60, 16);
            this.cb_IsNotUDWord.TabIndex = 73;
            this.cb_IsNotUDWord.Text = "有符号";
            this.cb_IsNotUDWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_IsNotUDWord.UseVisualStyleBackColor = true;
            // 
            // cb_IsNotUWord
            // 
            this.cb_IsNotUWord.AutoSize = true;
            this.cb_IsNotUWord.Location = new System.Drawing.Point(250, 14);
            this.cb_IsNotUWord.Name = "cb_IsNotUWord";
            this.cb_IsNotUWord.Size = new System.Drawing.Size(60, 16);
            this.cb_IsNotUWord.TabIndex = 72;
            this.cb_IsNotUWord.Text = "有符号";
            this.cb_IsNotUWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_IsNotUWord.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 69;
            this.label5.Text = "端口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 68;
            this.label4.Text = "IP";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(11, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 1);
            this.label3.TabIndex = 67;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(11, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 1);
            this.label2.TabIndex = 66;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 1);
            this.label1.TabIndex = 65;
            this.label1.Text = "label1";
            // 
            // btn_WriteDWord
            // 
            this.btn_WriteDWord.Enabled = false;
            this.btn_WriteDWord.Location = new System.Drawing.Point(457, 50);
            this.btn_WriteDWord.Name = "btn_WriteDWord";
            this.btn_WriteDWord.Size = new System.Drawing.Size(93, 23);
            this.btn_WriteDWord.TabIndex = 64;
            this.btn_WriteDWord.Text = "写入DWord(32)";
            this.btn_WriteDWord.UseVisualStyleBackColor = true;
            this.btn_WriteDWord.Click += new System.EventHandler(this.btn_WriteDWord_Click);
            // 
            // btn_ReadDWord
            // 
            this.btn_ReadDWord.Enabled = false;
            this.btn_ReadDWord.Location = new System.Drawing.Point(457, 12);
            this.btn_ReadDWord.Name = "btn_ReadDWord";
            this.btn_ReadDWord.Size = new System.Drawing.Size(93, 23);
            this.btn_ReadDWord.TabIndex = 63;
            this.btn_ReadDWord.Text = "读取DWord(32)";
            this.btn_ReadDWord.UseVisualStyleBackColor = true;
            this.btn_ReadDWord.Click += new System.EventHandler(this.btn_ReadDWord_Click);
            // 
            // tb_WriteDWordValue
            // 
            this.tb_WriteDWordValue.Location = new System.Drawing.Point(126, 50);
            this.tb_WriteDWordValue.Name = "tb_WriteDWordValue";
            this.tb_WriteDWordValue.Size = new System.Drawing.Size(312, 21);
            this.tb_WriteDWordValue.TabIndex = 62;
            // 
            // tb_WriteDWordAddress
            // 
            this.tb_WriteDWordAddress.Location = new System.Drawing.Point(3, 50);
            this.tb_WriteDWordAddress.Name = "tb_WriteDWordAddress";
            this.tb_WriteDWordAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_WriteDWordAddress.TabIndex = 61;
            this.tb_WriteDWordAddress.Text = "D100";
            // 
            // tb_ReadDWordLength
            // 
            this.tb_ReadDWordLength.Location = new System.Drawing.Point(126, 12);
            this.tb_ReadDWordLength.Name = "tb_ReadDWordLength";
            this.tb_ReadDWordLength.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadDWordLength.TabIndex = 60;
            // 
            // tb_ReadDWordAddress
            // 
            this.tb_ReadDWordAddress.Location = new System.Drawing.Point(3, 12);
            this.tb_ReadDWordAddress.Name = "tb_ReadDWordAddress";
            this.tb_ReadDWordAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadDWordAddress.TabIndex = 59;
            this.tb_ReadDWordAddress.Text = "D100";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(573, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 568);
            this.listBox1.TabIndex = 58;
            // 
            // btn_WriteWord
            // 
            this.btn_WriteWord.Enabled = false;
            this.btn_WriteWord.Location = new System.Drawing.Point(457, 49);
            this.btn_WriteWord.Name = "btn_WriteWord";
            this.btn_WriteWord.Size = new System.Drawing.Size(93, 23);
            this.btn_WriteWord.TabIndex = 57;
            this.btn_WriteWord.Text = "写入Word(16)";
            this.btn_WriteWord.UseVisualStyleBackColor = true;
            this.btn_WriteWord.Click += new System.EventHandler(this.btn_WriteWord_Click);
            // 
            // btn_WriteBool
            // 
            this.btn_WriteBool.Location = new System.Drawing.Point(457, 50);
            this.btn_WriteBool.Name = "btn_WriteBool";
            this.btn_WriteBool.Size = new System.Drawing.Size(93, 23);
            this.btn_WriteBool.TabIndex = 56;
            this.btn_WriteBool.Text = "写入bool";
            this.btn_WriteBool.UseVisualStyleBackColor = true;
            this.btn_WriteBool.Click += new System.EventHandler(this.btn_WriteBool_Click);
            // 
            // btn_ReadWord
            // 
            this.btn_ReadWord.Enabled = false;
            this.btn_ReadWord.Location = new System.Drawing.Point(457, 11);
            this.btn_ReadWord.Name = "btn_ReadWord";
            this.btn_ReadWord.Size = new System.Drawing.Size(93, 23);
            this.btn_ReadWord.TabIndex = 55;
            this.btn_ReadWord.Text = "读取Word(16)";
            this.btn_ReadWord.UseVisualStyleBackColor = true;
            this.btn_ReadWord.Click += new System.EventHandler(this.btn_ReadWord_Click);
            // 
            // tb_WriteWordValue
            // 
            this.tb_WriteWordValue.Location = new System.Drawing.Point(126, 49);
            this.tb_WriteWordValue.Name = "tb_WriteWordValue";
            this.tb_WriteWordValue.Size = new System.Drawing.Size(312, 21);
            this.tb_WriteWordValue.TabIndex = 54;
            // 
            // tb_WriteWordAddress
            // 
            this.tb_WriteWordAddress.Location = new System.Drawing.Point(3, 49);
            this.tb_WriteWordAddress.Name = "tb_WriteWordAddress";
            this.tb_WriteWordAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_WriteWordAddress.TabIndex = 53;
            this.tb_WriteWordAddress.Text = "D100";
            // 
            // tb_WriteBoolValue
            // 
            this.tb_WriteBoolValue.Location = new System.Drawing.Point(126, 50);
            this.tb_WriteBoolValue.Name = "tb_WriteBoolValue";
            this.tb_WriteBoolValue.Size = new System.Drawing.Size(312, 21);
            this.tb_WriteBoolValue.TabIndex = 52;
            this.tb_WriteBoolValue.TextChanged += new System.EventHandler(this.tb_WriteBoolValue_TextChanged);
            // 
            // tb_WriteBoolAddress
            // 
            this.tb_WriteBoolAddress.Location = new System.Drawing.Point(3, 50);
            this.tb_WriteBoolAddress.Name = "tb_WriteBoolAddress";
            this.tb_WriteBoolAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_WriteBoolAddress.TabIndex = 51;
            this.tb_WriteBoolAddress.Text = "m100";
            this.tb_WriteBoolAddress.TextChanged += new System.EventHandler(this.tb_WriteBoolAddress_TextChanged);
            // 
            // tb_ReadWordLength
            // 
            this.tb_ReadWordLength.Location = new System.Drawing.Point(126, 11);
            this.tb_ReadWordLength.Name = "tb_ReadWordLength";
            this.tb_ReadWordLength.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadWordLength.TabIndex = 50;
            // 
            // tb_ReadWordAddress
            // 
            this.tb_ReadWordAddress.Location = new System.Drawing.Point(3, 11);
            this.tb_ReadWordAddress.Name = "tb_ReadWordAddress";
            this.tb_ReadWordAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadWordAddress.TabIndex = 49;
            this.tb_ReadWordAddress.Text = "D100";
            // 
            // tb_ReadBoolLength
            // 
            this.tb_ReadBoolLength.Location = new System.Drawing.Point(126, 12);
            this.tb_ReadBoolLength.Name = "tb_ReadBoolLength";
            this.tb_ReadBoolLength.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadBoolLength.TabIndex = 48;
            this.tb_ReadBoolLength.TextChanged += new System.EventHandler(this.tb_ReadBoolLength_TextChanged);
            // 
            // tb_ReadBoolAddress
            // 
            this.tb_ReadBoolAddress.Location = new System.Drawing.Point(3, 12);
            this.tb_ReadBoolAddress.Name = "tb_ReadBoolAddress";
            this.tb_ReadBoolAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadBoolAddress.TabIndex = 47;
            this.tb_ReadBoolAddress.Text = "m100";
            this.tb_ReadBoolAddress.TextChanged += new System.EventHandler(this.tb_ReadBoolAddress_TextChanged);
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(135, 69);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 21);
            this.tb_port.TabIndex = 46;
            this.tb_port.Text = "6000";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(12, 69);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(100, 21);
            this.tb_ip.TabIndex = 45;
            this.tb_ip.Text = "127.0.0.1";
            // 
            // btn_ReadBool
            // 
            this.btn_ReadBool.Location = new System.Drawing.Point(457, 12);
            this.btn_ReadBool.Name = "btn_ReadBool";
            this.btn_ReadBool.Size = new System.Drawing.Size(93, 23);
            this.btn_ReadBool.TabIndex = 44;
            this.btn_ReadBool.Text = "读取bool";
            this.btn_ReadBool.UseVisualStyleBackColor = true;
            this.btn_ReadBool.Click += new System.EventHandler(this.btn_ReadBool_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(465, 68);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(93, 23);
            this.connect.TabIndex = 43;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(9, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(550, 1);
            this.label6.TabIndex = 86;
            this.label6.Text = "label6";
            // 
            // btn_WriteString
            // 
            this.btn_WriteString.Enabled = false;
            this.btn_WriteString.Location = new System.Drawing.Point(457, 51);
            this.btn_WriteString.Name = "btn_WriteString";
            this.btn_WriteString.Size = new System.Drawing.Size(93, 23);
            this.btn_WriteString.TabIndex = 84;
            this.btn_WriteString.Text = "写入字符串";
            this.btn_WriteString.UseVisualStyleBackColor = true;
            this.btn_WriteString.Click += new System.EventHandler(this.btn_WriteString_Click);
            // 
            // btn_ReadString
            // 
            this.btn_ReadString.Enabled = false;
            this.btn_ReadString.Location = new System.Drawing.Point(457, 14);
            this.btn_ReadString.Name = "btn_ReadString";
            this.btn_ReadString.Size = new System.Drawing.Size(93, 23);
            this.btn_ReadString.TabIndex = 83;
            this.btn_ReadString.Text = "读取字符串";
            this.btn_ReadString.UseVisualStyleBackColor = true;
            this.btn_ReadString.Click += new System.EventHandler(this.btn_ReadString_Click);
            // 
            // tb_WriteStringValue
            // 
            this.tb_WriteStringValue.Location = new System.Drawing.Point(126, 51);
            this.tb_WriteStringValue.Name = "tb_WriteStringValue";
            this.tb_WriteStringValue.Size = new System.Drawing.Size(312, 21);
            this.tb_WriteStringValue.TabIndex = 82;
            // 
            // tb_WriteStringAddress
            // 
            this.tb_WriteStringAddress.Location = new System.Drawing.Point(3, 51);
            this.tb_WriteStringAddress.Name = "tb_WriteStringAddress";
            this.tb_WriteStringAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_WriteStringAddress.TabIndex = 81;
            this.tb_WriteStringAddress.Text = "D100";
            // 
            // tb_ReadStringLength
            // 
            this.tb_ReadStringLength.Location = new System.Drawing.Point(126, 14);
            this.tb_ReadStringLength.Name = "tb_ReadStringLength";
            this.tb_ReadStringLength.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadStringLength.TabIndex = 80;
            // 
            // tb_ReadStringAddress
            // 
            this.tb_ReadStringAddress.Location = new System.Drawing.Point(3, 14);
            this.tb_ReadStringAddress.Name = "tb_ReadStringAddress";
            this.tb_ReadStringAddress.Size = new System.Drawing.Size(100, 21);
            this.tb_ReadStringAddress.TabIndex = 79;
            this.tb_ReadStringAddress.Text = "D100";
            // 
            // cb_DoubleThreadTest
            // 
            this.cb_DoubleThreadTest.AutoSize = true;
            this.cb_DoubleThreadTest.Location = new System.Drawing.Point(365, 554);
            this.cb_DoubleThreadTest.Name = "cb_DoubleThreadTest";
            this.cb_DoubleThreadTest.Size = new System.Drawing.Size(96, 16);
            this.cb_DoubleThreadTest.TabIndex = 87;
            this.cb_DoubleThreadTest.Text = "双线程读测试";
            this.cb_DoubleThreadTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_DoubleThreadTest.UseVisualStyleBackColor = true;
            this.cb_DoubleThreadTest.CheckedChanged += new System.EventHandler(this.cb_DoubleThreadTest_CheckedChanged);
            // 
            // p_BoolContorl
            // 
            this.p_BoolContorl.Controls.Add(this.tb_ReadBoolAddress);
            this.p_BoolContorl.Controls.Add(this.btn_ReadBool);
            this.p_BoolContorl.Controls.Add(this.tb_ReadBoolLength);
            this.p_BoolContorl.Controls.Add(this.tb_WriteBoolAddress);
            this.p_BoolContorl.Controls.Add(this.tb_WriteBoolValue);
            this.p_BoolContorl.Controls.Add(this.btn_WriteBool);
            this.p_BoolContorl.Location = new System.Drawing.Point(9, 109);
            this.p_BoolContorl.Name = "p_BoolContorl";
            this.p_BoolContorl.Size = new System.Drawing.Size(558, 83);
            this.p_BoolContorl.TabIndex = 88;
            // 
            // p_Int16Contorl
            // 
            this.p_Int16Contorl.Controls.Add(this.tb_ReadWordAddress);
            this.p_Int16Contorl.Controls.Add(this.tb_ReadWordLength);
            this.p_Int16Contorl.Controls.Add(this.tb_WriteWordAddress);
            this.p_Int16Contorl.Controls.Add(this.tb_WriteWordValue);
            this.p_Int16Contorl.Controls.Add(this.btn_ReadWord);
            this.p_Int16Contorl.Controls.Add(this.btn_WriteWord);
            this.p_Int16Contorl.Controls.Add(this.cb_IsNotUWord);
            this.p_Int16Contorl.Location = new System.Drawing.Point(9, 199);
            this.p_Int16Contorl.Name = "p_Int16Contorl";
            this.p_Int16Contorl.Size = new System.Drawing.Size(558, 83);
            this.p_Int16Contorl.TabIndex = 89;
            // 
            // p_Int32Contorl
            // 
            this.p_Int32Contorl.Controls.Add(this.tb_ReadDWordAddress);
            this.p_Int32Contorl.Controls.Add(this.tb_ReadDWordLength);
            this.p_Int32Contorl.Controls.Add(this.tb_WriteDWordAddress);
            this.p_Int32Contorl.Controls.Add(this.tb_WriteDWordValue);
            this.p_Int32Contorl.Controls.Add(this.btn_ReadDWord);
            this.p_Int32Contorl.Controls.Add(this.btn_WriteDWord);
            this.p_Int32Contorl.Controls.Add(this.cb_IsNotUDWord);
            this.p_Int32Contorl.Location = new System.Drawing.Point(9, 289);
            this.p_Int32Contorl.Name = "p_Int32Contorl";
            this.p_Int32Contorl.Size = new System.Drawing.Size(558, 83);
            this.p_Int32Contorl.TabIndex = 90;
            // 
            // p_StringContorl
            // 
            this.p_StringContorl.Controls.Add(this.tb_ReadStringAddress);
            this.p_StringContorl.Controls.Add(this.tb_ReadStringLength);
            this.p_StringContorl.Controls.Add(this.tb_WriteStringAddress);
            this.p_StringContorl.Controls.Add(this.tb_WriteStringValue);
            this.p_StringContorl.Controls.Add(this.btn_ReadString);
            this.p_StringContorl.Controls.Add(this.btn_WriteString);
            this.p_StringContorl.Location = new System.Drawing.Point(9, 379);
            this.p_StringContorl.Name = "p_StringContorl";
            this.p_StringContorl.Size = new System.Drawing.Size(558, 83);
            this.p_StringContorl.TabIndex = 91;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 589);
            this.Controls.Add(this.p_StringContorl);
            this.Controls.Add(this.p_Int32Contorl);
            this.Controls.Add(this.p_Int16Contorl);
            this.Controls.Add(this.p_BoolContorl);
            this.Controls.Add(this.cb_DoubleThreadTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_StopThreadRead);
            this.Controls.Add(this.cb_ThreadReadOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.p_BoolContorl.ResumeLayout(false);
            this.p_BoolContorl.PerformLayout();
            this.p_Int16Contorl.ResumeLayout(false);
            this.p_Int16Contorl.PerformLayout();
            this.p_Int32Contorl.ResumeLayout(false);
            this.p_Int32Contorl.PerformLayout();
            this.p_StringContorl.ResumeLayout(false);
            this.p_StringContorl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_WriteString;
        private System.Windows.Forms.Button btn_ReadString;
        private System.Windows.Forms.TextBox tb_WriteStringValue;
        private System.Windows.Forms.TextBox tb_WriteStringAddress;
        private System.Windows.Forms.TextBox tb_ReadStringLength;
        private System.Windows.Forms.TextBox tb_ReadStringAddress;
        private System.Windows.Forms.CheckBox cb_DoubleThreadTest;
        private System.Windows.Forms.Panel p_BoolContorl;
        private System.Windows.Forms.Panel p_Int16Contorl;
        private System.Windows.Forms.Panel p_Int32Contorl;
        private System.Windows.Forms.Panel p_StringContorl;
    }
}

