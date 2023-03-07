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
using System.Threading;

namespace MyFirstWindowsFormsApp
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

       

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent (IntPtr hWndChild, IntPtr hWndNewParent);

        private void button1_Click(object sender, EventArgs e) 
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            { 
            Process proc = Process.Start(ofd.FileName);
            proc.WaitForInputIdle();

                while (proc.MainWindowHandle == IntPtr.Zero)
                { 
                Thread.Sleep(100);
                    proc.Refresh();
                }

            SetParent(proc.MainWindowHandle, this.Handle);

            }

        }

        
    }
}
