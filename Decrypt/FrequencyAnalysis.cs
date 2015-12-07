using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypt
{
    class FrequencyAnalysis
    {
        private Dictionary<char, double> FrequencyTable = new Dictionary<char, double>();
        private Dictionary<string, double> shiftscores = new Dictionary<string, double>();

        public FrequencyAnalysis(Dictionary<String, String> cipher)
        {
            PopulateFrequencyTable();
            generateScore(cipher);
        }

        private void PopulateFrequencyTable()
        {
            FrequencyTable.Add('e', 12.702);
            FrequencyTable.Add('t', 9.7056);
            FrequencyTable.Add('a', 8.167);
            FrequencyTable.Add('o', 7.507);
            FrequencyTable.Add('i', 6.966);
            FrequencyTable.Add('n', 6.749);
            FrequencyTable.Add('s', 6.327);
            FrequencyTable.Add('h', 6.094);
            FrequencyTable.Add('r', 5.987);
            FrequencyTable.Add('d', 4.253);
            FrequencyTable.Add('l', 4.025);
            FrequencyTable.Add('c', 2.782);
            FrequencyTable.Add('u', 2.758);
            FrequencyTable.Add('m', 2.406);
            FrequencyTable.Add('w', 2.361);
            FrequencyTable.Add('f', 2.228);
            FrequencyTable.Add('y', 2.015);
            FrequencyTable.Add('g', 1.974);
            FrequencyTable.Add('p', 1.929);
            FrequencyTable.Add('b', 1.492);
            FrequencyTable.Add('v', 0.978);
            FrequencyTable.Add('k', 0.772);
            FrequencyTable.Add('j', 0.153);
            FrequencyTable.Add('x', 0.150);
            FrequencyTable.Add('q', 0.095);
            FrequencyTable.Add('z', 0.074);
        }

        private void generateScore(Dictionary<String, String> cipher)
        {
            //loop for each decrypted string
            for (int index = 0; index < cipher.Count; index++)
            {
                KeyValuePair<String, String> item = cipher.ElementAt(index);
                String shift = item.Key;
                String decrypted = item.Value;
                Dictionary<Char, int> Count = CountCharacters(decrypted);
                //generate score for this decrypted text
                double score = 0;
                for (int i = 0; i < Count.Count; i++)
                {
                    score = 0;
                    KeyValuePair<Char, int> chartercount = Count.ElementAt(i);
                    char c = chartercount.Key;
                    int decryptPercentage = chartercount.Value;
                    double percentage = FrequencyTable[c];
                    score = score + (percentage + decryptPercentage);
                }
                shiftscores.Add(shift, score);
                Program.writeToConsole("\n HIGHEST count is" + shift+" "+score);
            }
            shiftscores = shiftscores.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); ;
            Program.writeToConsole("\n HIGHEST count is"+ shiftscores.ElementAt(shiftscores.Count-1));
        }

        private Dictionary<Char, int> CountCharacters(string EncryptedText)
        {
            Dictionary<Char, int> CharacterCount = new Dictionary<Char, int>();
            double NumberOfCharacter = 0.00;
            foreach (char c in EncryptedText.ToLowerInvariant())
            {
                if (c >= 'a' && c <= 'z')
                {
                    NumberOfCharacter++;
                    if (CharacterCount.ContainsKey(c))
                    {
                        int amount = CharacterCount[c];
                        amount++;
                        CharacterCount[c] = amount;
                    }
                    else
                    {
                        CharacterCount.Add(c, 1);
                    }
                }
            }
            return CharacterCount;
            /*
            CharacterCount = CharacterCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); ;
            for (int index = 0; index < CharacterCount.Count; index++)
            {
                var item = CharacterCount.ElementAt(index);
                var itemKey = item.Key;
                var itemValue = item.Value;
                Double percentage = (itemValue / NumberOfCharacter) * 100;
                Program.writeToConsole("  " + itemKey + " " + itemValue + "\t" + percentage + "% \n");
                var amount = FrequencyTable.ElementAt(index);
                var amountKey = amount.Key;
                var amountValue = amount.Value;
                Program.writeToConsole("  " + itemKey + " should be " + amountKey + "\n");
            }
            */
        }
    }
}
