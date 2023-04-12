using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models.Items
{
    public class ItemUbicaciones
    {
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string BarCode { get; set; }
        public decimal SalesUnitWeight { get; set; }
        public int ItemsGroupCode { get; set; }
        public string U_codigo { get; set; }
        public List<UbicacionesItems> ubicacionesItems { get; set; }

        public ItemUbicaciones(string itemCode, string itemName, string codeBars, decimal sWeight1, int itmsGrpCod, string u_codigo,List<UbicacionesItems> ubicaciones)
        {
            this.itemCode = itemCode;
            this.itemName = itemName;
            this.BarCode = codeBars;
            this.SalesUnitWeight = sWeight1;
            this.ItemsGroupCode = itmsGrpCod;
            U_codigo = u_codigo;
            this.ubicacionesItems = ubicaciones;
        }
    }
}
