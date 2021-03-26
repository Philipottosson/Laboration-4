
using Labb.ClassLIbary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listArray;
            List<string> languages = new List<string>();
            Regex regexMatch = new(@"^[a-z.\-A-Z]{1,20}$");
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].ToLower();
            }
            if (args[0] == "-lists")
            {
                listArray = WordList.GetLists();
                foreach (var name in listArray)
                {
                    //hämta information fårn en mapp
                    Console.WriteLine(name);
                }
                return;
            }
            for (int i = 0; i < args.Length - 2; i++)
            {
                languages.Add(args[i + 2]);
            }
            WordList wordList = new WordList(args[1], languages.ToArray());
            
            DirectoryInfo directory = new (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            if (args.Length < 2)
            {
                getInfo();
                Environment.Exit(0);
            }
            else if (args[0] == "-new")
            {
                if (Match(regexMatch, args) && args.Length > 3)
                {
                    args[1] = args[1].Trim(new Char[] { ' ', '<', '>' });
                    NewList(wordList);

                }
                else getInfo();


                /*
                using (StreamWriter newFile = new (directory + "\\" + args[1]))
                {
                    for (int i = 2; i < args.Length; i++)
                    {
                        args[i] = args[i].Trim(new Char[] { ' ', '<', '>' });
                        if (i == args.Length - 1)
                        {
                            newFile.Write(args[i]);
                        }
                        else newFile.Write(args[i] + ", ");
                    }
                }*/

            }
            else if (args[0] == "-add")
            {
                try
                {
                    wordList = WordList.LoadList(args[1]);

                }
                catch (Exception)
                {
                    Console.WriteLine("File is empty!");
                    getInfo();
                    return;
                }
                if (Match(regexMatch, args))
                {
                    AddWord(wordList);
                }
            }
            else if (args[0] == "-remove")
            {
                if (Match(regexMatch, args))
                {
                    RemoveWord(args);
                }
            }
            else if (args[0] == "-words")
            {
                try
                {
                    wordList = WordList.LoadList(args[1]);

                }
                catch (Exception)
                {
                    Console.WriteLine("File is empty!");
                    getInfo();
                    return;
                }
                if (Match(regexMatch, args))
                {
                    for (int i = 0; i < wordList.Languages.Length; i++)
                    {
                        if (wordList.Languages[i] == args[2])
                        {
                            PrintList(i, wordList);
                        }
                    }
                }
            }
            else if (args[0] == "-count")
            {
                if (Match(regexMatch, args))
                {
                    Console.WriteLine("There is " + wordList.Count() + " Words in this list!");
                }
            }
            else if (args[0] == "-practice")
            {
                try
                {
                    wordList = WordList.LoadList(args[1]);

                }
                catch (Exception)
                {
                    Console.WriteLine("File is empty!");
                    getInfo();
                    return;
                }
                if (Match(regexMatch, args))
                {
                    practiceWord(wordList);
                }
            }
            else getInfo();
        }

        /// <summary>
        /// Checks that the input from the user match the requierments
        /// </summary>
        /// <param name="regexMatch">The requierments</param>
        /// <param name="args">The input form the user</param>
        /// <returns></returns>
        public static bool Match(Regex regexMatch, string[] args)
        {
            for (int i = 1; i < args.Length; i++)
            {

                if (!regexMatch.IsMatch(args[i]))
                {
                    Console.WriteLine("User input did not match the requirements");
                    getInfo();
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// display information to the user
        /// </summary>
        public static void getInfo()
        {
            Console.WriteLine("Use any of the following parameters:\n" +
                                "-lists \n" +
                                "-new <list name> <language 1> <language 2> .. <language n>\n" +
                                "-add < list name >\n" +
                                "-remove < list name > < language > < word 1 > < word 2 > .. < word n >\n" +
                                "-words <listname> < sortByLanguage >\n" +
                                "-count < listname >\n" +
                                "-practice < listname > \n");
        }
        public static void practiceWord(WordList wordList)
        {
            Word word;
            bool stop = false;
            while (!stop)
            {
                word = wordList.GetWordToPractice();
                Console.WriteLine("What is the translation of the word " +word.Translations[word.FromLanguage]+
                    " from language \"" + wordList.Languages[word.FromLanguage] + 
                    "\" to the language \"" + wordList.Languages[word.ToLanguage] +"\"");
                string answer = Console.ReadLine();
                if (answer == word.Translations[word.ToLanguage])
                {
                    bool tryAgain = false;
                    Console.WriteLine("Correct! Well done.");
                    while (!tryAgain)
                    {
                        Console.WriteLine("Would u like to try one more? y/n" );
                        ConsoleKey again = Console.ReadKey().Key;
                        if (again.Equals(ConsoleKey.Y))
                        {
                            tryAgain = true;
                            
                        }
                        else if (again.Equals(ConsoleKey.N))
                        {
                            Console.WriteLine();
                            return;
                        }
                            Console.WriteLine();
                    }
                }
            }
        }
        public static void NewList(WordList wordList)
        {
            
            try
            {
                wordList.Save();

            }
            catch (Exception)
            {
                Console.WriteLine("Input from user does not match the amount of languages");
            }
        }
        public static void AddWord(WordList wordlist)
        {
            List<string> temp = new List<string>();
            bool exit = false;
            while (!exit)
            {
                exit = false;
                Console.WriteLine("What word would u like to add? (Empty line to finish) ");
                temp.Add(Console.ReadLine());
                if (temp[0] != "")
                {
                    int i = 0;

                    while (!exit)
                    {
                        Console.WriteLine("Enter translation to that word? (Empty line for a new word)");

                        string input = Console.ReadLine();

                        if (input != "")
                        {
                            temp.Add(input);
                        }
                        if (input == "")
                        {
                            exit = true;
                        }
                        i++;
                    }
                }
                
            }
            wordlist.Add(temp.ToArray());
        }
        public static void RemoveWord(string[] args)
        {
            WordList wordList;
            try
            {
                wordList = WordList.LoadList(args[1]);

            }
            catch (Exception)
            {
                Console.WriteLine("File is empty!");
                getInfo();
                return;
            }
           
            for (int i = 0; i < wordList.Languages.Length; i++)
            {
                if (wordList.Languages[i] == args[2])
                {
                    wordList.Remove(i, args[3]);
                }
            }
        }
        public static void PrintList(int sortByTranslation, WordList wordlist)
        {
            foreach (string s in wordlist.Languages)
            {
                Console.Write(s.ToUpper().PadRight(20));
            }
            Console.WriteLine();
            wordlist.List(sortByTranslation, trans =>
            {
                foreach (string s in trans)
                {
                    Console.Write(s.ToLower().PadRight(20));
                }
                Console.WriteLine();
            });
        }
    }
}

//mellan 65 -> 90 byt till 97-> 122