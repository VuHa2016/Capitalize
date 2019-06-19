using System;

namespace Capitalize
{
    class Program
    {
        public static string[] ToUpperFirstLetter(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                string name = arr[i].ToLower();
                arr[i] = char.ToUpper(name[0]) + name.Substring(1);
            }
            return arr;
        }

        static void Main(string[] args)
        {
            string[] arr = new string[] { "mavis", "senaida", "letty" };
            // string[] arr = new string[] { "samuel", "MABELLE", "letitia", "meridith" };
            // string[] arr = new string[] { "Slyvia", "Kristal", "Sharilyn", "Calista" };

            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
            string[] result = ToUpperFirstLetter(arr);

            foreach (string i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
