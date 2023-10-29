using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Consumos")]
    public class Consumo
    {

        public int Id { get; set; }
        [Key]
        
               
        public  String? Descricao { get; set; }
        [Required(ErrorMessage = "É obrigatório informar a descrição")]
        [Display(Name = "Descrição")]
        
        public Decimal Valor { get; set; }
        [Required(ErrorMessage = "É obrigatório informar o valor")]

        public DateTime Data { get; set; }
        [Required(ErrorMessage = "É obrigatório informar a data")]
       
        public int Km { get; set; }
        [Required(ErrorMessage = "É obrigatório informar a quilometragem")]
        [Display(Name = "Quilometragem")]
        
        public  TipoCombustivel combustivel { get; set; }
        [Required(ErrorMessage = "É obrigatório informar o tipo de combustível")]
        [Display(Name = "Tipo de Combustível")]

        public int VeiculoId { get; set; }
        [Required(ErrorMessage = "É obrigatório informar o veículo")]
        [Display(Name = "Veículo")]

        
        
        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
        






    }

    public enum TipoCombustivel
{
    Gasolina,
    Alcool,
    Diesel,
    Flex
}

}
    
  