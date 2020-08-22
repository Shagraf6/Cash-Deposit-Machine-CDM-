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
    public partial class Reciept : Form
    {
        int pre; int count; int curr;
        public Reciept(int pre,int curr,int count)
        {
            InitializeComponent();
            this.pre = pre;
            this.curr = curr;
            this.count = count;
            label4.Text = this.pre.ToString();
            label5.Text = (this.pre - this.curr).ToString();
            label6.Text = this.curr.ToString();
        
        }

        private void Reciept_Load(object sender, EventArgs e)
        {

        }

        private void preamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("   T H A N K   Y O U !!", "C D M   S Y S T E M");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdraw with = new withdraw(curr, count);
            this.Hide();
            with.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("   CONFIRM  YOU  WANT  TO  CANCEL TRANSACTION ?  ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main mn = new main(this.pre, this.count);

                MessageBox.Show("   T H A N K   Y O U !!", "C D M   S Y S T E M");
        
                Application.Exit();
            }

           // this.Close();

        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\n\n                        CASH DEPOSIT MACHINE");
            richTextBox1.AppendText("\n----------------------------------------------------------------------------------");
            richTextBox1.AppendText("\n\n\n\n\nYour previous amount            " + this.pre);
            richTextBox1.AppendText("\nYour Withdrew amount           " + (this.pre - this.curr));
            richTextBox1.AppendText("\nYour Current balance               " + this.curr);
            richTextBox1.AppendText("\n\n\n---------------------------------------------------------------------------------\n");
            richTextBox1.AppendText("\n\n                 ----------T H A N K   Y O U------------");
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
