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
            lboxDay.Items.Add(enumDay.Monday.ToString());
            lboxDay.Items.Add(enumDay.Tuesday.ToString());
            lboxDay.Items.Add(enumDay.Wednesday.ToString());
            lboxDay.Items.Add(enumDay.Thursday.ToString());
            lboxDay.Items.Add(enumDay.Friday.ToString());
            lboxDay.Items.Add(enumDay.Saturday.ToString());
            lboxDay.Items.Add(enumDay.Sunday.ToString());

            lboxTime.Items.Add(enumTime.Morning.ToString());
            lboxTime.Items.Add(enumTime.Afternoon.ToString());
            lboxTime.Items.Add(enumTime.Evening.ToString());
            lboxTime.Items.Add(enumTime.Night.ToString());
        }
        
        enum enumDay
        {
            Monday, //0
            Tuesday,//1
            Wednesday,//2
            Thursday,//3
            Friday,//4
            Saturday,//5
            Sunday//6
        }

        enum enumTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            //I will meet Junho on Monday Afternoon 
            string strResult = "I will meet " + tboxName.Text + " on " + lboxDay.SelectedItem.ToString() + " "+ lboxTime.SelectedItem.ToString();

            tboxResult.Text = strResult; 
        }

        private void btlResult2_Click(object sender, EventArgs e)
        {
            string strResult = String.Format("I will meet {0} on {1} {2}", tboxName.Text, lboxDay.SelectedItem.ToString(),lboxTime.SelectedItem.ToString() );

            tboxResult.Text = strResult;
        }
    }
}
