using Eternity1._0.Models.Picking;
using Eternity1._0.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace Eternity1._0.Controllers
{
    [ApiController]
    public class PickingController : Controller
    {

        private readonly string cadenaSQL;

        public PickingController(IConfiguration config)
        {
            cadenaSQL = config.GetConnectionString("CadenaSQL");
        }

        [HttpGet]
        [Route("ananda/eternity/picking/lista")]
        public IActionResult findAllByDate(string date)
        {
            List<PickingListAzafran> lista = new List<PickingListAzafran>();
            List<PickingListAzafran> listaDevuelta = new List<PickingListAzafran>();
            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("sp_lista_picking_date", conexion);
                    cmd.Parameters.AddWithValue("PickDate", date);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            lista.Add(new PickingListAzafran
                            {
                                AbsEntry = Convert.ToInt32(rd["AbsEntry"]),
                                DocNum = Convert.ToInt32(rd["DocNum"]),
                                PickDate =Convert.ToDateTime(rd["PickDate"]),
                                Series = Convert.ToInt32(rd["Series"]),
                                U_EstatusOV = rd["U_EstatusOV"].ToString()
                            });
                        }
                    }
                }
                return StatusCode(StatusCodes.Status200OK,lista);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status404NotFound,e);
            }
        }

        [HttpGet]
        [Route("ananda/eternity/picking/surtido")]
        public IActionResult findListPickingByNumeroPicking(int absEntry)
        {
            List<PickingListSurtido> lista = new List<PickingListSurtido>();

            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("sp_lista_picking_number_picking", conexion);
                    cmd.Parameters.AddWithValue("AbsEntry", absEntry);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            decimal quantity;
                            if(rd["Quantity"] != DBNull.Value)
                            {
                                quantity = Convert.ToDecimal(rd["Quantity"]);
                            }
                            else
                            {
                                quantity = 0m;
                            }
                            lista.Add(new PickingListSurtido
                            {
                                AbsEntry = Convert.ToInt32(rd["AbsEntry"]),
                                DocNum = Convert.ToInt32(rd["DocNum"]),
                                Dscription = rd["Dscription"].ToString(),
                                ItemCode = rd["ItemCode"].ToString(),
                                Name = rd["Name"].ToString(),
                                OrderEntry = Convert.ToInt32(rd["OrderEntry"]),
                                PickDate = Convert.ToDateTime(rd["PickDate"]),
                                Quantity = quantity,
                                Series = Convert.ToInt32(rd["Series"]),
                                U_EstatusOV = rd["U_EstatusOV"].ToString(),
                                CardName = rd["CardName"].ToString()
                            });
                        }
                    }
                }
                return StatusCode(StatusCodes.Status200OK, lista);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status404NotFound, e);
            }
        }

        [HttpPut]
        [Route("ananda/eternity/picking/por_surtir")]
        public IActionResult updateEstatusPorSurtir(string date, int docNum)
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("sp_crear_fecha_porsurtir", conexion);
                    cmd.Parameters.AddWithValue("U_DatePorSurtir", date);
                    cmd.Parameters.AddWithValue("DocNum", docNum);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Cambiado a por surtir" });
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { mensaje = e });
            }
        }
        [HttpPut]
        [Route("ananda/eternity/picking/inicio_surtido")]
        public IActionResult updateEstatusInicioSurtido(string date, int docNum)
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("sp_crear_fecha_inicio_surtido", conexion);
                    cmd.Parameters.AddWithValue("U_DateInicioSurtido", date);
                    cmd.Parameters.AddWithValue("DocNum", docNum);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Inicio Surtido" });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { mensaje = e });
            }
        }

        [HttpPut]
        [Route("ananda/eternity/picking/termino_surtido")]
        public IActionResult updateEstatusTerminoSurtido(string date, int docNum)
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("sp_crear_fecha_termino_surtido", conexion);
                    cmd.Parameters.AddWithValue("U_DateTerminoSurtido", date);
                    cmd.Parameters.AddWithValue("DocNum", docNum);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Termino Surtido" });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { mensaje = e });
            }
        }

        [HttpPut]
        [Route("ananda/eternity/picking/inicio_verificado")]
        public IActionResult updateEstatusInicioVerificado(string date, int docNum)
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("sp_crear_fecha_inicioverificado", conexion);
                    cmd.Parameters.AddWithValue("U_DateInicioVerificado", date);
                    cmd.Parameters.AddWithValue("DocNum", docNum);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Inicio Verificado" });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { mensaje = e });
            }
        }

        [HttpPut]
        [Route("ananda/eternity/picking/termino_verificado")]
        public IActionResult updateEstatusTerminoVerificado(string date, int docNum)
        {
            try
            {
                using (var conexion = new SqlConnection(cadenaSQL))
                {
                    conexion.Open();
                    var cmd = new SqlCommand("sp_crear_fecha_terminoVerficado", conexion);
                    cmd.Parameters.AddWithValue("U_DateTerminoVerificado", date);
                    cmd.Parameters.AddWithValue("DocNum", docNum);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Inicio Verificado" });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { mensaje = e });
            }
        }
    }
}
