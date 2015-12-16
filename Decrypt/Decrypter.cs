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

        public string DecryptAffine(String EncryptedText) //DecryptAffine for all possible shifts
        {
            Dictionary<String, String> AffineCiphers = new Dictionary<String, String>();// First string in the dictionary is the shift and the second string is the shifted text
            String Loop = " ";
            for (int a = 0; a < 26; a++)//loop throught all possible shifts
            {
                if (Program.isCoPrime(a)) // only loop through the shifts if the a value is a coprime of 26
                {
                    for (int b = 0; b < 26; b++)// loop though every value from 0-26
                    {
                        String DecryptedText = "\n\nShift:A value:" + a + " B value:" + b + "\n";
                        String decrypted = shiftaffine(EncryptedText, a, b); // shift the encrypted text
                        AffineCiphers.Add("A value:"+a+" B value:"+b,decrypted); // add the values to the dictionary
                        Loop = Loop + DecryptedText + decrypted; // add the newly shifted text to the rest of the different shifts
                    }

                }
            }
            Program.writeToConsole(Loop); // output all shifts to the console on screen
            new FrequencyAnalysis(AffineCiphers, EncryptedText);
            return Loop; // return all the shifts
        }
        public string DecryptAffine(String EncryptedText,int a,int b)//DecryptAffine for the user inputed shift
        {
            Program.writeToConsole("\n\nShift:A value:" + a + " B value:" + b + "\n");
            String decrypted = shiftaffine(EncryptedText, a, b); // shift the encrypted text the amount as defined by the user
            Program.writeToConsole(decrypted); // print to console the newly decrypted text to the screen
            return decrypted; // return the decrypted text
        }

        private string shiftaffine(String EncryptedText, int a, int b) // method for shifting the affine cipher
        {
            String DecryptedText = "";
            foreach (char c in EncryptedText.ToLowerInvariant()) // loop through each character in the encrypted text
            {
                int AsciiCode = (int)c; // get the asciicode for the specfic character
                if (AsciiCode >= 97 && AsciiCode <= 122) // check to see if the character is a letter from A-z
                {
                    int x = c - 97; // transform the ascii code to a postion in the alphabet
                    AsciiCode = ((a * x + b) % 26) + 97; // perfrom the shift and add 97 to transfrom in back into a ascii code
                    Char NewCharacter = (char)AsciiCode; // transfrom in back into a ascii code
                    DecryptedText = DecryptedText + NewCharacter; // add the character to the existing decrypted text
                }
            }
            return DecryptedText; // return the decrypted text
        }

        public String DecryptCaesar(String EncryptedText)//DecryptCaesar for all possible shifts
        {
            String Loop =" ";
            for (int i = 1; i <= 26; i++) //loop throught all possible 26 shifts
            {
                Loop = Loop + ShiftText(EncryptedText, i);// add the newly shifted text to the rest of the different shifts
            }
            return Loop;
        }

        public String DecryptCaesar(String EncryptedText, int shift) //DecryptCaesar for the user inputed shift
        {
            return ShiftText(EncryptedText, shift);// shift the encrypted text and return it.
        }

        private String ShiftText(String EncryptedText,int Shift) //method for shifting Caesar cipher 
        {
            String DecryptedText ="\n\nShift:"+Shift+"\n\n";
            foreach (char c in EncryptedText.ToLowerInvariant()) // loop through each character in the encryptedText
            {
                int AsciiCode = (int)c;// change the character to an asciicode
                if (AsciiCode >= 97 && AsciiCode <= 122) // check to see if the character is a letter from A-z
                {
                    AsciiCode = AsciiCode + Shift; // add the shift to the asciicode
                    if (AsciiCode > 122) // if the asciicode is above 122, then the character is greater than Z and needs to restart at A
                    {
                        int NewShiftAmount = AsciiCode - 122; // work out what the amount should be added to A
                        AsciiCode = 96 + NewShiftAmount; // add the newly worked out shift to the asciicode
                    }
                }
                Char NewCharacter = (char)AsciiCode; // transform asciicode to character
                DecryptedText = DecryptedText + NewCharacter; // add the newly shifted text to the rest of the different shifts
            }
            Program.writeToConsole(DecryptedText); //show output to TextBox on gui
            return DecryptedText; // return all the shifts
        }
    }
}
