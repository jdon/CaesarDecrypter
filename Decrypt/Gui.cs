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

        private String CaesarArrayToString(String[] shifts) // chanes the the array of shifts to a string
        {
            String allshifts = "";
            for (int i = 1; i <= 26; i++)// loops through each shift
            {
                allshifts += "\nCurrent Shift: "+i+"\n"+shifts[i];
            }
            return allshifts;
        }

        private String AffineCipherDictionaryToString(Dictionary<String, String> AffineShifts)// changes the dictionary of affine ciphers toa string
        {
            String allshifts = "";
            for (int index = 0; index < AffineShifts.Count; index++) // loops through each shift
            {
                KeyValuePair<String, String> item = AffineShifts.ElementAt(index);
                String shift = item.Key;
                String decrypted = item.Value;
                allshifts += "\n" + shift + "\n" + decrypted;
            }
            return allshifts;
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
        private void SaveDecryptedText(object sender, EventArgs e) //called when selecting "file" then "save" then "decryptedtext" on the strip menu
        {
            if (DecryptedText != null)
            {
                if (FolderDialog.ShowDialog().Equals(DialogResult.OK)) // creates a folder dialog for the user to select where to save the decrypted text
                {
                    FileProcess.WriteDecryptedFile(DecryptedText, FolderDialog.SelectedPath);
                }
            }
            else
            {
                MessageBox.Show("You don't have any decrypted text to save", "No Decrypted Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveEncryptedText(object sender, EventArgs e) //called when selecting "file" then "save" then "encryptedtext" on the strip menu
        {
            if (EncryptedText != null)
            {
                if (FolderDialog.ShowDialog().Equals(DialogResult.OK))// creates a folder dialog for the user to select where to save the encrypted text
                {
                    FileProcess.WriteEncryptedFile(EncryptedText, FolderDialog.SelectedPath);
                }
            }
            else
            {
                MessageBox.Show("You don't have any Encrypted text to save", "No Encrypted Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EncryptCaesarCipherButton(object sender, EventArgs e)//called when selecting "run" then "encrypt" then "Ceasar Cipher" on the strip menu
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InputDialog input = new InputDialog(); // creates an input for the user to input their desired shift
            if (input.ShowDialog().Equals(DialogResult.OK))// makes sure the inputted results are valid
            {
                EncryptedText = Encrypt.EncryptCaesar(TextInput, input.Shift);// pefroms the encryption and sets the global variable as the encrypted tex
            }

        }

        private void EncryptAffineCipherButton(object sender, EventArgs e)//called when selecting "run" then "encrypt" then "Advanced Cipher" on the strip menu
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AffineCipherInput input = new AffineCipherInput();// creates an input for the user to input their desired shift
            if (input.ShowDialog().Equals(DialogResult.OK))// makes sure the inputted results are valid
            {
                EncryptedText = Encrypt.encryptAffine(TextInput, input.A, input.B); // pefroms the encryption and sets the global variable as the encrypted text
            }
        }

        private void AllCeaserCipherShiftsDecryption(object sender, EventArgs e)//called when selecting "run" then "decrypt" then "Ceasar Cipher" then "all shifts" on the strip menu
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DecryptedText = CaesarArrayToString(Decrypt.DecryptCaesar(TextInput));// pefroms the decryption and sets the global variable as the decrypted text
        }

        private void UserSelectedCeaserCipeherDecryption(object sender, EventArgs e)//called when selecting "run" then "decrypt" then "Ceasar Cipher" then "user selected" on the strip menu
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InputDialog input = new InputDialog();// creates an input for the user to input their desired shift
            if (input.ShowDialog().Equals(DialogResult.OK)) // makes sure the inputted results are valid
            {
                DecryptedText = Decrypt.DecryptCaesar(TextInput, input.Shift); // pefroms the decryption and sets the global variable as the decrypted text
            }
        }

        private void AllAffineCipherShiftsDecryption(object sender, EventArgs e)//called when selecting "run" then "decrypt" then "advanced Cipher" then "all shifts" on the strip menu
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DecryptedText = AffineCipherDictionaryToString(Decrypt.DecryptAffine(TextInput));// pefroms the decryption and sets the global variable as the decrypted text
        }

        private void UserSelectedAffineCipherDecyption(object sender, EventArgs e)//called when selecting "run" then "decrypt" then "advanced Cipher" then "user selected" on the strip menu
        {
            if (Dialog.FileName == "")
            {
                MessageBox.Show("Please select a valid text file", "Text file not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AffineCipherInput input = new AffineCipherInput();// creates an input for the user to input their desired shift
            if (input.ShowDialog().Equals(DialogResult.OK))// makes sure the inputted results are valid
            {
                DecryptedText = Decrypt.DecryptAffine(TextInput, input.A, input.B);// pefroms the decryption and sets the global variable as the decrypted text
            }
        }
    }
}
