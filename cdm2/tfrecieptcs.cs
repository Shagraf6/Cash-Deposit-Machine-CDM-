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
    public partial class tfrecieptcs : Form
    {
        int amount1; int amount2; int pincode;
        public tfrecieptcs(int amount1,int amount2,int pincode)
        {
            InitializeComponent();
            this.amount1 = amount1;
            this.amount2 = amount2;
            this.pincode = pincode;
            label4.Text = this.amount1.ToString();
            label5.Text = (this.amount1 - this.amount2).ToString();
            label6.Text = this.amount2.ToString();
            label2.Text = "Your transfered amount\n   to account ' " + this.pincode+" '";
        }

        private void tfrecieptcs_Load(object sender, EventArgs e)
        {
         //   main mn = new main(this.amount1);
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   T H A N K   Y O U !!", "C D M   S Y S T E M");
            Application.Exit();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("  CONFIRM  YOU  WANT  TO  CANCEL TRANSACTION ? ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //main mn = new main(this, this.n);
                MessageBox.Show("T H A N K    Y O U !!", "C D M   S Y S T E M");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transfer tra = new transfer(this.amount2, this.amount2,this.pincode);
            this.Hide();
            tra.Show();
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\n\n                       CASH DEPOSIT MACHINE");
            richTextBox1.AppendText("\n------------------------------------------------------------------------------------");
            richTextBox1.AppendText("\n\n\n\n\nYour previous amount             " + this.amount1);
            richTextBox1.AppendText("\nYour transfered amount           " + (this.amount1 - this.amount2)+"   to account ' "+this.pincode+" '");
            richTextBox1.AppendText("\nYour Current balance              " + this.amount2);
            richTextBox1.AppendText("\n\n\n--------------------------------------------------------------------------------\n");
            richTextBox1.AppendText("\n\n               ----------T H A N K   Y O U------------");
        }

        private void label2_Click(object sender, EventArgs e)
        {
         //   label2.Text = ("Your transfered amount to account" + this.pincode).ToStri;
        }
    }
}
