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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            Numbers numbers = new Numbers();
            numbers.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void games_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show();
        }
    }
}
