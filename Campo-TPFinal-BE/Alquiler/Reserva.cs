namespace Campo_TPFinal_BE.Alquiler
{
    public class Reserva
    {
        public Reserva()
        {
        }
        public Reserva(Vehiculo.Auto auto, Usuario.Usuario usuario)
        {
            this.auto = auto;
            this.usuario = usuario;
            this.fechaInicio = DateTime.Now;
        }

        public int id { get; set; }
        public Vehiculo.Auto auto { get; set; }


        public Usuario.Usuario usuario { get; set; }
        public int id_auto { get; set; }
        public int id_usuario { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
    }
}
