using System.IO;
using System;
using System.Collections.Generic;

namespace KizhiPart1
{
    public class Interpreter
    {

        private TextWriter writer;
        public static Dictionary<string, int> dictionary = new Dictionary<string, int>();

        public Interpreter(TextWriter writer)
        {
            this.writer = writer;
        }

        public void ExecuteLine(string command)
        {
            string[] str = command.Split(" ".ToCharArray());
            switch (str[0])  // 0 is instruction's position in string 
            {
                case "set":
                    dictionary.Add(str[1], Convert.ToInt32(str[2]));
                    break;
                case "sub":
                    if (!dictionary.ContainsKey(str[1]))
                    {
                        writer.WriteLine("Переменная отсутствует в памяти");
                    }
                    else
                        dictionary[str[1]] -= Convert.ToInt32(str[2]);
                    break;
                case "print":
                    if (!dictionary.ContainsKey(str[1]))
                    {
                        writer.WriteLine("Переменная отсутствует в памяти");
                    }
                    else
                        Console.WriteLine(dictionary[str[1]]);
                        writer.WriteLine(dictionary[str[1]]);
                    break;
                case "rem":
                    if (!dictionary.ContainsKey(str[1]))
                    {
                        writer.WriteLine("Переменная отсутствует в памяти");
                    }
                    else
                        dictionary.Remove(str[1]);
                    break;
                default:
                    Console.WriteLine("Такой команды нет");
                    break;
            }


        }
    }
}