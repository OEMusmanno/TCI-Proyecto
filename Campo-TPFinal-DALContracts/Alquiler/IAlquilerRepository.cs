﻿using Campo_TPFinal_BE.Alquiler;
using Campo_TPFinal_BE.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts.Alquiler
{
    public interface IAlquilerRepository
    {
       public void RegistrarReserva(int id);
       public bool ValidarReservasAnteriores();
       Reserva ObtenerReserva(int idReserva);
        void FinalizarReserva(int id_auto);
        List<Reserva> Listar();
        List<Reserva> ListarPorPeriodo(DateTime fechaInicio, DateTime fechaFin);
    }
}
