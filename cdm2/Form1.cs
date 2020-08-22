using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace cdm2
{     
    public partial class Form1 : Form
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
        int n; int amount2; int chk = 0;
 //List<customer> newcustomer = new List<customer>();
        int[] pinam; int amount;
        public Form1()
        {
            InitializeComponent();
        }
        
        public Form1(int amount)
        {
            InitializeComponent();
            this.amount = amount;
            chk = 1;
        
        }
       private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult dr = 0; 
            
                load ld = new load();
                ld.Show();
                if(chk==0)
               dr= MessageBox.Show("I N S E R T   Y O U R   A T M  C A R D !! ", "C D M   S Y S T E M",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                else
                MessageBox.Show("ENTER PINCODE OF THE BENEFICIARY ACCOUNT");
                if (dr == DialogResult.Cancel)
                {
                    MessageBox.Show("T H A N K    Y O U !!!", "C D M    S Y S T E M");
                    Application.Exit();
                }
                    ld.Close();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result;

            result = MessageBox.Show("  CONFIRM  YOU  WANT  TO  CANCEL  TRANSACTION ? ", "C D M   S Y S T E M", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("   T H A N K   Y O U  !!", "C D M   S Y S T E M");
        
                Application.Exit();
            }

            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chk2 = 0;
            //List<customer> newcustomer = new List<customer>();
            pinam = new int[] { 2345, 3456, 4567 };
            int[] amount = new int[] { 500, 1000, 2000 };

            /*newcustomer.Add(new customer(2345, 23));
            newcustomer.Add(new customer(2356, 52));
            newcustomer.Add(new customer(2321, 496));
            newcustomer.Add(new customer(2334, 86));
            newcustomer.Add(new customer(0, 0));*/
            if (input.Text == "****")
                MessageBox.Show(" E N T E R   Y O U R   P I N C O D E", "C D M   S Y S T E M ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (input.Text != "****")
            {
                     string inputstring = string.Format(input.Text);
                     int pin = Convert.ToInt32(int.Parse(inputstring));

                     /*   while (newcustomer[n].pincode != 0)
                        {
                           // if (pin == newcustomer[n].pincode)
                
                            {
                                chk2 = 1;
                                main menu = new main(newcustomer[n].amount,this.n);
                                this.Hide();
                                menu.Show();

                                break;
                            }
                            n++;
                        }*/
                     for (int n = this.n; n < pinam.Length; n++)
                     {
                         if (pin == pinam[n])
                         {
                             chk2 = 1;
                             if (chk == 0)
                             {
                                 this.amount = amount[n];
                                 main menu = new main(this.amount, n);
                                 this.Hide();
                                 menu.Show();
                             }
                             else
                             {
                                 this.amount2 = amount[n];
                                 transfer tf = new transfer(this.amount, this.amount2,pin);
                                 tf.Show();
                                 this.Hide();
                             }
                             break;
                         }
                         this.n++;
                     }
                     if (chk2 == 0)
                     {
                         MessageBox.Show("I N V A L I D   P I N C O D E", " C D M   S Y S T E M",MessageBoxButtons.OK,MessageBoxIcon.Error);
                         n = 0;
                     }
                 }
              /*  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aryanz\Documents\Visual Studio 2013\Projects\cdm2\cdm2\logindb\logon.mdf;Integrated Security=True;Connect Timeout=30");
                string query="Select *from [Table] Where pincode='"+input.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                DataTable dt = new DataTable();
               // int amount"Select amount from [Table] Where"
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    //.Open();
                 string amp = "Select [amount] from[Table] Where pincode='" + input.Text + "'";
                 this.amount = Convert.ToInt32(int.Parse(amp));
                   // this.pinam
                    main menu = new main(this.amount,0);
                    this.Hide();
                    menu.Show();
                  }
                else
                    MessageBox.Show("invalid pincode");
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (input.Text == "****")
                input.Clear();
           
            Button button = (Button)sender;
          
            input.Text = input.Text + button.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input.Text = "****";

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
