namespace Write_Share.Models
{
    public class Publicacion
    {
        public int Td { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Estado { get; set; }
        public Usuario Autor { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public List<Calificacion> Calificaciones { get; set; }
    }
}
