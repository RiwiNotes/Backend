namespace Backend.Models
{
    public class Categoria
    {
        public int id { get; set; }
        public string nombre_categoria { get; set; }
        public List<Nota> notas { get; set; } // Cambia la propiedad a una colección de notas
    }
}
