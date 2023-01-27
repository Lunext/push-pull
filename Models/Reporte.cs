using System.ComponentModel.DataAnnotations;

namespace Push_Pull_Program.Models
{
    public class Reporte
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? RNC { get; set; } = null!;
        public string? Empresa { get; set; }
        public DateTime Fecha_Transmision { get; set; }
    }
}
