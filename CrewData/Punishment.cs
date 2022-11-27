using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.CrewData
{
    public class Punishment
    {
        public Guid CrewId { get; set; }

        public DateTime PunishmentDate { get; set; }

        public string Reason { get; set; }

        public string SheetRef { get; set; }

        public Punishment(Crew masterCrew)
        {
            CrewId = masterCrew.CrewId;
            PunishmentDate = new DateTime(2000, 1, 1);
            Reason = String.Empty;
            SheetRef = masterCrew.SheetRef;
        }
    }
}
