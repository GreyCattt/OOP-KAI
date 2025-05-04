using System;

namespace StringLibrary
{
    public class Letters : StringBase
    {
        // Конструктор з параметром
        public Letters(string str) : base(str) { }

        // Перевизначення функції для обробки рядка (перевертання)
        public override string Process()
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}