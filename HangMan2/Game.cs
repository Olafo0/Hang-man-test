using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan2
{
    public class Game
    {
        Api api = new Api()

        string apiword = Api.genword();
        string MainWord = apiword;
        public int lives = 6;



        List<char> CorrectChar = new List<char>();

        public void typecheck(char user, Button button, ListBox listBox1, ListBox listbox2, Label LivesLabel)
        {


            foreach (char c in MainWord)
            {
                if (user == c)
                {
                    if (listbox2.Items.Contains(user))
                    {

                    }
                    else
                    {
                        listbox2.Items.Add(user);
                        CorrectChar.Add(user);
                        break;

                    }
                }
                else if (MainWord.Contains(user) == false)
                {
                    if (listBox1.Items.Contains(user))
                    {

                    }
                    else
                    {
                        lives -= 1;
                        LivesLabel.Text = lives.ToString();
                        listBox1.Items.Add(user);
                    }
                }
            }
        }

        public void HasWon()
        {

            List<char> newList = MainWord.OrderBy(character => character).ToList();
            List<char> GC = CorrectChar.OrderBy(x => x).ToList();

            string CorrectWord = string.Concat(newList);
            string GuessedCorrectWords = string.Concat(GC);

            Console.WriteLine(CorrectWord + " VS " + GuessedCorrectWords);

            if (GuessedCorrectWords == CorrectWord)
            {
                Console.WriteLine("You've won the game");
            }
            else if (lives <= 0)
            {
                Console.WriteLine("You've lost the game");
            }
        }

        public void LabelInti(Label WordLabel)
        {
            // create a temp varaible replaced with underscores
            string temp_word = MainWord;
            char[] CharacterUnderscore = MainWord.ToCharArray();

            for (int i = 0; i < CharacterUnderscore.Length; i++)
            {
                if (CharacterUnderscore[i] == ' ')
                {

                }
                else
                {
                    CharacterUnderscore[i] = '-';
                }
            }


            string underscoreword = string.Concat(CharacterUnderscore);
            WordLabel.Text = underscoreword;
        }

        public void labelUpdater(Label WordLabel,char user)
        {
            string text = WordLabel.Text;
            StringBuilder sb = new StringBuilder(text);
            Console.WriteLine(sb);



            for (int i = 0; i < MainWord.Length; i++)
            {
                if (user == MainWord[i])
                {
                    sb[i] = user;
                    Console.WriteLine(sb[i]);
                    Console.WriteLine(sb);
                    string temp_sp = Convert.ToString(sb);
                    WordLabel.Text = temp_sp;
                    break;
                }
            }
        }


    }
}

    