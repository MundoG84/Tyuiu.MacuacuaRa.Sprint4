using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MacuacuaRa.Sprint4.Task7.V30.Lib
{
    public class DataService : ISprint4Task7V30
    {
        public int Calculate(int n, int m, string value)
        {
            int result = 1; // Начальное значение произведения
            bool hasEven = false; // Флаг для проверки, были ли четные числа

            int index = 0;
            int[,] matrix = new int[n, m];

            // Заполнение матрицы значениями из строки
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            // Подсчет произведения четных чисел
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0) // Если число четное
                    {
                        result *= matrix[i, j];
                        hasEven = true; // Установим флаг, что хотя бы одно четное число найдено
                    }
                }
            }

            // Если не найдено четных чисел, возвращаем 0
            if (!hasEven)
            {
                return 0;
            }

            return result;
        }

    }
}
