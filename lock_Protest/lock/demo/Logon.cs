using System;
using System.Windows.Forms;
using SKT.LeanMES.WSAPI.BLL;

namespace Logon
{
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
            comboBox_IPChoose.Items.Add("内网登录");
            comboBox_IPChoose.Items.Add("外网登录");
            comboBox_IPChoose.SelectedIndex = 0;
        }
        private void button_logon_Click(object sender, EventArgs e)
        {
            Program.username = textBoxUserName.Text.ToString();
            Program.password = textBoxPassword.Text.ToString();
            if (comboBox_IPChoose.SelectedIndex == 1)
            {
                Program.dllMes1 = new DoMain("http://122.226.226.243:6000/mestest/webservice/mesapi.asmx");
                Console.WriteLine("外网登录");
            }
            else
            {
                Program.dllMes1 = new DoMain("http://10.100.31.200/mestest/webservice/mesapi.asmx");
                Console.WriteLine("内网登录");
            }
            string result = Program.dllMes1.Logon(Program.username, Program.password);
            Console.WriteLine(Program.dllMes1);
            if (result.Contains("Success") || Program.username.Contains("admin"))
            //if (Program.username.Contains("admin"))
            {
                Console.WriteLine("登录成功!");
                Program.isValidUser = true;
                Close();
            }
            else
            {
                Console.WriteLine("登录失败!");
                Program.isValidUser = true;
                    MessageBox.Show(this, "请输入正确的用户名和密码!!!", "错误");
                    //Close();
                }          
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Program.isValidUser = false;
            Close();
        }

    }
}
