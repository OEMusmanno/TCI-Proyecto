using Campo_TPFinal_BE.Solicitud;
using Campo_TPFinal_BLL.Sistema.Serializacion;
using Campo_TPFinal_BLLContracts.SolicitudDeCompra;
using Campo_TPFinal_BLLContracts.Vehiculo;
using Campo_TPFinal_DALContracts.SolicitudDeCompra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_TPFinal_BLL.SolicitudDeCompra
{
    public class SolicitudDeCompraService : ISolicitudDeCompraService
    {
        readonly ISolicitudDeCompraRepository solicitudDeCompraRepository;
        readonly IEstacionamientoService estacionamientoService;
        XMLSerializator<SolicitudCompra> xMLSerializator;

        public SolicitudDeCompraService(ISolicitudDeCompraRepository solicitudDeCompraRepository, IEstacionamientoService estacionamientoService)
        {
            this.solicitudDeCompraRepository = solicitudDeCompraRepository;
            this.estacionamientoService = estacionamientoService;
            xMLSerializator = new XMLSerializator<SolicitudCompra>();
        }

        public void Aprobar(int id)
        {
            solicitudDeCompraRepository.Aprobar(id);
        }

        public void Crear(SolicitudCompra solicitudDeCompra)
        {
            ValidarDisponibilidadDeEspacios(solicitudDeCompra);
            solicitudDeCompraRepository.Crear(solicitudDeCompra);
        }

        public void ExportarXML(SolicitudCompra solicitudCompra, string selectedPath)
        {           
            xMLSerializator.Serializar(solicitudCompra,selectedPath);
        }

        public SolicitudCompra ImportarXML(string selectedPath)
        {            
            return (SolicitudCompra)xMLSerializator.Deserializar(selectedPath);
        }

        public List<SolicitudCompra> Listar()
        {
            return solicitudDeCompraRepository.Listar();
        }

        public SolicitudCompra ObtenerPorId(int id)
        {
            return solicitudDeCompraRepository.ObtenerPorId(id);
        }

        public void Rechazar(int id)
        {
            solicitudDeCompraRepository.Rechazar(id);
        }

        void ValidarDisponibilidadDeEspacios(SolicitudCompra solicitudDeCompra) 
        {
            int espaciosAOcupar = 0;
            var espaciosLibres = estacionamientoService.ObtenerTotalEspaciosLibres();
            foreach (var item in solicitudDeCompra.itemDeCompras)
            {
                espaciosAOcupar += espaciosAOcupar + item.cantidad;
            };
            if (espaciosAOcupar > espaciosLibres)
            {
                throw new Exception("se excede el limite de espacio de estacionamientos disponibles, reduzca la cantidad!");
            }

        }
    }
}
