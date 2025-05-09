namespace TextLibrary
{
    public class StringItem
    {
        private readonly string value;

        // Конструктор
        public StringItem(string value)
        {
            this.value = value;
        }

        // Геттер для значення рядка
        public string GetValue()
        {
            return value;
        }

        // Метод для заміни підрядка
        public string ReplaceSubstring(string oldSubstring, string newSubstring)
        {
            return value.Replace(oldSubstring, newSubstring);
        }

        // Перевизначення методу Equals для порівняння рядків
        public override bool Equals(object? obj)
        {
            if (obj is StringItem other)
            {
                return value == other.value;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}