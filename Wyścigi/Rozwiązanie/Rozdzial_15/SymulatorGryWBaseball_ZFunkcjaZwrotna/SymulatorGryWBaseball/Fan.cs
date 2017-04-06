using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorGryWBaseball
{
    using System.Collections.ObjectModel;

    class Fan
    {
        public ObservableCollection<string> FanSays = new ObservableCollection<string>();
        private int pitchNumber = 0;
        public Fan(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }
        void ball_BallInPlay(object sender, EventArgs e)
        {
            pitchNumber++;
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Distance > 400 && ballEventArgs.Trajectory > 30)
                    FanSays.Add("Rzut nr " + pitchNumber
                                 + ": Home run! Idę po piłkę!");
                else
                    FanSays.Add("Rzut nr " + pitchNumber + ": Jeee! Do boju!");
            }
        }
    }

}
