using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decrypt
{
    class FrequencyAnalysis
    {
        private Dictionary<Char, int> CharacterCount = new Dictionary<Char, int>();
        private Dictionary<char, double> FrequencyTable = new Dictionary<char, double>();
        

        private String EncryptedText;

        public string EncryptedText1
        {
            get
            {
                return EncryptedText;
            }

            set
            {
                EncryptedText = value;
            }
        }

        public FrequencyAnalysis(String EncryptedText)
        {
            this.EncryptedText = EncryptedText;
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

        private void CountCharacters()
        {
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
            CharacterCount = CharacterCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); ;
            for (int index = 0; index < CharacterCount.Count; index++)
            {
                var item = CharacterCount.ElementAt(index);
                var itemKey = item.Key;
                var itemValue = item.Value;
                Double percentage = (itemValue / NumberOfCharacter) * 100;
                Console.Write("  " + itemKey + " " + itemValue + "\t" + percentage + "% \n");
                var amount = FrequencyTable.ElementAt(index);
                var amountKey = amount.Key;
                var amountValue = amount.Value;
                Console.Write("  " + itemKey + " should be " + amountKey + "\n");
            }
        }

        private void newCount()
        {

            // 1.
            // Array to store frequencies.
            List<int> list = new List<int>();
            int[] c = new int[123];

            // 2.
            // Read entire text file.
            string s = EncryptedText.ToLowerInvariant();

            // 3.
            // Iterate over each character.
            foreach (char t in s)
            {
                if (t >= 97 && t <= 122)
                {
                    // Increment table.
                    c[(int)t]++;
                }
            }

            // 4.
            // Write all letters found.
            //Array.Sort(c);
            for (int i = 97; i < 122; i++)
            {
                char ss = (char)i;
               Console.Write("Letter: " + ss + "Frequency:" + c[i]);
            }
        }
    }
}
