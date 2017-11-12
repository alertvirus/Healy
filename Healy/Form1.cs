using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healy
{
    public partial class Form1 : Form
    {
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        //[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        //public static extern bool ReleaseCapture();

        //private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}

        public Form1()
        {
            InitializeComponent();
            browserSidePanel.Height = button1.Height;
            browserSidePanel.Top = button1.Top;
            browserUserControl1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            browserSidePanel.Height = button1.Height;
            browserSidePanel.Top = button1.Top;
            browserUserControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            browserSidePanel.Height = button2.Height;
            browserSidePanel.Top = button2.Top;
            outlookUserControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            browserSidePanel.Height = button3.Height;
            browserSidePanel.Top = button3.Top;
            ucGeneral1.BringToFront();
        }
    }
}
