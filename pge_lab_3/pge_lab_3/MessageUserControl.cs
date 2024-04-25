using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pge_lab_3
{
    public partial class MessageUserControl : UserControl
    {
        public MessageUserControl()
        {
            InitializeComponent();
        }

        public void SetLabelText(string label1Text, string label2Text, string label3Text)
        {
            label1.Text = label1Text;
            label2.Text = label2Text;
            textBox1.Text = label3Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void MessageUserControl_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Dock = DockStyle.Fill; 
        }
    }
}
