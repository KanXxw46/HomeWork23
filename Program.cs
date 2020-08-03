using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork23
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\STEP\C#\Solutions\lesson0409\";

            string[] words;
            List<int> numbers = new List<int>();

            using (StreamReader stream = new StreamReader(path + "input.txt"))
            {
                string text = stream.ReadLine();

                words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            int result = numbers[0] + numbers[1];

            Console.WriteLine(numbers[0] + " + " + numbers[1] + " = " + result);

            using (FileStream stream = new FileStream(path + "output.txt", FileMode.Create))
            {
                string data = result.ToString();

                byte[] bytes = System.Text.Encoding.Unicode.GetBytes(data);

                stream.Write(bytes, 0, bytes.Length);
            }

            Console.ReadLine();
        }
    }
}
