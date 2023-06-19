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
                game.typecheck(user, button, listBox1, listBox2, LivesLabel);
                // has won function
                game.HasWon();
                game.labelUpdater(WordLabel, user);
            }
            catch
            {

            }

          

        }

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
    }
}
