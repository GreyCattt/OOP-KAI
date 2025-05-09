using System;
using System.Collections.Generic;
using System.Linq;

namespace TextLibrary
{
    public class TextContainer : IDuplicateHandler
    {
        private readonly List<StringItem> strings = new List<StringItem>();

        // Додавання рядка
        public void AddString(StringItem stringItem)
        {
            strings.Add(stringItem);
        }

        // Видалення рядка
        public void RemoveString(StringItem stringItem)
        {
            strings.Remove(stringItem);
        }

        // Очищення тексту
        public void Clear()
        {
            strings.Clear();
        }

        // Повернення частоти появи символу
        public double GetSymbolFrequency(char symbol)
        {
            int totalSymbols = strings.Sum(s => s.GetValue().Length);
            int symbolCount = strings.Sum(s => s.GetValue().Count(c => c == symbol));

            return totalSymbols > 0 ? (double)symbolCount / totalSymbols : 0.0;
        }

        // Заміна підрядка
        public void ReplaceSubstring(string oldSubstring, string newSubstring)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                strings[i] = new StringItem(strings[i].ReplaceSubstring(oldSubstring, newSubstring));
            }
        }

        // Реалізація методу для видалення дублюючих рядків
        public void RemoveDuplicates()
        {
            var uniqueStrings = strings.Distinct().ToList();
            strings.Clear();
            strings.AddRange(uniqueStrings);
        }

        // Отримання тексту
        public List<string> GetText()
        {
            return strings.Select(s => s.GetValue()).ToList();
        }
    }
}