namespace Write_Share.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public Usuario Autor { get; set; }
        public DateTime Fecha_Comentario { get; set; }
    }
}
