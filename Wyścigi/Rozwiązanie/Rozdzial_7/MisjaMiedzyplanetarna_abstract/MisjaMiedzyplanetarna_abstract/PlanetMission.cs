using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisjaMiedzyplanetarna_abstract
{
    abstract class PlanetMission
    {
        public abstract void SetMissionInfo(int milesToPlanet, int rocketFuelPerMile, long rocketSpeedMPH);

        public long RocketFuelPerMile;
        public long RocketSpeedMPH;
        public int MilesToPlanet;

        public long UnitsOfFuelNeeded()
        {
            return MilesToPlanet * RocketFuelPerMile;
        }

        public int TimeNeeded()
        {
            return MilesToPlanet / (int)RocketSpeedMPH;
        }
        public string FuelNeeded()
        {
            return "Będziesz potrzebował "
              + MilesToPlanet * RocketFuelPerMile
              + " jednostek paliwa, aby się tam dostać. Zajmie Ci to "
              + TimeNeeded() + " godzin.";

        }
    }
}
