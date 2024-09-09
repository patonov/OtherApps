using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Value += 33;
        }

        private void True_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Value += 33;
        }

        private void Have_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Value += 34;
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                toolStripProgressBar1.Value += 5;
            }
            toolStripLabel1.Text = "Working...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
