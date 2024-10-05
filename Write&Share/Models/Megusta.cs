using Microsoft.Extensions.Hosting;

namespace Write_Share.Models
{
    public class Megusta
    {
        public int Id { get; set; }
        public Usuario Lector { get; set; }
        public Publicacion Post { get; set; }
    }
}
