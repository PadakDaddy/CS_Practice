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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA + iNumB;
            tboxResult.Text = iResult.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA - iNumB;
            tboxResult.Text = iResult.ToString();
        }

        private void btlMulti_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA * iNumB;
            tboxResult.Text = iResult.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA / iNumB; //몫
            //int iResultㅠ = iNumA % iNumB; //나머지
            tboxResult.Text = iResult.ToString();
        }

        private int fPlus(int iNumA, int iNumB)
        {
            int iResult = 0;
            iResult = iNumA + iNumB;
            return iResult; 
        }
    }
}
