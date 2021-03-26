using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb.ClassLIbary
{
    public class Word
    {
        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        public Word(params string[] translations)
        {
            //initialiserar ’Translations’ med data som skickas in som ’translations’
            List<string> newList = new List<string>();
            for (int i = 0; i < translations.Length; i++)
            {
                newList.Add(translations[i]);
            }
            Translations = newList.ToArray();
        }
        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            //som ovan, fast sätter även FromLanguage och ToLanguage.
           
            Translations = translations;
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
        }
    }
}
