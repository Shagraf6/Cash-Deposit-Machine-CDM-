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
    public partial class summary : Form
    {
        int pre; int curr; int n;
        public summary(int pre,int curr,int n)
        {
            InitializeComponent();
            this.pre=pre;
            this.curr=curr;
            this.n=n;
            label4.Text = this.pre.ToString();
            label5.Text = (this.curr-this.pre).ToString();
            label6.Text = this.curr.ToString();
        }

        private void summary_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   T H A N K   Y O U !!", "C D M   S Y S T E M");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            depform dep = new depform(curr, n);
            this.Hide();
            dep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("   CONFIRM  YOU  WANT  TO  CANCEL TRANSACTION ?  ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main mn = new main(this.pre, this.n);
                MessageBox.Show("T H A N K    Y O U !!", "C D M   S Y S T E M");
                Application.Exit();
            }
        }

        private void preamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\n\n                          CASH DEPOSIT MACHINE");
            richTextBox1.AppendText("\n--------------------------------------------------------------------------------");
            richTextBox1.AppendText("\n\n\n\n\nYour previous amount             " + this.pre);
            richTextBox1.AppendText("\nYour deposited amount           " + (this.curr - this.pre));
            richTextBox1.AppendText("\nYour Current balance              " + this.curr);
            richTextBox1.AppendText("\n\n\n----------------------------------------------------------------------------\n");
            richTextBox1.AppendText("\n\n                  ----------T H A N K   Y O U------------");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
