using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdpornyFacet
{
    class RobustGuy
    {
        public DateTime? Birthday { get; private set; }
        public int? Height { get; private set; }

        public RobustGuy(string birthday, string height)
        {
            DateTime tempDate;
            if (DateTime.TryParse(birthday, out tempDate))
                Birthday = tempDate;
            else
                Birthday = null;

            int tempInt;
            if (int.TryParse(height, out tempInt))
                Height = tempInt;
            else
                Height = null;
        }

        public override string ToString()
        {
            string description;
            if (Birthday.HasValue)
                description = "Urodziłem się dnia " + Birthday.Value.ToLongDateString();
            else
                description = "Nie znam daty swoich urodzin";
            if (Height.HasValue)
                description += ", mam " + Height + " centymetrów wzrostu.";
            else
                description += ", nie wiem, ile mam wzrostu.";
            return description;
        }
    }
}
