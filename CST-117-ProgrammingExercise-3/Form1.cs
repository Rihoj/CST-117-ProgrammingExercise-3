using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CST_117_ProgrammingExercise_3
{
    public partial class Form1 : Form
    {
        string[] words;
        string first = null;
        string last = null;
        string longest = null;
        string mostVowels = null;
        int mostVowelsCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<string> wordsInLine = new List<string>();
                StreamReader inputFile;
                inputFile = File.OpenText(openFile.FileName);
                while (!inputFile.EndOfStream)
                {
                    foreach (string word in inputFile.ReadLine().ToLower().Split(' '))
                    {
                        wordsInLine.Add(word);
                    }
                }
                inputFile.Close();
                words = wordsInLine.ToArray();
                foreach(string word in words)
                {
                    findAlphabetical(word);
                    findLongestWord(word);
                    countVowels(word);
                }
                string[] lines =
                {
                    "Alphabetically First word: "+first,
                    "Alphabetically Last word: "+last,
                    "Longest Word: "+longest,
                    "Word with the most vowels: "+mostVowels
                };
                statsTextBox.Text = string.Join("\r\n", lines);
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFile.FileName, lines);
                }
            }
            else
            {
                MessageBox.Show("You clicked the Cancel button.");
            }
        }

        private void findAlphabetical(string word)
        {
            if(first == null)
            {
                last = word;
                first = word;
                return;
            }
            if(word.CompareTo(first) == -1)
            {
                first = word;
            }
            if(word.CompareTo(last) == 1)
            {
                last = word;
            }
        }

        private void findLongestWord(string word)
        {
            if(longest == null)
            {
                longest = word;
                return;
            }
            if(longest.Length < word.Length)
            {
                longest = word;
            }
        }

        private void countVowels(string word)
        {
            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                if(word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    count++;
                }
            }
            if (count > mostVowelsCount)
            {
                mostVowelsCount = count;
                mostVowels = word;
            }
        }
    }
}
