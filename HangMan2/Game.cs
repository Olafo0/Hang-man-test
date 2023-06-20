using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan2
{
    public class Game
    {


        public Game()
        {
            MainWord = apiword();
        }

        public string MainWord;
        public int lives = 6;
        


        List<char> CorrectChar = new List<char>();

        public void typecheck(char user, Button button, ListBox listBox1, ListBox listbox2, Label LivesLabel, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5, PictureBox pic6)
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

                        if (lives == 6)
                        {
                            pic1.Visible = true;
                        }
                        else if (lives == 5)
                        {
                            pic1.Visible = false;
                            pic2.Visible = true;
                        }
                        else if (lives == 4)
                        {
                            pic2.Visible = false;
                            pic3.Visible = true;
                        }
                        else if (lives == 3)
                        {
                            pic3.Visible = false;
                            pic4.Visible = true;
                        }
                        else if (lives == 2)
                        {
                            pic4.Visible = false;
                            pic5.Visible = true;
                        }
                        else if (lives == 1)
                        {
                            pic5.Visible = false;
                            pic6.Visible = true;
                        }



                    }
                }
            }
        }

        public void HasWon(Label WordLabel)
        {

            // -- OLD FEATURE 
            //List<char> newList = MainWord.OrderBy(character => character).ToList();
            //List<char> GC = CorrectChar.OrderBy(x => x).ToList();

            //string CorrectWord = string.Concat(newList);
            //string GuessedCorrectWords = string.Concat(GC);

            //Console.WriteLine(CorrectWord + " VS " + GuessedCorrectWords);

            // GuessedCorrectWords == CorrectWord

            if (MainWord == WordLabel.Text)
            {
                Console.WriteLine("CONSOLE: You've won the game");

                string msg = "Do you want to play again?";
                string title = "You have won well done punk";
                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
                
            }
            else if (lives <= 0)
            {
                Console.WriteLine("CONSOLE: You've lost the game");

                string msg = "The correct word  " + MainWord + " .Do you want to play again?";
                string title = "To win next time uninstall system32!";
                MessageBoxButtons but = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(msg, title, but);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public void LabelInti(Label WordLabel)
        {
            // create a temp varaible replaced with 
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

                }
            }
        }

        public string apiword()
        {
            string downloadedString;
            WebClient client;
            client = new WebClient();
            downloadedString = client.DownloadString("https://random-word-api.herokuapp.com/word");
            Clean Word = new Clean(downloadedString);
            Console.WriteLine(Word.word);
            Word.word = Word.word.Replace("[", "");
            Word.word = Word.word.Replace("]", "");
            Word.word = Word.word.Replace("\"", "");

            return Word.word;
        }



    }
}
