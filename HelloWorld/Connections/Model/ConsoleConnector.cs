﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class ConsoleConnector : IDataConnection
    {
        public string Line { get; set; }
        public static Dictionary<string, string> DisplayByLanguages { get => displayByLanguages; set => displayByLanguages = value; }
        private static Dictionary<string, string> displayByLanguages;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="consoleString">String to display</param>
        public ConsoleConnector(string consoleString = "Hello World")
        {
            Line = consoleString;
            displayByLanguages = new Dictionary<string, string>()
            {
                { "Italian", "Ciao mondo" },
                { "Spanish", "Hola Mundo" },
                { "English", "Hello World" }
            };

        }
        /// <summary>
        /// Display the line using console
        /// </summary>
        public void ShowLine()
        {
            Console.WriteLine(this.Line);
        }
        /// <summary>
        /// Translates Hello World to other languages // Gold plating
        /// </summary>
        public void TranslateHelloWorld()
        {
            Console.WriteLine($"You can translate 'Hello World' in these {ConsoleConnector.DisplayByLanguages.Count} different languages :");

            foreach (KeyValuePair<string, string> entry in ConsoleConnector.DisplayByLanguages)
            {
                Console.WriteLine(entry.Key);
            }
            Console.WriteLine("Pick one!");

            string response = Console.ReadLine();
            string translatedPhrase;
            if (!ConsoleConnector.DisplayByLanguages.TryGetValue(response, out translatedPhrase))
            {
                Console.WriteLine("That's not in there, stopping the program");
                return; // Todo, give user the option to add it to the dictionary (or database)
            }
            Console.WriteLine($"Translated to: {translatedPhrase}");

            Console.ReadLine();
        }


    }
}
