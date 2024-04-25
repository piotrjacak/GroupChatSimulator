namespace pge_lab_3
{
    partial class ConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutConnect = new TableLayoutPanel();
            buttonConnect = new Button();
            progressBar1 = new ProgressBar();
            tableLayoutParameters = new TableLayoutPanel();
            tableAddress = new TableLayoutPanel();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            tablePort = new TableLayoutPanel();
            labelPort = new Label();
            textBoxPort = new TextBox();
            tableUser = new TableLayoutPanel();
            labelUsername = new Label();
            textBoxUser = new TextBox();
            tableKey = new TableLayoutPanel();
            labelKey = new Label();
            textBoxKey = new TextBox();
            checkBoxShowKey = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutConnect.SuspendLayout();
            tableLayoutParameters.SuspendLayout();
            tableAddress.SuspendLayout();
            tablePort.SuspendLayout();
            tableUser.SuspendLayout();
            tableKey.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutConnect, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutParameters, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBoxShowKey, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(615, 228);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutConnect
            // 
            tableLayoutConnect.ColumnCount = 2;
            tableLayoutConnect.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 448F));
            tableLayoutConnect.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutConnect.Controls.Add(buttonConnect, 1, 0);
            tableLayoutConnect.Controls.Add(progressBar1, 0, 0);
            tableLayoutConnect.Dock = DockStyle.Fill;
            tableLayoutConnect.Location = new Point(4, 173);
            tableLayoutConnect.Margin = new Padding(4, 2, 4, 2);
            tableLayoutConnect.Name = "tableLayoutConnect";
            tableLayoutConnect.RowCount = 1;
            tableLayoutConnect.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutConnect.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutConnect.Size = new Size(607, 53);
            tableLayoutConnect.TabIndex = 0;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(452, 2);
            buttonConnect.Margin = new Padding(4, 2, 4, 2);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(150, 47);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(4, 2);
            progressBar1.Margin = new Padding(4, 2, 4, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(440, 49);
            progressBar1.TabIndex = 1;
            // 
            // tableLayoutParameters
            // 
            tableLayoutParameters.ColumnCount = 2;
            tableLayoutParameters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutParameters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutParameters.Controls.Add(tableAddress, 0, 0);
            tableLayoutParameters.Controls.Add(tablePort, 1, 0);
            tableLayoutParameters.Controls.Add(tableUser, 0, 1);
            tableLayoutParameters.Controls.Add(tableKey, 1, 1);
            tableLayoutParameters.Dock = DockStyle.Fill;
            tableLayoutParameters.Location = new Point(4, 2);
            tableLayoutParameters.Margin = new Padding(4, 2, 4, 2);
            tableLayoutParameters.Name = "tableLayoutParameters";
            tableLayoutParameters.RowCount = 2;
            tableLayoutParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutParameters.Size = new Size(607, 110);
            tableLayoutParameters.TabIndex = 1;
            // 
            // tableAddress
            // 
            tableAddress.ColumnCount = 2;
            tableAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableAddress.Controls.Add(labelAddress, 0, 0);
            tableAddress.Controls.Add(textBoxAddress, 1, 0);
            tableAddress.Dock = DockStyle.Fill;
            tableAddress.Location = new Point(4, 2);
            tableAddress.Margin = new Padding(4, 2, 4, 2);
            tableAddress.Name = "tableAddress";
            tableAddress.RowCount = 1;
            tableAddress.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableAddress.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableAddress.Size = new Size(295, 51);
            tableAddress.TabIndex = 0;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Dock = DockStyle.Fill;
            labelAddress.Location = new Point(4, 0);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(139, 51);
            labelAddress.TabIndex = 0;
            labelAddress.Text = "Address:";
            labelAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Dock = DockStyle.Fill;
            textBoxAddress.Location = new Point(151, 2);
            textBoxAddress.Margin = new Padding(4, 2, 4, 2);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(140, 39);
            textBoxAddress.TabIndex = 1;
            textBoxAddress.Text = "127.0.0.1";
            textBoxAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // tablePort
            // 
            tablePort.ColumnCount = 2;
            tablePort.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePort.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablePort.Controls.Add(labelPort, 0, 0);
            tablePort.Controls.Add(textBoxPort, 1, 0);
            tablePort.Dock = DockStyle.Fill;
            tablePort.Location = new Point(307, 2);
            tablePort.Margin = new Padding(4, 2, 4, 2);
            tablePort.Name = "tablePort";
            tablePort.RowCount = 1;
            tablePort.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePort.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tablePort.Size = new Size(296, 51);
            tablePort.TabIndex = 1;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Dock = DockStyle.Fill;
            labelPort.Location = new Point(4, 0);
            labelPort.Margin = new Padding(4, 0, 4, 0);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(140, 51);
            labelPort.TabIndex = 0;
            labelPort.Text = "Port:";
            labelPort.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPort
            // 
            textBoxPort.Dock = DockStyle.Fill;
            textBoxPort.Location = new Point(152, 2);
            textBoxPort.Margin = new Padding(4, 2, 4, 2);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(140, 39);
            textBoxPort.TabIndex = 1;
            textBoxPort.Text = "9000";
            textBoxPort.TextAlign = HorizontalAlignment.Center;
            // 
            // tableUser
            // 
            tableUser.ColumnCount = 2;
            tableUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableUser.Controls.Add(labelUsername, 0, 0);
            tableUser.Controls.Add(textBoxUser, 1, 0);
            tableUser.Dock = DockStyle.Fill;
            tableUser.Location = new Point(4, 57);
            tableUser.Margin = new Padding(4, 2, 4, 2);
            tableUser.Name = "tableUser";
            tableUser.RowCount = 1;
            tableUser.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableUser.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableUser.Size = new Size(295, 51);
            tableUser.TabIndex = 2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Dock = DockStyle.Fill;
            labelUsername.Location = new Point(4, 0);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(139, 51);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username:";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxUser
            // 
            textBoxUser.Dock = DockStyle.Fill;
            textBoxUser.Location = new Point(151, 2);
            textBoxUser.Margin = new Padding(4, 2, 4, 2);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(140, 39);
            textBoxUser.TabIndex = 1;
            textBoxUser.Text = "user";
            textBoxUser.TextAlign = HorizontalAlignment.Center;
            // 
            // tableKey
            // 
            tableKey.ColumnCount = 2;
            tableKey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableKey.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableKey.Controls.Add(labelKey, 0, 0);
            tableKey.Controls.Add(textBoxKey, 1, 0);
            tableKey.Dock = DockStyle.Fill;
            tableKey.Location = new Point(307, 57);
            tableKey.Margin = new Padding(4, 2, 4, 2);
            tableKey.Name = "tableKey";
            tableKey.RowCount = 1;
            tableKey.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableKey.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableKey.Size = new Size(296, 51);
            tableKey.TabIndex = 3;
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Dock = DockStyle.Fill;
            labelKey.Location = new Point(4, 0);
            labelKey.Margin = new Padding(4, 0, 4, 0);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(140, 51);
            labelKey.TabIndex = 0;
            labelKey.Text = "Key:";
            labelKey.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxKey
            // 
            textBoxKey.Dock = DockStyle.Fill;
            textBoxKey.Location = new Point(152, 2);
            textBoxKey.Margin = new Padding(4, 2, 4, 2);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(140, 39);
            textBoxKey.TabIndex = 1;
            textBoxKey.TextAlign = HorizontalAlignment.Center;
            textBoxKey.UseSystemPasswordChar = true;
            // 
            // checkBoxShowKey
            // 
            checkBoxShowKey.AutoSize = true;
            checkBoxShowKey.Dock = DockStyle.Right;
            checkBoxShowKey.Location = new Point(463, 116);
            checkBoxShowKey.Margin = new Padding(4, 2, 4, 2);
            checkBoxShowKey.Name = "checkBoxShowKey";
            checkBoxShowKey.Size = new Size(148, 53);
            checkBoxShowKey.TabIndex = 2;
            checkBoxShowKey.Text = "Show key";
            checkBoxShowKey.UseVisualStyleBackColor = true;
            checkBoxShowKey.CheckedChanged += checkBoxShowKey_CheckedChanged;
            checkBoxShowKey.Click += checkBoxShowKey_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // ConnectForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 228);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "ConnectForm";
            Text = "Connect";
            Load += ConnectForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutConnect.ResumeLayout(false);
            tableLayoutParameters.ResumeLayout(false);
            tableAddress.ResumeLayout(false);
            tableAddress.PerformLayout();
            tablePort.ResumeLayout(false);
            tablePort.PerformLayout();
            tableUser.ResumeLayout(false);
            tableUser.PerformLayout();
            tableKey.ResumeLayout(false);
            tableKey.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutConnect;
        private TableLayoutPanel tableLayoutParameters;
        private TableLayoutPanel tableAddress;
        private TableLayoutPanel tablePort;
        private TableLayoutPanel tableUser;
        private TableLayoutPanel tableKey;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Label labelPort;
        private TextBox textBoxPort;
        private Label labelUsername;
        private TextBox textBoxUser;
        private Label labelKey;
        private TextBox textBoxKey;
        private Button buttonConnect;
        private ProgressBar progressBar1;
        private CheckBox checkBoxShowKey;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}