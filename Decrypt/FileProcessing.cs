using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Decrypt
{
    class FileProcessing
    {
        public String ReadTextFile(String FileLocation) // method for reading the text files
        {
            try
            {
                return File.ReadAllText(FileLocation, Encoding.GetEncoding("Windows-1255")); // reads the text file at the location specified by the user
            }
            catch (Exception e)
            {
                //any exceptions show a error message on screen
                MessageBox.Show(e.GetType().Name, e.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void WriteDecryptedFile(String DecryptedText,String FileLocation)
        {
            try
            {
                Program.writeToConsole(FileLocation);
                //write the output to the output location selected
                File.WriteAllText(FileLocation+"/DecryptedText.txt", DecryptedText);
                MessageBox.Show("File saved to "+ FileLocation + "\\DecryptedText.txt", "File Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                //any exceptions show a error message on screen
                MessageBox.Show(e.GetType().Name, e.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void WriteEncryptedFile(String DecryptedText, String FileLocation)
        {
            try
            {
                Program.writeToConsole(FileLocation);
                //write the output to the output location selected
                File.WriteAllText(FileLocation + "/EncryptedText.txt", DecryptedText);
                MessageBox.Show("File saved to " + FileLocation + "\\EncryptedText.txt", "File Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                //any exceptions show a error message on screen
                MessageBox.Show(e.GetType().Name, e.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
