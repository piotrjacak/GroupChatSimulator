using System.Net.Sockets;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using Messages;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System;

namespace pge_lab_3
{
    public partial class Form1 : Form
    {
        public TcpClient Client;
        public StreamWriter STW;
        public StreamReader STR;
        public string username;
        private MessageUserControl msgUserControl;
        public bool isConnected = false;
        public Task serverTask;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            disconnectToolStripMenuItem.Enabled = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string textBox = textBox1.Text;
            string time = DateTime.Now.ToString("HH:mm");
            string person = "You";
            string message;


            if (string.IsNullOrEmpty(textBox))
            {
                return;
            }

            msgUserControl = new MessageUserControl();
            msgUserControl.Margin = new Padding(50, 2, 0, 2);
            msgUserControl.Width = this.ClientSize.Width - 60;
            msgUserControl.Height = 50;
            msgUserControl.Anchor = AnchorStyles.Right;
            msgUserControl.Dock = DockStyle.None;

            msgUserControl.SetLabelText(person, time, textBox);
            textBox1.Clear();
            flowLayoutPanel1.Controls.Add(msgUserControl);
            msgUserControl.Visible = true;

            if (!isConnected)
            {
                return;
            }
            try
            {
                Messages.Message newMessage = new Messages.Message(username, textBox, DateTime.Now);
                message = JsonSerializer.Serialize(newMessage);
                STW.WriteLine(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                sendButton.PerformClick();
                e.Handled = true;
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ConnectForm dialog = new ConnectForm())
            {
                dialog.ShowDialog();
                if (dialog.connected == 1)
                {
                    this.Client = dialog.client;
                    this.STW = dialog.STW;
                    this.STW.AutoFlush = true;
                    this.STR = dialog.STR;
                    this.username = dialog.username;

                    isConnected = true;
                    connectToolStripMenuItem.Enabled = false;
                    disconnectToolStripMenuItem.Enabled = true;

                    Panel panel = new Panel();
                    panel.Height = 40;
                    panel.Width = flowLayoutPanel1.ClientSize.Width - 25;
                    flowLayoutPanel1.Controls.Add(panel);

                    Label newConnected = new Label();
                    newConnected.Text = "Connected";
                    newConnected.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                    newConnected.ForeColor = Color.Black;
                    newConnected.TextAlign = ContentAlignment.MiddleCenter;
                    newConnected.Width = panel.Width - 10;
                    newConnected.Height = 40;
                    newConnected.Left = (panel.Width - newConnected.Width) / 2;
                    newConnected.Anchor = AnchorStyles.None;
                    panel.Controls.Add(newConnected);

                    serverTask = Task.Run(() =>
                    {
                        communicationFromServer();
                    });
                }
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectToolStripMenuItem.Enabled = true;
            isConnected = false;
            disconnectToolStripMenuItem.Enabled = false;

            Messages.Message endMessage = new Messages.Message(username, "", DateTime.Now);
            string end = JsonSerializer.Serialize(endMessage);
            STW.WriteLine(end);

            serverTask.Wait();
            Client.Dispose();
            Client.Close();

            Panel panel = new Panel();
            panel.Height = 40;
            panel.Width = flowLayoutPanel1.ClientSize.Width - 25;
            flowLayoutPanel1.Controls.Add(panel);

            Label disconnected = new Label();
            disconnected.Text = "Disconnected";
            disconnected.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            disconnected.ForeColor = Color.Black;
            disconnected.TextAlign = ContentAlignment.MiddleCenter;
            disconnected.Width = panel.Width - 10;
            disconnected.Height = 40;
            disconnected.Left = (panel.Width - disconnected.Width) / 2;
            disconnected.Anchor = AnchorStyles.None;
            panel.Controls.Add(disconnected);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                Client.Close();
                isConnected = false;
            }
            this.Close();
        }

        private void communicationFromServer()
        {
            string message;
            Messages.Message getMessage;
            StreamReader str = new StreamReader(Client.GetStream());
            while ((message = str.ReadLine()) != null && isConnected)
            {
                try
                {
                    getMessage = JsonSerializer.Deserialize<Messages.Message>(message);
                    msgUserControl = new MessageUserControl();
                    msgUserControl.Margin = new Padding(0, 2, 50, 2);
                    msgUserControl.Width = tableLayoutPanel1.ClientSize.Width;
                    msgUserControl.Height = 50;
                    msgUserControl.Anchor = AnchorStyles.Top & AnchorStyles.Right;
                    msgUserControl.Dock = DockStyle.Fill;


                    msgUserControl.SetLabelText(getMessage.Sender, getMessage.Time.ToString("HH:mm"), getMessage.Text);
                    msgUserControl.Visible = true;

                    this.flowLayoutPanel1.Invoke(new MethodInvoker(delegate ()
                    {
                        flowLayoutPanel1.Controls.Add(msgUserControl);
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
