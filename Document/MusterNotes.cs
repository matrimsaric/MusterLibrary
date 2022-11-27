using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusterLibrary.Document
{
    public class MusterNotes
    {
        public string SheetRef { get; set; }
        public DateTime MusterStart { get; set; }
        public DateTime MusterEnd { get; set; }

        public string Notes { get; set; }
    }
}
