using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteCCZ.Models
{
    public partial class Animaisachados
    {
        public int IdAnimalAchado { get; set; }
        [Required(ErrorMessage="Insira uma foto do animal",AllowEmptyStrings=false)]
        public string Foto { get; set; }   
        [Required(ErrorMessage="Insira a espécie (cão, gato, outro)",AllowEmptyStrings=false)]     
        [Display(Name = "Espécie")]
        [StringLength(10)]
        public string Especie { get; set; }
        [Display(Name = "Raça")]
        [StringLength(20)]
        public string Raca { get; set; }        
        [Display(Name = "Quem encontrou?")]
        [Required(ErrorMessage="Insira seu nome",AllowEmptyStrings=false)]
        [StringLength(80)]
        public string AchadorNome { get; set; }
        [Display(Name = "Telefone")]
        [Required(ErrorMessage="Insira seu telefone",AllowEmptyStrings=false)]
        [StringLength(20)]
        public string AchadorTelefone { get; set; }        
        [Required(ErrorMessage="Insira o bairro onde o animal foi encontrado",AllowEmptyStrings=false)]
        [StringLength(50)]
        public string Bairro { get; set; }
        [Required(ErrorMessage="Acrescente detalhes sobre a ocorrência",AllowEmptyStrings=false)]
        [StringLength(150)]
        public string Detalhes { get; set; }

    }
}
