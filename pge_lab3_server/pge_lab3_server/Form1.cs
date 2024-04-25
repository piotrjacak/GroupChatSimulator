using System.Net;
using System.Text.Json;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace pge_lab3_server
{
    public partial class Form1 : Form
    {
        private Dictionary<string, TcpClient> clients = new Dictionary<string, TcpClient>();
        public List<Task> tasks = new List<Task>();
        public TcpListener listener;
        public StreamWriter STW;
        public StreamReader STR = null;
        public string received;
        public string toSend;
        public bool disconnectAll = false;
        public int connected = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                keyTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                keyTextBox.UseSystemPasswordChar = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logListBox.Items.Clear();
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            if (startStopButton.Text == "Start")
            {
                startStopButton.Text = "Stop";
                addressTextBox.Enabled = false;
                portTextBox.Enabled = false;
                sendButton.Enabled = true;
                logListBox.Items.Add($"{DateTime.Now.ToString("HH:mm")} | Listening for incoming connections...");
                logListBox.Items.Add($"{DateTime.Now.ToString("HH:mm")} | IP: {addressTextBox.Text}, Port: {portTextBox.Text}");

                if (backgroundWorker1.IsBusy != true)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                startStopButton.Text = "Start";
                addressTextBox.Enabled = true;
                portTextBox.Enabled = true;
                sendButton.Enabled = false;
                logListBox.Items.Add($"{DateTime.Now.ToString("HH:mm")} | Shutting down current connection...");
                foreach (var cl in clients)
                {
                    cl.Value.Close();
                    logListBox.Items.Add($"{DateTime.Now.ToString("HH:mm")} | Client {cl.Key} has disconnected");
                    clients.Remove(cl.Key);
                }
                backgroundWorker1.CancelAsync();
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            logListBox.Items.Add($"{DateTime.Now.ToString("HH:mm")} | Server: {message}");
            Task sendTask = Task.Run(() =>
            {
                communicationToUsers("Server", message);
            });
            sendTask.Wait();
            messageTextBox.Text = "";
        }

        // Worker for connecting with all clients
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string received = "";
            string sent = "";
            Messages.Authorization? receivedAuthorization = null;
            Messages.Message sentMessage;
            int connected = 0;
         

            // Creating listener
            try
            {
                listener = new TcpListener(IPAddress.Parse(addressTextBox.Text), int.Parse(portTextBox.Text));
                listener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This server is already opened");
                backgroundWorker1.CancelAsync();
                return;
            }

            while (true)
            {
                TcpClient client;
                client = listener.AcceptTcpClient();
                STR = new StreamReader(client.GetStream());
                STW = new StreamWriter(client.GetStream());
                STW.AutoFlush = true;
                // Waiting for client 
                try
                {
                    while ((received = STR.ReadLine()) == null) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    break;
                }

                // Sending authorization message
                if (received != null)
                {
                    receivedAuthorization = JsonSerializer.Deserialize<Messages.Authorization>(received);
                    this.logListBox.Invoke(new MethodInvoker(delegate ()
                    {
                        logListBox.Items.Add($"{DateTime.Now.ToString("HH:mm")} | New client... Authorizing");
                    }));

                    if (receivedAuthorization.Key == keyTextBox.Text)
                    {
                        sentMessage = new Messages.Message(userTextBox.Text, "Authorized", DateTime.Now);
                        try
                        {
                            sent = JsonSerializer.Serialize(sentMessage);
                            STW.WriteLine(sent);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                            break;
                        }
                    }
                    else
                    {
                        sentMessage = new Messages.Message(userTextBox.Text, "Unauthorized", DateTime.Now);
                        try
                        {
                            sent = JsonSerializer.Serialize(sentMessage);
                            STW.WriteLine(sent);
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                            break;
                        }
                    }
                }

                // Checking connection
                if (client.Connected)
                {
                    connected++;
                    this.logListBox.Invoke(new MethodInvoker(delegate ()
                    {
                        logListBox.Items.Add($"{DateTime.Now.ToString("HH:mm")} | {receivedAuthorization.Sender} has connected");
                    }));
                    this.usersListView.Invoke(new MethodInvoker(delegate ()
                    {
                        ListViewItem userItem = new ListViewItem(new[] { $"{connected}", $"{receivedAuthorization.Sender}", "Disconnect" });
                        usersListView.Items.Add(userItem);
                    }));
                    clients.Add(receivedAuthorization.Sender, client);
                    Task clientTask = Task.Run(() =>
                    {
                        communicationFromUser(receivedAuthorization.Sender);
                    });
                    tasks.Add(clientTask);
                }
            }
            return;
        }

        private void communicationFromUser(string user)
        {
            string message;
            Messages.Message getMessage;

            if (!clients.TryGetValue(user, out TcpClient cl))
                return;

            StreamReader str = new StreamReader(cl.GetStream());
            while ((message = str.ReadLine()) != null && cl.Connected)
            {
                try
                {
                    getMessage = JsonSerializer.Deserialize<Messages.Message>(message);
                    this.logListBox.Invoke(new MethodInvoker(delegate ()
                    {
                        logListBox.Items.Add($"{getMessage.Time.ToString("HH:mm")} | {user}: {getMessage.Text}");
                    }));
                    communicationToUsers(user, getMessage.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            this.logListBox.Invoke(new MethodInvoker(delegate ()
            {
                logListBox.Items.Add($"{DateTime.Now.ToString("HH:mm")} | {user} has disconnected");
            }));
            clients.Remove(user);
            return;
        }

        private void communicationToUsers(string sender, string message)
        {
            foreach (var client in clients)
            {
                if (client.Key == sender) continue;
                try
                {
                    StreamWriter stw = new StreamWriter(client.Value.GetStream());
                    stw.AutoFlush = true;
                    Messages.Message Message = new Messages.Message(sender, message, DateTime.Now);
                    string jsonMessage = JsonSerializer.Serialize(Message);
                    stw.WriteLine(jsonMessage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void disconnectAllButton_Click(object sender, EventArgs e)
        {  
            foreach (var cl in clients)
            {
                StreamWriter stw = new StreamWriter(cl.Value.GetStream());
                stw.AutoFlush = true;
                Messages.Message endMessage = new Messages.Message(cl.Key, "", DateTime.Now);
                string end = JsonSerializer.Serialize(endMessage);
                stw.WriteLine(end);
                cl.Value.Dispose();
                cl.Value.Close();
            }
            Task.WaitAll(tasks.ToArray());
        }
    }
}
