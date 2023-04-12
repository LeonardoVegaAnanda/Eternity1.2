using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models.Items
{
    public class ItemPurchaseOrders
    {
        public string ItemCode { get; set; }

        public string ItemDescription { get; set; }

        public decimal Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal PriceAfterVAT { get; set; }

        public string WarehouseCode { get; set; }

        public string BarCode { get; set; }

        public decimal UnitPrice { get; set; }

        public string NCMCode { get; set; }

        public ItemPurchaseOrders(string itemCode, string itemDescription, decimal quantity, decimal price, decimal priceAfterVAT, string warehouseCode, string barCode, decimal unitPrice, string nCMCode)
        {
            this.ItemCode = itemCode;
            this.ItemDescription = itemDescription;
            this.Quantity = quantity;
            this.Price = price;
            this.PriceAfterVAT = priceAfterVAT;
            this.WarehouseCode = warehouseCode;
            this.BarCode = barCode;
            this.UnitPrice = unitPrice;
            this.NCMCode = nCMCode;
        }

        public ItemPurchaseOrders() { }
    }

}
