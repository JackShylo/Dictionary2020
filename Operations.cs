using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary2020
{
    class Operations
    {
        // Fields
        public Dictionary<string, string> DictionaryWords = new Dictionary<string, string>();

        // Properties
        public string SearchWord { get; set; }
        // Methods

        public void LoadDictionary()
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Dictionary.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            foreach (string Word in File.ReadLines(FileName))
            {
                // If the Word is not the in the Dictionary then add it
                if (!(DictionaryWords.ContainsKey(Word)))
                {
                    DictionaryWords.Add(Word, Word);
                }
            }
        }


        public string RunSearch(Dictionary<string, string> Dict, string Search)
        {
            if (DictionaryWords.ContainsKey(SearchWord))
            {
                return " is found";
            }
            else
            {
                return " is not found";
            }
        }
    }
}
