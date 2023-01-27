using System.ComponentModel.DataAnnotations;

namespace Push_Pull_Program.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(13)]
        public string? Cedula { get; set; }
        public string? Nombre { get; set; } = null!; 
        public decimal Salario { get; set; }
        [MaxLength(1)]
        public string? Sexo { get; set; }
        public DateOnly Nacimiento_Fecha { get; set; }
    }
}
