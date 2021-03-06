﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOModule7
{
    [Table]
    public class Timer
    {
        [Column]
        public int TimerId { get; set; }
        [Column]
        public int AreaId { get; set; }
        [Column]
        public DateTime DateStart { get; set; }
        [Column]
        public DateTime DateFinish { get; set; }
        public virtual Area Area { get; set; }
    }
}
