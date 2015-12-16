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
        public String EncryptCaesar(String Text, int Shift)//EncryptCaesar given the user inputs
        {
            String EncryptedText = "";
            foreach (char c in Text.ToLowerInvariant()) // loop through each character in the text
            {
                int AsciiCode = (int)c;// change the character to an asciicode
                if (AsciiCode >= 97 && AsciiCode <= 122)  // check to see if the character is a letter from A-z
                {
                    AsciiCode = AsciiCode + Shift; // add the shift to the asciicode
                    if (AsciiCode > 122)// if the asciicode is above 122, then the character is greater than Z and needs to restart at A
                    {
                        int NewShiftAmount = AsciiCode - 122; // work out what the amount should be added to A
                        AsciiCode = 96 + NewShiftAmount;// add the newly worked out shift to the asciicode
                    }
                    Char NewCharacter = (char)AsciiCode;// transform asciicode to character
                    EncryptedText = EncryptedText + NewCharacter;// add the newly shifted text to the rest of the different shifts
                }
            }
            //show output to TextBox on gui
            Program.writeToConsole("\nInputed Text");
            Program.writeToConsole("\n"+ Text);
            Program.writeToConsole("\nEncrypted using a "+Shift+ " shift");
            Program.writeToConsole("\n"+EncryptedText);
            return EncryptedText; // return the newly encrypted text
        }

        public String encryptAffine(String Text, int a, int b) // method used for encrypted affine cipher
        {
            // A has to be a coprime of 26
            // b is the magnitude of the shift so must between 0-25
            // is this validated on the AffineCipherInput GUI 
            string EncryptedText = "";
            Program.writeToConsole("\nInputed Text");
            Program.writeToConsole("\n" + Text);
            foreach (char c in Text.ToLowerInvariant())// loop through each character in the text
            {
                if (c >= 97 && c <= 122) // check to see if the character is a letter from A-z
                {
                    int x = c - 97;// transform the ascii code to a postion in the alphabet
                    int AsciiCode = ((a * x + b) % 26) + 97; // perfrom the shift and add 97 to transfrom in back into a ascii code
                    Char NewCharacter = (char)AsciiCode;// transfrom in back into a ascii code
                    EncryptedText = EncryptedText + NewCharacter;// add the character to the existing encrypted text
                }
            }
            //show output to TextBox on gui
            Program.writeToConsole("\nEncrypted Text:");
            Program.writeToConsole("\n" + EncryptedText);
            return EncryptedText; // return the newly encrypted text
        }
    }
}
