using MusterLibrary.Support.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.CrewData
{
    public class Discharge
    {
        public Guid PersonGuid { get; set; }

        public DISCHARGE DischargeReason { get; set; }

        public DateTime DischargeDate { get; set; }

        public string Reason { get; set; }

        public string SheetRef { get; set; }

        public Discharge(Crew masterCrew)
        {
            DischargeReason = DISCHARGE.UNKNOWN;
            DischargeDate = new DateTime(2000, 1, 1);
            Reason = String.Empty;
            SheetRef = masterCrew.SheetRef;
            PersonGuid = masterCrew.CrewId;
        }

       
    }
}
