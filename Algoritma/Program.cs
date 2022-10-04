using System;

namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteIndex();
        }

        static void DeleteIndex()
        {
            Console.WriteLine("Bir ifade giriniz: ");

            var input = Console.ReadLine();

            var inputSplit = input.Split(separator: ',');

            var result = inputSplit[0].Remove(startIndex: Convert.ToInt16(inputSplit[1]), 1);

            Console.WriteLine(result);





        }
    }
}
