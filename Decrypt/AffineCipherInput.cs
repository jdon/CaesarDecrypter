using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decrypt
{
    public partial class AffineCipherInput : Form
    {

        private int a, b;


        public AffineCipherInput()
        {
            InitializeComponent();
        }
        //getters and setters for the public variables
        public int A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }
        //getters and setters for the public variables
        public int B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None; //stops user from entering data into dropdown box so they must select the data from the dropdown box
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (MaskedTextBox.Text != null) // ensure that input into the masked text is not null
            {
                int i = int.Parse(MaskedTextBox.Text);
                if (Program.isCoPrime(i) && i <26) // ensure that the inputted text is a comprime of 26
                {
                    a = int.Parse(MaskedTextBox.Text);
                    b = int.Parse(comboBox1.Text);
                    this.DialogResult = DialogResult.OK;// set the dialogresults as "ok", so this can be used to make sure that a valid input has been given
                    this.Close();// close the input dialog since the they have succesfully inputted valid data
                }
                else
                {
                    // show error message if the number is not a coprime of 26
                    MessageBox.Show("Number must be a coprime of 26", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // show error message
                MessageBox.Show("Values can't be null", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
