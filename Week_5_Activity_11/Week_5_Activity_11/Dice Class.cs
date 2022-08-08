using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Activity_11
{
    internal class Dice_Class
    {
     
      
        public int DiceOne()
        {
            Random getRanNum1 = new Random();
            Random getRanNum2 = new Random();

            int diceNumberOne = getRanNum1.Next(6);
            int diceNumberTwo = getRanNum2.Next(6);

            while (diceNumberTwo == diceNumberOne)
                diceNumberTwo = getRanNum1.Next(6);

            return diceNumberTwo;
            

        }

        public int DiceTwo()
        {
            int diceSideNumber;
            Random rand1 = new Random();

            diceSideNumber = rand1.Next(6);


            return diceSideNumber;

        }

       


    }
}
