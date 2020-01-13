using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterMango
{
    public partial class Story2 : Form
    {
        public Story2()
        {
            InitializeComponent();
        }

        int time1 = 0;
        int time2 = 0;
        int time3 = 0;
        int time4 = 0;
        int time5 = 0;

        string status1 = "";
        string status2 = "";
        string status3 = "";
        string status4 = "";
        string status5 = "";

        bool check1 = false;
        bool check2 = false;
        bool check3 = false;
        bool check4 = false;
        bool check5 = false;

        // Button for Plant 1
        private void button1_Click(object sender, EventArgs e)
        {
            check1 = story4(time1);

            if(check1 == true)
            {
                timer1.Start();
                time1 = 0;
                label6.Text = "";
            }

            else
            {
                label6.Text = "Please wait until 30 seconds to water again";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1++;
            status1 = story2(time1, status1);
            label1.Text = status1.ToString();

            if (story5(time1) == true)
            {
                label6.Text = "";
                label1.Text = "It has been 60 seconds since last watering sessions";
            }

        }

        // Button for Plant 2
        private void button2_Click(object sender, EventArgs e)
        {
            check2 = story4(time2);

            if (check2 == true)
            {
                timer2.Start();
                time2 = 0;
                label7.Text = "";
            }

            else
            {
                label7.Text = "Please wait until 30 seconds to water again";
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time2++;
            status2 = story2(time2, status2);
            label2.Text = status2.ToString();

            if (story5(time2) == true)
            {
                label7.Text = "";
                label2.Text = "It has been 60 seconds since last watering sessions";
            }
        }

        // Button for Plant 3
        private void button3_Click(object sender, EventArgs e)
        {
            check3 = story4(time3);

            if (check3 == true)
            {
                timer3.Start();
                time3 = 0;
                label8.Text = "";
            }

            else
            {
                label8.Text = "Please wait until 30 seconds to water again";
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time3++;
            status3 = story2(time3, status3);
            label3.Text = status3.ToString();

            if (story5(time3) == true)
            {
                label8.Text = "";
                label3.Text = "It has been 60 seconds since last watering sessions";
            }
        }

        // Button for Plant 4
        private void button4_Click(object sender, EventArgs e)
        {
            check4 = story4(time4);

            if (check4 == true)
            {
                timer4.Start();
                time4 = 0;
                label9.Text = "";
            }

            else
            {
                label9.Text = "Please wait until 30 seconds to water again";
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            time4++;
            status4 = story2(time4, status4);
            label4.Text = status4.ToString();

            if (story5(time4) == true)
            {
                label9.Text = "";
                label4.Text = "It has been 60 seconds since last watering sessions";
            }
        }

        // Button for Plant 5
        private void button5_Click(object sender, EventArgs e)
        {
            check5 = story4(time5);

            if (check5 == true)
            {
                timer5.Start();
                time5 = 0;
                label10.Text = "";
            }

            else
            {
                label10.Text = "Please wait until 30 seconds to water again";
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            time5++;
            status5 = story2(time5, status5);
            label5.Text = status5.ToString();

            if(story5(time5) == true)
            {
                label10.Text = "";
                label5.Text = "It has been 60 seconds since last watering sessions";
            }
        }

        // Method for User Story 2
        // As a user, I want to start and stop watering of a plant. A plant takes 10 seconds to water.
        private string story2(int time, string status)
        {
            if (time >= 10)
            {
                status = "Watered " + time.ToString() + " seconds ago.";
                return status;
            }

            else
            {
                status = "Watering... ( " + time.ToString() + " )";
                return status;
            }
        }

        // Method for User Story 4
        // Plants need to rest from watering, so as a User, 
        // I should not be able to water the plant again within 30 seconds of the last watering session.
        private bool story4(int time)
        {
            if((time >= 30) || (time == 0))
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // Method for User Story 5
        // As a user, I should be visually alerted if a plant hasn’t been watered for more than 6 hours.
        // Instead of 6 hours, its 60 seconds, for testing purposes.
        private bool story5(int time)
        {
            if(time >= 60)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Method for User Story 3
        // The system should support watering multiple plants at the same time.
        private void button6_Click(object sender, EventArgs e)
        {
            check1 = story4(time1);

            if (check1 == true)
            {
                timer1.Start();
                time1 = 0;
                label6.Text = "";
            }

            else
            {
                label6.Text = "Please wait until 30 seconds to water again";
            }

            check2 = story4(time2);

            if (check2 == true)
            {
                timer2.Start();
                time2 = 0;
                label7.Text = "";
            }

            else
            {
                label7.Text = "Please wait until 30 seconds to water again";
            }

            check3 = story4(time3);

            if (check3 == true)
            {
                timer3.Start();
                time3 = 0;
                label8.Text = "";
            }

            else
            {
                label8.Text = "Please wait until 30 seconds to water again";
            }

            check4 = story4(time4);

            if (check4 == true)
            {
                timer4.Start();
                time4 = 0;
                label9.Text = "";
            }

            else
            {
                label9.Text = "Please wait until 30 seconds to water again";
            }

            check5 = story4(time5);

            if (check5 == true)
            {
                timer5.Start();
                time5 = 0;
                label10.Text = "";
            }

            else
            {
                label10.Text = "Please wait until 30 seconds to water again";
            }

        }
    }
}
