using System.ComponentModel;

namespace ConsoleApp1
{
    public class ArrayHelper
    {
        public static void Add(ref string[] arr, string newValue)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = newValue;
        }

        public static void Remove(ref string[] arr, string newValue)
        {
            Array.Resize(ref arr, arr.Length - 1);
            arr[arr.Length - 1] = newValue;
        }

    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = { "faska" };
            string name1 = "musa";
            ArrayHelper.Add(ref arr, name1);
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }


            ArrayHelper.Remove(ref arr, name1);
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }




        }

    }
}