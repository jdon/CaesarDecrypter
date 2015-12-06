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
        public AffineCipherInput()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None; //stops user from entering data into dropdown box
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (MaskedTextBox.Text != null)
            {
                int i = int.Parse(MaskedTextBox.Text);
                if (Program.isCoPrime(i)) {
                    Program.getGui().EncryptAfine(int.Parse(MaskedTextBox.Text), int.Parse(comboBox1.Text));
                    this.Close();
                }
                else
                {
                    // show error message
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
