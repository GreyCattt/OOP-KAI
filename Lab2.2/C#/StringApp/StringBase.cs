namespace StringLibrary
{
    public abstract class StringBase
    {
        protected string value;

        // Конструктор з параметром
        protected StringBase(string str)
        {
            value = str;
        }

        // Віртуальна функція для обчислення довжини рядка
        public virtual int GetLength()
        {
            return value.Length;
        }

        // Абстрактна функція для обробки рядка
        public abstract string Process();

        // Геттер для значення рядка
        public string GetValue()
        {
            return value;
        }
    }
}