﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MacuacuaRa.Sprint4.Task4.V24.Lib
{
    public class DataService : ISprint4Task4V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) // Перебираем строки
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Перебираем столбцы
                {
                    if (matrix[i, j] % 2 == 0) // Если элемент четный
                    {
                        matrix[i, j] = 1; // Заменяем четный элемент на 1
                    }
                }
            }
            return matrix;
        }
    }
}
