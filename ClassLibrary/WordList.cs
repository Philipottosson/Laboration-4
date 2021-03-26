using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Labb.ClassLIbary
{
    public class WordList
    {
        public static List<Word> words; //Contains all the words like hej;hello;hola
        public string Name { get; } 
        public string[] Languages { get; }
        
        //Konstruktor.Sätter properites Name och Languages till parametrarnas värden.
        public WordList(string name, params string[] languages)
        {
            Name = name;
            words = new List<Word>();
            Languages = languages;
            
        }
        
        //Returnerar array med namn på alla listor som finns lagrade(utan filändelsen).
        // return languages;

        public static string[] GetLists()
        {
            DirectoryInfo directory = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            FileInfo[] Files = directory.GetFiles("*.dat");
            string[] str = new string[Files.Length];
            int i = 0;
            foreach (FileInfo file in Files)
            {
                str[i] = file.Name;
                i++;
            }            
            return str;
        }
        
        // Laddar in ordlistan(name anges utan filändelse) och returnerar som WordList.
        public static WordList LoadList(string name)
        {
            List<string> temp = new List<string>();
            List<Word> getWords = new List<Word>();
            if(!File.Exists(Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData)
                + "\\" + name + ".dat"))
            {
                throw new Exception();
            }
            using (StreamReader loadFile = new(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + name + ".dat"))
            {
                string[] lang = loadFile.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < lang.Length; i++)
                { 
                    temp.Add(lang[i]);
                }
                while (!loadFile.EndOfStream)
                {
                    string[] wordArray = loadFile.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                    getWords.Add(new(wordArray));
                }
            }
            WordList newList = new WordList(name, temp.ToArray());
            words = getWords;
            return newList;
        }

        //Sparar listan till en fil med samma namn som listan och filändelse.dat
        public void Save()
        {
            StringBuilder builder = new StringBuilder();
            using (StreamWriter saveFile = new(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Name + ".dat"))
            {
                int count = 0;
                foreach (string lang in Languages)
                {
                    
                    builder.Append(lang+";");
                }
                saveFile.WriteLine(builder.ToString());
                foreach (Word langArr in words)
                {
                    count = 0;
                    builder = new StringBuilder();
                    foreach (var item in langArr.Translations)
                    {
                        count++;
                        builder.Append(item +";");
                    }
                    if (count == Languages.Length)
                    {
                        saveFile.WriteLine(builder.ToString());
                    }
                    else throw new WrongCountException();
                }
            }
        }
        
        //Lägger till ord i listan.Kasta ArgumentException om det är fel antal translations.
        public void Add(params string[] translations)
        {
            words.Add(new Word(translations));
            try
            {
                Save();
            }
            catch (WrongCountException)
            {
                Console.WriteLine("Input from user does not match the amount of languages");
            }
        }
        
        //translation motsvarar index i Languages.Sök igenom språket och ta bort ordet.
         public bool Remove(int translation, string word)
        {
            Regex contains = new Regex(@""+ word);
            //getWords();
            bool changeMade = false;
            for (int i = 0; i < words.Count; i++)
            {
                if (contains.IsMatch(words[i].Translations[translation]))
                {
                    words.Remove(words[i]);
                    changeMade = true;
                }
            }
            if (changeMade)
            {
                Save();
                return true;
            }
            return false;
        }
        
        //Räknar och returnerar antal ord i listan.
        public int Count()
        {
            WordList newList = LoadList(Name);
            return words.Count * newList.Languages.Length; //langCount;
        }

        //sortByTranslation = Vilket språk listan ska sorteras på.
        //showTranslations = Callback som anropas för varje ord i listan.
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {

            if (sortByTranslation < 0 || sortByTranslation >= Languages.Count())
            {
                throw new ArgumentOutOfRangeException("sortByTranslation argument out of range.");
            }

            foreach (Word word in words.OrderBy(w => w.Translations[0]).ToList())
            {
                showTranslations?.Invoke(word.Translations);
            }
        }
        //Returnerar slumpmässigt Word från listan, med slumpmässigt valda
        //FromLanguage och ToLanguage(dock inte samma).
        public Word GetWordToPractice()
         {
             Random rand = new Random();
             int word = rand.Next(0, words.Count);
             int fromWord = rand.Next(0, Languages.Length);
             int toWord = rand.Next(0, Languages.Length);
             while (fromWord == toWord && Languages.Length > 0)
             {
                 toWord = rand.Next(0, Languages.Length);
             }
             return new Word(fromWord, toWord, words[word].Translations);

         }
    }
}

