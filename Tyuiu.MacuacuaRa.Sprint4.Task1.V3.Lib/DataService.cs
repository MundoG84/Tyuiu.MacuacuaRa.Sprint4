using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MacuacuaRa.Sprint4.Task1.V3.Lib
{
    public class DataService : ISprint4Task1V3
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
