using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\t\t\t 1. Enter the keyword to select\n");
                Console.WriteLine("\t\t\t 2. Exit\n");
                string usr_inp, s; // usr_inp - строка для пользовательского ввода, s - строка для считывания текстового файла
                try
                {
                    usr_inp = Console.ReadLine();
                    switch (int.Parse(usr_inp))
                    {
                        case 1:
                            {
                                Console.WriteLine("\t\t\t Please enter the keyword\n");
                                usr_inp = Console.ReadLine();
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
                                if (s.Length > 0) // Если строка не пустая
                                {
                                    string[] Sentences = s.Split(new char[] { '.', '!', '?' }); // Разбиение строки на подстроки в массив строк Sentences по литералам '.', '!', '?'
                                    for (int i = 0; i < Sentences.Length; i++)
                                    {
                                        if (Sentences[i].Contains(usr_inp))
                                        {
                                            Console.WriteLine(Sentences[i]);
                                        }
                                    }
                                }
                            }
                            break;
                        case 2: return;

                        default: return;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            } while (true);
        }
    }
}