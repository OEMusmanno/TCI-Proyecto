namespace Campo_TPFinal_BE.Sistema
{
    public class ControlCambio
    {
        public string? id { get; set; }
        public string? property { get; set; }
        public string? value { get; set; }
        public Usuario.Usuario Usuario{ get; set; }
        public string? descripcion { get; set; }
        public DateTime fecha { get; set; }
    }
}
