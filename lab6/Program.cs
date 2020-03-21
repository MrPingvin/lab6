using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пооочередно вводите слова. Для окончания ввода введите -0.");
            List<String> list = new List<string>();
            string elem = "";
            while(elem != "-0")
            {
                if (elem.Length > 0)
                    list.Add(elem);
                elem = Console.ReadLine();
            }

            Array sort_array = list.ToArray();
            string final_word = "";
            Array.Sort(sort_array);

            Console.WriteLine("\nОтсортированный список элементов:");
            for (int i = 0; i < sort_array.Length; i++)
            {
                string element_ = sort_array.GetValue(i).ToString();

                Console.WriteLine(element_);
                final_word += element_[element_.Length-1];
            }
            Console.WriteLine("Слово составленное из последних символов слов: " + final_word);
            Console.ReadKey();
        }
    }
}
