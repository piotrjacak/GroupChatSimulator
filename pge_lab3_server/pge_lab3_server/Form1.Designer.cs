namespace pge_lab3_server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            connectionTableLayout = new TableLayoutPanel();
            startStopButton = new Button();
            clearButton = new Button();
            disconnectAllButton = new Button();
            label1 = new Label();
            DetailConnectionTableLayout = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            addressTable = new TableLayoutPanel();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            userTable = new TableLayoutPanel();
            userLabel = new Label();
            userTextBox = new TextBox();
            portTable = new TableLayoutPanel();
            portLabel = new Label();
            portTextBox = new TextBox();
            keyTable = new TableLayoutPanel();
            keyLabel = new Label();
            keyTextBox = new TextBox();
            MessagesTableLayout = new TableLayoutPanel();
            sendTableLayout = new TableLayoutPanel();
            sendButton = new Button();
            messageTextBox = new TextBox();
            logListBox = new ListBox();
            usersListView = new ListView();
            idColumn = new ColumnHeader();
            nameColumn = new ColumnHeader();
            disconnectColumn = new ColumnHeader();
            listView1 = new ListView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            mainLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            connectionTableLayout.SuspendLayout();
            DetailConnectionTableLayout.SuspendLayout();
            addressTable.SuspendLayout();
            userTable.SuspendLayout();
            portTable.SuspendLayout();
            keyTable.SuspendLayout();
            MessagesTableLayout.SuspendLayout();
            sendTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.ColumnCount = 2;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.07872F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9212837F));
            mainLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            mainLayoutPanel.Controls.Add(usersListView, 1, 0);
            mainLayoutPanel.Controls.Add(listView1, 0, 1);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Margin = new Padding(4, 2, 4, 2);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.RowCount = 2;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayoutPanel.Size = new Size(1827, 1410);
            mainLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(connectionTableLayout, 0, 0);
            tableLayoutPanel1.Controls.Add(MessagesTableLayout, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(6, 6);
            tableLayoutPanel1.Margin = new Padding(6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.4635754F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.53642F));
            tableLayoutPanel1.Size = new Size(1103, 1378);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // connectionTableLayout
            // 
            connectionTableLayout.ColumnCount = 3;
            connectionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.39081F));
            connectionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.6091957F));
            connectionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 641F));
            connectionTableLayout.Controls.Add(startStopButton, 0, 0);
            connectionTableLayout.Controls.Add(clearButton, 0, 2);
            connectionTableLayout.Controls.Add(disconnectAllButton, 2, 2);
            connectionTableLayout.Controls.Add(label1, 1, 2);
            connectionTableLayout.Controls.Add(DetailConnectionTableLayout, 2, 0);
            connectionTableLayout.Dock = DockStyle.Fill;
            connectionTableLayout.Location = new Point(6, 6);
            connectionTableLayout.Margin = new Padding(6);
            connectionTableLayout.Name = "connectionTableLayout";
            connectionTableLayout.RowCount = 3;
            connectionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 61.3496933F));
            connectionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38.6503067F));
            connectionTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            connectionTableLayout.Size = new Size(1091, 407);
            connectionTableLayout.TabIndex = 0;
            // 
            // startStopButton
            // 
            startStopButton.Location = new Point(6, 6);
            startStopButton.Margin = new Padding(6);
            startStopButton.Name = "startStopButton";
            startStopButton.Size = new Size(139, 49);
            startStopButton.TabIndex = 0;
            startStopButton.Text = "Start";
            startStopButton.UseVisualStyleBackColor = true;
            startStopButton.Click += startStopButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearButton.Location = new Point(6, 352);
            clearButton.Margin = new Padding(6);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(139, 49);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // disconnectAllButton
            // 
            disconnectAllButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            disconnectAllButton.AutoSize = true;
            disconnectAllButton.Location = new Point(758, 350);
            disconnectAllButton.Margin = new Padding(6);
            disconnectAllButton.Name = "disconnectAllButton";
            disconnectAllButton.Size = new Size(327, 51);
            disconnectAllButton.TabIndex = 2;
            disconnectAllButton.Text = "Disconnect All\r\n";
            disconnectAllButton.UseVisualStyleBackColor = true;
            disconnectAllButton.Click += disconnectAllButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(390, 359);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 32);
            label1.TabIndex = 3;
            label1.Text = "Log";
            // 
            // DetailConnectionTableLayout
            // 
            DetailConnectionTableLayout.ColumnCount = 2;
            DetailConnectionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.85251F));
            DetailConnectionTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.14749F));
            DetailConnectionTableLayout.Controls.Add(checkBox1, 1, 2);
            DetailConnectionTableLayout.Controls.Add(addressTable, 0, 0);
            DetailConnectionTableLayout.Controls.Add(userTable, 0, 1);
            DetailConnectionTableLayout.Controls.Add(portTable, 1, 0);
            DetailConnectionTableLayout.Controls.Add(keyTable, 1, 1);
            DetailConnectionTableLayout.Dock = DockStyle.Fill;
            DetailConnectionTableLayout.Location = new Point(455, 6);
            DetailConnectionTableLayout.Margin = new Padding(6);
            DetailConnectionTableLayout.Name = "DetailConnectionTableLayout";
            DetailConnectionTableLayout.RowCount = 3;
            DetailConnectionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DetailConnectionTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DetailConnectionTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            DetailConnectionTableLayout.Size = new Size(630, 199);
            DetailConnectionTableLayout.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(476, 157);
            checkBox1.Margin = new Padding(6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 36);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Show key";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += checkBox1_Click;
            // 
            // addressTable
            // 
            addressTable.ColumnCount = 2;
            addressTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            addressTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            addressTable.Controls.Add(addressLabel, 0, 0);
            addressTable.Controls.Add(addressTextBox, 1, 0);
            addressTable.Dock = DockStyle.Fill;
            addressTable.Location = new Point(6, 6);
            addressTable.Margin = new Padding(6);
            addressTable.Name = "addressTable";
            addressTable.RowCount = 1;
            addressTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            addressTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            addressTable.Size = new Size(302, 58);
            addressTable.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Right;
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(42, 13);
            addressLabel.Margin = new Padding(6, 0, 6, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(103, 32);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Left;
            addressTextBox.Location = new Point(157, 9);
            addressTextBox.Margin = new Padding(6);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(138, 39);
            addressTextBox.TabIndex = 1;
            addressTextBox.Text = "127.0.0.1";
            addressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // userTable
            // 
            userTable.ColumnCount = 2;
            userTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            userTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            userTable.Controls.Add(userLabel, 0, 0);
            userTable.Controls.Add(userTextBox, 1, 0);
            userTable.Dock = DockStyle.Fill;
            userTable.Location = new Point(6, 76);
            userTable.Margin = new Padding(6);
            userTable.Name = "userTable";
            userTable.RowCount = 1;
            userTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            userTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            userTable.Size = new Size(302, 58);
            userTable.TabIndex = 2;
            // 
            // userLabel
            // 
            userLabel.Anchor = AnchorStyles.Right;
            userLabel.AutoSize = true;
            userLabel.Location = new Point(19, 13);
            userLabel.Margin = new Padding(6, 0, 6, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(126, 32);
            userLabel.TabIndex = 0;
            userLabel.Text = "Username:";
            // 
            // userTextBox
            // 
            userTextBox.Anchor = AnchorStyles.Left;
            userTextBox.Location = new Point(157, 9);
            userTextBox.Margin = new Padding(6);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(138, 39);
            userTextBox.TabIndex = 1;
            userTextBox.Text = "Server";
            userTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // portTable
            // 
            portTable.ColumnCount = 2;
            portTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            portTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            portTable.Controls.Add(portLabel, 0, 0);
            portTable.Controls.Add(portTextBox, 1, 0);
            portTable.Dock = DockStyle.Fill;
            portTable.Location = new Point(320, 6);
            portTable.Margin = new Padding(6);
            portTable.Name = "portTable";
            portTable.RowCount = 1;
            portTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            portTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            portTable.Size = new Size(304, 58);
            portTable.TabIndex = 3;
            // 
            // portLabel
            // 
            portLabel.Anchor = AnchorStyles.Right;
            portLabel.AutoSize = true;
            portLabel.Location = new Point(85, 13);
            portLabel.Margin = new Padding(6, 0, 6, 0);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(61, 32);
            portLabel.TabIndex = 0;
            portLabel.Text = "Port:";
            // 
            // portTextBox
            // 
            portTextBox.Anchor = AnchorStyles.Left;
            portTextBox.Location = new Point(158, 9);
            portTextBox.Margin = new Padding(6);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(138, 39);
            portTextBox.TabIndex = 1;
            portTextBox.Text = "9000";
            portTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // keyTable
            // 
            keyTable.ColumnCount = 2;
            keyTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            keyTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            keyTable.Controls.Add(keyLabel, 0, 0);
            keyTable.Controls.Add(keyTextBox, 1, 0);
            keyTable.Dock = DockStyle.Fill;
            keyTable.Location = new Point(320, 76);
            keyTable.Margin = new Padding(6);
            keyTable.Name = "keyTable";
            keyTable.RowCount = 1;
            keyTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            keyTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            keyTable.Size = new Size(304, 58);
            keyTable.TabIndex = 4;
            // 
            // keyLabel
            // 
            keyLabel.Anchor = AnchorStyles.Right;
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(88, 13);
            keyLabel.Margin = new Padding(6, 0, 6, 0);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(58, 32);
            keyLabel.TabIndex = 0;
            keyLabel.Text = "Key:";
            // 
            // keyTextBox
            // 
            keyTextBox.Anchor = AnchorStyles.Left;
            keyTextBox.Location = new Point(158, 9);
            keyTextBox.Margin = new Padding(6);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(138, 39);
            keyTextBox.TabIndex = 1;
            keyTextBox.TextAlign = HorizontalAlignment.Center;
            keyTextBox.UseSystemPasswordChar = true;
            // 
            // MessagesTableLayout
            // 
            MessagesTableLayout.ColumnCount = 1;
            MessagesTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MessagesTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MessagesTableLayout.Controls.Add(sendTableLayout, 0, 1);
            MessagesTableLayout.Controls.Add(logListBox, 0, 0);
            MessagesTableLayout.Dock = DockStyle.Fill;
            MessagesTableLayout.Location = new Point(6, 425);
            MessagesTableLayout.Margin = new Padding(6);
            MessagesTableLayout.Name = "MessagesTableLayout";
            MessagesTableLayout.RowCount = 2;
            MessagesTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 91.1111145F));
            MessagesTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8.888889F));
            MessagesTableLayout.Size = new Size(1091, 947);
            MessagesTableLayout.TabIndex = 1;
            // 
            // sendTableLayout
            // 
            sendTableLayout.ColumnCount = 2;
            sendTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sendTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            sendTableLayout.Controls.Add(sendButton, 1, 0);
            sendTableLayout.Controls.Add(messageTextBox, 0, 0);
            sendTableLayout.Dock = DockStyle.Fill;
            sendTableLayout.Location = new Point(6, 868);
            sendTableLayout.Margin = new Padding(6);
            sendTableLayout.Name = "sendTableLayout";
            sendTableLayout.RowCount = 1;
            sendTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sendTableLayout.Size = new Size(1079, 73);
            sendTableLayout.TabIndex = 0;
            // 
            // sendButton
            // 
            sendButton.Dock = DockStyle.Fill;
            sendButton.Enabled = false;
            sendButton.Location = new Point(899, 6);
            sendButton.Margin = new Padding(6);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(174, 61);
            sendButton.TabIndex = 0;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Dock = DockStyle.Fill;
            messageTextBox.Location = new Point(6, 6);
            messageTextBox.Margin = new Padding(6);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(881, 39);
            messageTextBox.TabIndex = 1;
            // 
            // logListBox
            // 
            logListBox.Dock = DockStyle.Fill;
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 32;
            logListBox.Location = new Point(6, 6);
            logListBox.Margin = new Padding(6);
            logListBox.Name = "logListBox";
            logListBox.ScrollAlwaysVisible = true;
            logListBox.SelectionMode = SelectionMode.None;
            logListBox.Size = new Size(1079, 850);
            logListBox.TabIndex = 1;
            // 
            // usersListView
            // 
            usersListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersListView.Columns.AddRange(new ColumnHeader[] { idColumn, nameColumn, disconnectColumn });
            usersListView.FullRowSelect = true;
            usersListView.Location = new Point(1118, 3);
            usersListView.Name = "usersListView";
            usersListView.RightToLeft = RightToLeft.No;
            usersListView.Size = new Size(706, 1384);
            usersListView.TabIndex = 1;
            usersListView.UseCompatibleStateImageBehavior = false;
            usersListView.View = View.Details;
            // 
            // idColumn
            // 
            idColumn.Text = "ID";
            idColumn.Width = 150;
            // 
            // nameColumn
            // 
            nameColumn.Text = "Name";
            nameColumn.TextAlign = HorizontalAlignment.Center;
            nameColumn.Width = 300;
            // 
            // disconnectColumn
            // 
            disconnectColumn.Text = "Disconnect";
            disconnectColumn.TextAlign = HorizontalAlignment.Center;
            disconnectColumn.Width = 250;
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 1393);
            listView1.Name = "listView1";
            listView1.Size = new Size(242, 14);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1410);
            Controls.Add(mainLayoutPanel);
            Margin = new Padding(4, 2, 4, 2);
            MinimumSize = new Size(1463, 1413);
            Name = "Form1";
            Text = "Server";
            mainLayoutPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            connectionTableLayout.ResumeLayout(false);
            connectionTableLayout.PerformLayout();
            DetailConnectionTableLayout.ResumeLayout(false);
            DetailConnectionTableLayout.PerformLayout();
            addressTable.ResumeLayout(false);
            addressTable.PerformLayout();
            userTable.ResumeLayout(false);
            userTable.PerformLayout();
            portTable.ResumeLayout(false);
            portTable.PerformLayout();
            keyTable.ResumeLayout(false);
            keyTable.PerformLayout();
            MessagesTableLayout.ResumeLayout(false);
            sendTableLayout.ResumeLayout(false);
            sendTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel connectionTableLayout;
        private Button startStopButton;
        private Button clearButton;
        private Button disconnectAllButton;
        private Label label1;
        private TableLayoutPanel DetailConnectionTableLayout;
        private CheckBox checkBox1;
        private TableLayoutPanel addressTable;
        private Label addressLabel;
        private TableLayoutPanel userTable;
        private Label userLabel;
        private TableLayoutPanel portTable;
        private Label portLabel;
        private TableLayoutPanel keyTable;
        private Label keyLabel;
        private TextBox addressTextBox;
        private TextBox userTextBox;
        private TextBox portTextBox;
        private TextBox keyTextBox;
        private TableLayoutPanel MessagesTableLayout;
        private TableLayoutPanel sendTableLayout;
        private Button sendButton;
        private TextBox messageTextBox;
        private ListBox logListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView usersListView;
        private ColumnHeader idColumn;
        private ColumnHeader nameColumn;
        private ColumnHeader disconnectColumn;
        private ListView listView1;
    }
}
