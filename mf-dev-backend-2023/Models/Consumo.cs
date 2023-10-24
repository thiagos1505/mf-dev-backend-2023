using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        public int VeiculoId { get; set; }
        [ForeignKey("VeiculoId")]

        public Veiculo Veiculo { get; set; }
        [Required(ErrorMessage = "É obrigatório informar o modelo")]
        [Display(Name = "Modelo")]

        public DateTime Data { get; set; }
        
        public double Valor { get; set; }

        public int Km { get; set; }
        [Required(ErrorMessage = "É obrigatório informar a quilometragem")]
        [Display(Name = "Quilometragem")]

        public TipoCombustivel  combustivel { get; set;}

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Alcool,
        Diesel,
        Flex
    }
}
