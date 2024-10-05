namespace Write_Share.Models
{
    public class Calificacion
    {
        public int Id { get; set; }
        public int Valor { get; set; } // se podria calificar mediante estrellas
        public Usuario Lector { get; set; }
    }
}
