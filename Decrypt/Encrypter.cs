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


        public String EncryptCaesar(String Text, int Shift)
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
            Program.writeToConsole("\nInputed Text");
            Program.writeToConsole("\n"+ Text);
            Program.writeToConsole("\nEncrypted using a "+Shift+ " shift");
            Program.writeToConsole("\n"+EncryptedText);
            return EncryptedText;
        }

        public String encryptAffine(String Text, int a, int b) {
            // A has to be a coprime of 26
            // b is the magnitude of the shift so must between 0-25 
            string EncryptedText = "";
            Program.writeToConsole("\nInputed Text");
            Program.writeToConsole("\n" + Text);
            foreach (char c in Text.ToLowerInvariant())
            {
                if (c >= 97 && c <= 122)
                {
                    int x = c - 97;
                    int AsciiCode = ((a * x + b) % 26) + 97;
                    Char NewCharacter = (char)AsciiCode;
                    EncryptedText = EncryptedText + NewCharacter;
                }
            }
            Program.writeToConsole(EncryptedText);
            return EncryptedText;
        }
    }
}
