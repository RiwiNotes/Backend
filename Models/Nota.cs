namespace Backend.Models
{
    public class Nota
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public DateOnly fecha { get; set; }

        public int categoria_id {get; set;}
        public Categoria categoria { get; set; }
        
        
    }
}

