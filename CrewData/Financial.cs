using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.CrewData
{
    public class Financial
    {
        public Guid PersonGuid { get; set; }
        public string StragglingString { get; set; }
        public double Straggling { get; set; }
        public string VeneralsString { get; set; }
        public double Venerals { get; set; }

        public string DeathClothsString { get; set; }
        public double DeathCloths { get; set; }

        public string WagesString { get; set; }
        public double Wages { get; set; }

        public string SlopsString { get; set; }
        public double Slops { get; set; }

        public string BedsString { get; set; }
        public double Beds { get; set; }

        public string TobaccoString { get; set; }
        public double Tobacco { get; set; }
        public string BountyString { get; set; }
        public double Bounty { get; set; }

        public string OtherString { get; set; }
        public double Other { get; set; }

        public DateTime PayDate { get; set; }

        public string SheetRef { get; set; }

        public Financial(Crew masterCrew)
        {
            PersonGuid = masterCrew.CrewId;
            SheetRef = masterCrew.SheetRef;
            StragglingString = String.Empty;
            Straggling = 0.0;
            VeneralsString = String.Empty;
            Venerals = 0.0;
            DeathClothsString = String.Empty;
            DeathCloths = 0.0;
            WagesString = String.Empty;
            Wages = 0.0;
            SlopsString = String.Empty;
            Slops = 0.0;
            BedsString = String.Empty;
            Beds = 0.0;
            TobaccoString = String.Empty;
            Tobacco = 0.0;
            BountyString = String.Empty;
            Bounty = 0.0;
            OtherString = String.Empty;
            Other = 0.0;
            PayDate = new DateTime(2000, 1, 1);



        }

    }
}
