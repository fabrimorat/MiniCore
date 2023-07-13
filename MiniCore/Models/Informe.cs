using System.ComponentModel.DataAnnotations;

namespace MiniCore.Models
{
    public class Informe
    {
        [Key]
        public int InformeId { get; set; }
        public DateTime Fecha { get; set; }
        public string Resultado { get; set; }
        public string Detalles { get; set; }
    }
}