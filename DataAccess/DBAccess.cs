using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.DataAccess
{
    internal interface DBAccess
    {
        public void Save();
        public void Delete();
        public void ClearAll();
        public void Load(Guid id);
    }
}
