using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.IO;

namespace Program
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private float _btn1xScale;
        private float _btn1yScale;

        public Form1()
        {
            InitializeComponent();
            _btn1xScale = button1.Location.X / (float)pictureBox1.Width;
            _btn1yScale = button1.Location.Y / (float)pictureBox1.Height;
            Bounds = Screen.PrimaryScreen.Bounds;
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode.ToString() == "162")     //Left CTRL
                {
                    return (IntPtr)1;
                }
                else if (vkCode.ToString() == "262144")     //ALT 보조키
                {
                    return (IntPtr)1;
                }
                else if (vkCode.ToString() == "131072")     //CTRL 보조키
                {
                    return (IntPtr)1;
                }
                else if (vkCode.ToString() == "17")     //CTRL
                {
                    return (IntPtr)1;
                }
                else if (vkCode.ToString() == "115")     //F4
                {
                    return (IntPtr)1;
                }
                else if (vkCode.ToString() == "18" && vkCode.ToString() == "9")     //ALT
                {
                    return (IntPtr)1;
                }
                else if (vkCode.ToString() == "92")     //Window
                {
                    return (IntPtr)1;
                }
                else if (vkCode.ToString() == "18")     //ALT
                {
                    return (IntPtr)1;
                }
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
            }
            else
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;

            //DB 서버 중지 시 프로그램 자동 종료
            string conncetstring = string.Format("Server = {0}; Port = {1}; Database = {2}; Uid = {3}; Pwd = {4}", "203.241.227.164", "0415", "user", "root", "1683");
            MySqlConnection conn = new MySqlConnection(conncetstring);
            try
            {
                conn.Open();
                SetHook();
            }
            catch
            {
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnHook();
        }

        private void pictureBoxResize(object sender, EventArgs e)
        {
            button1.Location = new Point(
            (int)(pictureBox1.Width * _btn1xScale),
            (int)(pictureBox1.Height * _btn1yScale));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //사용 시작 버튼 클릭 시 Form2 로드(모달 형식)
            Form2 F2 = new Form2();
            F2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //사용 종료 버튼 클릭 시 Window 종료 메세지 출력
            MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo);

            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start("shutdown", "/s /f /t 0");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
             if (e.KeyData == (Keys.Alt | Keys.F4))
             {
                e.SuppressKeyPress = true;
                return;
             }
        }
    }
}
