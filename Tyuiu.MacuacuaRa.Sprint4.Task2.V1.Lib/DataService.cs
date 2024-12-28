using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MacuacuaRa.Sprint4.Task2.V1.Lib
{
    public class DataService : ISprint4Task2V1
    {
        public int Calculate(int[] array)
        {
            int product = 1; 
            bool foundEven = false; 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) 
                {
                    product *= array[i]; 
                    foundEven = true; 
                }
            }
            return foundEven ? product : 0;
        }
    }
}
