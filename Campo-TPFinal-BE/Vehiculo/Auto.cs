﻿using Campo_TPFinal_BE.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BE.Vehiculo
{
    public class Auto
    {        
        public Auto()
        {
          
        }
        public Auto(Estacionamiento estacionamiento, string marca, string modelo)
        {
            Estacionamiento = estacionamiento;
            Marca = marca;
            Marca = marca;
            Modelo = modelo;
        }

        public Auto(Estacionamiento estacionamiento, string marca, TipoVehiculo tipoVehiculo, string modelo)
        {
            Estacionamiento = estacionamiento;
            Marca = marca;
            this.tipoVehiculo = tipoVehiculo;
            Modelo = modelo;
        }

        public Estacionamiento Estacionamiento { get; set; }
        public Estado.Estado Estado{ get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Id { get; set; }

        public TipoVehiculo tipoVehiculo { get; set; }
        
       
    }
}
