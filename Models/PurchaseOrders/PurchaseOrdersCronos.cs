using Eternity1._0.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models.Orders
{
    public class PurchaseOrdersCronos
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string DocDate { get; set; }
        public string DocTime { get; set; }
        public decimal DocTotal { get; set; }
        public decimal DocTotalSys { get; set; }
        public decimal VatSum { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public List<ItemPurchaseOrders> DocumentLines { get; set; }

        public PurchaseOrdersCronos(int docEntry, int docNum, string DocDate, string DocTime,decimal docTotalSys, decimal vatSum, decimal DocTotal, string CardCode, string CardName, List<ItemPurchaseOrders> documentLine)
        {
            this.DocEntry = docEntry;
            this.DocNum = docNum;
            this.DocDate = DocDate;
            this.DocTime = DocTime;
            this.DocTotal = DocTotal;
            this.CardCode = CardCode;
            this.CardName = CardName;
            this.DocumentLines = documentLine;
            this.DocTotalSys = docTotalSys;
            this.VatSum = vatSum;
        }
       public  PurchaseOrdersCronos() { }
    }
}
