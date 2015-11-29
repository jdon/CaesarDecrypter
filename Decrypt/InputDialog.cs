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
        public InputDialog()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MaskedTextBox.Text != null && int.Parse(MaskedTextBox.Text) >= 1 && int.Parse(MaskedTextBox.Text) <= 25 )
            {
                Program.getGui().EncryptText(int.Parse(MaskedTextBox.Text));
                this.Close();
            }
            else
            {
                // show error message
                MessageBox.Show("Number must be between 1 and 25", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
