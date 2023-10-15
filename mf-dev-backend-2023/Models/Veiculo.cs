using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "A placa é obrigatória")]
        public string? Placa { get; set; }
        
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string? Modelo { get; set; }
        
        [Required(ErrorMessage = "O ano de fabricação é obrigatório")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "O ano do modelo é obrigatório")]
        public int AnoModelo { get; set; }
    }
}
