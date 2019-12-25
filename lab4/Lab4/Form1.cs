using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace files
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Word list type
        /// </summary> 
        List<string> list = new List<string>();

        private void ReadButton_Click(object sender, EventArgs e) //clicking on *OPEN* button
        {
            OpenFileDialog OD = new OpenFileDialog(); //new open dialog
            OD.Filter = "Текстовые файлы|*.txt"; //setting a filter
            if (OD.ShowDialog() == DialogResult.OK) //if file has been chosen
            {
                Stopwatch sw = new Stopwatch(); //a new stopwatch
                sw.Start(); //Чтение файла в виде строки //starting a stopwatch
                string text = File.ReadAllText(OD.FileName); //reading whole text from the file
                char[] sep = new char[] {' ','.',',','!','?','/','\t','\n'}; //separators for words
                string[] array = text.Split(sep); //splitting a text by seps
                foreach (string cur in array) //removing extra spaces
                {
                    string str = cur.Trim();
                    if (!list.Contains(str)) //add to list if unique
                        list.Add(str); 
                }
                sw.Stop(); //stopping the stopwatch
                this.ReadTimeText.Text = sw.Elapsed.ToString(); //showing time of a search
                this.ReadCountText.Text = list.Count.ToString(); //showing counter of words
            }
            else 
                MessageBox.Show("It's necessary to open a file!");
        }

        private void ExactSearchButton_Click(object sender, EventArgs e)
        {
            string word = this.SearchWordText.Text.Trim(); //a word for a search
            if (!string.IsNullOrEmpty(word) && list.Count > 0) //if a field wasn't empty
            { 
                string Upper = word.ToUpper(); //upping a case
                List<string> TmpList = new List<string>(); //temporaty results list
                Stopwatch sw = new Stopwatch(); //new stopwatch
                sw.Start(); //starting the stopwatch
                foreach (string str in list) //searching
                    if (str.ToUpper().Contains(Upper)) 
                        TmpList.Add(str); //adding a word
                sw.Stop(); //stopping a stopwatch
                this.ExactSearchTimeText.Text = sw.Elapsed.ToString(); //showing a time
                this.ResultBox.BeginUpdate(); //updating a listbox
                this.ResultBox.Items.Clear(); //clearing a listbox
                foreach (string str in TmpList) //swowing found words to listbox
                    this.ResultBox.Items.Add(str); 
                this.ResultBox.EndUpdate(); //ending of listbox updating
            }
            else 
                MessageBox.Show("It's necessary to choose a file and a word to search!"); 
        }
    }
}
