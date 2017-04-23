using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRestWT.Models
{
    public class TramaSerial
    {
        public int Nro { get; set; }
        public long ID { get; set; }
        public Nullable<int> EstadoGPS { get; set; }
        public Nullable<int> EstadoMotor { get; set; }
        public Nullable<double> Velocidad { get; set; }
        public Nullable<double> Latitud { get; set; }
        public Nullable<double> Longitud { get; set; }
        public Nullable<System.DateTime> FechaGPS { get; set; }
        public string NroPlaca { get; set; }
        public string Nombre { get; set; }
        public Nullable<double> Asimut { get; set; }
        public string NIT { get; set; }
        public string IDButton { get; set; }
        public Nullable<double> Kilometraje { get; set; }
        public Nullable<double> Temperatura { get; set; }
        public Nullable<double> VoltajeBateria { get; set; }
        public Nullable<bool> EstadoPuerta { get; set; }
        public Nullable<int> tipov { get; set; }
        public string IMEI { get; set; }
        public string direcciones { get; set; }
    }
}