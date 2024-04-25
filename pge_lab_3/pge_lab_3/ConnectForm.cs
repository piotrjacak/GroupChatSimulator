using Messages;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pge_lab_3
{
    public partial class ConnectForm : Form
    {
        public TcpClient client;
        public StreamWriter STW;
        public StreamReader STR;
        public string username;
        public int connected = 0;

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {
        }

        private void checkBoxShowKey_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBoxShowKey_Click(object sender, EventArgs e)
        {
            if (checkBoxShowKey.Checked)
            {
                textBoxKey.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxKey.UseSystemPasswordChar = true;

            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.WorkerSupportsCancellation = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Messages.Message msgReceived = null;
            Messages.Authorization msgSend = null;
            string stringSend = "";
            string stringReceived = "";

            // Creating client
            try
            {
                client = new TcpClient(textBoxAddress.Text, int.Parse(textBoxPort.Text));
                STW = new StreamWriter(client.GetStream());
                STR = new StreamReader(client.GetStream());
                STW.AutoFlush = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                backgroundWorker1.CancelAsync();
                return;
            }
            this.progressBar1.Invoke(new MethodInvoker(delegate ()
                {
                    progressBar1.Value = 25;
                }));

            // Sending authorization message
            try
            {
                msgSend = new Messages.Authorization(textBoxUser.Text, textBoxKey.Text);
                stringSend = JsonSerializer.Serialize(msgSend);
                STW.WriteLine(stringSend);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.progressBar1.Invoke(new MethodInvoker(delegate ()
                {
                    progressBar1.Value = 0;
                }));
                backgroundWorker1.CancelAsync();
                return;
            }
            this.progressBar1.Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Value = 50;
            }));
            
            // Receiving authorization message
            try
            {
                stringReceived = STR.ReadLine();
                msgReceived = JsonSerializer.Deserialize<Messages.Message>(stringReceived);
                if (msgReceived.Text == "Authorized")
                {
                    this.progressBar1.Invoke(new MethodInvoker(delegate ()
                    {
                        progressBar1.Value = 75;
                    }));
                }
                else
                {
                    throw new Exception("Authorization failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.progressBar1.Invoke(new MethodInvoker(delegate ()
                {
                    progressBar1.Value = 0;
                }));
                backgroundWorker1.CancelAsync();
                return;
            }

            // Confirm Connection
            if (client.Connected)
            {
                this.progressBar1.Invoke(new MethodInvoker(delegate ()
                {
                    progressBar1.Value = 100;
                }));
                connected = 1;
                username = textBoxUser.Text;
                MessageBox.Show("Connected");
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.Close();
                }));
                backgroundWorker1.CancelAsync();
            }
            else
            {
                MessageBox.Show("Something went wrong");
                this.progressBar1.Invoke(new MethodInvoker(delegate ()
                {
                    progressBar1.Value = 0;
                }));
                backgroundWorker1.CancelAsync();
            }
        }
    }
}
