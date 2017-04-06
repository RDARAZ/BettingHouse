using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozgrywkiLigiKoszykowki.ViewModel
{
    using Model;
    using System.Collections.ObjectModel;

    class LeagueViewModel
    {
        public RosterViewModel BriansTeam { get; private set; }
        public RosterViewModel JimmysTeam { get; private set; }

        public LeagueViewModel()
        {
            Roster briansRoster = new Roster("Bombiarze", GetBomberPlayers());
            BriansTeam = new RosterViewModel(briansRoster);

            Roster jimmysRoster = new Roster("Wspaniali", GetAmazinPlayers());
            JimmysTeam = new RosterViewModel(jimmysRoster);
        }

        private IEnumerable<Player> GetBomberPlayers()
        {
            List<Player> bomberPlayers = new List<Player>() {
                new Player("Damian", 31, true),
                new Player("Leszek", 23, true),
                new Player("Krystyna",6, true),
                new Player("Maciek", 0, true),
                new Player("Jurek", 42, true),
                new Player("Heniek",32, false),
                new Player("Franek",8, false),
            };
            return bomberPlayers;
        }

        private IEnumerable<Player> GetAmazinPlayers()
        {
            List<Player> amazinPlayers = new List<Player>() {
                new Player("Kuba",42, true),
                new Player("Henryk",11, true),
                new Player("Jakub",4, true),
                new Player("Lidia", 18, true),
                new Player("Kim", 16, true),
                new Player("Bernadeta", 23, false),
                new Player("Edek",21,  false),
            };
            return amazinPlayers;
        }
    }
}
