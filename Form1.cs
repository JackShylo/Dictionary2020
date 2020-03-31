using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary2020
{
    public partial class Form1 : Form
    {
        Operations myOperations = new Operations();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadWords_Click(object sender, EventArgs e)
        {
            myOperations.LoadDictionary();
            this.Text = myOperations.DictionaryWords.Count.ToString();

            BtnSearch.Enabled = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            myOperations.SearchWord = TxtSearchWord.Text.ToLower();

            string Outcome = myOperations.RunSearch(myOperations.DictionaryWords, myOperations.SearchWord);
            LbxWords.Items.Add(myOperations.SearchWord + Outcome);
        }
    }
}
