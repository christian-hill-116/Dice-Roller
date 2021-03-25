using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class DiceRoll : Form
    {
        int counter = 0;
        public DiceRoll()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dice1_Click(object sender, EventArgs e)
        {

        }

        private void btn_roll_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int box1 = new int();
            int box2 = new int();

            box1 = r.Next(0, 5);
            box2 = r.Next(0, 5);

            if (box1 == 0) bigDice1.Image = dice1.Image;
            else if (box1 == 1) bigDice1.Image = dice2.Image;
            else if (box1 == 2) bigDice1.Image = dice3.Image;
            else if (box1 == 3) bigDice1.Image = dice4.Image;
            else if (box1 == 4) bigDice1.Image = dice5.Image;
            else bigDice1.Image = dice6.Image;

            if (box2 == 0) bigDice2.Image = dice1.Image;
            else if (box2 == 1) bigDice2.Image = dice2.Image;
            else if (box2 == 2) bigDice2.Image = dice3.Image;
            else if (box2 == 3) bigDice2.Image = dice4.Image;
            else if (box2 == 4) bigDice2.Image = dice5.Image;
            else bigDice2.Image = dice6.Image;

            if (box1 == 0 && box2 == 0) MessageBox.Show("It took " + counter + " roll(s) to get snake eyes!" );
        }

        private void btn_roll_MouseClick(object sender, MouseEventArgs e)
        {
            counter++;
        }
    }
}
