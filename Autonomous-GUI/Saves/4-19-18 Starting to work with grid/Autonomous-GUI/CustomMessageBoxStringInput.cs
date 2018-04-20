using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autonomous_GUI
{
    public partial class CustomMessageBoxStringInput : Form
    {
        public string input { get; set; }

        public CustomMessageBoxStringInput(string message)
        {
            InitializeComponent();

            label_message.Text = message;
        }

        private void label_message_Click(object sender, EventArgs e)
        {

        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            input = textBox_input.Text;
            this.Close();
        }
    }
}
