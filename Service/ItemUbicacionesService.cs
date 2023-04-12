using Eternity1._0.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Service
{
    public class ItemUbicacionesService
    {
        private readonly string cadenaSQL;

        public ItemUbicacionesService(IConfiguration config)
        {
            cadenaSQL = config.GetConnectionString("CadenaSQL");
        }
        public ItemUbicacionesService() { }
        public List<UbicacionesItems> listarUbicaciones(string itemCode)
        {
            List<UbicacionesItems> lista = new List<UbicacionesItems>();
            UbicacionesItems item = new UbicacionesItems();
            List<UbicacionesItems> listaUbis = new List<UbicacionesItems>();

                try
                {
                    using (var conexion = new SqlConnection(cadenaSQL))
                    {
                        conexion.Open();
                        var cmd = new SqlCommand("sp_traerUbicaciones", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (var rd = cmd.ExecuteReader())
                        {

                            while (rd.Read())
                            {
                                decimal stockUbicacion;
                                decimal totalStockAlmacen;

                                if (rd["stockUbicacion"] != DBNull.Value)
                                {
                                    stockUbicacion = Convert.ToDecimal(rd["stockUbicacion"]);
                                }
                                else
                                {
                                    stockUbicacion = 0m;
                                }
                                if (rd["TotalStockAlmacen"] != DBNull.Value)
                                {
                                    totalStockAlmacen = Convert.ToDecimal(rd["TotalStockAlmacen"]);
                                }
                                else
                                {
                                    totalStockAlmacen = 0m;
                                }
                                lista.Add(new UbicacionesItems
                                {
                                    AbsEntry = rd["AbsEntry"].ToString(),
                                    BinCode = rd["Bincode"].ToString(),
                                    ItemCode = rd["ItemCode"].ToString(),
                                    ItemName = rd["ItemName"].ToString(),
                                    WhsCode = rd["WhsCode"].ToString(),
                                    StockUbicacion = stockUbicacion,
                                    TotalStockAlmacen = totalStockAlmacen
                                });
                            }

                        }

                    }
                    listaUbis = lista.Where(item => item.ItemCode == itemCode).ToList();
                    return listaUbis;
                   
                }
                catch (Exception error)
                {
                return listaUbis;
                }
            }

        }
    }

