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
        OpenFileDialog Dialog = new OpenFileDialog();
        FolderBrowserDialog FolderDialog = new FolderBrowserDialog();
        FileProcessing FileProcess = new FileProcessing();
        Decrypter Decrypt = new Decrypter();
        Encrypter Encrypt = new Encrypter();

        //            //
        // Gui Events //
        //            //

        public RichTextBox getTextBox() {
            return TextOutput;
        }

        public void EncryptText(int shift) {
            Encrypt.EncryptCeaser(FileProcess.ReadTextFile(Dialog.FileName), shift);
        }

        private void TextOutput_TextChanged(object sender, EventArgs e)
        {
            TextOutput.SelectionStart = TextOutput.Text.Length; //Set the current caret position at the end
            TextOutput.ScrollToCaret(); //Now scroll it automatically
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog.Filter = "Text files|*.txt"; // show only text files
            Dialog.ShowDialog(); //Show the File Dialog
            TextOutput.AppendText("Input File: \n" + Dialog.FileName+ "\n"); //output the filelocation to the screen
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderDialog.ShowDialog();//Show the File Dialog
            TextOutput.AppendText("\n Output Location: \n" + FolderDialog.SelectedPath + "\n"); //output the filelocation to the screen
        }

        private void caesarCipherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DecryptedText = Decrypt.DecryptCeaser(FileProcess.ReadTextFile(Dialog.FileName));
        }

        private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextOutput.Clear(); //Clear the text box on screen
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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

        private void decryptedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save decryptedtext
            if (DecryptedText != null)
            {
                if (FolderDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    FileProcess.WriteOutputFile(DecryptedText, FolderDialog.SelectedPath);
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
                    FileProcess.WriteOutputFile(EncryptedText, FolderDialog.SelectedPath);
                }
            }
        }
    }
}
