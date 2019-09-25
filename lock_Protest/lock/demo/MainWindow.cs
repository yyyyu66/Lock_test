using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Logon
{
    public partial class MainWindow : Form
    {
        //定义三个串口的新实例
        public SerialPort Golden_Port = new SerialPort();  //金板串口
        public SerialPort Test_Port = new SerialPort();    //测试串口
        public SerialPort Scan_Port = new SerialPort();    //扫码器串口

        public string Product_Type;  //产品类型
        public string BurnFilePath;  //加载的烧录文件路径
        public string result;        //用于存放测试结果(从线程中获取的标准输出数据)
        public string result1;       //用于存放测试结果(从线程中获取的错误数据)
        public string SN;            //SN序列号
        public string MAC;           //MAC编号
        public bool Test_Flag = false;
        public int TypeChoose_Count = 0;
        Thread thread_BurnProgram;   //烧录线程
        public const int WM_DEVICECHANGE = 0x219;
        public const int DBT_DEVICEARRIVAL        = 0x8000;  //USB设备插入事件
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;  //USB设备拔出事件
        public int times_used = 0;   //烧录程序耗时
    
        //界面的一些初始化操作
        public MainWindow()
        {
            InitializeComponent();
            textBox_ShowUser.AppendText(Program.username);
            label_Time.Text = DateTime.Now.ToLocalTime().ToString();

            //**获取串口信息
            string[] ports = SerialPort.GetPortNames();

            //**创建一个用于显示时间的定时器
            System.Timers.Timer date_timer = new System.Timers.Timer(1000);
            date_timer.Elapsed  += new System.Timers.ElapsedEventHandler(ShowDate);
            date_timer.AutoReset = true;
            date_timer.Enabled   = true;
            date_timer.Start();

            timer_TestTime.Stop();

            comboBox_Golden.Items.AddRange(ports);
            comboBox_Test.Items.AddRange(ports);
            comboBox_Scaner.Items.AddRange(ports);
            //foreach (string s in ports)
            //{
            //    comboBox_Golden.Items.Add(s);
            //    comboBox_Test.Items.Add(s);
            //    comboBox_Scaner.Items.Add(s);
            //}

            comboBox_Type.Items.Add("光交箱");
            comboBox_Type.Items.Add("M0B门锁");
            comboBox_Golden.SelectedIndex = 0;
            comboBox_Test.SelectedIndex = 0;
            comboBox_Scaner.SelectedIndex = 0;
            comboBox_Type.SelectedIndex = 0;
            Console.WriteLine(Program.password);
            Console.WriteLine(Program.username);
            Test_Port.DataReceived += new SerialDataReceivedEventHandler(Test_Port_DataReceived);
            Scan_Port.DataReceived += new SerialDataReceivedEventHandler(Scan_Port_DataReceived);
            label_TestState.Text = "......";
            CreaFiles();
            Console.WriteLine("初始化完毕.");
        }

        //打开测试串口
        private void button_OpenTestSerial_Click(object sender, EventArgs e)
        {
            try { 
                    if (Test_Port.IsOpen == false)
                    {
                        Test_Port.PortName = comboBox_Test.SelectedItem.ToString();
                        Console.WriteLine("{0},{1}", "测试串口为:", Test_Port.PortName);
                        comboBox_Test.Enabled = false;
                        Test_Port.BaudRate = 115200;
                        Test_Port.Parity = Parity.None;
                        Test_Port.DataBits = 8;
                        Test_Port.StopBits = StopBits.One;
                        Test_Port.Handshake = Handshake.RequestToSend;
                        Test_Port.ReceivedBytesThreshold = 1;
                        Console.WriteLine("测试串口的信息:{0},{1},{2}.", Test_Port.PortName, Test_Port.BaudRate, Test_Port.DataBits);
                        Program.sw.WriteLine("测试串口的信息:{0},{1},{2}.", Test_Port.PortName, Test_Port.BaudRate, Test_Port.DataBits);
                        Program.sw.Flush();
                        Test_Port.Open();
                        button_OpenTestSerial.ForeColor = Color.Green;
                        button_OpenTestSerial.Text = "关闭";
                        Console.WriteLine("{0}{1}.", "已打开", Test_Port.PortName);
                   }
                  else
                    {
                        Test_Port.Close();
                        button_OpenTestSerial.ForeColor = Color.Black;
                        button_OpenTestSerial.Text = "打开";
                        comboBox_Test.Enabled = true;
                        Console.WriteLine("{0}{1}.", "关闭", Test_Port.PortName);
                    }
            }
            catch(Exception err)
            {
                Console.WriteLine("错误：" + err.Message);
                comboBox_Test.Enabled = true;
                MessageBox.Show("请选择正确的串口号.");
                return;
            }
        }

        //接收串口数据
        private void Test_Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] readBytes = new byte[Test_Port.BytesToRead];
            Test_Port.Read(readBytes, 0, readBytes.Length);
            richTextBox_Log.Invoke((EventHandler)delegate
            {
                string rec_str = "";
                for (int i = 0; i < readBytes.Length; i++)
                {
                    byte b = readBytes[i];
                    rec_str += b.ToString("X2"); //转换为16进制的数据
                }
                //Console.WriteLine(readBytes.Length);
                if ((readBytes.Length == 6))
                {
                    if ((readBytes[0] == Convert.ToByte(0xAA)) && (readBytes[5] == Convert.ToByte(0x55)))
                    {
                        Console.WriteLine("收到自检消息.");
                        Console.WriteLine(Convert.ToInt32(readBytes[1]));
                        int cmd = Convert.ToInt32(readBytes[2]);
                        string Info = string.Empty;
                        string BoxInfo = string.Empty;
                        BoxInfo = (cmd == 0) ? ("正常") : ("异常");

                        switch (Convert.ToInt32(readBytes[1]))
                        {
                            case 0x01:
                                Info = (cmd == 0) ? ("NB模块正常") : ("NB模块异常");
                                textBox_NB.BackColor = Color.White;
                                textBox_NB.Text = BoxInfo;
                                textBox_NB.ForeColor = (cmd == 0) ? Color.Green : Color.Red;
                                Console.WriteLine(Info);
                                richTextBox_Log.AppendText(Info);
                                break;
                            case 0x02:
                                Info = (cmd == 0) ? ("SIM卡正常") : ("SIM卡异常");
                                //textBox_SIM.BackColor = Color.White;
                                //textBox_SIM.Text = BoxInfo;
                                //textBox_SIM.ForeColor = (cmd == 0) ? Color.Green : Color.Red;
                                Console.WriteLine(Info);
                                richTextBox_Log.AppendText(Info);
                                break;
                            case 0x03:
                                Info = (cmd == 0) ? ("加密芯片正常") : ("加密芯片异常");
                                textBox_IL005.BackColor = Color.White;
                                textBox_IL005.Text = BoxInfo;
                                textBox_IL005.ForeColor = (cmd == 0) ? Color.Green : Color.Red;
                                Console.WriteLine(Info);
                                richTextBox_Log.AppendText(Info);
                                break;
                            case 0x04:
                                Info = (cmd == 0) ? ("扩展IO正常") : ("扩展IO异常");
                                textBox_PCA9555.BackColor = Color.White;
                                textBox_PCA9555.Text = BoxInfo;
                                textBox_PCA9555.ForeColor = (cmd == 0) ? Color.Green : Color.Red;
                                Console.WriteLine(Info);
                                richTextBox_Log.AppendText(Info);
                                break;
                            case 0x05:
                                Info = (cmd == 0) ? ("OLED正常") : ("OLED异常");
                                Console.WriteLine(Info);
                                richTextBox_Log.AppendText(Info);
                                break;
                            case 0x06:
                                Info = (cmd == 0) ? ("TSM12正常") : ("TSM12异常");
                                textBox_TSM12.BackColor = Color.White;
                                textBox_TSM12.Text = BoxInfo;
                                textBox_TSM12.ForeColor = (cmd == 0) ? Color.Green : Color.Red;
                                Console.WriteLine(Info);
                                richTextBox_Log.AppendText(Info);
                                break;
                            case 0x07:
                                Info = (cmd == 0) ? ("读卡模块正常") : ("读卡模块异常");
                                textBox_CardReader.BackColor = Color.White;
                                textBox_CardReader.Text = BoxInfo;
                                textBox_CardReader.ForeColor = (cmd == 0) ? Color.Green : Color.Red;
                                Console.WriteLine(Info);
                                richTextBox_Log.AppendText(Info);
                                break;
                            default:
                                //this.richTextBox_Log.AppendText("一切正常.\n");
                                break;
                        }
                        Program.sw.WriteLine("串口数据:{0},{1}.", rec_str, Info);
                        Program.sw.Flush();
                    }
                }
                richTextBox_Log.AppendText("0x" + rec_str + "\n");                               
            });
        }
        //打开金板串口
        private void button_OpenGoldenSerial_Click(object sender, EventArgs e)
        {
            try {
                if (Golden_Port.IsOpen == false)
                {
                    Golden_Port.PortName = comboBox_Golden.SelectedItem.ToString();
                    Console.WriteLine(Golden_Port.PortName);

                    comboBox_Golden.Enabled = false;
                    Golden_Port.BaudRate = 115200;
                    Golden_Port.Parity = Parity.None;
                    Golden_Port.DataBits = 8;
                    Golden_Port.StopBits = StopBits.One;
                    Golden_Port.Handshake = Handshake.RequestToSend;
                    Console.Write("测试串口的信息:{0},{1},{2}.", Golden_Port.PortName, Golden_Port.BaudRate, Golden_Port.DataBits);
                    Program.sw.WriteLine("金板串口的信息:{0},{1},{2}.", Golden_Port.PortName, Golden_Port.BaudRate, Golden_Port.DataBits);
                    Program.sw.Flush();
                    Golden_Port.Open();
                    button_OpenGoldenSerial.ForeColor = Color.Green;
                    button_OpenGoldenSerial.Text = "关闭";
                    Console.WriteLine("{0}{1}.", "已打开", Golden_Port.PortName);
                }
                else
                {
                    Golden_Port.Close();
                    button_OpenGoldenSerial.ForeColor = Color.Black;
                    comboBox_Golden.Enabled = true;
                    button_OpenGoldenSerial.Text = "打开";
                    Console.WriteLine("{0}{1}.", "关闭", Test_Port.PortName);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("错误：" + err.Message);
                comboBox_Golden.Enabled = true;
                MessageBox.Show("请选择正确的串口号.");
                return;
            }

        }

        //打开扫码器串口
        private void button_OpenScaner_Click(object sender, EventArgs e)
        {
            try {
                if (Scan_Port.IsOpen == false)
                {
                    Scan_Port.PortName = comboBox_Scaner.SelectedItem.ToString();
                    Console.WriteLine(Scan_Port.PortName);

                    comboBox_Scaner.Enabled = false;
                    Scan_Port.BaudRate = 115200;
                    Scan_Port.Parity = Parity.None;
                    Scan_Port.DataBits = 8;
                    Scan_Port.StopBits = StopBits.One;
                    Scan_Port.Handshake = Handshake.RequestToSend;
                    Console.Write("扫码器串口的信息:{0},{1},{2}.", Scan_Port.PortName, Scan_Port.BaudRate, Scan_Port.DataBits);
                    Program.sw.WriteLine("扫码器串口的信息:{0},{1},{2}.", Scan_Port.PortName, Scan_Port.BaudRate, Scan_Port.DataBits);
                    Program.sw.Flush();
                    Scan_Port.Open();
                    button_OpenScaner.ForeColor = Color.Green;
                    button_OpenScaner.Text = "关闭";
                    Console.WriteLine("{0}{1}.", "已打开", Scan_Port.PortName);
                }
                else
                {
                    Scan_Port.Close();
                    button_OpenScaner.ForeColor = Color.Black;
                    comboBox_Scaner.Enabled = true;
                    button_OpenScaner.Text = "打开";
                    Console.WriteLine("{0}{1}.", "关闭", Scan_Port.PortName);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("错误：" + err.Message);
                comboBox_Scaner.Enabled = true;
                MessageBox.Show("请选择正确的串口号.");
                return;
            }

        }

        //接收扫码器串口数据
        private void Scan_Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] readBytes = new byte[Test_Port.BytesToRead];
            Test_Port.Read(readBytes, 0, readBytes.Length);
            richTextBox_Log.Invoke((EventHandler)delegate
            {
                MAC = System.Text.Encoding.Default.GetString(readBytes); //转化为字符串数据
                richTextBox_Log.AppendText("MAC:" + MAC + "\n");
                Program.sw.WriteLine("MAC:" + MAC);
                Program.sw.Flush();
                //显示MAC SN
                /*根据MAC匹配查找SN*/
                string sn_info = Program.dllMes1.GetListImportData("MAC", MAC);
                Program.sw.WriteLine(sn_info);
                Program.sw.Flush();
                if (sn_info.Length > 0)
                {
                    int err_a = sn_info.IndexOf("<SN>");
                    int err_b = sn_info.IndexOf("</SN>");
                    if (err_a < 0 || err_b < 0)  //未找到SN相关的信息，则返回
                    {
                        richTextBox_MES.Clear();
                        richTextBox_MES.ForeColor = Color.Red;
                        richTextBox_MES.Text = "未找到SN信息！！！";
                        return;
                    }
                    SN = sn_info.Substring(err_a + 4, err_b - err_a - 4);
                    textBox_SN.Text = SN;
                    Console.WriteLine(SN);
                    textBox_SN.AppendText(SN);
                    Program.sw.WriteLine(SN);
                    Program.sw.Flush();
                }
            });
        }
        //选择产品类型
        private void button_ChooseType_Click(object sender, EventArgs e)
        {
            //第一次选中，第二次取消  
            if (TypeChoose_Count % 2 == 0)
            {
                comboBox_Type.Enabled = false;
                button_ChooseType.Text = "已选";
            }
            else
            {
                comboBox_Type.Enabled = true;
                button_ChooseType.Text = "选择";
            }
            Product_Type = comboBox_Type.SelectedItem.ToString();
            TypeChoose_Count++;
            Console.WriteLine(Product_Type);
            Program.sw.WriteLine(Product_Type);
            Program.sw.Flush();
        }

        //蓝牙测试
        private void button_BLETest_Click(object sender, EventArgs e)
        {
            if((Test_Port.IsOpen == false) || (Golden_Port.IsOpen == false))
            {
                MessageBox.Show("请先打开串口.");
                Console.WriteLine("请先打开蓝牙测试串口.");
                return;
            }
            Console.WriteLine("蓝牙测试开始.");
            richTextBox_Log.AppendText("蓝牙测试开始.\n");
            /****************************************************************************
            ******************************启动烧录脚本************************************
            ****************************************************************************/
            Console.WriteLine("启动CMD.");
            richTextBox_Log.AppendText("启动CMD.\n");
            Process p = new Process();
            p.StartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
            p.StartInfo.Arguments = "/c D:\\firmware\\download_dtm.bat";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Verb = "RunAS";
            p.Start();
            p.StandardInput.WriteLine("exit");

            result = p.StandardOutput.ReadToEnd();
            result1 = p.StandardError.ReadToEnd();
            p.WaitForExit();
            p.Close();
            richTextBox_Log.AppendText(result);
            richTextBox_Log.AppendText(result1);
            Console.WriteLine(result, result1);
            if (result.Contains("Run") == true) //
            {
                richTextBox_Log.AppendText("烧录成功.\n");
                richTextBox_Log.AppendText("Run dtm test.\n");
                /****************************************************************************
                ******************************启动DTM测试************************************
                ****************************************************************************/
                Console.WriteLine("启动DTM测试.");
                richTextBox_Log.AppendText("启动DTM测试.\n");
                string DTM_Path = Directory.GetCurrentDirectory();

                string tmp_path = string.Empty;
                for (int i = 0; i < DTM_Path.Length; i++)// 转换为可用的路径格式
                {
                    char b = DTM_Path[i];
                    tmp_path += b;
                    if (b.CompareTo('\\') == 0)
                        tmp_path += '\\';
                }

                Process DTM = new Process();
                DTM.StartInfo.FileName = tmp_path + "\\files\\dtm_run.exe";
                richTextBox_Log.AppendText(DTM.StartInfo.FileName);

                DTM.StartInfo.Arguments = Golden_Port.PortName + " " + Test_Port.PortName;
                richTextBox_Log.AppendText(DTM.StartInfo.Arguments);
                DTM.StartInfo.UseShellExecute = false;
                DTM.StartInfo.RedirectStandardInput = true;
                DTM.StartInfo.RedirectStandardOutput = true;
                DTM.StartInfo.RedirectStandardError = true;
                DTM.StartInfo.CreateNoWindow = true;
                DTM.StartInfo.Verb = "RunAS";
                DTM.Start();
                DTM.StandardInput.WriteLine("&exit");

                result = DTM.StandardOutput.ReadToEnd();
                DTM.WaitForExit();
                DTM.Close();
                richTextBox_Log.AppendText(result);
                Console.WriteLine(result);

                if (result.Contains("dtm test failed") == true)
                {
                    textBox_BLE.Clear();
                    textBox_BLE.BackColor = Color.White;
                    textBox_BLE.AppendText("蓝牙测试失败.");
                    textBox_BLE.ForeColor = Color.Red;
                }
                else
                {
                    textBox_BLE.Clear();
                    textBox_BLE.BackColor = Color.White;
                    textBox_BLE.AppendText("蓝牙测试成功.");
                    textBox_BLE.ForeColor = Color.Green;
                }
                return;
            }
            else
            {
                richTextBox_Log.AppendText("烧写失败.\n");
                if (result1.Contains("There is no debugger connected to the PC") == true)
                    richTextBox_Log.AppendText("请连接好仿真器.\n");
                return;
            }
        }

        //清空显示
        private void button_Clear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("清空显示区.");
            richTextBox_Log.Clear();
        }

        //***************************加载烧录文件******************************
        private void button_ChooseFile_Click(object sender, EventArgs e)
        {
            BurnFilePath = string.Empty;
            string tmpPath = string.Empty;
            var FileChoose = new OpenFileDialog()
            {
                Filter = "Files (*.hex)|*.hex"//如果需要筛选txt文件（"Files (*.txt)|*.txt"）
            };
            var result = FileChoose.ShowDialog();
            Console.WriteLine(result);
            if (result == DialogResult.OK)
            {
                tmpPath = FileChoose.FileName;
                Console.WriteLine(FileChoose.FileName);
                textBox_FilePath.AppendText(tmpPath);

                for (int i = 0; i < tmpPath.Length; i++)
                {
                    char b = tmpPath[i];
                    BurnFilePath += b;
                    if (b.CompareTo('\\') == 0)
                        BurnFilePath += '\\';
                }
                Console.WriteLine(BurnFilePath);
                if (File.Exists(@"D:\firmware\factory.hex") == true)
                {
                    Console.WriteLine("文件已存在,删除后新建文件.");
                    File.Delete(@"D:\firmware\factory.hex");
                    File.Copy(BurnFilePath, @"D:\firmware\factory.hex", true);
                }
                else
                {
                    Console.WriteLine("文件不存在,新建文件.");
                    File.Copy(BurnFilePath, @"D:\firmware\factory.hex", true);
                }
            }
        }

        //**************************启动线程烧录程序***************************
        private void button_BurnTest_Click(object sender, EventArgs e)
        {
            thread_BurnProgram = new Thread(new ThreadStart(method));
            Test_Flag = true;
            thread_BurnProgram.Start();
            label_TestState.Text = "测试中...";
            Thread.Sleep(2000);
            timer_TestTime.Start();
        }

        //**************************退出窗口**************************
        private void button_ExitMain_Click(object sender, EventArgs e)
        {
            Program.sw.Close();
            Close();
        }

        /************************生成相关文件**********************************/
        private void CreaFiles()
        {
            string DirPath = "D:\\firmware";
            string File1 = "D:\\firmware\\firmware.bat";
            string File2 = "D:\\firmware\\download_dtm.bat";
            string File3 = "D:\\firmware\\nrf52810_dtm.hex";

            if (!Directory.Exists(DirPath))
                Directory.CreateDirectory(DirPath);

            if (!File.Exists(File1))
            {
                FileStream fs = new FileStream(File1, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("nrfjprog.exe  --family NRF52 --eraseall");
                sw.WriteLine("nrfjprog.exe  --family NRF52 --program D:\\firmware\\factory.hex   --verify  --reset");
                sw.Flush();
                //sw.Close();
                fs.Close();
            }

            if (!File.Exists(File3))
            {
                FileStream fs = new FileStream(File3, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                string DTM_Path = System.IO.Directory.GetCurrentDirectory();
                string tmp_path = string.Empty;
                for (int i = 0; i < DTM_Path.Length; i++)// 转换为可用的路径格式
                {
                    char b = DTM_Path[i];
                    tmp_path += b;
                    if (b.CompareTo('\\') == 0)
                        tmp_path += '\\';
                }

                StreamReader Sr = new StreamReader(tmp_path + "\\files\\list.py");
                string line = "";
                while ((line = Sr.ReadLine()) != null)
                {
                    if (line.Length > 10)
                    {
                        int a = line.IndexOf("'");
                        int b = line.IndexOf("',");
                        if (b < 0)
                            b = line.Length - 1;
                        //Console.WriteLine("{0} {1}", a, b);
                        string tmpStr = line.Substring(a + 1, b - a - 1);
                        Console.WriteLine(tmpStr);
                        sw.WriteLine(tmpStr);
                        line = string.Empty;
                    }
                }
                sw.Flush();
                sw.Close();
                //fs.Close();
                Sr.Close();
            }
            if (!File.Exists(File2))
            {
                FileStream fs = new FileStream(File2, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("nrfjprog.exe  --family NRF52 --eraseall");
                sw.WriteLine("nrfjprog.exe  --family NRF52 --program  D:\\firmware\\nrf52810_dtm.hex   --verify  --reset");
                sw.Flush();
                //sw.Close();
                fs.Close();
            }
        }
        /**********************************************************************/

        /**********************启动烧录线程后执行的操作***********************/
        private void method()
        {
            if (this.richTextBox_Log.InvokeRequired)
            {
                richTextBox_Log.AppendText("程序烧录即将开始:\n");
                richTextBox_Log.AppendText("-----启动烧录脚本:-----\n");
            }
            /*   启动烧录脚本  */
            Process BurnProcess = new Process();
            BurnProcess.StartInfo.FileName = @"C:\Windows\system32\cmd.exe";
            BurnProcess.StartInfo.Arguments = "/c" + " " + "D:\\firmware\\firmware.bat";
            richTextBox_Log.AppendText(BurnProcess.StartInfo.Arguments);
            BurnProcess.StartInfo.UseShellExecute = false;
            BurnProcess.StartInfo.RedirectStandardInput = true;
            BurnProcess.StartInfo.RedirectStandardOutput = true;
            BurnProcess.StartInfo.RedirectStandardError = true;
            BurnProcess.StartInfo.CreateNoWindow = true;
            BurnProcess.StartInfo.Verb = "RunAS";
            BurnProcess.Start();
            BurnProcess.StandardInput.WriteLine("&exit");

            result = BurnProcess.StandardOutput.ReadToEnd();
            result1 = BurnProcess.StandardError.ReadToEnd();
            BurnProcess.WaitForExit();
            BurnProcess.Close();
            richTextBox_Log.AppendText(result);
            richTextBox_Log.AppendText(result1);
            timer_TestTime.Start();
            Console.WriteLine(result);
            Console.WriteLine(result1);
            thread_BurnProgram.Abort();
        }
        /**********************************************************************/

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        void ShowDate(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            label_Time.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void timer_TestTime_Tick(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            SelfTest_Time.Text = times_used.ToString();
            times_used++;
            if (times_used >= 50)
            {
                timer_TestTime.Stop();
                times_used = 0;
                label_TestState.Text = "测试结束...";
                if(textBox_PCA9555.Text.Contains("异常") || textBox_TSM12.Text.Contains("异常") ||
                   textBox_CardReader.Text.Contains("异常") || textBox_IL005.Text.Contains("异常") ||
                   textBox_NB.Text.Contains("异常"))
                {
                    textBox_Burn.Text = "测试失败!!!";
                }
                else
                    textBox_Burn.Text = "测试通过!!!";
                /*********此处上传测试结果到MES************/
            }
        }

        private void button_WriteSN_Click(object sender, EventArgs e)
        {
            SN = textBox_SN.Text;
            Console.WriteLine(SN);
            richTextBox_Log.AppendText(SN + '\n');
        }
        /**/
        protected override void WndProc(ref Message m)
        {
            //Console.WriteLine(m.WParam.ToInt32());
            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    string[] ports = SerialPort.GetPortNames();
                    switch (m.WParam.ToInt32())
                    {
                        case DBT_DEVICEARRIVAL:
                            comboBox_Golden.Items.Clear();
                            comboBox_Test.Items.Clear();
                            comboBox_Scaner.Items.Clear();
                            comboBox_Golden.Items.AddRange(ports);
                            comboBox_Test.Items.AddRange(ports);
                            comboBox_Scaner.Items.AddRange(ports);
                            comboBox_Test.SelectedIndex = 0;
                            comboBox_Golden.SelectedIndex = 0;
                            comboBox_Scaner.SelectedIndex = 0;
                            Console.WriteLine("USB设备插入.");
                            break;
                        case DBT_DEVICEREMOVECOMPLETE:
                            comboBox_Golden.Items.Clear();
                            comboBox_Test.Items.Clear();
                            comboBox_Scaner.Items.Clear();
                            comboBox_Golden.Items.AddRange(ports);
                            comboBox_Test.Items.AddRange(ports);
                            comboBox_Scaner.Items.AddRange(ports);
                            comboBox_Test.SelectedIndex = 0;
                            comboBox_Golden.SelectedIndex = 0;
                            comboBox_Scaner.SelectedIndex = 0;
                            Console.WriteLine("USB设备拔出.");
                            break;

                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);　　//异常处理函数
            }
            base.WndProc(ref m);
        }

    }
}
