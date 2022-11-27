using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.CrewData
{
    public class Note
    {
        public Guid CrewId { get; set; }

        public string SubNote { get; set; }

        public string SheetRef { get; set; }

        public Note(Crew masterCrew)
        {
            CrewId = masterCrew.CrewId;
            SubNote = String.Empty;
            SheetRef = String.Empty;
        }
    }
}
