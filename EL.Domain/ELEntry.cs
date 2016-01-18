using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL.Domain
{
    public class ELEntry
    {
        public int Id { get; set; }

        public DateTime DateOfEntry { get; set; }
        public string Feeling { get; set; }
        public string Thinking { get; set; }
        public string Facts { get; set; }
        public string Opinion { get; set; }
        public string Location { get; set; }

        public ICollection<EntryUpdate> Updates { get; set; }

    }

    public class EntryUpdate
    {
        public int Id { get; set; }
        public virtual ELEntry Entry { get; set; }

        public DateTime DateTime { get; set; }
        public string Update { get; set; }

    }
}
