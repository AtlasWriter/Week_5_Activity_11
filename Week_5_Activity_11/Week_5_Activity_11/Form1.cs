using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_Activity_11
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            Dice_Class Dice_One = new Dice_Class();

            Dice_Class Dice_Two = new Dice_Class();



            // If statement assigning images to dice numbers
         



            if (Dice_One.DiceOne() == 1)
            {
                diceOnePictureBox.Image = diceImageList.Images[0];
            }
            else if (Dice_One.DiceOne() == 2)
            {
                diceOnePictureBox.Image = diceImageList.Images[1];
            }
            else if (Dice_One.DiceOne() == 3)
            {
                diceOnePictureBox.Image = diceImageList.Images[2];
            }
            else if (Dice_One.DiceOne() == 4)
            {
                diceOnePictureBox.Image = diceImageList.Images[3];
            }
            else if (Dice_One.DiceOne() == 5)
            {
                diceOnePictureBox.Image = diceImageList.Images[4];
            }
            else if (Dice_One.DiceOne() == 6)
            {
                diceOnePictureBox.Image = diceImageList.Images[5];
            }

            if (Dice_Two.DiceTwo() == 1 && Dice_One.DiceOne() == 1)
            {
                string str = "Congradulations you rolled snake eyes";

                winner.Text = str;

                MessageBox.Show("Congradulations you rolled snake rolls");

            }



            // If statement assigning images to dice number two

            if (Dice_Two.DiceTwo() == 1)
            {
                diceTwoPictureBox.Image = diceImageList.Images[0];

            }
            else if (Dice_Two.DiceTwo() == 2)
            {
                diceTwoPictureBox.Image = diceImageList.Images[1];
            }

            else if (Dice_Two.DiceTwo() == 3)
            {
                diceTwoPictureBox.Image = diceImageList.Images[2];
            }
            else if (Dice_Two.DiceTwo() == 4)
            {
                diceTwoPictureBox.Image = diceImageList.Images[3];
            }
            else if (Dice_Two.DiceTwo() == 5)
            {
                diceTwoPictureBox.Image = diceImageList.Images[4];
            }
            else if (Dice_Two.DiceTwo() == 6)
            {
                diceTwoPictureBox.Image = diceImageList.Images[5];

            }
            
          
        }
 
    }
}
