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
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void hangman_Click(object sender, EventArgs e)
        {
            Hangman hangman = new Hangman();
            hangman.Show();
        }

        private void Games_Load(object sender, EventArgs e)
        {

        }

        private void tictactoe_Click(object sender, EventArgs e)
        {
            TicTacToe tictactoe = new TicTacToe();
            tictactoe.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
