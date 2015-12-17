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
    public partial class InputDialog : Form
    {
        private int shift;
        public InputDialog()
        {
            InitializeComponent();
        }
        public int Shift
        {
            //getters and setters for the public variable
            get
            {
                return shift;
            }

            set
            {
                shift = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MaskedTextBox.Text != null && int.Parse(MaskedTextBox.Text) >= 1 && int.Parse(MaskedTextBox.Text) <= 25 ) // make sure that the text contains a valid number between 1-25
            {
                shift = int.Parse(MaskedTextBox.Text);// parse the text in the masked textbox
                this.DialogResult = DialogResult.OK; // set the dialogresults as "ok", so this can be used to make sure that a valid input has been given
                this.Close();// close the input dialog since the they have succesfully inputted valid data
            }
            else
            {
                MessageBox.Show("Number must be between 1 and 25", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error); // show error message if the input is not valid
            }
        }
    }
}
