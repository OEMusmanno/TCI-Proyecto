using Campo_TPFinal_BE.Solicitud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_DALContracts.SolicitudDeCompra
{
    public interface ISolicitudDeCompraRepository
    {
        void Aprobar(int id);
        void Crear(SolicitudCompra solicitudDeCompra);
        List<SolicitudCompra> Listar();
        SolicitudCompra ObtenerPorId(int id);
        void Rechazar(int id);
    }
}
