  using System.Collections.Generic;

namespace RemoveDuplicateAssessments
{
  public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "apple", "banana", "apple", "orange", "banana", "grape" };

            List<string> uniqueList = RemoveDuplicates(list);

            foreach (string item in uniqueList)
            {
                Console.WriteLine(item);
            }
        }

        public static List<T> RemoveDuplicates<T>(List<T> list)
        {
            HashSet<T> uniqueSet = new HashSet<T>();

            foreach (T item in list)
            {
                uniqueSet.Add(item);
            }

            return new List<T>(uniqueSet);
        }
    }
}
