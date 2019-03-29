using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan_WinForm
{
    public partial class Form1 : Form
    {

        private String[] poolOfWords = { "EARTH", "PLUTO", "NEPTUNE", "SATURN", "MARS","MERCURY","VENUS","JUPITER","URANUS" };

        private String wordToGuess;

        private int numberOfTriesLeft;

        private int numberOfLettersDiscovered;

        private char[] wordToDisplay;

        ArrayList userGoodHistory;
        ArrayList userBadHistory;


        public Form1()
        {

            /** hangman **/
            Random r = new Random();
            wordToGuess = poolOfWords[r.Next(0,poolOfWords.Length)];

            numberOfTriesLeft = 6;

            numberOfLettersDiscovered = 0;

            wordToDisplay = new char[wordToGuess.Length];

            //initialization of the displayable word             
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                wordToDisplay[i] = '*';
            }

            userGoodHistory = new ArrayList(); // the set of letters given by the user since the beginning of the program
            userBadHistory = new ArrayList();


            /** UI **/
            InitializeComponent();
            //we prevent the window from being resized
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            //load the hangman image inside the picture box
            LoadNewPict();

            word.Text = new String(wordToDisplay); //because the textBox can't process array of char
            histo.Text = "";

            //let's display the rules!
            MessageBox.Show("Press leters on your keyboard to guess the word", "WLECOME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        //this method will load the corresponding image to the number of lives left
        private void LoadNewPict()
        {
            // first, let's release the former image
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            //then load a new one, where the name of the file will contain the information about how many lives are left
            pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Pix\\hang_" + numberOfTriesLeft + ".bmp");
        }


        //all the game actions will be performed in this method (when the player enter a new letter
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char guess = Char.ToUpper(e.KeyChar);

            //is the typed key a letter?
            if (guess >= 'A' && guess <= 'Z')
            {
              
                if (userBadHistory.Contains(guess) || userGoodHistory.Contains(guess))
                {
                    MessageBox.Show("Letter already tried", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                else
                {
                    

                    //is it a good letter or not?                     
                    if (wordToGuess.Contains(guess)) //YES
                    {
                        //let's remember for next time
                        userGoodHistory.Add(guess);
                        //let's update the word to display in order to reveal the newly found character                         
                        for (int i = 0; i < wordToGuess.Length; i++)
                        {
                            if (guess == wordToGuess[i])
                            {
                                wordToDisplay[i] = guess;
                                numberOfLettersDiscovered++;
                            }
                        }

                        //we have to print the new version of the word
                        word.Text = new String(wordToDisplay);
                    }
                    else //NO                     
                    {
                        numberOfTriesLeft--;
                        
                        //we save this new letter inside our history
                        userBadHistory.Add(guess);

                        //we have to update this information to the display
                        histo.Text += guess;

                        //we have to update the display
                        labelChances.Text = numberOfTriesLeft.ToString();

                        //let's update the corresonding picture
                        LoadNewPict();
                    }


                }
                
                //so, is the game over?
                if (numberOfTriesLeft == 0)
                {
                    MessageBox.Show("TOO BAD", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (numberOfLettersDiscovered == wordToGuess.Length)
                {
                    MessageBox.Show("CONGRATULATIONS\n" + wordToGuess + " was discovered", "WIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else //invalid letter typed
            {
                MessageBox.Show("entered key is not a letter", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       
    }
}
