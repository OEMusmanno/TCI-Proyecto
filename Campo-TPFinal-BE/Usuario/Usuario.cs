namespace Campo_TPFinal_BE.Usuario
{
    public class Usuario
    {
        public string alias { get; set; }
        public string password { get; set; }
        public int Id { get; set; }

        public List<Penalidad> Penalidades{ get; set; }

    }
}
