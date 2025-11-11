using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            tboxResult.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            int iResult = 0;

            for (int i = 1; i < 10; i++)
            {
                iResult = iResult + i;
                sb.Append(string.Format("From 1 + to {0} = {1} \r\n", i, iResult));


            }
            tboxResult.Text = sb.ToString();
        }

        private void tboxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}