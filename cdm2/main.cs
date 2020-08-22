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
    public partial class main : Form
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
        int count
            ; int amount; int temp = 0; int chk = 0;
        int amount2;
        int[] pinam;
        int[] amount1;
       // customer c;
       //List<customer> newcustomer=new List<customer>();
        public main(int amount,int count)
        {
          //  pinam = new int[] { 2345, 3456, 4567 };
           // amount1 = new int[] { 23, 56, 78 };
           
            InitializeComponent();
            this.count = count;
//            this.amount1[count] = amount;
  //          this.amount = amount1[count];
            this.amount = amount;
            /* newcustomer.Add(new customer(2345, 23));
            newcustomer.Add(new customer(2356, 52));
            newcustomer.Add(new customer(2321, 496));
            newcustomer.Add(new customer(2334, 86));
            newcustomer.Add(new customer(0, 0));*/
           // this.amount = amount1[count];
        }
        
        public main()
        {
            InitializeComponent();
        }
      public main(int count,int amount2,int chk)
        {

            InitializeComponent();
            //pinam = new int[] { 2345, 3456, 4567 };
          //  amount1 = new int[] { 500, 1000, 2000 };
           // this.chk=chk;
            if (chk == 1)
            {
                // this.temp = chk;
                //  this.newcustomer[this.temp].amount = amount;
                //     this.amount1[count] = amount2;
                //   this.amount = this.amount1[count];
                this.amount = amount2;
                this.chk = 0;
            }
//            else
  //              this.amount = this.amount; 
               // this.amount = amount1[count];
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            enquiry en = new enquiry(this.amount,this.count);
            en.Show();
        //    this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            deposit dp = new deposit(this.amount, this.count);
            dp.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show(" CONFIRM  YOU  WANT  TO  CANCEL TRANSACTION ?  ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               // main mn = new main(this.pre, this.count);

                MessageBox.Show("   T H A N K   Y O U  !!", "C D M   S Y S T E M");

                Application.Exit();
            }

//            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            withdraw dp = new withdraw(this.amount, this.count);
            dp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form1 fm = new Form1(this.amount);
            fm.Show();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
