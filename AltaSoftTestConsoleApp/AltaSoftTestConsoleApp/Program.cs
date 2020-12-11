using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltaSoftTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input string");
            string text = Console.ReadLine();
            if (text.Length < 1)
            {
                Console.WriteLine("your text is empty");
            }

            //First Version
            //List<string> MexicanWaveTexts = new List<string>();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    MexicanWaveTexts.Add(StandUp(text, i));
            //}

            // MexicanWaveTexts.ForEach(x => Console.WriteLine(x));

            //Second Version With Linq
            Enumerable.Range(0, text.Length).Select(x => StandUp(text, x)).ToList().ForEach(x => Console.WriteLine(x));
        }


        static string StandUp(string text, int index)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (index == i)
                {
                    var tempChar = char.ToUpper(text[i]);
                    stringBuilder.Append(tempChar);
                }
                else
                {
                    stringBuilder.Append(text[i]);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
