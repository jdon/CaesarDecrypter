using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Decrypt
{
    class Encrypter
    {
        public Encrypter()
        {
            
        }


        public String EncryptCeaser(String Text, int Shift)
        {
            String EncryptedText = "";
            foreach (char c in Text.ToLowerInvariant())
            {
                int AsciiCode = (int)c;
                if (AsciiCode >= 97 && AsciiCode <= 122)
                {
                    // the ascii code is a valid character from the alphabet
                    // so shift the character
                    AsciiCode = AsciiCode + Shift;
                    if (AsciiCode > 122)
                    {
                        //shift the difference from the start of the alphabet since the ascii number is greater than 122
                        int NewShiftAmount = AsciiCode - 122;
                        AsciiCode = 96 + NewShiftAmount;
                    }
                    Char NewCharacter = (char)AsciiCode;
                    EncryptedText = EncryptedText + NewCharacter;
                }
            }
            //show output to TextBox on gui
            Program.WriteText("\nInputed Text");
            Program.WriteText("\n"+ Text);
            Program.WriteText("\nEncrypted using a "+Shift+ " shift");
            Program.WriteText("\n"+EncryptedText);
            return EncryptedText;
        }

}
}
