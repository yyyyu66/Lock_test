namespace Logon
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button_OpenGoldenSerial = new System.Windows.Forms.Button();
            this.button_OpenTestSerial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Golden = new System.Windows.Forms.ComboBox();
            this.comboBox_Test = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.button_ChooseType = new System.Windows.Forms.Button();
            this.button_BLETest = new System.Windows.Forms.Button();
            this.groupBox_SerialInfo = new System.Windows.Forms.GroupBox();
            this.button_OpenScaner = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_Scaner = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_BLE = new System.Windows.Forms.TextBox();
            this.textBox_Burn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_BurnTest = new System.Windows.Forms.Button();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.button_ChooseFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ShowUser = new System.Windows.Forms.TextBox();
            this.groupBox_UserInfo = new System.Windows.Forms.GroupBox();
            this.button_ExitMain = new System.Windows.Forms.Button();
            this.label_Time = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_SN = new System.Windows.Forms.Label();
            this.textBox_SN = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_MAC = new System.Windows.Forms.Label();
            this.textBox_MAC = new System.Windows.Forms.TextBox();
            this.groupBox5_TestInfo = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SelfTest_Time = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_TestState = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_NB = new System.Windows.Forms.TextBox();
            this.textBox_IL005 = new System.Windows.Forms.TextBox();
            this.textBox_CardReader = new System.Windows.Forms.TextBox();
            this.textBox_TSM12 = new System.Windows.Forms.TextBox();
            this.textBox_PCA9555 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_mes = new System.Windows.Forms.Label();
            this.richTextBox_MES = new System.Windows.Forms.RichTextBox();
            this.timer_TestTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox_SerialInfo.SuspendLayout();
            this.groupBox_UserInfo.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5_TestInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OpenGoldenSerial
            // 
            this.button_OpenGoldenSerial.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OpenGoldenSerial.Location = new System.Drawing.Point(224, 30);
            this.button_OpenGoldenSerial.Name = "button_OpenGoldenSerial";
            this.button_OpenGoldenSerial.Size = new System.Drawing.Size(87, 27);
            this.button_OpenGoldenSerial.TabIndex = 0;
            this.button_OpenGoldenSerial.Text = "打开";
            this.button_OpenGoldenSerial.UseVisualStyleBackColor = true;
            this.button_OpenGoldenSerial.Click += new System.EventHandler(this.button_OpenGoldenSerial_Click);
            // 
            // button_OpenTestSerial
            // 
            this.button_OpenTestSerial.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OpenTestSerial.Location = new System.Drawing.Point(224, 68);
            this.button_OpenTestSerial.Name = "button_OpenTestSerial";
            this.button_OpenTestSerial.Size = new System.Drawing.Size(87, 27);
            this.button_OpenTestSerial.TabIndex = 1;
            this.button_OpenTestSerial.Text = "打开";
            this.button_OpenTestSerial.UseVisualStyleBackColor = true;
            this.button_OpenTestSerial.Click += new System.EventHandler(this.button_OpenTestSerial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "金板串口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "测试串口";
            // 
            // comboBox_Golden
            // 
            this.comboBox_Golden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Golden.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Golden.FormattingEnabled = true;
            this.comboBox_Golden.Location = new System.Drawing.Point(98, 30);
            this.comboBox_Golden.Name = "comboBox_Golden";
            this.comboBox_Golden.Size = new System.Drawing.Size(107, 27);
            this.comboBox_Golden.TabIndex = 4;
            // 
            // comboBox_Test
            // 
            this.comboBox_Test.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Test.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Test.FormattingEnabled = true;
            this.comboBox_Test.Location = new System.Drawing.Point(98, 68);
            this.comboBox_Test.Name = "comboBox_Test";
            this.comboBox_Test.Size = new System.Drawing.Size(107, 27);
            this.comboBox_Test.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "产品类型";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(98, 148);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(107, 27);
            this.comboBox_Type.TabIndex = 7;
            // 
            // button_ChooseType
            // 
            this.button_ChooseType.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ChooseType.Location = new System.Drawing.Point(224, 148);
            this.button_ChooseType.Name = "button_ChooseType";
            this.button_ChooseType.Size = new System.Drawing.Size(87, 27);
            this.button_ChooseType.TabIndex = 8;
            this.button_ChooseType.Text = "选择";
            this.button_ChooseType.UseVisualStyleBackColor = true;
            this.button_ChooseType.Click += new System.EventHandler(this.button_ChooseType_Click);
            // 
            // button_BLETest
            // 
            this.button_BLETest.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_BLETest.Location = new System.Drawing.Point(12, 21);
            this.button_BLETest.Name = "button_BLETest";
            this.button_BLETest.Size = new System.Drawing.Size(104, 30);
            this.button_BLETest.TabIndex = 9;
            this.button_BLETest.Text = "蓝牙测试";
            this.button_BLETest.UseVisualStyleBackColor = true;
            this.button_BLETest.Click += new System.EventHandler(this.button_BLETest_Click);
            // 
            // groupBox_SerialInfo
            // 
            this.groupBox_SerialInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox_SerialInfo.Controls.Add(this.button_OpenScaner);
            this.groupBox_SerialInfo.Controls.Add(this.label15);
            this.groupBox_SerialInfo.Controls.Add(this.comboBox_Scaner);
            this.groupBox_SerialInfo.Controls.Add(this.label1);
            this.groupBox_SerialInfo.Controls.Add(this.button_OpenGoldenSerial);
            this.groupBox_SerialInfo.Controls.Add(this.button_ChooseType);
            this.groupBox_SerialInfo.Controls.Add(this.button_OpenTestSerial);
            this.groupBox_SerialInfo.Controls.Add(this.label2);
            this.groupBox_SerialInfo.Controls.Add(this.comboBox_Golden);
            this.groupBox_SerialInfo.Controls.Add(this.comboBox_Type);
            this.groupBox_SerialInfo.Controls.Add(this.comboBox_Test);
            this.groupBox_SerialInfo.Controls.Add(this.label3);
            this.groupBox_SerialInfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_SerialInfo.Location = new System.Drawing.Point(9, 87);
            this.groupBox_SerialInfo.Name = "groupBox_SerialInfo";
            this.groupBox_SerialInfo.Size = new System.Drawing.Size(331, 202);
            this.groupBox_SerialInfo.TabIndex = 10;
            this.groupBox_SerialInfo.TabStop = false;
            this.groupBox_SerialInfo.Text = "串口信息";
            // 
            // button_OpenScaner
            // 
            this.button_OpenScaner.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OpenScaner.Location = new System.Drawing.Point(224, 109);
            this.button_OpenScaner.Name = "button_OpenScaner";
            this.button_OpenScaner.Size = new System.Drawing.Size(87, 27);
            this.button_OpenScaner.TabIndex = 9;
            this.button_OpenScaner.Text = "打开";
            this.button_OpenScaner.UseVisualStyleBackColor = true;
            this.button_OpenScaner.Click += new System.EventHandler(this.button_OpenScaner_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(6, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 19);
            this.label15.TabIndex = 10;
            this.label15.Text = "扫 码 器";
            // 
            // comboBox_Scaner
            // 
            this.comboBox_Scaner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Scaner.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_Scaner.FormattingEnabled = true;
            this.comboBox_Scaner.Location = new System.Drawing.Point(98, 109);
            this.comboBox_Scaner.Name = "comboBox_Scaner";
            this.comboBox_Scaner.Size = new System.Drawing.Size(107, 27);
            this.comboBox_Scaner.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(122, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "结果";
            // 
            // textBox_BLE
            // 
            this.textBox_BLE.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_BLE.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_BLE.Location = new System.Drawing.Point(163, 28);
            this.textBox_BLE.Name = "textBox_BLE";
            this.textBox_BLE.ReadOnly = true;
            this.textBox_BLE.Size = new System.Drawing.Size(124, 29);
            this.textBox_BLE.TabIndex = 12;
            // 
            // textBox_Burn
            // 
            this.textBox_Burn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Burn.Location = new System.Drawing.Point(163, 68);
            this.textBox_Burn.Name = "textBox_Burn";
            this.textBox_Burn.ReadOnly = true;
            this.textBox_Burn.Size = new System.Drawing.Size(124, 29);
            this.textBox_Burn.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(122, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "结果";
            // 
            // button_BurnTest
            // 
            this.button_BurnTest.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_BurnTest.Location = new System.Drawing.Point(12, 64);
            this.button_BurnTest.Name = "button_BurnTest";
            this.button_BurnTest.Size = new System.Drawing.Size(104, 30);
            this.button_BurnTest.TabIndex = 15;
            this.button_BurnTest.Text = "烧写自检";
            this.button_BurnTest.UseVisualStyleBackColor = true;
            this.button_BurnTest.Click += new System.EventHandler(this.button_BurnTest_Click);
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.Location = new System.Drawing.Point(338, 177);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.ReadOnly = true;
            this.richTextBox_Log.Size = new System.Drawing.Size(602, 148);
            this.richTextBox_Log.TabIndex = 18;
            this.richTextBox_Log.Text = "";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(869, 144);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(71, 27);
            this.button_Clear.TabIndex = 19;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_FilePath.Location = new System.Drawing.Point(6, 59);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.ReadOnly = true;
            this.textBox_FilePath.Size = new System.Drawing.Size(546, 29);
            this.textBox_FilePath.TabIndex = 1;
            // 
            // button_ChooseFile
            // 
            this.button_ChooseFile.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ChooseFile.Location = new System.Drawing.Point(6, 25);
            this.button_ChooseFile.Name = "button_ChooseFile";
            this.button_ChooseFile.Size = new System.Drawing.Size(113, 28);
            this.button_ChooseFile.TabIndex = 0;
            this.button_ChooseFile.Text = "加载文件";
            this.button_ChooseFile.UseVisualStyleBackColor = true;
            this.button_ChooseFile.Click += new System.EventHandler(this.button_ChooseFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "当前用户";
            // 
            // textBox_ShowUser
            // 
            this.textBox_ShowUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ShowUser.Location = new System.Drawing.Point(79, 18);
            this.textBox_ShowUser.Name = "textBox_ShowUser";
            this.textBox_ShowUser.ReadOnly = true;
            this.textBox_ShowUser.Size = new System.Drawing.Size(169, 26);
            this.textBox_ShowUser.TabIndex = 22;
            // 
            // groupBox_UserInfo
            // 
            this.groupBox_UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox_UserInfo.Controls.Add(this.textBox_ShowUser);
            this.groupBox_UserInfo.Controls.Add(this.button_ExitMain);
            this.groupBox_UserInfo.Controls.Add(this.label6);
            this.groupBox_UserInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBox_UserInfo.Name = "groupBox_UserInfo";
            this.groupBox_UserInfo.Size = new System.Drawing.Size(331, 59);
            this.groupBox_UserInfo.TabIndex = 23;
            this.groupBox_UserInfo.TabStop = false;
            // 
            // button_ExitMain
            // 
            this.button_ExitMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ExitMain.Location = new System.Drawing.Point(258, 19);
            this.button_ExitMain.Name = "button_ExitMain";
            this.button_ExitMain.Size = new System.Drawing.Size(67, 27);
            this.button_ExitMain.TabIndex = 28;
            this.button_ExitMain.Text = "退出";
            this.button_ExitMain.UseVisualStyleBackColor = true;
            this.button_ExitMain.Click += new System.EventHandler(this.button_ExitMain_Click);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Time.ForeColor = System.Drawing.Color.Blue;
            this.label_Time.Location = new System.Drawing.Point(70, 24);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(53, 19);
            this.label_Time.TabIndex = 32;
            this.label_Time.Text = "time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(7, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "时间:";
            // 
            // label_SN
            // 
            this.label_SN.AutoSize = true;
            this.label_SN.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SN.Location = new System.Drawing.Point(15, 59);
            this.label_SN.Name = "label_SN";
            this.label_SN.Size = new System.Drawing.Size(67, 19);
            this.label_SN.TabIndex = 24;
            this.label_SN.Text = "SN编号";
            // 
            // textBox_SN
            // 
            this.textBox_SN.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_SN.ForeColor = System.Drawing.Color.Red;
            this.textBox_SN.Location = new System.Drawing.Point(88, 55);
            this.textBox_SN.Name = "textBox_SN";
            this.textBox_SN.ReadOnly = true;
            this.textBox_SN.Size = new System.Drawing.Size(169, 29);
            this.textBox_SN.TabIndex = 25;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox4.Controls.Add(this.label_MAC);
            this.groupBox4.Controls.Add(this.textBox_MAC);
            this.groupBox4.Controls.Add(this.label_SN);
            this.groupBox4.Controls.Add(this.textBox_SN);
            this.groupBox4.Location = new System.Drawing.Point(6, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 90);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // label_MAC
            // 
            this.label_MAC.AutoSize = true;
            this.label_MAC.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_MAC.Location = new System.Drawing.Point(3, 25);
            this.label_MAC.Name = "label_MAC";
            this.label_MAC.Size = new System.Drawing.Size(79, 20);
            this.label_MAC.TabIndex = 47;
            this.label_MAC.Text = "MAC编号";
            // 
            // textBox_MAC
            // 
            this.textBox_MAC.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_MAC.ForeColor = System.Drawing.Color.Red;
            this.textBox_MAC.Location = new System.Drawing.Point(89, 22);
            this.textBox_MAC.Name = "textBox_MAC";
            this.textBox_MAC.ReadOnly = true;
            this.textBox_MAC.Size = new System.Drawing.Size(169, 29);
            this.textBox_MAC.TabIndex = 48;
            // 
            // groupBox5_TestInfo
            // 
            this.groupBox5_TestInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox5_TestInfo.Controls.Add(this.groupBox4);
            this.groupBox5_TestInfo.Controls.Add(this.groupBox3);
            this.groupBox5_TestInfo.Controls.Add(this.groupBox7);
            this.groupBox5_TestInfo.Controls.Add(this.richTextBox_Log);
            this.groupBox5_TestInfo.Controls.Add(this.groupBox2);
            this.groupBox5_TestInfo.Controls.Add(this.label_mes);
            this.groupBox5_TestInfo.Controls.Add(this.button_Clear);
            this.groupBox5_TestInfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5_TestInfo.Location = new System.Drawing.Point(12, 311);
            this.groupBox5_TestInfo.Name = "groupBox5_TestInfo";
            this.groupBox5_TestInfo.Size = new System.Drawing.Size(946, 342);
            this.groupBox5_TestInfo.TabIndex = 30;
            this.groupBox5_TestInfo.TabStop = false;
            this.groupBox5_TestInfo.Text = "测试信息";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox3.Controls.Add(this.SelfTest_Time);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label_TestState);
            this.groupBox3.Location = new System.Drawing.Point(7, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 58);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // SelfTest_Time
            // 
            this.SelfTest_Time.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelfTest_Time.Location = new System.Drawing.Point(84, 20);
            this.SelfTest_Time.Name = "SelfTest_Time";
            this.SelfTest_Time.ReadOnly = true;
            this.SelfTest_Time.Size = new System.Drawing.Size(56, 26);
            this.SelfTest_Time.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "自检用时";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Pink;
            this.label16.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.DeepPink;
            this.label16.Location = new System.Drawing.Point(158, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 19);
            this.label16.TabIndex = 46;
            this.label16.Text = "状态:";
            // 
            // label_TestState
            // 
            this.label_TestState.AutoSize = true;
            this.label_TestState.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_TestState.Location = new System.Drawing.Point(217, 21);
            this.label_TestState.Name = "label_TestState";
            this.label_TestState.Size = new System.Drawing.Size(69, 20);
            this.label_TestState.TabIndex = 45;
            this.label_TestState.Text = "......";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox7.Controls.Add(this.button_BLETest);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.textBox_BLE);
            this.groupBox7.Controls.Add(this.textBox_Burn);
            this.groupBox7.Controls.Add(this.button_BurnTest);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Location = new System.Drawing.Point(6, 133);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(298, 111);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.textBox_NB);
            this.groupBox2.Controls.Add(this.textBox_IL005);
            this.groupBox2.Controls.Add(this.textBox_CardReader);
            this.groupBox2.Controls.Add(this.textBox_TSM12);
            this.groupBox2.Controls.Add(this.textBox_PCA9555);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(338, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 142);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模块自检信息";
            // 
            // textBox_NB
            // 
            this.textBox_NB.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_NB.Location = new System.Drawing.Point(396, 76);
            this.textBox_NB.Name = "textBox_NB";
            this.textBox_NB.ReadOnly = true;
            this.textBox_NB.Size = new System.Drawing.Size(55, 29);
            this.textBox_NB.TabIndex = 40;
            this.textBox_NB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_IL005
            // 
            this.textBox_IL005.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_IL005.Location = new System.Drawing.Point(396, 27);
            this.textBox_IL005.Name = "textBox_IL005";
            this.textBox_IL005.ReadOnly = true;
            this.textBox_IL005.Size = new System.Drawing.Size(55, 29);
            this.textBox_IL005.TabIndex = 39;
            this.textBox_IL005.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CardReader
            // 
            this.textBox_CardReader.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_CardReader.Location = new System.Drawing.Point(165, 105);
            this.textBox_CardReader.Name = "textBox_CardReader";
            this.textBox_CardReader.ReadOnly = true;
            this.textBox_CardReader.Size = new System.Drawing.Size(55, 29);
            this.textBox_CardReader.TabIndex = 38;
            this.textBox_CardReader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_TSM12
            // 
            this.textBox_TSM12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_TSM12.Location = new System.Drawing.Point(165, 62);
            this.textBox_TSM12.Name = "textBox_TSM12";
            this.textBox_TSM12.ReadOnly = true;
            this.textBox_TSM12.Size = new System.Drawing.Size(55, 29);
            this.textBox_TSM12.TabIndex = 37;
            this.textBox_TSM12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PCA9555
            // 
            this.textBox_PCA9555.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_PCA9555.Location = new System.Drawing.Point(165, 23);
            this.textBox_PCA9555.Name = "textBox_PCA9555";
            this.textBox_PCA9555.ReadOnly = true;
            this.textBox_PCA9555.Size = new System.Drawing.Size(55, 29);
            this.textBox_PCA9555.TabIndex = 36;
            this.textBox_PCA9555.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(52, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "扩展IO模块:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(257, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 19);
            this.label12.TabIndex = 35;
            this.label12.Text = "加密芯片模块:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(313, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "NB模块:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(34, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "读卡芯片模块:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(34, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "触摸键盘模块:";
            // 
            // label_mes
            // 
            this.label_mes.AutoSize = true;
            this.label_mes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_mes.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_mes.Location = new System.Drawing.Point(448, 255);
            this.label_mes.Name = "label_mes";
            this.label_mes.Size = new System.Drawing.Size(93, 40);
            this.label_mes.TabIndex = 47;
            this.label_mes.Text = "  MES\r\n执行结果";
            // 
            // richTextBox_MES
            // 
            this.richTextBox_MES.Location = new System.Drawing.Point(6, 21);
            this.richTextBox_MES.Name = "richTextBox_MES";
            this.richTextBox_MES.ReadOnly = true;
            this.richTextBox_MES.Size = new System.Drawing.Size(546, 73);
            this.richTextBox_MES.TabIndex = 48;
            this.richTextBox_MES.Text = "";
            // 
            // timer_TestTime
            // 
            this.timer_TestTime.Enabled = true;
            this.timer_TestTime.Interval = 1000;
            this.timer_TestTime.Tick += new System.EventHandler(this.timer_TestTime_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.textBox_FilePath);
            this.groupBox1.Controls.Add(this.button_ChooseFile);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(373, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 104);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择文件";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(145, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "烧录文件只需加载一次就行";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label_Time);
            this.groupBox5.Location = new System.Drawing.Point(379, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(478, 59);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox_MES);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.ForeColor = System.Drawing.Color.Lime;
            this.groupBox6.Location = new System.Drawing.Point(373, 196);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(558, 100);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "MES执行结果";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(970, 676);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5_TestInfo);
            this.Controls.Add(this.groupBox_UserInfo);
            this.Controls.Add(this.groupBox_SerialInfo);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试工具v1.0";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox_SerialInfo.ResumeLayout(false);
            this.groupBox_SerialInfo.PerformLayout();
            this.groupBox_UserInfo.ResumeLayout(false);
            this.groupBox_UserInfo.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5_TestInfo.ResumeLayout(false);
            this.groupBox5_TestInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OpenGoldenSerial;
        private System.Windows.Forms.Button button_OpenTestSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Golden;
        private System.Windows.Forms.ComboBox comboBox_Test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Button button_ChooseType;
        private System.Windows.Forms.Button button_BLETest;
        private System.Windows.Forms.GroupBox groupBox_SerialInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_BLE;
        private System.Windows.Forms.TextBox textBox_Burn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_BurnTest;
        private System.Windows.Forms.RichTextBox richTextBox_Log;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Button button_ChooseFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ShowUser;
        private System.Windows.Forms.GroupBox groupBox_UserInfo;
        private System.Windows.Forms.Label label_SN;
        private System.Windows.Forms.TextBox textBox_SN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_ExitMain;
        private System.Windows.Forms.GroupBox groupBox5_TestInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_NB;
        private System.Windows.Forms.TextBox textBox_IL005;
        private System.Windows.Forms.TextBox textBox_CardReader;
        private System.Windows.Forms.TextBox textBox_TSM12;
        private System.Windows.Forms.TextBox textBox_PCA9555;
        private System.Windows.Forms.TextBox SelfTest_Time;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer_TestTime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label_TestState;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_MAC;
        private System.Windows.Forms.Label label_MAC;
        private System.Windows.Forms.RichTextBox richTextBox_MES;
        private System.Windows.Forms.Label label_mes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_OpenScaner;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_Scaner;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label17;
    }
}