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
    public partial class depform : Form
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
        int amount; int count; int pincode;
      public depform(int amount,int count)
        {
            InitializeComponent();
            this.amount = amount;
            this.count= count;
//            this.pincode = pincode;
           // this.newcustomer.Add(new customer(amount, pincode));
        }
        private void depform_Load(object sender, EventArgs e)
        {
            DialogResult result;
            this.Show();
            result=MessageBox.Show("DO NOT DEPOSIT MORE THAN 200 NOTES \n YOU CAN DEPOSIT UPTO 5000 ONLY","C D M   S E R V I C E S",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(result==DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       }

        private void button2_Click(object sender, EventArgs e)
        {

            int temp = this.amount;
            if (input2.Text == "")
                MessageBox.Show(" E N T E R   A M O U N T   T O  B E   D E P O S I T E D", "C D M   S Y S T E M ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(input2.Text!="")
            {
                string inputstring = string.Format(input2.Text);
                int pin2 = Convert.ToInt32(int.Parse(inputstring));

                if (pin2 % 100 != 0)
                {
                    DialogResult ss = MessageBox.Show("ENTER   AMOUNT   IN   MULTIPLE  OF  100", "C D M   S Y S T E M", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (pin2 > 5000)
                {
                    DialogResult result;
                    result = MessageBox.Show("YOU   CAN   YOU   DEPOSIT   UPTO   5000  ONLY  !!", "C D M   S E R V I C E S", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    if (result == DialogResult.Cancel)
                    {
                        result = MessageBox.Show("C0NFIRM   YOU   WANT   TO   EXIT ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    temp = temp + pin2;
                    MessageBox.Show("P L A C E   T H E   C A S H");
                    MessageBox.Show("P L E A S E   W A I T.... \n V A L I D A T I N G   T H E   C A S H....", "C D M   S Y S T E M");
                    main mn = new main(this.count, temp, 1);
                    summary sm = new summary(this.amount, temp, count);
                    this.Hide();
                    sm.Show();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("  CONFIRM   YOU   WANT   TO   CANCEL   TRANSACTION ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main mn = new main(this.amount, this.count);
                MessageBox.Show("   T H A N K   Y O U", "C D M   S Y S T E M");
                Application.Exit();
            }

        }
    }
}
