using System.ComponentModel.DataAnnotations;

namespace OneClick.Models
{
    public class Viagens
    {

        [Key]
        public int Id_Viagem { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
    }
}
