using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgectElectr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonForTotalResist_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text));
        }
    }
}
