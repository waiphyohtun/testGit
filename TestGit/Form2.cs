using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGit
{
    public partial class Form2 : Form
    {
        string str = "";
        public Form2(string s)
        {
            InitializeComponent();
            str = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer :" + str);
        }
    }
}
