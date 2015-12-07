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

        private Dictionary<String, String> AffineCiphers = new Dictionary<String, String>();

        public string DecryptAffine(String EncryptedText)
        {
            String Loop = " ";
            //loop throught all possible shifts
            for (int a = 0; a < 26; a++)
            {
                if (Program.isCoPrime(a))
                {
                    for (int b = 0; b < 26; b++)
                    {
                        String DecryptedText = "\n\nCurrent shift: a " + a + " b " + b + "\n\n";
                        String decrypted = shiftaffine(EncryptedText, a, b);
                        AffineCiphers.Add("A value:"+a+"B value"+b,decrypted);
                        Loop = Loop + DecryptedText + decrypted;
                    }

                }
            }
            Program.writeToConsole(Loop);
            new FrequencyAnalysis(AffineCiphers);
            return Loop;
        }

        private string shiftaffine(String EncryptedText, int a, int b)
        {
            String DecryptedText = "";
            foreach (char c in EncryptedText.ToLowerInvariant())
            {
                int AsciiCode = (int)c;
                if (AsciiCode >= 97 && AsciiCode <= 122)
                {
                    int x = c - 97;
                    AsciiCode = ((a * x + b) % 26) + 97;
                    Char NewCharacter = (char)AsciiCode;
                    DecryptedText = DecryptedText + NewCharacter;
                }
            }
            //show output to TextBox on gui
            //Program.writeToConsole(DecryptedText);
            return DecryptedText;
        }

        public String DecryptCaesar(String EncryptedText)
        {
            String Loop =" ";
            //loop throught all possible 26 shifts
            for (int i = 1; i <= 26; i++) {
                Loop = Loop + ShiftText(EncryptedText, i);
            }
            return Loop;
        }

        private String ShiftText(String EncryptedText,int Shift) {
            String DecryptedText ="\n\nCurrent shift:"+Shift+"\n\n";
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
            Program.writeToConsole(DecryptedText);
            return DecryptedText;
        }
    }
}
