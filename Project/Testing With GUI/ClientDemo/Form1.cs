﻿using SimpleTCP;
using System;
using System.Text;
using System.Windows.Forms;

namespace ClientDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SimpleTcpClient client;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            //Connect to server
            client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update message to txtStatus
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += "TEST";
                txtStatus.Text += e.MessageString;
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}