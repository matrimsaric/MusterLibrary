using MusterLibrary.Support.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.CrewData
{
    public class Quality
    {
        public Guid PersonGuid { get; set; }
        public DateTime ChangeDate { get; set; }
        public KNOWN_RANKS Rank { get; set; }
        public string OtherRank { get; set; }
        public string Notes { get; set; }
        public string SheetRef { get; set; }


        public Quality(Crew masterCrew)
        {
            PersonGuid = masterCrew.CrewId;
            ChangeDate = new DateTime(2000, 1, 1);
            Rank = KNOWN_RANKS.UNKNOWN;
            OtherRank = String.Empty;
            Notes = String.Empty;
            SheetRef = String.Empty;
        }
    }

}
