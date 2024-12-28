using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MacuacuaRa.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int max = array[0, 0]; // Начинаем с первого элемента первой строки

            for (int j = 1; j < array.GetLength(1); j++) // Перебираем элементы первой строки
            {
                if (array[0, j] > max) // Если элемент больше текущего максимума, обновляем максимальный элемент
                {
                    max = array[0, j];
                }
            }

            return max;
        }
    }
}
