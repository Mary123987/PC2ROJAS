using System.ComponentModel.DataAnnotations.Schema;

namespace PC2ROJAS.Models
{
      [Table("t_cliente")]

    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string? NombreTitular { get; set; } 
        public string? TipoCuenta { get; set; } 
        public decimal SaldoInicial { get; set; } 
        public string? Email { get; set; }  
    }
}