using Campo_TPFinal_BE.Solicitud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLLContracts.SolicitudDeCompra
{
    public interface ISolicitudDeCompraService
    {
        void Aprobar(int id);
        void Rechazar(int id);
        void Crear(SolicitudCompra solicitudDeCompra);
        List<SolicitudCompra> Listar();
        SolicitudCompra ObtenerPorId(int id);
        void ExportarXML(SolicitudCompra solicitudCompra, string selectedPath);
        SolicitudCompra ImportarXML(string selectedPath);
    }
}
