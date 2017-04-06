using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścigi
{
    public class Greyhound
    {
        public int StartingPosition;                                                        //Miejsce, gdzie rozpoczyna się PictureBox
        public int RacetrackLength;                                                         //Jak długa jest trasa
        public PictureBox MyPictureBox = null;                                              //Mój obiekt PictureBox
        public int Location = 0;                                                            //Moje położenie na torze wyścigowym
        public Random Randomizer;

        public bool Run(PictureBox racetrack)
        {
            this.MyPictureBox.Left += this.Randomizer.Next(1, 4);                                       //Przesuń się do przodu losowo o 1, 2, 3 lub 4 punkty
    
            if (this.MyPictureBox.Right > racetrack.Right)
            {
                return true;
            }

            return false;
        }
        public void TakeStartingPosition()
        {
            Location = 0;                                                        //Wyzeruj położenie i ustaw na linii startowej
            StartingPosition = 0;
        }

    }
}
