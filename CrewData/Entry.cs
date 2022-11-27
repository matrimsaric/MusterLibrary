using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.CrewData
{
    public class Entry
    {
        public Guid CrewId { get; set; }

        public DateTime EntryDate { get; set; }

        public DateTime AppearanceDate { get; set; }

        public string PressedOrNot { get; set; }

        public string NumberAndAmountOfTickets { get; set; }

        public string SheetRef { get; set; }

        public Entry(Crew masterCrew)
        {
            CrewId = masterCrew.CrewId;
            EntryDate = new DateTime(2000, 1, 1);
            AppearanceDate = new DateTime(2000, 1, 1);
            PressedOrNot = String.Empty;
            NumberAndAmountOfTickets = String.Empty;
            SheetRef = masterCrew.SheetRef;


        }
    }
}
