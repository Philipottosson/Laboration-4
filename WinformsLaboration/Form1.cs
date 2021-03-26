using Labb.ClassLIbary;
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

namespace WinformsLaboration
{
    public partial class Form1: Form
    {
        private Word word;
        private List<string> addWord = new List<string>();
        private List<string> Languages = new List<string>();
        private string fileName;
        private int lanuagesCount;
        public Form1()
        {
            InitializeComponent();
            hideAll();
        }
        private void Wordlist_Load(object sender, EventArgs e)
        {
            hideAll();
        }

        /// <summary>
        /// Button for practice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            hideAll();
            grp_practice.Show();
        }

        /// <summary>
        /// Button for removing words
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_menuRemove_Click(object sender, EventArgs e)
        {
            hideAll();
            grp_remove.Show();
        }
        /// <summary>
        /// Button for listing words
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_list_Click(object sender, EventArgs e)
        {
            hideAll();
            txt_listAll.Text = "";
            grp_list.Show();
        }

        /// <summary>
        /// Button for creating a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_create_Click(object sender, EventArgs e)
        {
            hideAll();
            if (!String.IsNullOrEmpty(txt_filename.Text))
            {
                grp_menu.Hide();
                hideAll();
                fileName = txt_filename.Text;
                grp_createNewList.Show();
                lanuagesCount = 0;
            }
            else MessageBox.Show("You must enter a filename!");
        }
        /// <summary>
        /// Will hide all the GUI below the menu
        /// </summary>
        private void hideAll()
        {
            grp_list.Hide();
            grp_practice.Hide();
            grp_remove.Hide();
            grp_add.Hide();
        }

        /// <summary>
        /// This button will generate a random word
        /// for practice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generateWord_Click(object sender, EventArgs e)
        {
            WordList wordlist = WordList.LoadList(txt_filename.Text);
            word = wordlist.GetWordToPractice();
            txt_practiceFrom.Text = word.Translations[word.FromLanguage];
            txt_practiceTo.Text = wordlist.Languages[word.ToLanguage];
            Label_answer.Hide();
            txt_practiceAnswer.Text = "";
        }

        /// <summary>
        /// Button for loading a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_load_Click(object sender, EventArgs e)
        {
            hideAll();
            if (!String.IsNullOrEmpty(txt_filename.Text))
            {
                fileName = txt_filename.Text;
                lanuagesCount = 0;
                if (File.Exists(Environment.GetFolderPath
                    (Environment.SpecialFolder.LocalApplicationData) + "\\" + fileName + ".dat"))
                {
                    WordList wordlist = WordList.LoadList(fileName);
                    grp_menu.Show();

                }
                else MessageBox.Show("Wrong filename");
            }
        }

        /// <summary>
        /// Will remove words
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_remove_Click(object sender, EventArgs e)
        {
            WordList wordlist = WordList.LoadList(fileName);
            if (!String.IsNullOrEmpty(txt_removeLanguages.Text) &&
                !String.IsNullOrEmpty(txt_removeWord.Text))
            {
                for (int i = 0; i < wordlist.Languages.Length; i++)
                {
                    if (txt_removeLanguages.Text == wordlist.Languages[i])
                    {             
                        if(wordlist.Remove(i, txt_removeWord.Text))
                        {
                            MessageBox.Show("Word removed");
                        }
                        else MessageBox.Show("Word not found");
                    }
                }
            }
            txt_removeWord.Text = "";
            txt_removeLanguages.Text = "";
        }

        /// <summary>
        /// Will check if the user entered the correct answer
        /// to the practice word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PracticeCheck_Click(object sender, EventArgs e)
        {
            hideAll();
            grp_practice.Show();
            if (txt_practiceAnswer.Text == word.Translations[word.ToLanguage])
            {
                Label_answer.Text = "Correct Answer! Well done.";
                Label_answer.Show();
            }
            else
            {
                Label_answer.Text = "Wrong Answer. Try again! The correct answer was "+ word.Translations[word.ToLanguage];
                Label_answer.Show();
            }
        }
        /// <summary>
        /// Will list the wordlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_listBylanguage_Click(object sender, EventArgs e)
        {
            WordList wordlist = WordList.LoadList(fileName);
            txt_listAll.Font = new Font(FontFamily.GenericMonospace, txt_listAll.Font.Size);
            for (int i = 0; i < wordlist.Languages.Length; i++)
            {
                if (txt_sortByLanguages.Text == wordlist.Languages[i])
                {
                    foreach (string s in wordlist.Languages)
                    {
                        txt_listLanguages.Text += s.ToUpper().PadRight(22);
                    }
                    wordlist.List(i, trans =>
                    {
                        foreach (string s in trans)
                        {
                            txt_listAll.Text += s.ToLower().PadRight(10);

                        }
                        txt_listAll.Text += System.Environment.NewLine;
                    });
                }
            }
        }
        /// <summary>
        /// This is for adding new words.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            WordList wordlist = WordList.LoadList(fileName);
            if (label_WordOrTranslation.Text == "Word in")
            {
                addWord = new List<string>();
                label_WordOrTranslation.Text = "Translation in";
                lanuagesCount++;
                label_InLanguages.Text = wordlist.Languages[lanuagesCount];
                addWord.Add(txt_word.Text);
                txt_word.Text = "";
            }
            else if (label_WordOrTranslation.Text == "Translation in")
            {
                lanuagesCount++;
                addWord.Add(txt_word.Text);
                txt_word.Text = "";
            }
            if (lanuagesCount == wordlist.Languages.Length)
            {
                label_WordOrTranslation.Text = "Word in";
                wordlist.Add(addWord.ToArray());
                label_InLanguages.Text = wordlist.Languages[0];
                lanuagesCount = 0;
            }
            else label_InLanguages.Text = wordlist.Languages[lanuagesCount];
        }

        /// <summary>
        /// This is for adding new languages to the list
        /// after you have pressed on the button to created it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addLanguages_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_CreateNewList.Text))
            {
                Languages.Add(txt_CreateNewList.Text);
            }
            txt_CreateNewList.Text = "";
        }
        /// <summary>
        /// This button is for creating a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CreateFile_Click(object sender, EventArgs e)
        {
            if (Languages.Count > 1)
            {
                WordList wordlist = new WordList(fileName, Languages.ToArray());
                wordlist.Save();
                grp_createNewList.Hide();
                MessageBox.Show("File Created!");
                grp_menu.Show();
            }
            else MessageBox.Show("You need more than one languages to create a file!");
        }

        /// <summary>
        /// Button for Adding words
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_menuAdd_Click(object sender, EventArgs e)
        {
            hideAll();
            grp_add.Show();
            WordList wordlist = WordList.LoadList(fileName);
            label_InLanguages.Text = wordlist.Languages[0];
        }
    }
}
