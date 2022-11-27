using MusterLibrary.DataAccess;
using MusterLibrary.Support.Validators;

namespace MusterLibrary.CrewData
{
    public class Crew : DBAccess
    {
        private TextValidator textValidator = new TextValidator();
        private DataAccessProvider dataAccess = new DataAccessProvider();
        public Guid CrewId { get; set; }
        public string CrewName { get; set; }
        public int MusterNumber { get; set; }
        public string SheetRef { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get; set; }

        // other joiinh data as lists
        public List<Quality> Qualities { get; set; }
        public List<Note> Notes { get; set; }

        public List<Punishment> Punishments { get; set; }

        public List<Entry> Entries { get; set; }

        public List<Discharge> Discharges { get; set; }

        public List<Financial> Financials { get; set; }

        public Crew(string usNewName, string usSheetRef)
        {
            CrewId = Guid.NewGuid();

            SetDefaults();
            

            string sName = String.Empty;
            if (textValidator.ValidateText(usNewName, out sName))
            {
                CrewName = sName;
            }
            if (textValidator.ValidateTextNumber(usSheetRef, out sName))
            {
                SheetRef = sName;
            }
            
            
            

        }

        public Crew()
        {

        }

        public Crew(Guid id)
        {
            SetDefaults();
            Load(id);
            
        }

        private void SetDefaults()
        {
            CrewName = String.Empty;
            SheetRef = String.Empty;
            MusterNumber = -1;
            Age = 0;
            BirthPlace = String.Empty;
            Financials = new List<Financial>();
            Discharges = new List<Discharge>();
            Notes = new List<Note>();
            Qualities = new List<Quality>();
            Punishments = new List<Punishment>();
            Entries = new List<Entry>();

        }

        public void Save()
        {
            dataAccess.GetLiveDataAccess().SaveCrew(this, false);

            
        }

        public void Delete()
        {
            dataAccess.GetLiveDataAccess().DeleteCrew(this, false);
        }

        public void ClearAll()
        {
            SetDefaults();
        }

        public void Load(Guid id)
        {
            Task<Crew> loadedCrew = dataAccess.GetLiveDataAccess().LoadCrew(id);
            CrewId = id;
            if (loadedCrew.Result != null)
            {

                CrewName = loadedCrew.Result.CrewName;
                MusterNumber = loadedCrew.Result.MusterNumber;
                Age = loadedCrew.Result.Age;
                BirthPlace = loadedCrew.Result.BirthPlace;
                SheetRef = loadedCrew.Result.SheetRef;

                // Tell container sub classes to load as well
                //Financials = loadedCrew.Result.Financials;
                //Discharges = loadedCrew.Result.Discharges;
                //Notes = loadedCrew.Result.Notes;
                //Qualities = loadedCrew.Result.Qualities;
                //Punishments = loadedCrew.Result.Punishments;
                //Entries = loadedCrew.Result.Entries;

            }
        }
    }
}

