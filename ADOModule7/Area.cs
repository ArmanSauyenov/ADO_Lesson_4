using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace ADOModule7
{
    [Table]
    public class Area
    {
        [Column(IsPrimaryKey = true)]
        public int AreaId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public int WorkingPeople { get; set; }
        public virtual ICollection<Timer> Timer { get; set; }
        public int WorkinPeople { get; internal set; }
        [Column]
        public bool? AssemblyArea { get; set; }
    }
}
