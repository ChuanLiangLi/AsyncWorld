using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Thread.Sleep(4000);
            Thread th = new Thread(new ParameterizedThreadStart(ShowName));
            th.Start("Hello ,lichuanliang");
        }
        void  ShowName(object name)
        {
            string name1 = (string)name;
            //() => lblMessage.Text = name1
            lblMessage.Invoke((Action)(delegate() { lblMessage.Text = name1; }));
        }
    }
}
