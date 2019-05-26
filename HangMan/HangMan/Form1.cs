using System;                           //generated namespaces
using System.Collections.Generic;       //
using System.ComponentModel;            // 
using System.Data;                      //
using System.Drawing;                   //
using System.Linq;                      //
using System.Text;                      //
using System.Threading.Tasks;           //
using System.Windows.Forms;             
using System.Data.OleDb;             //added in to connect to the database

namespace HangMan
{
    public partial class Form1 : Form  //full name of the partial class would be HangMan.form1 : form, because of the name space 
    {
        private string _currentWord; //implement currentword

        private Bitmap[] hangImages = { HangMan.Properties.Resources.hangman1, HangMan.Properties.Resources.hangman2, HangMan.Properties.Resources.hangman3,//images which are stored and called from the resources
                                          HangMan.Properties.Resources.hangman4, HangMan.Properties.Resources.hangman5 };    //images are stored and called from the resources 
        private int wrongGuesses = 0;     //implement worngGuesses to 0
        private List<HangmanWord> words;  // create a list hangmanword
        private List<string> guessedChars;  // creating a list of guessed characters 
        private Random _random;  

        public Form1()
        {
            InitializeComponent();   //default constructor 
        }

        private void Guessed_Click(object sender, EventArgs e) // object sender is the button clicked to get here
        {
            Button sendingButton = (Button) sender;
            sendingButton.Enabled = false;

            bool wrongGuess = !_currentWord.ToLowerInvariant().Contains(sendingButton.Text.ToLowerInvariant());  // ! checks for the opposite condition 

            if (!guessedChars.Contains(sendingButton.Text.ToUpperInvariant()))  //checking to see if guesschars contains the word, which was converted to UPPER case
                guessedChars.Add(sendingButton.Text.ToUpperInvariant());        

            if (wrongGuess)
            {
                GuessedLetters.Items.Clear();
                GuessedLetters.Items.AddRange(guessedChars.Where(p=>!_currentWord.ToUpperInvariant().Contains(p.ToUpperInvariant())).ToArray());//loop through guessedchars were letter is not in current word, add results to listbox
                if (++wrongGuesses >= 5) {  
                    MessageBox.Show("you lose!");  //message box will indecate if the user losses a game
                    LoadGame();                     // calls on the method load game
                    return;
                }
                hangImage.Image = hangImages[wrongGuesses]; // next image will be shown and wrong guesses will go up one
                return; //exit the method
            }
            label1.Text = string.Join("", // method that joins collection of char into a string
                _currentWord.Select(      // select goes through each char one by one
                  p => guessedChars.Contains(p.ToString().ToUpperInvariant()) ? p : '*').ToArray());   // p is the current selected letter  and ? if its true return unmasked char if false return masked char
  
            if (string.Equals(label1.Text, _currentWord, StringComparison.OrdinalIgnoreCase)) {  //compare currentword and label text to see if game is over
                MessageBox.Show("Game won!");      //message box shows that the user won the game
                LoadGame();                        //calls on the method LoadGame
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGame(); 
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {      
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void LoadGame()    //method LoadGame will load the game and is called upon in other places 
        {
            words = new List<HangmanWord>(); //  words is a new instance of the list hangmanwords 
            guessedChars = new List<string>(); // guessedChars is a new instance of the list string
            _random = new Random();            // random is a new random //basically to randomly generate something

            //The connection string for the database that we want to connect to.
            string str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=words.accdb.mdb";
            //Create a new connection to the database. 
            using (OleDbConnection con = new OleDbConnection(str))
            {
                //Open the connection
                try
                {
                    con.Open();
                }
                catch (Exception) //indicate if connection did not open
                {
                    MessageBox.Show("Connection did not open");
                }
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT words, hint FROM words";  // selects the columns words and hint from the words database, which is saved in the bin folder

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        words.Add(new HangmanWord { Word = reader[0].ToString(), Hint = reader[1].ToString() }); // a new instance using an object initializer and added to a list
                    }
                }
            }
            HangmanWord word = words[_random.Next(words.Count - 1)];  // next word will be random
            _currentWord = word.Word;
            label1.Text = new string('*', _currentWord.Length);  // label1 will show the lenght of the word, but will be shown as *
            lblHint.Text = word.Hint; // lblHint will show the hint that is associated with the word
            wrongGuesses = 0;
            hangImage.Image = hangImages[wrongGuesses];
            GuessedLetters.Items.Clear();

            foreach (Button button in this.Controls.Cast<Control>().Where(p => p.GetType() == typeof(Button))) //loops through all controls on form where control is button
            {
                if (button.Enabled)    
                    continue;

                button.Enabled = true;            
            }
        }

        private void GuessedLetters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class HangmanWord
    {
        public string Word { get; set; } // get gets the word, set sets word
        public string Hint { get; set; } // get gets the hint, set sets the hint
    }
}
