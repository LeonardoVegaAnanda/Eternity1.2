using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models
{
    public class Item
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string VatLiable { get; set; }
        public string TaxType { get; set; }
        public string NCMCode { get; set; }
        public string IndirectTax { get; set; }
        public string ItemType { get; set; }
        public string Mainsupplier { get; set; }
        public int ItemsGroupCode { get; set; }
        public decimal SalesUnitWeight { get; set; }
        public int SalesWeightUnit { get; set; }
        public decimal SalesItemsPerUnit { get; set; }
        public string PlanningSystem { get; set; }
        public string ProcurementMethod { get; set; }
        public string BarCode { get; set; }
        public string U_CLASIF_STORE { get; set; }
        public string U_codigo { get; set; }
        public string SalesUnit { get; set; }
        public decimal SalesQtyPerPackUnit { get; set; }
        public string InventoryUOM { get; set; }
        public string PurchaseUnit { get; set; }
        public string PurchasePackagingUnit { get; set; }
        public string SalesPackagingUnit { get; set; }
        public string SWW { get; set; }

        /* +++ PROPIEDADES  +++ */
        public string Properties1 { get; set; } //Linea
        public string Properties2 { get; set; } //Mixto
        public string Properties3 { get; set; } //Casa
        public string Properties4 { get; set; }  //ProductoN
        public string Properties5 { get; set; }  //LAColors
        public string Properties6 { get; set; }  //RubyRose
        public string Properties7 { get; set; }  //IMNatural
        public string Properties8 { get; set; }//peaceGlos
        public string Properties9 { get; set; }  //Curtis
        public string Properties10 { get; set; } //Moda
        public string Properties11 { get; set; } //Temporada
        public string Properties12 { get; set; } //AretesP
        public string Properties13 { get; set; } //AnilloP
        public string Properties14 { get; set; } //Collar
        public string Properties15 { get; set; } //CabelloApple
        public string Properties16 { get; set; } //AccesoriosApple
        public string Properties17 { get; set; } //PestanasApple
        public string Properties18 { get; set; } //AplicadoresApple
        public string Properties19 { get; set; } //DepiladoresApple
        public string Properties20 { get; set; } //LapizAND
        public string Properties21 { get; set; } //CosmeticoMega
        public string Properties22 { get; set; } //DonasValerinas
        public string Properties23 { get; set; } //BrosPasCucas
        public string Properties24 { get; set; } //PinzasDiademas
        public string Properties25 { get; set; } //LigasColetero
        public string Properties26 { get; set; } //Naturone
        public string Properties27 { get; set; } //Prosa41
        public string Properties28 { get; set; } //Postizas
        public string Properties29 { get; set; } //Hogar
        public string Properties30 { get; set; } //Cocina
        public string Properties31 { get; set; } //Juguetes
        public string Properties32 { get; set; } //Escritura
        public string Properties33 { get; set; } //CortaPega
        public string Properties34 { get; set; } //EmpaquesRegalo
        public string Properties35 { get; set; } //Ultramo
        public string Properties36 { get; set; } //Remate
        public string Properties37 { get; set; } //Importacion
        public string Properties38 { get; set; } //TempSep
        public string Properties39 { get; set; } //TempHal
        public string Properties40 { get; set; } //TempNav
        public string Properties41 { get; set; } //Fiesta
        public string Properties42 { get; set; } //CajaCerrada
        public string Properties43 { get; set; } //Nails
        public string Properties44 { get; set; } //AccesoriosMegaline
        public string Properties45 { get; set; }//CabelloMegaline
        public string Properties46 { get; set; } //AccesoriosAND
        public string Properties47 { get; set; } //CabelloAND
        public string Properties48 { get; set; } //PestanaAND
        public string Properties49 { get; set; } //DepiladoresAND
        public string Properties50 { get; set; } //AplicadoresAND
        public string Properties51 { get; set; } //HebleeCosmetics
        public string Properties52 { get; set; } //Marcas
        public string Properties53 { get; set; } //Rostro
        public string Properties54 { get; set; } //Ojos
        public string Properties55 { get; set; } //Labios
        public string Properties56 { get; set; } //CuidadoPiel
        public string Properties57 { get; set; } //AccesorioBelleza
        public string Properties58 { get; set; } //Bissu
        public string Properties59 { get; set; } //Maravilla
        public string Properties60 { get; set; } //ByApple
        public string Properties61 { get; set; } //Saniye
        public string Properties62 { get; set; } //Pink21
        public string Properties63 { get; set; } //AmorUs
        public string Properties64 { get; set; } //DanzonCosmetics

        /* +++Listas de Precios+++ */
        public List<ItemPrice> ItemPrice { get; set; }

        /* +++Listas de Almacenes+++ */
        public List<WarehouseInfo> ItemWarehouseInfoCollection { get; set; }

        public Item(string itemCode, string itemName, string vatLiable, string taxType, string nCMCode, string indirectTax, string itemType, string mainsupplier, int itemsGroupCode, decimal salesUnitWeight, int salesWeightUnit, decimal salesItemsPerUnit, string planningSystem, string procurementMethod, string barCode, string u_CLASIF_STORE, string u_codigo, string salesUnit, decimal salesQtyPerPackUnit, string inventoryUOM, string purchaseUnit, string purchasePackagingUnit, string salesPackagingUnit, string sWW, string properties1, string properties2, string properties3, string properties4, string properties5, string properties6, string properties7, string properties8, string properties9, string properties10, string properties11, string properties12, string properties13, string properties14, string properties15, string properties16, string properties17, string properties18, string properties19, string properties20, string properties21, string properties22, string properties23, string properties24, string properties25, string properties26, string properties27, string properties28, string properties29, string properties30, string properties31, string properties32, string properties33, string properties34, string properties35, string properties36, string properties37, string properties38, string properties39, string properties40, string properties41, string properties42, string properties43, string properties44, string properties45, string properties46, string properties47, string properties48, string properties49, string properties50, string properties51, string properties52, string properties53, string properties54, string properties55, string properties56, string properties57, string properties58, string properties59, string properties60, string properties61, string properties62, string properties63, string properties64, List<ItemPrice> itemPrice, List<WarehouseInfo> itemWarehouseInfoCollection)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            VatLiable = vatLiable;
            TaxType = taxType;
            NCMCode = nCMCode;
            IndirectTax = indirectTax;
            ItemType = itemType;
            Mainsupplier = mainsupplier;
            ItemsGroupCode = itemsGroupCode;
            SalesUnitWeight = salesUnitWeight;
            SalesWeightUnit = salesWeightUnit;
            SalesItemsPerUnit = salesItemsPerUnit;
            PlanningSystem = planningSystem;
            ProcurementMethod = procurementMethod;
            BarCode = barCode;
            U_CLASIF_STORE = u_CLASIF_STORE;
            U_codigo = u_codigo;
            SalesUnit = salesUnit;
            SalesQtyPerPackUnit = salesQtyPerPackUnit;
            InventoryUOM = inventoryUOM;
            PurchaseUnit = purchaseUnit;
            PurchasePackagingUnit = purchasePackagingUnit;
            SalesPackagingUnit = salesPackagingUnit;
            SWW = sWW;
            Properties1 = properties1;
            Properties2 = properties2;
            Properties3 = properties3;
            Properties4 = properties4;
            Properties5 = properties5;
            Properties6 = properties6;
            Properties7 = properties7;
            Properties8 = properties8;
            Properties9 = properties9;
            Properties10 = properties10;
            Properties11 = properties11;
            Properties12 = properties12;
            Properties13 = properties13;
            Properties14 = properties14;
            Properties15 = properties15;
            Properties16 = properties16;
            Properties17 = properties17;
            Properties18 = properties18;
            Properties19 = properties19;
            Properties20 = properties20;
            Properties21 = properties21;
            Properties22 = properties22;
            Properties23 = properties23;
            Properties24 = properties24;
            Properties25 = properties25;
            Properties26 = properties26;
            Properties27 = properties27;
            Properties28 = properties28;
            Properties29 = properties29;
            Properties30 = properties30;
            Properties31 = properties31;
            Properties32 = properties32;
            Properties33 = properties33;
            Properties34 = properties34;
            Properties35 = properties35;
            Properties36 = properties36;
            Properties37 = properties37;
            Properties38 = properties38;
            Properties39 = properties39;
            Properties40 = properties40;
            Properties41 = properties41;
            Properties42 = properties42;
            Properties43 = properties43;
            Properties44 = properties44;
            Properties45 = properties45;
            Properties46 = properties46;
            Properties47 = properties47;
            Properties48 = properties48;
            Properties49 = properties49;
            Properties50 = properties50;
            Properties51 = properties51;
            Properties52 = properties52;
            Properties53 = properties53;
            Properties54 = properties54;
            Properties55 = properties55;
            Properties56 = properties56;
            Properties57 = properties57;
            Properties58 = properties58;
            Properties59 = properties59;
            Properties60 = properties60;
            Properties61 = properties61;
            Properties62 = properties62;
            Properties63 = properties63;
            Properties64 = properties64;
            ItemPrice = itemPrice;
            ItemWarehouseInfoCollection = itemWarehouseInfoCollection;
        }
    
        public Item(string ItemCode)
        {
            this.ItemCode = ItemCode;
        }
        public Item(string ItemCode, string itemName)
        {
            this.ItemCode = ItemCode;
            this.ItemName = itemName;
        }
        public Item(string ItemCode, string itemName,string ncmCode, string properties4)
        {
            this.ItemCode = ItemCode;
            this.ItemName = itemName;
            this.NCMCode = ncmCode;
            this.Properties4 = properties4;
        }
        public Item() { }
    }

}

