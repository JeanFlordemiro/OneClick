using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneClick.Models
{
    public class Clientes
    {
        [Key]

        public int Id { get; set; }
        [ForeignKey("Id_Viagem")]

        public int Numero_Voo { get; set; }
        public virtual Viagens ? Viagens { get; set;}
        public string ? Nome { get; set; }
        [StringLength(11)]

        public string ? CPF { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public DataType Email { get; set; }

        [DataType(DataType.CreditCard)]
        public DataType CreditCard { get; set; }
    }
}
