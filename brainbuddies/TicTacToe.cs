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
    public partial class TicTacToe : Form
    {
        private string playerMark = "X";
        private string computerMark = "O";
        private bool playerTurn = true;
        private Button[,] cells = new Button[3, 3];

        public TicTacToe()
        {
            InitializeComponent();
            // Create the game board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button cell = new Button();
                    cell.Width = 100;
                    cell.Height = 100;
                    cell.Font = new Font(cell.Font.FontFamily, 36);
                    cell.Click += Cell_Click;
                    tableLayoutPanel1.Controls.Add(cell, j, i);
                    cells[i, j] = cell;
                }
            }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Button clickedCell = (Button)sender;

            if (clickedCell.Text == "")
            {
                clickedCell.Text = playerMark;
                clickedCell.Enabled = false;

                if (CheckForWinner(playerMark))
                {
                    GameOver("You win!");
                }
                else if (CheckForTie())
                {
                    GameOver("Tie game!");
                }
                else
                {
                    playerTurn = false;
                    ComputerMove();
                }
            }
        }

        private void ComputerMove()
        {
            // Find an empty cell to mark as the computer's move
            List<Button> emptyCells = new List<Button>();
            foreach (Button cell in cells)
            {
                if (cell.Text == "")
                {
                    emptyCells.Add(cell);
                }
            }

            Random random = new Random();
            int index = random.Next(emptyCells.Count);
            Button computerCell = emptyCells[index];
            computerCell.Text = computerMark;
            computerCell.Enabled = false;

            if (CheckForWinner(computerMark))
            {
                GameOver("Computer wins!");
            }
            else if (CheckForTie())
            {
                GameOver("Tie game!");
            }
            else
            {
                playerTurn = true;
            }
        }

        private bool CheckForWinner(string mark)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (cells[i, 0].Text == mark && cells[i, 1].Text == mark && cells[i, 2].Text == mark)
                {
                    return true;
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (cells[0, j].Text == mark && cells[1, j].Text == mark && cells[2, j].Text == mark)
                {
                    return true;
                }
            }

            // Check diagonals
            if (cells[0, 0].Text == mark && cells[1, 1].Text == mark && cells[2, 2].Text == mark)
            {
                return true;
            }

            if (cells[0, 2].Text == mark && cells[1, 1].Text == mark && cells[2, 0].Text == mark)
            {
                return true;
            }

            return false;
        }

        private bool CheckForTie()
        {
            foreach (Button cell in cells)
            {
                if (cell.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        private void GameOver(string message)
        {
            MessageBox.Show(message);
            foreach (Button cell in cells)
            {
                cell.Enabled = false;
            }
        }


        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reset the game board
            foreach (Button cell in cells)
            {
                cell.Enabled = true;
                cell.Text = "";
            }

            // Reset the game state
            playerTurn = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
