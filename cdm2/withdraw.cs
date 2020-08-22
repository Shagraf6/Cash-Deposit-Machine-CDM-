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
    public partial class withdraw : Form
    {
        int amount; int count;
        public withdraw(int amount,int count)
        {
            InitializeComponent();
            this.amount = amount;
            this.count = count;
        }

        private void withdraw_Load(object sender, EventArgs e)
        {

        }

        private void input2_TextChanged(object sender, EventArgs e)
        {
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("  C O N F I R M   Y O U   W A N T   T O   C A N C E L   T R A N S A C T I O N ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main mn = new main(this.amount, this.count);
                MessageBox.Show("   T H A N K   Y O U", "C D M   S Y S T E M");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chk = 0;
            int temp = this.amount;
            if (input3.Text == "")
                MessageBox.Show(" E N T E R  A M O U N T   T O  B E   W I T H D R A W D E D ", "C D M   S Y S T E M ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(input3.Text!="")
            {
                string inputstring = string.Format(input3.Text);
                int pin2 = Convert.ToInt32(int.Parse(inputstring));

                if (pin2 % 100 != 0)
                {
                    MessageBox.Show("E N T E R   A M O U N T   I N   M U L T I P L E  OF  100", "C D M   S Y S T E M",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
                else if (pin2 > temp)
                {
                    DialogResult re;
                    re = MessageBox.Show("I N S U F F I C I E N T   F U N D !! ", "C D M   S Y S T E M", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (re == DialogResult.Cancel)
                        Application.Exit();
                }
                else
                {
                    temp = temp - pin2;
                    main mn = new main(this.count, temp, 1);
                    Reciept rec = new Reciept(this.amount, temp, count);
                    this.Hide();
                    MessageBox.Show("P L E A S E   W A I T.... \n V A L I D A T I N G   T H E   C A S H....", "C D M   S Y S T E M");
                    MessageBox.Show("T A K E    T H E   C A S H", "C D M   S Y S T E M");
                    rec.Show();
                }
            }
        }
    }
}
