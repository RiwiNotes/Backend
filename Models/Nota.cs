namespace Backend.Models
{
    public class Nota
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string contenido { get; set; }
        public DateTime fecha { get; set; } 

        public string categoria {get; set;}
        
    }
}


