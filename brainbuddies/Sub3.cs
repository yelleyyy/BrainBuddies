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
    public partial class Sub3 : Form
    {
        private Random random;
        private int minValue;
        private int maxValue;
        private int number1;
        private int number2;
        private int difference;
        private int equationCounter;
        private int correctCount;
        private int incorrectCount;

        public Sub3()
        {
            InitializeComponent();
            random = new Random(); // Create a new instance of the Random Class
            minValue = 5;
            maxValue = 15; // Defines the range for the random numbers
            equationCounter = 0;
            correctCount = 0;
            incorrectCount = 0;
            GenerateEquation();
        }

        private void GenerateEquation()
        {
            number1 = random.Next(minValue, maxValue);
            number2 = random.Next(minValue, number1);
            difference = number1 - number2; // calculates the sum

            numberLabel1.Text = number1.ToString();
            numberLabel2.Text = number2.ToString();
            resultLabel.Text = string.Empty;
            answerTextBox.Text = string.Empty; // where the user presents their answer
            equationCounter++;

            if (equationCounter > 5)
            {
                if (correctCount > 3)
                {
                    MessageBox.Show($"You finished and got {correctCount} / {correctCount + incorrectCount} !!!\n\nYou have finished all 3 levels!");
                    Close();

                }

                if (correctCount < 3)
                {
                    MessageBox.Show($"You finished and got {correctCount} / {correctCount + incorrectCount} !!!\n\nPlease try this level again to be a pro!");
                    Close();
                }
            }
        }
        private void Sub3_Load(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int userInput;
            bool isValidNumber = int.TryParse(answerTextBox.Text, out userInput);

            if (isValidNumber)
            {
                if (userInput == difference) // Checks if the user's answer matches the actual sum
                {
                    resultLabel.Text = "Correct!";
                    correctCount++;
                }
                else
                {
                    resultLabel.Text = "Incorrect!";
                    incorrectCount++;
                }
            }
            else
            {
                MessageBox.Show("Please enter a number. \n(Input is invalid)");
                return;
            }
        }

        private void newEquationButton_Click(object sender, EventArgs e)
        {
            GenerateEquation();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
