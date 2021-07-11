using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace money_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //check if values have been entered
            if (MoneyGot.Text == string.Empty)
            {
                MessageBox.Show("Please enter money recieved");
            }
            else if (TimeGot.Text == string.Empty)
            {
                MessageBox.Show("Please enter time between recieving money");
            }
            else if (TimeTotal.Text == string.Empty)
            {
                MessageBox.Show("Please enter total time recieving money");
            }
            else
            {
                try
                {
                    //define some values
                    float moneyrecieved = float.Parse(MoneyGot.Text);
                    int timeframereceiving = int.Parse(TimeGot.Text);
                    int timeframetotal = int.Parse(TimeTotal.Text);
                    float moneyintime; //total per days
                    int timeneeded; //the required time for the amount of money wanted

                    int timesrecieved = timeframetotal / timeframereceiving; //calculate how many times one recieves money in defined timeframe
                    moneyintime = moneyrecieved * timesrecieved; //calculate total money over time (split into two lines due to int to float funny business)
                    MoneyTotal.Text = moneyintime.ToString(); //output result
                    if (MoneyWant.Text != String.Empty) //only get text and run calculation if something has been entered
                    {
                        float moneywanted = float.Parse(MoneyWant.Text);
                        timeneeded = (int)Math.Ceiling(moneywanted / moneyrecieved * timeframereceiving); //calculate and round to nearest whole number
                        TimeNeed.Text = timeneeded.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Input"); //fail safely if some idiot enters letters
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            var formPopup = new formPopup();
            formPopup.Show(this); // if you need non-modal window
        }
    }
}
/* //todo: learn to delete stuff
                     //Todo: Program days weeks years dropdowns
                    //string timeframetype = TimeFrame.Text;
                    //string timeframetypetotal = TimeFrameTotal.Text;
                    //int timeframe1days;
                    //int timeframe2days;
*/