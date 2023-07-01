using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brainbuddies
{
    public partial class Hangman : Form
    {
        private string secretWord;
        private int guessesLeft;
        private StringBuilder currentWord;
        private string guessedLetters = "";

        public Hangman()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Define a list of possible words
            List<string> possibleWords = new List<string>() // List of random words that could be chosen as the word to guess

             {
                "apple",
                "friend",
                "family",
                "roof",
                "house",
                "home",
                "rice",
                "cheese",
                "milk",
                "cow",
                "bread",
                "time",
                "clock",
                "year",
                "age",
                "date",
                "week",
                "month",
                "monster",
                "brain",
                "red",
                "pink",
                "blue",
                "green",
                "yellow",
                "purple",
                "black",
                "white",
                "rain",
                "banana",
                "cherry",
                "orange",
                "pear",
                "grape",
                "mango",
                "grape",
                "car",
                "truck",
                "happy",
                "sad",
                "soft",
                "loud",
                "sky",
                "cloud",
                "hair",
                "eyes",
                "nose",
                "mouth",
                "feet",
                "dog",
                "cat",
                "mouse",
                "bye",
                "hello"

             };

            // Initialize game variables
            Random random = new Random();
            secretWord = possibleWords[random.Next(possibleWords.Count)];
            guessesLeft = 10;
            currentWord = new StringBuilder();
            guessedLetters = "";
            guessedLetterLabel.Text = "Guessed Letters: ";

            // Display initial status
            for (int i = 0; i < secretWord.Length; i++)
            {
                currentWord.Append("-"); // Use dashes to represent how many letters
            }
            UpdateStatus();

        }

        private void UpdateStatus()
        {
            // Update label to display current word and guesses left
            labelStatus.Text = $"{currentWord} ({guessesLeft} guesses left)";
        }

        private void Hangman_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            char guess = textBoxGuess.Text.ToLower().FirstOrDefault(); // Get the user's guess from the TextBox and convert it to lowercase

            // Check if the user has already guessed this letter
            if (guessedLetters.Contains(guess))
            {
                MessageBox.Show("You have already guessed this letter.");
                textBoxGuess.Clear();
                return;
            }

            // Check if the user entered a valid guess
            if (guess == '\0')
            {
                MessageBox.Show("Please enter a letter.");
                return;
            }
            if (!char.IsLetter(guess))
            {
                MessageBox.Show("Please enter a valid letter.");
                return;
            }

            // Check if the guess is correct
            if (secretWord.Contains(guess))
            {
                // Update the current word with the guessed letter
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guess)
                    {
                        currentWord[i] = guess;
                    }
                }
                // Check if the user has won
                if (currentWord.ToString() == secretWord)
                {
                    MessageBox.Show($"You won! The word was {secretWord}.");
                    textBoxGuess.Clear();
                    InitializeGame();
                    return;
                }
            }
            else // Guess is incorrect
            {
                guessesLeft--; // Decrease number of guesses left

                if (!currentWord.ToString().Contains(guess))
                {
                    guessedLetters += guess;
                    guessedLetterLabel.Text = "Guessed Letters: " + string.Join(", ", guessedLetters); // Shows letters that have been guessed
                }

                // Check if the user has lost
                if (guessesLeft == 0)
                {
                    MessageBox.Show($"You lost! The word was {secretWord}.");
                    textBoxGuess.Clear();
                    InitializeGame();
                    return;
                }
            }

            // Update the status label to show the current word and guesses left
            UpdateStatus();

            // Clear the TextBox for the next guess
            textBoxGuess.Clear();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void home_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
