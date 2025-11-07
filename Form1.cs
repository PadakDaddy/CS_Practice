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
            ifTest();
            switchTest();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void switchTest()
        {
            int iRet = 3;
            string strResult = "";
            switch (iRet)
            {
                case 3:
                    {
                        strResult = "2 or 3";
                    }
                    break;
                case 4:
                    {
                        strResult = "4";
                    }
                    break;
                default:
                    {
                        strResult = "I do not know";
                    }
                    break;
            }
        }


        private void ifTest()
        {
            int ia = 30;
            int ib = 20;

            string strResult = "";

            if (ia > ib)
            {
                strResult = "ia is bigger";
            }
            else if (ia < ib)
            {
                strResult = "ia is smaller";
            }
            else
            {
                strResult = "ia, ib are same";
            }

            strResult = (ia > ib) ? "ia is bigger" : "ia, ib are same";

        }

        private void btnIfResult_Click(object sender, EventArgs e)
        {
            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;

            if(iNumber1 > iNumber2)
            {
                lblIfResult.Text = string.Format("- Number1 is {0} bigger than Number2.", iNumber1 - iNumber2);
            }
            else if (iNumber1 < iNumber2)
            {
                lblIfResult.Text = string.Format("- Number2 is {0} bigger than Number1.", iNumber2 - iNumber1);
            }
            else
            {
                lblIfResult.Text =string.Format( "Number 1,2 are same. Number is {0}" , iNumber1);
            }
        }

        private void btnSwitchResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "Monday":
                    lblSwitchResult.Text = "- Selected day is Monday";
                    break;
                case "TuesDay":
                    lblSwitchResult.Text = "- Selected day is TuesDay";
                    break;
                case "Wednesday":
                    lblSwitchResult.Text = "- Selected day is Wednesday";
                    break;
                case "Thursday":
                    lblSwitchResult.Text = "- Selected day is Thursday";
                    break;
                case "Friday":
                    lblSwitchResult.Text = "- Selected day is Friday";
                    break;
                default:
                    lblSwitchResult.Text = "- Selected day is Weekend";
                    break;
            }
        }
    }
}
