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
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();
        }

        private void add1_Click(object sender, EventArgs e)
        {
            Add1 add1 = new Add1();
            add1.Show();
        }

        private void add2_Click(object sender, EventArgs e)
        {
            Add2 add2 = new Add2();
            add2.Show();
        }

        private void add3_Click(object sender, EventArgs e)
        {
            Add3 add3 = new Add3();
            add3.Show();
        }

        private void sub1_Click(object sender, EventArgs e)
        {
            Sub1 sub1 = new Sub1();
            sub1.Show();
        }

        private void sub2_Click(object sender, EventArgs e)
        {
            Sub2 sub2 = new Sub2();
            sub2.Show();
        }

        private void sub3_Click(object sender, EventArgs e)
        {
            Sub3 sub3 = new Sub3();
            sub3.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Numbers_Load(object sender, EventArgs e)
        {

        }

        private void mul1_Click_1(object sender, EventArgs e)
        {
            Mul1 mul1 = new Mul1();
            mul1.Show();
        }

        private void mul2_Click(object sender, EventArgs e)
        {
            Mul2 mul2 = new Mul2();
            mul2.Show();
        }

        private void mul3_Click(object sender, EventArgs e)
        {
            Mul3 mul3 = new Mul3();
            mul3.Show();
        }
    }
}
