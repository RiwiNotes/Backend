namespace Backend.Models
{
    public class Nota
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public DateOnly fecha { get; set; }

        public int id_categoria { get; set; } 
        
        public Categoria categoria {get; set;}
    }
}

