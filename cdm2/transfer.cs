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
    public partial class transfer : Form
    {
        int amount1; int amount2; int pincode;
        public transfer(int amount1,int amount2 ,int pincode)
        {
            InitializeComponent();
            this.amount1 = amount1;
            this.amount2 = amount2;
        this.pincode=pincode;
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int temp = this.amount1;
            if (input2.Text == "")
                MessageBox.Show(" ENTER  AMOUNT  TO  BE  TRANSFERD", "C D M   S Y S T E M ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (input2.Text != "")
            {
                string inputstring = string.Format(input2.Text);
                int pin2 = Convert.ToInt32(int.Parse(inputstring));

                DialogResult re = 0;
                if (pin2 % 100 != 0)
                {
                    DialogResult ss = MessageBox.Show("ENTER   AMOUNT   IN   MULTIPLE  OF  100", "C D M   S Y S T E M", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
               if (pin2 > amount1)
                    re = MessageBox.Show("INSUFFIICIENT   FUND !!", "C D M   S Y S T E M", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                else if (re == DialogResult.Cancel)
                    Application.Exit();
                   
                else if (pin2 > 5000)
                {
                    DialogResult result;
                    result = MessageBox.Show("YOU CAN TRANSFER  UPTO  5000  ONLY  !!", "C D M  S Y S T E M", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    if (result == DialogResult.Cancel)
                    {
                        result = MessageBox.Show("C0NFIRM   YOU   WANT   TO   EXIT ?", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                        temp = amount1 - pin2;
                        this.amount2 = this.amount2 + pin2;
                        MessageBox.Show("P L A C E   T H E   C A S H");
                        MessageBox.Show("P L E A S E   W A I T.... \n V A L I D A T I N G   T H E   C A S H....", "C D M   S Y S T E M");
                        main mn = new main(0, temp, 1);
                        tfrecieptcs sm = new tfrecieptcs(this.amount1, temp, this.pincode);
                        this.Hide();
                        sm.Show();
                    

                }
            }
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("  CONFIRM   YOU   WANT   TO   CANCEL   TRANSACTION ? ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
             //   main mn = new main(this.amount, this.count);
                MessageBox.Show("   T H A N K   Y O U !!", "C D M   S Y S T E M");
                Application.Exit();
            }
        }

        private void transfer_Load(object sender, EventArgs e)
        {

        }
    }
}
