using System;
using System.Collections.Generic;

namespace nst
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text("Лаба 2 завдання 1");
            Console.WriteLine(text.getTitle());
            text.addSentence();
            text.addSentence();
            text.changeSentence();
            text.changeSentence();
            text.changeSentence();
            Console.WriteLine(text.ToString());

        }
    }
    //lab2 njfvngfjtunhjfnvjf


    class Text
    {
        private List<Sentence> sentences = new List<Sentence>();
        private string title;

        public Text(string title)
        {
            this.title = title;
            this.sentences = sentences;
        }
        public void addSentence()
        {
            sentences.Add(new Sentence());
        }
        public string getTitle()
        {
            return this.title;
        }
        public override string ToString()
        {
            string text = "";
            for (int index = 0; index < this.sentences.Count; index++)
            {
                Sentence sentence = this.sentences[index];
                for (int index2 = 0; index2 < sentence.words.Count; index2++)
                {
                    text += sentence.words[index2].Val + " ";
                }
            }

            return text;

        }
        public void changeSentence()
        {
            Console.Write("Введіть номер речення, до якого хочете додати слово: ");
            int index = Int32.Parse(Console.ReadLine()) - 1;
            Console.Write("Введіть слово, яке хочете додати: ");
            string word = Console.ReadLine();
            this.sentences[index].AddWord(new Word(word));
        }
    }
    internal class Sentence
    {
        public List<Word> words = new List<Word>();

        public Sentence()
        {
            this.words = words;
        }

        public void AddWord(Word word)
        {
            this.words.Add(word);
        }
    }

    class Word
    {
        private string val;
        public string Val
        {
            get => val;
            set => val = value;
        }
        public Word(string word)
        {
            this.val = word;
        }


    }


}