using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyścigi
{
    public partial class Form1 : Form
    {
        Guy[] guys = new Guy[3];
        Greyhound[] GreyhoundArray = new Greyhound[4];

        public Form1()
        {
            InitializeComponent();

            guys[0] = new Guy()
            {
                Cash = 200,
                Name = "Janek",
                MyLabel = label1,
                MyRadioButton = joeRadioButton
            };
            guys[1] = new Guy()
            {
                Cash = 200,
                Name = "Bartek",
                MyLabel = label2,
                MyRadioButton = bobRadioButton
            };
            guys[2] = new Guy()
            {
                Cash = 200,
                Name = "Arek",
                MyLabel = label5,
                MyRadioButton = alRadioButton
            };
            foreach (Guy guy in guys)
                guy.PlaceBet(0, 0);

            //ustaw domyślnie zakład dla Janka
            name.Text = guys[0].Name;

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = pictureBox1.Width - pictureBox2.Width,
                Randomizer = new Random()
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = pictureBox1.Width - pictureBox3.Width,
                Randomizer = GreyhoundArray[0].Randomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = pictureBox1.Width - pictureBox4.Width,
                Randomizer = GreyhoundArray[0].Randomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox5,
                StartingPosition = pictureBox5.Left,
                RacetrackLength = pictureBox1.Width - pictureBox5.Width,
                Randomizer = GreyhoundArray[0].Randomizer
            };

            updateForm();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Greyhound hound in GreyhoundArray)
            {
                hound.MyPictureBox.Left = hound.StartingPosition;
            }
            timer1.Enabled = true;
        }

        public void updateForm()
        {
            joeRadioButton.Text = guys[0].Name + " ma " + guys[0].Cash + " zł";
            bobRadioButton.Text = guys[1].Name + " ma " + guys[1].Cash + " zł";
            alRadioButton.Text = guys[2].Name + " ma " + guys[2].Cash + " zł";
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guys[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guys[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guys[2].Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guy;
            if (joeRadioButton.Checked)
            {
                guy = 0;
            }
            else if (bobRadioButton.Checked)
            {
                guy = 1;
            }
            else
            {
                guy = 2;
            }
            guys[guy].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value - 1);

            Console.WriteLine(guys[guy].Name + " postawił " + guys[guy].MyBet.Amount + " zł na psa nr " + (guys[guy].MyBet.Dog + 1));
        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int winner;

            for(int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (GreyhoundArray[i].Run(pictureBox1))
                {
                    winner = i;
                    timer1.Enabled = false;
                    MessageBox.Show("Wygrał chart z numerem: " + (winner + 1), "Koniec wyścigu!");

                    for (int j = 0; j < guys.Length; j++)
                    {
                        if (guys[j].MyBet.PayOut(winner) != 0)
                            guys[j].Cash += guys[j].MyBet.PayOut(winner);
                        guys[j].MyRadioButton.Text = guys[j].Name + " ma " + guys[j].Cash;
                    }
                    break;
                }
            }
        }

    }
}
