using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;

namespace PingMonitor
{
    public partial class Test : Form
    {
        private readonly Timer timer;
        private readonly Ping pingClass;
        private readonly IPAddress ipAddress;
        private readonly int timeout;
        int[] pingHistory = new int[60];
        int secondsPassed = 0;

        public Test()
        {
            InitializeComponent();
            IPAddress.TryParse("216.52.241.254", out ipAddress);
            timer = new Timer();
            timeout = 3000;
            pingClass = new Ping();
            pingClass.PingCompleted += PingClassPingCompleted;
        }

        void PingClassPingCompleted(object sender, PingCompletedEventArgs e)
        {
            if(e != null)
            {
                if(e.Reply != null)
                {
                    RefreshPing(e.Reply);
            
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Tick += TimerTick;
            timer.Interval = 1000;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            pingClass.SendAsyncCancel();
            pingClass.SendAsync(ipAddress, timeout);
        }

        private void RefreshPing(PingReply r)
        {
            if (r.Status == IPStatus.Success)
            {
                if (r.RoundtripTime <= 100)
                {
                    currentPing.ForeColor = Color.Green;
                }
                else if (r.RoundtripTime <= 200)
                {
                    currentPing.ForeColor = Color.Orange;
                }
                else
                {
                    currentPing.ForeColor = Color.Red;
                }
                currentPing.Text = r.RoundtripTime.ToString() + " ms";
                pingHistory[secondsPassed % pingHistory.Length] = (int)r.RoundtripTime;
            }
            else
            {
                currentPing.ForeColor = Color.Red;
                currentPing.Text = "Error";
                pingHistory[secondsPassed % pingHistory.Length] = -1;
            }

            float avgPing = 0;
            int totalPings = 0;

            for (int i = 0; i < pingHistory.Length; i++)
            {
                if (pingHistory[i] != -1 && pingHistory[i] != 0)
                {
                    avgPing += pingHistory[i];
                    totalPings++;
                }
            }

            avgPing /= totalPings;

            if (avgPing <= 100)
            {
                orangeLight.Visible = false;
                redLight.Visible = false;
                greenLight.Visible = true;
            }
            else if (avgPing <= 250)
            {
                orangeLight.Visible = true;
                redLight.Visible = false;
                greenLight.Visible = false;
            }
            else
            {
                orangeLight.Visible = false;
                redLight.Visible = true;
                greenLight.Visible = false;
            }

            secondsPassed++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /*
        private void t_Tick(object sender, EventArgs e)
        {
            r = p.Send(pingingIP); 

            if (r.Status == IPStatus.Success)
            {
                if(r.RoundtripTime <= 100)
                {
                    currentPing.ForeColor = Color.Green;
                }
                else if(r.RoundtripTime <= 250)
                {
                    currentPing.ForeColor = Color.Orange;
                }
                else
                {
                    currentPing.ForeColor = Color.Red;
                }
                currentPing.Text = r.RoundtripTime.ToString() + " ms";
                pingHistory[secondsPassed % pingHistory.Length] = (int)r.RoundtripTime;
            }
            else
            {
                currentPing.ForeColor = Color.Red;
                currentPing.Text = "Error";
                pingHistory[secondsPassed % pingHistory.Length] = -1;
            }

            float avgPing = 0;
            int totalPings = 0;
            
            for (int i = 0; i < pingHistory.Length; i++)
            {
                if (pingHistory[i] != -1 && pingHistory[i] != 0)
                {
                    avgPing += pingHistory[i];
                    totalPings++;
                }
            }

            avgPing /= totalPings;

            if(avgPing <= 100)
            {
                orangeLight.Visible = false;
                redLight.Visible = false;
                greenLight.Visible = true;
            }
            else if (avgPing <= 250)
            {
                orangeLight.Visible = true;
                redLight.Visible = false;
                greenLight.Visible = false;
            }
            else
            {
                orangeLight.Visible = false;
                redLight.Visible = true;
                greenLight.Visible = false;
            }

            secondsPassed++;
        }
         */
    }
}
