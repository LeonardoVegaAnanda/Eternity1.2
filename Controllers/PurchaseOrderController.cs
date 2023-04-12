using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Eternity1._0.Models.Orders;
using Microsoft.AspNetCore.Http;
using Eternity1._0.Service;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Eternity1._0.Controllers
{
    public class PurchaseOrderController : Controller
    {
        private readonly string cadenaSQL;
        string sessionId;
        LoginService service = new LoginService();

        public IActionResult Index()
        {
            return View();
        }

        public PurchaseOrderController(IConfiguration config)
        {
            cadenaSQL = config.GetConnectionString("CadenaSQL1");
        }
        [HttpGet]
        [Route("ananda/eternity/purchaseOrder/docNum")]
        public IActionResult traerOrdenCompraByDocEntry(int NumeroOrden)
        {
            List<PurchaseOrdersCronos> lista = new List<PurchaseOrdersCronos>();
            PurchaseOrdersCronos ordenDevuelta = new PurchaseOrdersCronos();

            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("sp_orden_cronos", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            
                            lista.Add(new PurchaseOrdersCronos
                            {
                                DocEntry = Convert.ToInt32(rd["DocEntry"]),
                                DocNum = Convert.ToInt32(rd["DocNum"]),
                                DocDate = rd["DocDate"].ToString(),
                                DocTime = rd["DocTime"].ToString(),
                                DocTotal = Convert.ToDecimal(rd["DocTotal"]),
                                DocTotalSys = Convert.ToDecimal(rd["DocTotalSy"]),
                                VatSum = Convert.ToDecimal(rd["VatSum"]),
                                CardCode = rd["CardCode"].ToString(),
                                CardName = rd["CardName"].ToString()
                            });
                        }
                    }
                }
                ordenDevuelta = lista.Where(orden => orden.DocNum == NumeroOrden).FirstOrDefault();
                var cliente = new RestClient("https://199.89.53.35:50000/b1s/v1/PurchaseOrders" + "(" +ordenDevuelta.DocEntry +")");
                cliente.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Cookie", "B1SESSION=" + service.LoginSAPProductivo());
                var body = @"";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = cliente.Execute(request);
                var resultado = JsonConvert.DeserializeObject<PurchaseOrdersCronos>(response.Content, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
                PurchaseOrdersCronos orden = new PurchaseOrdersCronos(resultado.DocEntry, resultado.DocNum, resultado.DocDate, resultado.DocTime, resultado.DocTotalSys, resultado.VatSum, resultado.DocTotal, resultado.CardCode, resultado.CardName, resultado.DocumentLines);
                return StatusCode(StatusCodes.Status200OK, orden);
            }
            catch (Exception error)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = error.Message, response = ordenDevuelta });

            }
        }
    }
}
