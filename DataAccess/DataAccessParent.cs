using MusterLibrary.CrewData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.DataAccess
{
    public abstract class DataAccessParent
    {
        public abstract Task<bool> SaveCrew(Crew current, bool infoOnly);

        public abstract Task<Crew> LoadCrew(Guid idToLoad);

        public abstract Task<bool> DeleteCrew(Crew current, bool ifTestClear);

        public abstract Task<bool> DeleteCrew(Guid id);

        public abstract Task<bool> SaveCrewEntry(Entry current);
    }
}
