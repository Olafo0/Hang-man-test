using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan2
{
    public partial class Form1 : Form
    {

        public Game game { get; set; }

        public Form1()
        {
            InitializeComponent();
            game = new Game(); 
            game.LabelInti(WordLabel);
            

        }

        private void Button_Click(object sender, EventArgs e)
        {

            var button = ((Button)sender);

            string input = textBox1.Text;
            textBox1.Clear();
            try
            {
                // convete the users input to a character 
                char user = Convert.ToChar(input);
                // run the function
                game.typecheck(user, button, listBox1, listBox2, LivesLabel, Pic1, Pic2, Pic3, Pic4, Pic5, Pic6);
                // has won function
                game.labelUpdater(WordLabel, user);
                game.HasWon(WordLabel);
            }
            catch
            {

            }

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("Hi");
            //string downloadedString;
            //WebClient client;
            //client = new WebClient(); 
            //downloadedString = client.DownloadString("https://random-word-api.herokuapp.com/word");
            //downloadedString = downloadedString.Replace("[", "");
            //downloadedString = downloadedString.Replace("]", "");
            //downloadedString = downloadedString.Replace("\"", "");
            //MainMenu = downloadedString;



            //Console.WriteLine("WORD USER HAS TO GUESS {0}", downloadedString)
        }





        // useless garbage ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
