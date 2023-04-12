using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models.Picking
{
    public class PickingListSurtido
    {
        public int AbsEntry { get; set; }
        public string Name { get; set; }
        public DateTime PickDate { get; set; }
        public int OrderEntry { get; set; }
        public int DocNum { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public decimal Quantity { get; set; }
        public int Series { get; set; }
        public string U_EstatusOV { get; set; }
        public string CardName { get; set; }
    }
}
