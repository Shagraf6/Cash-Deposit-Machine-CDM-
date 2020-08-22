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
    public partial class deposit : Form
    {
        class customer
        {
            public int pincode;
            public int amount;
            public customer(int pincode, int amount)
            {
                this.pincode = pincode;
                this.amount = amount;
            }
        }
        int amount, count;
        public deposit(int amount,int count)
        {
            InitializeComponent();
            this.amount = amount;
            this.count = count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           depform dep = new depform(this.amount, this.count);
            dep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main(this.amount,this.count);
            m.Show();
        }

        private void deposit_Load(object sender, EventArgs e)
        {

        }
    }
}
