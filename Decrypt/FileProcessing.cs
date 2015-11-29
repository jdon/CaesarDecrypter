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
        public String ReadTextFile(String FileLocation)
        {
            try
            {
                return File.ReadAllText(FileLocation);
            }
            catch (Exception e)
            {
                //any exceptions show a error message on screen
                MessageBox.Show(e.GetType().Name, e.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void WriteOutputFile(String DecryptedText,String FileLocation)
        {
            try
            {
                Program.WriteText(FileLocation);
                //write the output to the output location selected
                File.WriteAllText(FileLocation+"/output.txt", DecryptedText);
                MessageBox.Show("File saved to "+ FileLocation + "\\output.txt", "File Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                //any exceptions show a error message on screen
                MessageBox.Show(e.GetType().Name, e.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
