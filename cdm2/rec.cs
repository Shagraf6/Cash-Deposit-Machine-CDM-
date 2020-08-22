using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cdm2
{
    public partial class rec : Form
    {
        int pre; int curr;
        public rec(int pre,int curr)
        {
            InitializeComponent();
            this.pre = pre;
            this.curr = curr;
        }

        private void rec_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.AppendText("CASH DEPOSIT MACHINE");
            richTextBox1.AppendText("----------------------------------------------");
        }
    }
}
