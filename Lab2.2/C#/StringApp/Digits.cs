namespace StringLibrary
{
    public class Digits : StringBase
    {
        // Конструктор з параметром
        public Digits(string str) : base(str) { }

        // Перевизначення функції для обробки рядка (подвоєння)
        public override string Process()
        {
            return value + value;
        }
    }
}