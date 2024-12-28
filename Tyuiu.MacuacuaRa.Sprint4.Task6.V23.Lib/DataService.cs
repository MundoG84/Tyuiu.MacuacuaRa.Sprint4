using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MacuacuaRa.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {
            string[] sixLetterWords = Array.FindAll(array, word => word.Length == 6);

            return sixLetterWords.Length;
        }
    }
}
