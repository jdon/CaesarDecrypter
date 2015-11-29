using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Decrypt
{
    class Decrypter
    {
        public Decrypter()
        {

        }

        public string DecryptAffine() {
            return null;
        }

        public String DecryptCeaser(String EncryptedText)
        {
            String Loop =" ";
            //loop throught all possible 26 shifts
            for (int i = 1; i <= 26; i++) {
                Loop = Loop + ShiftText(EncryptedText, i);
            }
            return Loop;
        }

        private String ShiftText(String EncryptedText,int Shift) {
            String DecryptedText ="\n \n Current shift:"+Shift+"\n \n";
            foreach (char c in EncryptedText.ToLowerInvariant())
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
                    DecryptedText = DecryptedText + NewCharacter;
                }
            }
            //show output to TextBox on gui
            Program.WriteText(DecryptedText);
            return DecryptedText;
        }
    }
}
