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

        public void EncryptText(int shift)
        {
            EncryptedText = Encrypt.EncryptCaesar(TextInput, shift);
        }

        public void EncryptAfine(int a, int b)
        {
            // Save encryptedtext
            String text = FileProcess.ReadTextFile(Dialog.FileName);
            EncryptedText = Encrypt.encryptAffine(text, a, b);
        }
        //            //
        // Gui Events //
        //            //

        private void TextOutput_TextChanged(object sender, EventArgs e) //called when text is output to textbox on screen
        {
            TextOutput.SelectionStart = TextOutput.Text.Length; //set the current caret position at the end
            TextOutput.ScrollToCaret(); //scroll to it automatically
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //called when selecting "File" then "Open" on the strip menu
        {
            Dialog.Filter = "Text files|*.txt"; // show only text files
            Dialog.ShowDialog(); //Show the File Dialog
            TextOutput.AppendText("Input File: \n" + Dialog.FileName+ "\n"); //output the filelocation to the screen
            TextInput = FileProcess.ReadTextFile(Dialog.FileName); // set the input tex
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) //called when selecting "File" then "Save" on the strip menu
        {
            FolderDialog.ShowDialog();//Show the File Dialog
            TextOutput.AppendText("\n Output Location: \n" + FolderDialog.SelectedPath + "\n"); //output the filelocation to the screen
        }

        private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e) //called when selecting "Edit" then "Clear Console" on the strip menu
        {
            TextOutput.Clear(); //Clear the text box on screen
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void decryptedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save decryptedtext
            if (DecryptedText != null)
            {
                if (FolderDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    FileProcess.WriteDecryptedFile(DecryptedText, FolderDialog.SelectedPath);
                }
            }
        }

        private void encryptedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save encryptedtext
            if (EncryptedText != null)
            {
                if (FolderDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    FileProcess.WriteEncryptedFile(EncryptedText, FolderDialog.SelectedPath);
                }
            }
        }

        private void caesarCipherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DecryptedText = Decrypt.DecryptCaesar(TextInput);
            //FrequencyAnalysis f = new FrequencyAnalysis(DecryptedText);
        }

        private void advancedCipherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Decrypt.DecryptAffine("czstr");
        }

        private void caesarCipherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InputDialog input = new InputDialog();
            input.Show();
        }

        private void advancedCipherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //encrypt affine cipher open gui
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AffineCipherInput input = new AffineCipherInput();
            input.Show();
        }
    }
}
