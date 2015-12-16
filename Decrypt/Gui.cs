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
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        String DecryptedText;
        String EncryptedText;
        String TextInput;
        OpenFileDialog Dialog = new OpenFileDialog();
        FolderBrowserDialog FolderDialog = new FolderBrowserDialog();
        FileProcessing FileProcess = new FileProcessing();
        Decrypter Decrypt = new Decrypter();
        Encrypter Encrypt = new Encrypter();


        public RichTextBox getTextBox()
        {
            return TextOutput;
        }
        //            //
        // Gui Events //
        //            //

        private void TextBoxTextChangedEvent(object sender, EventArgs e) //called when text is output to textbox on screen
        {
            TextOutput.SelectionStart = TextOutput.Text.Length; //set the current caret position at the end
            TextOutput.ScrollToCaret(); //scroll to it automatically
        }

        private void OpenFile(object sender, EventArgs e) //called when selecting "File" then "Open" on the strip menu
        {
            Dialog.Filter = "Text files|*.txt"; // show only text files
            if (Dialog.ShowDialog().Equals(DialogResult.OK))
            {
                Program.writeToConsole("Input File: \n" + Dialog.FileName + "\n"); //output the filelocation to the screen
                TextInput = FileProcess.ReadTextFile(Dialog.FileName); // set the input text
            }
        }
        private void ClearConsole(object sender, EventArgs e) //called when selecting "Edit" then "Clear Console" on the strip menu
        {
            TextOutput.Clear(); //Clear the text box on screen
        }
        private void SaveDecryptedText(object sender, EventArgs e) //called when selecting "save" then "decryptedtext" on the strip menu
        {
            if (DecryptedText != null)
            {
                if (FolderDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    FileProcess.WriteDecryptedFile(DecryptedText, FolderDialog.SelectedPath);
                }
            }
            else
            {
                MessageBox.Show("You don't have any decrypted text to save", "No Decrypted Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveEncryptedText(object sender, EventArgs e) //called when selecting "save" then "encryptedtext" on the strip menu
        {
            if (EncryptedText != null)
            {
                if (FolderDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    FileProcess.WriteEncryptedFile(EncryptedText, FolderDialog.SelectedPath);
                }
            }
            else
            {
                MessageBox.Show("You don't have any Encrypted text to save", "No Encrypted Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DecryptedCaesarCipherButton(object sender, EventArgs e)
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DecryptedText = Decrypt.DecryptCaesar(TextInput);
        }

        private void DecryptAffineCipherButton(object sender, EventArgs e)
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DecryptedText = Decrypt.DecryptAffine(TextInput);
        }

        private void EncryptCaesarCipherButton(object sender, EventArgs e)
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InputDialog input = new InputDialog();
            if (input.ShowDialog().Equals(DialogResult.OK))
            {
                EncryptedText = Encrypt.EncryptCaesar(TextInput, input.Shift);
            }

        }

        private void EncryptAffineCipherButton(object sender, EventArgs e)
        {

            //encrypt affine cipher open gui
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AffineCipherInput input = new AffineCipherInput();
            if (input.ShowDialog().Equals(DialogResult.OK))
            {
                // TODO Improve output
                EncryptedText = Encrypt.encryptAffine(TextInput, input.A, input.B);
            }
        }

        private void AllCeaserCipherShiftsDecryption(object sender, EventArgs e)
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DecryptedText = Decrypt.DecryptCaesar(TextInput);
        }

        private void UserSelectedCeaserCipeherDecryption(object sender, EventArgs e)
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InputDialog input = new InputDialog();
            if (input.ShowDialog().Equals(DialogResult.OK))
            {
                EncryptedText = Decrypt.DecryptCaesar(TextInput, input.Shift);
            }
        }

        private void AllAffineCipherShiftsDecryption(object sender, EventArgs e)
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DecryptedText = Decrypt.DecryptAffine(TextInput);
        }

        private void UserSelectedAffineCipherDecyption(object sender, EventArgs e)
        {

            //encrypt affine cipher open gui
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AffineCipherInput input = new AffineCipherInput();
            if (input.ShowDialog().Equals(DialogResult.OK))
            {
                // TODO Improve output
                DecryptedText = Decrypt.DecryptAffine(TextInput, input.A, input.B);
            }
        }
    }
}
