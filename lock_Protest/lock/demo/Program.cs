using System;
using System.Windows.Forms;
using System.IO;

namespace Logon
{
    static class Program
    {
        public static bool isValidUser;
        public static string username;
        public static string password;
        public static SKT.LeanMES.WSAPI.BLL.DoMain dllMes1;
        public static FileStream fs;
        public static StreamWriter sw;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists(".\\log.txt"))
            {
                Console.WriteLine(File.Exists(".\\log.txt"));
                fs = new FileStream(".\\log.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            }
            else
            {
                Console.WriteLine(File.Exists(".\\log.txt"));
                fs = new FileStream(".\\log.txt", FileMode.Append);
            }
            sw = new StreamWriter(fs);
            Application.Run(new Logon()); //登录窗口
            if (isValidUser)
            {
                Application.Run(new MainWindow()); //测试窗口
            }
        }
    }
}
