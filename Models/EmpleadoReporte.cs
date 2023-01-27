using System.ComponentModel.DataAnnotations;

namespace Push_Pull_Program.Models
{
    public class EmpleadoReporte
    {
        [Key]
        public int Id { get; set; }
        public Empleado? Empleado { get; set; }
        public Reporte Reporte { get; set; }
    }
}
