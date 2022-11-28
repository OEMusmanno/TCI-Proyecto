using Campo_TPFinal_BLL.Seguridad;
using Campo_TPFinal_BLLContracts.Sistema.Reportes;
using System.Reflection.Metadata;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
using System.Reflection;
using Campo_TPFinal_BLLContracts.Alquiler;
using Campo_TPFinal_BLLContracts;
using Campo_TPFinal_BE.Alquiler;
using Campo_TPFinal_BE.Solicitud;
using Campo_TPFinal_BE.Vehiculo;
using static iTextSharp.text.pdf.AcroFields;
using System.Globalization;

namespace Campo_TPFinal_BLL.Sistema.Reportes
{
    public class ReporteService: IReporteService
    {
        readonly IAlquilerService _alquilerService;
        readonly IBitacoraService _bitacoraService;
        double total;

        public ReporteService(IAlquilerService alquilerService, IBitacoraService bitacoraService)
        {
            this._alquilerService = alquilerService;
            this._bitacoraService = bitacoraService;
        }

        public void SacarReporteDeGanancias(string path, DateTime fechaInicio, DateTime fechaFin)
        {
            string dateFormat = "-yyyy-MM-dd-HH-mm-ss";
            string archivoPath = path + "\\ReporteDeGanancias" + DateTime.Now.ToString(dateFormat) + ".pdf";
            FileStream fs = new FileStream(archivoPath, FileMode.Create);
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            Font titleFont = FontFactory.GetFont("Arial", 32);
            Font regularFont = FontFactory.GetFont("Arial", 36);
            Font subtileFont = FontFactory.GetFont("Arial", 20);
            PdfPTable table = new PdfPTable(5);

            var listadoDeReservas = _alquilerService.ListarPorPeriodo(fechaInicio, fechaFin);
            Dictionary<Reserva,double> dictionario = CalcEngine(listadoDeReservas);
                     

            table.AddCell($"Id");
            table.AddCell($"Auto");
            table.AddCell($"Usuario");
            table.AddCell($"Tiempo Recorrido");
            table.AddCell($"Monto");

            foreach (var item in listadoDeReservas)
            {
                table.AddCell($"{item.id}");
                table.AddCell($"{item.auto.Marca} {item.auto.Modelo}");
                table.AddCell($"{item.usuario.alias}");
                table.AddCell($"Dias: {item.fechaFin.Subtract(item.fechaInicio).ToString("%d")}, Horas:{item.fechaFin.Subtract(item.fechaInicio).ToString(@"hh\:mm\:ss")}");
                table.AddCell($"{dictionario[item].ToString("C", CultureInfo.CurrentCulture)}");
            }

            var cell = new PdfPCell(new Phrase("Total"));
            cell.Colspan = 4;
            table.AddCell(cell);
            table.AddCell($"{total.ToString("C", CultureInfo.CurrentCulture)}");

            document.Open();
                        
            document.Add(new Paragraph("Reporte de ganancias por reserva", titleFont));
            document.Add(new Paragraph("   "));
            document.Add(new Paragraph($"Usuario: {Session.GetInstance().usuario.alias}"));
            document.Add(new Paragraph($"Fecha: {DateTime.Now.ToString()}"));
            document.Add(new Paragraph("   "));
            document.Add(new Paragraph("Este reporte el total de ganancias en el periodo seleccionados"));
            document.Add(new Paragraph("Datos:", subtileFont));
            document.Add(new Paragraph("   "));
            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();

        }

        private Dictionary<Reserva, double> CalcEngine(List<Reserva> reservas)
        {
            Dictionary<Reserva, double> engine = new Dictionary<Reserva, double>();     
            foreach (var item in reservas)
            {
                TimeSpan hora = item.fechaFin.Subtract(item.fechaInicio);
                double calculo;
                if (hora.TotalHours > 6)
                {
                    calculo = (hora.TotalHours/6) * item.auto.tipoVehiculo.PrecioDia;
                }
                else
                {
                    calculo  = hora.TotalHours * item.auto.tipoVehiculo.PrecioHora;

                }
                total += calculo;
                engine.Add(item, calculo);
            }
            return engine;
        }
    }
}
