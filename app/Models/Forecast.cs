using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("forecasts")]
    public class Forecast
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Column("city")]
        public string? City { get; set; }

        [Column("temperate")]
        public double Temperature { get; set; }
    }
}