using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pingwithloop
{
    public partial class Pingwithloop : Form
    {
        
        public Pingwithloop()
        {
            InitializeComponent();
            MyInit();
        }
        public void MyInit()
        {
            
        
            buttonPingLoopStart.Enabled = true;
            buttonPingLoopStop.Enabled = false;

            

        }
        IPAddress ip;
        int counterSuccess = 0;
        int counterFailed = 0;
        int counterAll = 0;

        



        public void PingIP()
        {
            byte[] buffer = new byte[Convert.ToInt32(textBoxBufferSize.Text)];
            bool ValidateIP = IPAddress.TryParse(textBoxIP.Text, out ip);
            if (!ValidateIP)
            {
                MessageBox.Show("Zadejte platnou IP", "Kontrola IP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Stop();
                MyInit();
                
            }
            else
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(textBoxIP.Text, Convert.ToInt32(textBoxTimeOut.Text), buffer);
                DateTime now = DateTime.Now;
                
                if (reply.Status == IPStatus.Success)
                {
                    //textBoxSuccess.AppendText("Ping to " + textBoxIP.Text + " " + reply.Status + " " + now + Environment.NewLine);
                    counterSuccess++;
                    labelCounterSuccess.Text = counterSuccess.ToString();
                    dataGridViewSuccess.Rows.Add (textBoxIP.Text, textBoxBufferSize.Text,  reply.Status, DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("HH:mm:ss"));

                }
                else
                {
                    //textBoxFailed.AppendText("Ping to " + textBoxIP.Text + " " + reply.Status + " " + now + Environment.NewLine);
                    counterFailed++;
                    labelCounterFailed.Text = counterFailed.ToString();
                    dataGridViewFailed.Rows.Add(textBoxIP.Text, textBoxBufferSize.Text, reply.Status, DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("HH:mm:ss"));
                }
                counterAll = counterSuccess + counterFailed;
                labelCounterAll.Text = counterAll.ToString();
                

            }
            
        }
        private void buttonPing_Click(object sender, EventArgs e)
        {
            PingIP();
        }
        public int ticks;
        private void onTick(object sender, EventArgs e)
        {
            ticks++;
            
            //progressBarCounterLimit.Maximum = Convert.ToInt32(textBoxCounterLimit.Text);
            //progressBarCounterLimit.Value = _ticks;
            PingIP();
            if (labelCounterAll.Text == textBoxCounterLimit.Text)
            {
                timer1.Stop();
                buttonPingLoopStart.Enabled = true;
                buttonPingLoopStop.Enabled = false;
                labelStatus.Text = "Stoped";

            }
        }
        
        private void buttonPingLoopStart_Click(object sender, EventArgs e)
        {
            
            
            timer1.Start();
            timer1.Interval =  Convert.ToInt32(textBoxTimeLoop.Text) * 1000;
            buttonPingLoopStart.Enabled = false;
            buttonPingLoopStop.Enabled = true;
            labelStatus.Text = "Running";
            labelStatus.ForeColor = Color.Green;
        }

        private void buttonPingLoopStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonPingLoopStart.Enabled = true;
            buttonPingLoopStop.Enabled = false;
            labelStatus.Text = "Stoped";
            labelStatus.ForeColor = Color.Red;
        }

        private void buttonClearSuccess_Click(object sender, EventArgs e)
        {
            dataGridViewSuccess.Rows.Clear();
            labelCounterAll.Text = "0";
            labelCounterSuccess.Text = "0";
            counterSuccess = 0;
        }

        private void buttonClearFailed_Click(object sender, EventArgs e)
        {
            dataGridViewFailed.Rows.Clear();
            labelCounterAll.Text = "0";
            labelCounterFailed.Text = "0";
            counterFailed = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/petr-maly/");
        }
    }
}
