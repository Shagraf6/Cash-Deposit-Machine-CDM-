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
    public partial class enquiry : Form
    {
        int count; int amount;
        public enquiry(int amount,int count)
        {
            InitializeComponent();
            this.amount = amount;
            this.count = count;
          //  textBox1.Text = this.amount.ToString();
            label2.Text = this.amount.ToString();
        }

        private void enquiry_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("  C O N F I R M   Y O U   W A N T   T O   E X I T ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("T H A N K    Y O U !!", "C D M   S Y S T E M");
                
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main f1 = new main(this.amount,this.count);
            f1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
