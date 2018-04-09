namespace Task_1
{
    #region Задание №1
    // Реализовать простейшую хэш-функцию.На вход функции подается строка, на выходе получается сумма кодов символов
    #endregion
    class Program
    {
        /// <summary>
        /// Простейшую хэш-функцию, на вход подается строка, на выходе получается сумма кодов символов Unicode
        /// </summary>
        static double Convert(string str)
        {
            double res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                res += System.Convert.ToChar(str[i]);
            }

            return res;
        }

        static void Main(string[] args)
        {
            System.Console.Write("Введите строку: ");

            string str = System.Console.ReadLine();

            System.Console.WriteLine($"{Convert(str)}");

            System.Console.ReadKey();
        }
    }
}
