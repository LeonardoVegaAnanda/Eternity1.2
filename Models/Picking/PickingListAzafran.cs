using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models.Picking
{
    public class PickingListAzafran
    {
        public int AbsEntry { get; set; }
        public DateTime PickDate { get; set; } 
        public int DocNum { get; set; }
        public int Series { get; set; }
        public string U_EstatusOV { get; set; }
    }
}