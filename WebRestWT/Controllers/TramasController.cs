using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebRestWT.Models;
using WebRestWT.Models.BD;

namespace WebRestWT.Controllers
{
    public class TramasController : ApiController
    {

        WISETRACKEntities db = new WISETRACKEntities();

        public IEnumerable<TramaSerial> GetAllTramas()
        {
            TramaSerial[] trama = new TramaSerial[] { };
            var result = (from t in db.TramaTemp1
                          select new TramaSerial
                          {
                              Asimut = t.Asimut,
                              direcciones = t.direcciones,
                              EstadoGPS = t.EstadoGPS,
                              EstadoMotor = t.EstadoMotor,
                              EstadoPuerta = t.EstadoPuerta,
                              FechaGPS = t.FechaGPS,
                              ID = t.ID,
                              IDButton = t.IDButton,
                              IMEI = t.IMEI,
                              Kilometraje = t.Kilometraje,
                              Latitud = t.Latitud,
                              Longitud = t.Longitud,
                              NIT = t.NIT,
                              Nombre = t.Nombre,
                              Nro = t.Nro,
                              NroPlaca = t.NroPlaca,
                              Temperatura = t.Temperatura,
                              tipov = t.tipov,
                              Velocidad = t.Velocidad,
                              VoltajeBateria = t.VoltajeBateria
                          }).ToList();

            trama = result.ToArray();

            return trama;
        }


        [HttpGet]
        public IHttpActionResult GetTrama(string placa)
        {
            //TramaSerial[] trama = new TramaSerial[] { };
            var result = (from t in db.TramaTemp1
                          where t.NroPlaca == placa
                          select new TramaSerial
                          {
                              Asimut = t.Asimut,
                              direcciones = t.direcciones,
                              EstadoGPS = t.EstadoGPS,
                              EstadoMotor = t.EstadoMotor,
                              EstadoPuerta = t.EstadoPuerta,
                              FechaGPS = t.FechaGPS,
                              ID = t.ID,
                              IDButton = t.IDButton,
                              IMEI = t.IMEI,
                              Kilometraje = t.Kilometraje,
                              Latitud = t.Latitud,
                              Longitud = t.Longitud,
                              NIT = t.NIT,
                              Nombre = t.Nombre,
                              Nro = t.Nro,
                              NroPlaca = t.NroPlaca,
                              Temperatura = t.Temperatura,
                              tipov = t.tipov,
                              Velocidad = t.Velocidad,
                              VoltajeBateria = t.VoltajeBateria
                          }).FirstOrDefault();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}

