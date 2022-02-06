using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("\t\t\t Enter the keyword to select\n");
            string usr_inp, s;
            try
            {
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                usr_inp = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            try
            {
                StreamReader f = new StreamReader("input.txt");
                s = f.ReadToEnd();
                f.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Check correct name of the file");
                return;
            }
            if (s.Length > 0)
            {
                string[] Sentences = s.Split(new char[] { '.','!','?' });
                for (int i = 0; i < Sentences.Length; i++)
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                    if (Sentences[i].Contains(usr_inp))
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
                        Console.WriteLine(Sentences[i]);
            }
            Console.WriteLine();
        }
    }
}